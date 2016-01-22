﻿using System;
using System.Collections.Generic;
using Microsoft.WindowsAzure.Storage.Queue;
using Moq;
using NUnit.Framework;
using Sfa.Eds.Standards.Indexer.AzureWorkerRole.AzureAbstractions;
using Sfa.Eds.Standards.Indexer.AzureWorkerRole.Consumers;
using Sfa.Eds.Standards.Indexer.AzureWorkerRole.Services;
using Sfa.Eds.Standards.Indexer.AzureWorkerRole.Settings;

namespace Sfa.Eds.Standards.Indexer.Test.Consumers
{
    [TestFixture]
    public class StandardControlQueueConsumerTests
    {
        private Mock<IStandardService> _mockService;
        private Mock<ICloudQueueService> _mockCloudQueueService;
        private Mock<ICloudQueueWrapper> _mockQueue;
        private IStandardIndexSettings _mockSettings;
        private StandardControlQueueConsumer _sut;

        [SetUp]
        public void setup()
        {
            // Arrange
            _mockService = new Mock<IStandardService>();
            _mockCloudQueueService = new Mock<ICloudQueueService>();
            _mockQueue = new Mock<ICloudQueueWrapper>();
            _mockSettings = Mock.Of<IStandardIndexSettings>();
            _sut = new StandardControlQueueConsumer(_mockService.Object, _mockSettings, _mockCloudQueueService.Object);
        }

        [Test]
        public void shouldnt_create_an_index_if_there_arent_any_messages()
        {
            //Arrange
            _mockCloudQueueService
                .Setup(x => x.GetQueueReference(It.IsAny<string>(), It.IsAny<string>()))
                .Returns(_mockQueue.Object);
            
            // Act
            _sut.CheckMessage();

            // Assert
            _mockService.Verify(x => x.CreateScheduledIndex(It.IsAny<DateTime>()), Times.Never);
            _mockQueue.Verify(x => x.DeleteMessage(It.IsAny<CloudQueueMessage>()), Times.Never);
            _mockService.VerifyAll();
            _mockCloudQueueService.VerifyAll();
            _mockQueue.VerifyAll();
        }

        [Test]
        public void should_create_an_index_if_there_are_messages()
        {
            // Arrange
            _mockCloudQueueService
                .Setup(x => x.GetQueueReference(It.IsAny<string>(), It.IsAny<string>()))
                .Returns(_mockQueue.Object);
            _mockQueue
                .Setup(x => x.GetMessages(It.IsAny<int>()))
                .Returns(new List<CloudQueueMessage>() { new CloudQueueMessage(string.Empty)});

            // Act
            _sut.CheckMessage();

            // Assert
            _mockService.Verify(x => x.CreateScheduledIndex(It.IsAny<DateTime>()), Times.Once);
            _mockQueue.Verify(x => x.DeleteMessage(It.IsAny<CloudQueueMessage>()), Times.Once);
            _mockService.VerifyAll();
            _mockCloudQueueService.VerifyAll();
            _mockQueue.VerifyAll();
        }
    }
}