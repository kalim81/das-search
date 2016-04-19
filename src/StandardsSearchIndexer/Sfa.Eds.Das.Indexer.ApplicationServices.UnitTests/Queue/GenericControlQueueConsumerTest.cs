﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using Sfa.Eds.Das.Indexer.ApplicationServices.Queue;
using Sfa.Eds.Das.Indexer.ApplicationServices.Services;
using Sfa.Eds.Das.Indexer.ApplicationServices.Settings;
using Sfa.Eds.Das.Indexer.AzureWorkerRole.DependencyResolution;
using Sfa.Eds.Das.Indexer.Core.Services;
using StructureMap;

namespace Sfa.Eds.Das.Indexer.ApplicationServices.UnitTests.Queue
{
    [TestFixture]
    public sealed class GenericControlQueueConsumerTest
    {
        private const string QueueName = "testQueue";

        private GenericControlQueueConsumer _sut;
        private Mock<IAppServiceSettings> _mockServiceSettings;
        private Mock<IMessageQueueService> _mockQueueService;
        private Mock<IIndexerServiceFactory> _mockIndexerServiceFactory; 
        private Mock<IIndexerService<IMaintainProviderIndex>> _mockIndexerService;
        private Mock<ILog> _mockLogger;
        private Mock<IQueueMessage> _mockMessage;
        private List<IQueueMessage> _messages;

        [SetUp]
        public void Setup()
        {
            _mockServiceSettings = new Mock<IAppServiceSettings>();
            _mockQueueService = new Mock<IMessageQueueService>();
            _mockIndexerServiceFactory = new Mock<IIndexerServiceFactory>();
            _mockIndexerService = new Mock<IIndexerService<IMaintainProviderIndex>>();
            _mockLogger = new Mock<ILog>();
            _mockMessage = new Mock<IQueueMessage>();

            _messages = new List<IQueueMessage>
            {
                _mockMessage.Object
            };

            _mockIndexerServiceFactory.Setup(x => x.GetIndexerService<IMaintainProviderIndex>()).Returns(_mockIndexerService.Object);

            _mockServiceSettings.Setup(x => x.QueueName(typeof(IMaintainProviderIndex))).Returns(QueueName);

            _sut = new GenericControlQueueConsumer(
                _mockServiceSettings.Object,
                _mockQueueService.Object,
                _mockIndexerServiceFactory.Object,
                _mockLogger.Object);
        }

        [Test]
        public void ShouldRunIndexerIfMessagesArePresent()
        {
            //Assign
            var insertionTime = DateTime.Now;
            _mockMessage.Setup(x => x.InsertionTime).Returns(insertionTime);
            _mockQueueService.Setup(x => x.GetQueueMessages(It.IsAny<string>())).Returns(_messages);
            _mockIndexerService.Setup(x => x.CreateScheduledIndex(insertionTime)).Returns(Task.Factory.StartNew(() => { }));

            //Act
            var task = _sut.CheckMessage<IMaintainProviderIndex>();
            task.Wait(1000);

            //Assert
            _mockQueueService.Verify(x => x.GetQueueMessages(It.IsAny<string>()),Times.Once);
            _mockIndexerService.Verify(x => x.CreateScheduledIndex(insertionTime), Times.Once());
        }

        [Test]
        public void ShouldNotRunIndexerIfNoMessagesArePresent()
        {
            //Assign
            _mockQueueService.Setup(x => x.GetQueueMessages(It.IsAny<string>())).Returns(new List<IQueueMessage>());
            _mockIndexerService.Setup(x => x.CreateScheduledIndex(It.IsAny<DateTime>()));

            //Act
            var task = _sut.CheckMessage<IMaintainProviderIndex>();
            task.Wait(1000);

            //Assert
            _mockQueueService.Verify(x => x.GetQueueMessages(It.IsAny<string>()), Times.Once);
            _mockIndexerService.Verify(x => x.CreateScheduledIndex(It.IsAny<DateTime>()), Times.Never);
        }

