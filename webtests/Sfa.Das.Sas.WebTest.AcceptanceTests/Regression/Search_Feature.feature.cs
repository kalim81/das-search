﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.0.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Sfa.Das.Sas.WebTest.AcceptanceTests.Regression
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Search_Feature")]
    public partial class Search_FeatureFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Search_Feature.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Search_Feature", "\tAs an employer I want to be able to use the service\r\n\tTo search for different St" +
                    "andards\r\n\tTo search for different Frameworks\r\n\tTo search for different Providers" +
                    " in different postcodes \t", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Should find a apprenticeship by the job role")]
        [NUnit.Framework.CategoryAttribute("Regression")]
        [NUnit.Framework.TestCaseAttribute("railway", "Railway engineering design technician", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Junior management consultant", "Junior management consultant", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Relationship manager (banking)", "Relationship manager (banking)", new string[0])]
        public virtual void ShouldFindAApprenticeshipByTheJobRole(string searchTerm, string title, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Regression"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Should find a apprenticeship by the job role", @__tags);
#line 11
this.ScenarioSetup(scenarioInfo);
#line 13
 testRunner.Given("I navigated to the Search page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table1.AddRow(new string[] {
                        "Search Box",
                        string.Format("{0}", searchTerm)});
#line 14
 testRunner.When("I enter data", ((string)(null)), table1, "When ");
#line 17
 testRunner.And("I choose Search Button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 18
 testRunner.Then("I am on the Search Results page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table2.AddRow(new string[] {
                        "Title",
                        "Equals",
                        string.Format("{0}", title)});
#line 19
 testRunner.And("I see Apprenticeship Results list Contains", ((string)(null)), table2, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Should display error for invalid postcode")]
        [NUnit.Framework.CategoryAttribute("Regression")]
        public virtual void ShouldDisplayErrorForInvalidPostcode()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Should display error for invalid postcode", new string[] {
                        "Regression"});
#line 31
this.ScenarioSetup(scenarioInfo);
#line 32
 testRunner.Given("I navigated to the Search page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table3.AddRow(new string[] {
                        "Search Box",
                        "Digital"});
#line 33
 testRunner.When("I enter data", ((string)(null)), table3, "When ");
#line 36
 testRunner.And("I choose Search Button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
 testRunner.Then("I am on the Search Results page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 38
 testRunner.When("I choose First Standard Result", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 39
 testRunner.Then("I am on the Standard Details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 40
 testRunner.When("I choose Search Page Button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 41
 testRunner.Then("I am on the Standard Provider Search page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table4.AddRow(new string[] {
                        "Postcode Search Box",
                        "X123"});
#line 42
 testRunner.When("I enter data", ((string)(null)), table4, "When ");
#line 45
 testRunner.And("I choose Search Button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 46
 testRunner.When("I wait for the view to become active", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Rule",
                        "Value"});
            table5.AddRow(new string[] {
                        "error message",
                        "contains",
                        "You must enter a full and valid postcode"});
#line 47
 testRunner.Then("I see", ((string)(null)), table5, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
