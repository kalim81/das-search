﻿namespace Sfa.Eds.Das.Indexer.ApplicationServices.Standard
{
    using System.Configuration;

    using Sfa.Eds.Das.Indexer.ApplicationServices.Settings;
    using Sfa.Eds.Das.Indexer.Core.Models;

    public class StandardIndexSettings : IIndexSettings<MetaDataItem>
    {
        public string SearchHost => $"http://{ElasticServerIp}:{ElasticsearchPort}";

        public string IndexesAlias => ConfigurationManager.AppSettings["StandardIndexesAlias"];

        public string StandardIndexesAlias => ConfigurationManager.AppSettings["StandardIndexesAlias"];

        public string StorageAccountName => ConfigurationManager.AppSettings["StorageAccountName"];

        public string StorageAccountKey => ConfigurationManager.AppSettings["StorageAccountKey"];

        public string ConnectionString => $"DefaultEndpointsProtocol=https;AccountName={StorageAccountName};AccountKey={StorageAccountKey}";

        public string QueueName => ConfigurationManager.AppSettings["QueueName"];

        public string PauseTime => ConfigurationManager.AppSettings["PauseTime"];

        private string ElasticServerIp => ConfigurationManager.AppSettings["ElasticServerIp"];

        private string ElasticsearchPort => ConfigurationManager.AppSettings["ElasticsearchPort"];
    }
}