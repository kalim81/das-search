﻿using System.Collections.Generic;
using FluentAssertions;
using Moq;
using NUnit.Framework;
using Sfa.Das.Sas.ApplicationServices.Handlers;
using Sfa.Das.Sas.ApplicationServices.Models;
using Sfa.Das.Sas.ApplicationServices.Queries;
using Sfa.Das.Sas.ApplicationServices.Responses;
using Sfa.Das.Sas.Core.Domain.Model;
using Sfa.Das.Sas.Core.Domain.Services;

namespace Sfa.Das.Sas.Web.UnitTests.Application.Handlers
{
    [TestFixture]
    public sealed class GetFrameworkHandlerTest
    {
        private GetFrameworkHandler _sut;
        private Mock<IGetFrameworks> _mockGetFrameworks;

        [SetUp]
        public void Init()
        {
            _mockGetFrameworks = new Mock<IGetFrameworks>();

            _sut = new GetFrameworkHandler(_mockGetFrameworks.Object);
        }

        [Test]
        public void ShouldReturnInvalidFrameworkIdStatusIfIdIsBelowZero()
        {
            var response = _sut.Handle(new GetFrameworkQuery() { Id = -1, Keywords = "Test" });

            response.StatusCode.Should().Be(GetFrameworkResponse.ResponseCodes.InvalidFrameworkId);
        }

        [Test]
        public void ShouldReturnFrameworkNotFoundStatusIfFrameworkCannotBeFound()
        {
            var response = _sut.Handle(new GetFrameworkQuery() { Id = 1, Keywords = "Test" });

            response.StatusCode.Should().Be(GetFrameworkResponse.ResponseCodes.FrameworkNotFound);
        }

        [Test]
        public void ShouldGetFrameworkFromGetFrameworkRepository()
        {
            var query = new GetFrameworkQuery() { Id = 1, Keywords = "Test" };

            _mockGetFrameworks.Setup(x => x.GetFrameworkById(query.Id));

            var response = _sut.Handle(query);

            _mockGetFrameworks.Verify(x => x.GetFrameworkById(query.Id), Times.Once);
        }

        [Test]
        public void ShouldReturnFoundFrameworkInResponse()
        {
            var query = new GetFrameworkQuery() { Id = 1, Keywords = "Test" };
            var framework = new Framework { FrameworkId = query.Id };

            _mockGetFrameworks.Setup(x => x.GetFrameworkById(query.Id)).Returns(framework);

            var response = _sut.Handle(query);

            response.Framework.Should().Be(framework);
        }

        [Test]
        public void ShouldReturnSearchTerms()
        {
            var query = new GetFrameworkQuery() { Id = 1, Keywords = "Test" };
            var framework = new Framework { FrameworkId = query.Id };

            _mockGetFrameworks.Setup(x => x.GetFrameworkById(query.Id)).Returns(framework);

            var response = _sut.Handle(query);

            response.SearchTerms.Should().Be(query.Keywords);
        }
    }
}
