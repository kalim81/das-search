﻿using System.Text.RegularExpressions;

namespace Sfa.Das.Sas.Infrastructure.Elasticsearch
{
    internal static class QueryHelper
    {
        internal static string FormatQuery(string query, bool toLower = true)
        {
            if (string.IsNullOrEmpty(query))
            {
                return "*";
            }

            var queryformated = Regex.Replace(query, @"[+\-&|!(){}\[\]^""~?:\\/]", @" ");

            return toLower ? queryformated.ToLowerInvariant() : queryformated;
        }
    }
}
