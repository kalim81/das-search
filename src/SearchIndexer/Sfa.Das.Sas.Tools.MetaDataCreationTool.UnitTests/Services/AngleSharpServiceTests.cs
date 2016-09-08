﻿using System.Linq;
using Moq;
using NUnit.Framework;
using Sfa.Das.Sas.Indexer.ApplicationServices.Http;
using Sfa.Das.Sas.Tools.MetaDataCreationTool.Services;

namespace Sfa.Das.Sas.Tools.MetaDataCreationTool.UnitTests.Services
{
    using Sfa.Das.Sas.Indexer.Core.Logging;

    [TestFixture]
    public class AngleSharpServiceTests
    {
        private readonly string _htmlText = "<html><body>" + "<div>" + "<a href=\"goodbye.com\">Goodbye</a>" + "<a href=\"hello.com\">HELLO</a>" + "<a href=\"Hej.com\">Hej</a>" + "</div>" + "</body></html>";

        [Test]
        public void WhenGettingLinks()
        {
            var mockBrowsingContext = new Mock<IHttpGet>();
            mockBrowsingContext.Setup(m => m.Get(It.IsAny<string>(), null, null)).Returns(_htmlText);

            AngleSharpService angleSharpService = new AngleSharpService(mockBrowsingContext.Object, Mock.Of<ILog>());
            var x = angleSharpService.GetLinks("path/to/something", "div a", "HELLO");

            Assert.AreEqual(1, x.Count);
            Assert.AreEqual("hello.com", x.FirstOrDefault());
        }

        [Test]
        public void WhenUrlIsEmpty()
        {
            var mockBrowsingContext = new Mock<IHttpGet>();
            mockBrowsingContext.Setup(m => m.Get(It.IsAny<string>(), null, null)).Returns(_htmlText);

            AngleSharpService angleSharpService = new AngleSharpService(mockBrowsingContext.Object, Mock.Of<ILog>());
            var x = angleSharpService.GetLinks(string.Empty, "div a", "HELLO");

            Assert.AreEqual(0, x.Count);
        }
    }
}
