namespace Sfa.Eds.Das.Web.DependencyResolution
{
    using ApplicationServices;
    using Core.Logging;
    using Infrastructure.Logging;
    using Infrastructure.PostCodeIo;

    using Sfa.Das.ApplicationServices;
    using Sfa.Eds.Das.Core.Configuration;
    using Sfa.Eds.Das.Core.Domain.Services;
    using Sfa.Eds.Das.Infrastructure.Configuration;
    using Sfa.Eds.Das.Infrastructure.ElasticSearch;
    using Sfa.Eds.Das.Web.Services;

    using StructureMap.Configuration.DSL;

    public class SearchRegistry : Registry
    {
        public SearchRegistry()
        {
            For<IElasticsearchClientFactory>().Use<ElasticsearchClientFactory>();
            For<IConfigurationSettings>().Use<ApplicationSettings>();
            For<IMappingService>().Use<MappingService>();
            For<ILog>().Use(x => new NLogLogger(x.ParentType)).AlwaysUnique();

            // New infrastructure
            For<IElasticsearchClientFactory>().Use<ElasticsearchClientFactory>();
            For<ILookupLocations>().Use<PostCodesIOLocator>();

            For<IStandardSearchService>().Use<StandardSearchService>();
            For<IStandardRepository>().Use<StandardRepository>();
            For<ISearchProvider>().Use<ElasticsearchProvider>();

            For<IProviderSearchService>().Use<ProviderSearchService>();
        }
    }
}