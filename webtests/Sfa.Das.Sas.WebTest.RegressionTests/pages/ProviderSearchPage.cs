﻿namespace Sfa.Das.Sas.WebTest.RegressionTests.pages
{
    using OpenQA.Selenium;

    using Sfa.Das.Sas.WebTest.RegressionTests.pages.shared;

    using SpecBind.Pages;

    [PageNavigation("/Apprenticeship/SearchForProviders")]
    public class ProviderSearchPage : SharedTemplatePage
    {
        [ElementLocator(Id = "search-box")]
        public IWebElement PostcodeSearchBox { get; set; }

        [ElementLocator(Class = "postcode-search-button")]
        public IWebElement SearchButton { get; set; }
    }
}