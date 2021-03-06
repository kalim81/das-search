namespace Sfa.Das.Sas.Web.ViewModels
{
    public class ProviderSearchViewModel
    {
        public string Title { get; set; }

        public bool HasError { get; set; }

        public bool WrongPostcode { get; set; }

        public string PostUrl { get; set; }

        public int ApprenticeshipId { get; set; }

        public string PostCode { get; set; }

        public string SearchTerms { get; set; }
    }
}