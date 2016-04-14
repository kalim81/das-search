﻿using Elasticsearch.Net;
using Nest;
using Sfa.Infrastructure.Settings;

namespace Sfa.Infrastructure.Elasticsearch
{
    public class ElasticsearchClientFactory : IElasticsearchClientFactory
    {
        private readonly ConnectionSettings _connectionSettings;

        public ElasticsearchClientFactory(IInfrastructureSettings infrastructureSettings)
        {
            _connectionSettings = new ConnectionSettings(new StaticConnectionPool(infrastructureSettings.ElasticServerUrls));
        }

        public IElasticClient GetElasticClient()
        {
            var client = new ElasticClient(_connectionSettings);
            return client;
        }
    }
}