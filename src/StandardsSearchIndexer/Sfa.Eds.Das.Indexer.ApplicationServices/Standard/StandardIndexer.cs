﻿namespace Sfa.Eds.Das.Indexer.ApplicationServices.Standard
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Core.Services;
    using Sfa.Eds.Das.Indexer.Core;
    using Sfa.Eds.Das.Indexer.Core.Models;
    using Services;
    using Settings;

    public sealed class StandardIndexer : IGenericIndexerHelper<MetaDataItem>
    {
        private readonly IMetaDataHelper _metaDataHelper;
        private readonly IMaintainSearchIndexes<MetaDataItem> _searchIndexMaintainer;
        private readonly IIndexSettings<MetaDataItem> _settings;
        private readonly ILog _log;

        public StandardIndexer(
            IIndexSettings<MetaDataItem> settings,
            IMetaDataHelper metaDataHelper,
            IMaintainSearchIndexes<MetaDataItem> searchIndexMaintainer,
            ILog log)
        {
            _settings = settings;
            _metaDataHelper = metaDataHelper;
            _searchIndexMaintainer = searchIndexMaintainer;
            _log = log;
        }

        public async Task IndexEntries(DateTime scheduledRefreshDateTime, ICollection<MetaDataItem> entries)
        {
            try
            {
                _log.Debug("Indexing " + entries.Count + " standards");

                var indexNameAndDateExtension = IndexerHelper.GetIndexNameAndDateExtension(scheduledRefreshDateTime, _settings.IndexesAlias);
                await _searchIndexMaintainer.IndexEntries(indexNameAndDateExtension, entries).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                _log.Error("Error indexing PDFs", ex);
            }
        }

        public Task<ICollection<MetaDataItem>> LoadEntries()
        {
            UpdateMetadataRepositoryWithNewStandards();
            _log.Info("Indexing standard PDFs...");

            return Task.FromResult<ICollection<MetaDataItem>>(GetStandardsMetaDataFromGit().ToList());
        }

        public bool CreateIndex(DateTime scheduledRefreshDateTime)
        {
            var indexName = IndexerHelper.GetIndexNameAndDateExtension(scheduledRefreshDateTime, _settings.IndexesAlias);
            var indexExistsResponse = _searchIndexMaintainer.IndexExists(indexName);

            // If it already exists and is empty, let's delete it.
            if (indexExistsResponse)
            {
                _log.Warn("Index already exists, deleting and creating a new one");

                _searchIndexMaintainer.DeleteIndex(indexName);
            }

            // create index
            _searchIndexMaintainer.CreateIndex(indexName);

            return _searchIndexMaintainer.IndexExists(indexName);
        }

        public bool IsIndexCorrectlyCreated(DateTime scheduledRefreshDateTime)
        {
            var indexName = IndexerHelper.GetIndexNameAndDateExtension(scheduledRefreshDateTime, _settings.IndexesAlias);

            return _searchIndexMaintainer.IndexContainsDocuments(indexName);
        }

        public void SwapIndexes(DateTime scheduledRefreshDateTime)
        {
            var indexAlias = _settings.IndexesAlias;
            var newIndexName = IndexerHelper.GetIndexNameAndDateExtension(scheduledRefreshDateTime, _settings.IndexesAlias);

            if (!CheckIfAliasExists(indexAlias))
            {
                _log.Warn("Alias doesn't exists, creating a new one...");

                CreateAlias(newIndexName);
            }

            _searchIndexMaintainer.SwapAliasIndex(indexAlias, newIndexName);
        }

        public bool DeleteOldIndexes(DateTime scheduledRefreshDateTime)
        {
            var oneDayAgo2 = IndexerHelper.GetIndexNameAndDateExtension(scheduledRefreshDateTime.AddDays(-1), _settings.IndexesAlias, "yyyy-MM-dd");
            var twoDaysAgo2 = IndexerHelper.GetIndexNameAndDateExtension(scheduledRefreshDateTime.AddDays(-2), _settings.IndexesAlias, "yyyy-MM-dd");

            return _searchIndexMaintainer.DeleteIndexes(x => x.StartsWith(oneDayAgo2) || x.StartsWith(twoDaysAgo2));
        }

        private void UpdateMetadataRepositoryWithNewStandards()
        {
            _metaDataHelper.UpdateMetadataRepository();
        }

        private IEnumerable<MetaDataItem> GetStandardsMetaDataFromGit()
        {
            return _metaDataHelper.GetAllStandardsMetaData();
        }

        private void CreateAlias(string indexName)
        {
            _searchIndexMaintainer.CreateIndexAlias(_settings.IndexesAlias, indexName);
        }

        private bool CheckIfAliasExists(string aliasName)
        {
            return _searchIndexMaintainer.AliasExists(aliasName);
        }
    }
}