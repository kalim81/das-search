﻿namespace Sfa.Eds.Das.Web.ViewModels
{
    using System.Collections.Generic;

    public class ProviderStandardSearchResultViewModel
    {
        public long TotalResults { get; set; }

        public int StandardId { get; set; }

        public string StandardName { get; set; }

        public string PostCode { get; set; }

        public IEnumerable<ProviderResultItemViewModel> Hits { get; set; }

        public bool HasError { get; set; }

        public bool PostCodeMissing { get; set; }
    }
}