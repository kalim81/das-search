﻿namespace Sfa.Eds.Das.Indexer.ApplicationServices.UnitTests.Services
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using ApplicationServices.Services.Interfaces;
    using Core;
    using Core.Services;
    using Moq;
    using NUnit.Framework;
    using Settings;

    [TestFixture]
    public class IndexerServiceTests
    {
        private Mock<IGenericIndexerHelper<Core.Models.Provider.Provider>> _mockHelper;
        private IIndexSettings<Core.Models.Provider.Provider> _mockSettings;
        private IndexerService<Core.Models.Provider.Provider> _sut;

        [SetUp]
        public void Setup()
        {
            _mockHelper = new Mock<IGenericIndexerHelper<Core.Models.Provider.Provider>>();
            _mockSettings =
                Mock.Of<IIndexSettings<Core.Models.Provider.Provider>>(
                    x => x.PauseTime == "10" && x.SearchHost == "http://123.456.789:9200" && x.IndexesAlias == "testproviderindexesalias");

            _sut = new IndexerService<Core.Models.Provider.Provider>(_mockSettings, _mockHelper.Object, Mock.Of<ILog>());
        }

        [Test]
        public async Task ShouldIndexProvidersIfThatIndexHasBeenCreatedProperly()
        {
            // Arrange
            _mockHelper.Setup(x => x.CreateIndex(It.IsAny<string>())).Returns(true);

            // Act
            await _sut.CreateScheduledIndex(It.IsAny<DateTime>());

            // Assert
            _mockHelper.Verify(x => x.IndexEntries(It.IsAny<string>()), Times.Once);
            _mockHelper.Verify(x => x.IsIndexCorrectlyCreated(It.IsAny<string>()), Times.Once);
            _mockHelper.Verify(x => x.SwapIndexes(It.IsAny<string>()), Times.AtMostOnce);
            _mockHelper.VerifyAll();
        }

        [Test]
        public async Task ShouldNotIndexProvidersIfThatIndexHasNotBeenCreatedProperly()
        {
            // Arrange
            _mockHelper.Setup(x => x.CreateIndex(It.IsAny<string>())).Returns(false);

            // Act
            await _sut.CreateScheduledIndex(It.IsAny<DateTime>());

            // Assert
            _mockHelper.Verify(x => x.IndexEntries(It.IsAny<string>()), Times.Never);
            _mockHelper.VerifyAll();
        }

        [Test]
        public async Task ShouldNotSwapIdexesIfNewOneHasNotBeenCreatedProperly()
        {
            // Arrange
            _mockHelper.Setup(x => x.CreateIndex(It.IsAny<string>())).Returns(true);
            _mockHelper.Setup(x => x.IsIndexCorrectlyCreated(It.IsAny<string>())).Returns(false);

            // Act
            await _sut.CreateScheduledIndex(It.IsAny<DateTime>());

            // Assert
            _mockHelper.Verify(x => x.IndexEntries(It.IsAny<string>()), Times.Once);
            _mockHelper.Verify(x => x.IsIndexCorrectlyCreated(It.IsAny<string>()), Times.Once);
            _mockHelper.Verify(x => x.SwapIndexes(It.IsAny<string>()), Times.Never);
            _mockHelper.VerifyAll();
        }

        [Test]
        public async Task ShouldSwapIdexesIfNewOneHasBeenCreatedProperly()
        {
            // Arrange
            _mockHelper.Setup(x => x.CreateIndex(It.IsAny<string>())).Returns(true);
            _mockHelper.Setup(x => x.IsIndexCorrectlyCreated(It.IsAny<string>())).Returns(true);

            // Act
            await _sut.CreateScheduledIndex(It.IsAny<DateTime>());

            // Assert
            _mockHelper.Verify(x => x.IndexEntries(It.IsAny<string>()), Times.Once);
            _mockHelper.Verify(x => x.IsIndexCorrectlyCreated(It.IsAny<string>()), Times.Once);
            _mockHelper.Verify(x => x.SwapIndexes(It.IsAny<string>()), Times.Once);
            _mockHelper.VerifyAll();
        }
    }
}