        [Test]
        public void ShouldNotRunIndexerIfReturnedMessagesAreNull()
        {
            //Assign
            _mockQueueService.Setup(x => x.GetQueueMessages(It.IsAny<string>()));
            _mockIndexerService.Setup(x => x.CreateScheduledIndex(It.IsAny<DateTime>()));

            //Act
            var task = _sut.CheckMessage<IMaintainProviderIndex>();
            task.Wait(1000);

            //Assert
            _mockQueueService.Verify(x => x.GetQueueMessages(It.IsAny<string>()), Times.Once);
            _mockIndexerService.Verify(x => x.CreateScheduledIndex(It.IsAny<DateTime>()), Times.Never);
        }

        [Test]
        public void ShouldUseCorrectQueueNameFromSettings()
        {
            //Assign
            _mockMessage.Setup(x => x.InsertionTime).Returns(DateTime.Now);
            _mockQueueService.Setup(x => x.GetQueueMessages(QueueName)).Returns(_messages);
            _mockIndexerService.Setup(x => x.CreateScheduledIndex(It.IsAny<DateTime>())).Returns(Task.Factory.StartNew(() => { }));

            //Act
            var task = _sut.CheckMessage<IMaintainProviderIndex>();
            task.Wait(1000);

            //Assert
            _mockQueueService.Verify(x => x.GetQueueMessages(QueueName), Times.Once);
        }

        [Test]
        public void ShouldNotGetMessagesIfQueueNameHasNotBeenFound()
        {
            //Assign
            _mockServiceSettings.Setup(x => x.QueueName(typeof(IMaintainProviderIndex)));
            _mockMessage.Setup(x => x.InsertionTime).Returns(DateTime.Now);
            _mockQueueService.Setup(x => x.GetQueueMessages(It.IsAny<string>())).Returns(_messages);
            _mockIndexerService.Setup(x => x.CreateScheduledIndex(It.IsAny<DateTime>())).Returns(Task.Factory.StartNew(() => { }));

            //Act
            var task = _sut.CheckMessage<IMaintainProviderIndex>();
            task.Wait(1000);

            //Assert
            _mockQueueService.Verify(x => x.GetQueueMessages(It.IsAny<string>()), Times.Never);
        }

        [Test]
        public void ShouldDeleteAnyExtraMessagesAfterTheLatest()
        {
            // Assign
            var extraMessage = new Mock<IQueueMessage>().Object;
            _messages.Add(extraMessage);
            _mockMessage.Setup(x => x.InsertionTime).Returns(DateTime.Now);
            _mockQueueService.Setup(x => x.GetQueueMessages(It.IsAny<string>())).Returns(_messages);
            _mockIndexerService.Setup(x => x.CreateScheduledIndex(It.IsAny<DateTime>())).Returns(Task.Factory.StartNew(() => { }));
            _mockQueueService.Setup(x => x.DeleteQueueMessages(
                QueueName,
                It.Is<IEnumerable<IQueueMessage>>(
                    m => m.Contains(extraMessage) && 
                    !m.Contains(_mockMessage.Object))));

            // Act
            var task = _sut.CheckMessage<IMaintainProviderIndex>();
            task.Wait(1000);

            // Assert
            _mockQueueService.Verify(
                x => x.DeleteQueueMessages(
                    QueueName,
                It.Is<IEnumerable<IQueueMessage>>(
                    m => m.Contains(extraMessage) &&
                    !m.Contains(_mockMessage.Object))),
                    Times.Once);
        }

        [Test]
        public void ShouldDeleteFirstMessagesIfIndexingIsSuccessful()
        {
            // Assign
            var extraMessage = new Mock<IQueueMessage>().Object;
            _messages.Add(extraMessage);
            _mockMessage.Setup(x => x.InsertionTime).Returns(DateTime.Now);
            _mockQueueService.Setup(x => x.GetQueueMessages(It.IsAny<string>())).Returns(_messages);
            _mockIndexerService.Setup(x => x.CreateScheduledIndex(It.IsAny<DateTime>())).Returns(Task.Factory.StartNew(() => { }));
            _mockQueueService.Setup(x => x.DeleteQueueMessage(QueueName, _mockMessage.Object));

            // Act
            var task = _sut.CheckMessage<IMaintainProviderIndex>();
            task.Wait(1000);

            // Assert
            _mockQueueService.Verify(x => x.DeleteQueueMessage(QueueName, _mockMessage.Object));
        }
    }
}