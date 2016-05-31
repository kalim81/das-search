﻿namespace Sfa.Das.Sas.WebTest.Pages
{
    using OpenQA.Selenium;

    using Sfa.Das.Sas.WebTest.Pages.Shared;

    using SpecBind.Pages;

    [PageNavigation("/Apprenticeship/Standard")]
    public class StandardDetailsPage : SharedTemplatePage
    {
        [ElementLocator(CssSelector = "a.ui-find-training-providers")]
        public IWebElement SearchPageButton { get; set; }
        
        [ElementLocator(CssSelector = "#bottom-actions .shortlist-link")]
        public IWebElement ShortlistLink { get; set; }
    }
}