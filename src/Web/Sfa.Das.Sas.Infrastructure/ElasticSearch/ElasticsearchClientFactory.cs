﻿using Elasticsearch.Net;
using Nest;
using Sfa.Das.Sas.ApplicationServices.Models;
using Sfa.Das.Sas.Core.Configuration;

namespace Sfa.Das.Sas.Infrastructure.Elasticsearch
{
    public sealed class ElasticsearchClientFactory : IElasticsearchClientFactory
    {
        private readonly IConfigurationSettings _applicationSettings;

        public ElasticsearchClientFactory(IConfigurationSettings applicationSettings)
        {
            _applicationSettings = applicationSettings;
        }

        public IElasticClient Create()
        {
            using (var settings = new ConnectionSettings(new StaticConnectionPool(_applicationSettings.ElasticServerUrls)))
            {
                settings.DisableDirectStreaming();
                settings.MapDefaultTypeNames(d => d.Add(typeof(StandardSearchResultsItem), "standarddocument"));
                settings.MapDefaultTypeNames(d => d.Add(typeof(StandardProviderSearchResultsItem), "standardprovider"));
                settings.MapDefaultTypeNames(d => d.Add(typeof(FrameworkProviderSearchResultsItem), "frameworkprovider"));

                return new ElasticClient(settings);
            }
        }
    }
}