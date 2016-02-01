﻿namespace Sfa.Eds.Das.Web.Services
{
    using System.Linq;
    using System;
    using System.Configuration;
    using Nest;
    using Sfa.Eds.Das.Web.Models;

    public class SearchService : ISearchForStandards
    {
        public SearchResults Search(string keywords)
        {
            var searchHost = ConfigurationManager.AppSettings["SearchHost"];
            var node = new Uri(searchHost);

            var settings = new ConnectionSettings(
                node,
                defaultIndex: "cistandardindexesalias");

            settings.MapDefaultTypeNames(d => d.Add(typeof(SearchResultsItem), "standarddocument"));

            var client = new ElasticClient(settings);

            var results = client.Search<SearchResultsItem>(s => s
            .From(0)
            .Size(1000)
            .QueryString(keywords));

            return new SearchResults
            {
                TotalResults = results.Total,
                Results = results.Documents
            };
        }

        public SearchResultsItem GetStandardItem(string standardId)
        {
            var searchHost = ConfigurationManager.AppSettings["SearchHost"];
            var node = new Uri(searchHost);

            var settings = new ConnectionSettings(
                node,
                defaultIndex: "cistandardindexesalias");

            settings.MapDefaultTypeNames(d => d.Add(typeof(SearchResultsItem), "standarddocument"));
            var client = new ElasticClient(settings);

            var results =
                client.Search<SearchResultsItem>(
                    s => s
                    .From(0)
                    .Size(1000)
                    .Query(q =>
                        q.QueryString(qs =>
                            qs.OnFields(e => e.StandardId)
                            .Query(standardId)))
                    );

            return results.Documents.Any() ? results.Documents.First() : null;
        }

    }
}