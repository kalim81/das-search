﻿using System.Linq;
using Sfa.Das.Sas.ApplicationServices.Models;
using Sfa.Das.Sas.Core.Domain.Model;

namespace Sfa.Das.Sas.Infrastructure.Mapping
{
    public class FrameworkMapping : IFrameworkMapping
    {
        public Framework MapToFramework(FrameworkSearchResultsItem document)
        {
            var framework = new Framework
            {
                Title = document.Title,
                Level = document.Level,
                FrameworkCode = document.FrameworkCode,
                FrameworkId = document.FrameworkId,
                FrameworkName = document.FrameworkName,
                PathwayCode = document.PathwayCode,
                PathwayName = document.PathwayName,
                TypicalLength = document.TypicalLength,
                ExpiryDate = document.ExpiryDate,
                JobRoleItems = document.JobRoleItems,
                CompletionQualifications = document.CompletionQualifications,
                FrameworkOverview = document.FrameworkOverview,
                EntryRequirements = document.EntryRequirements,
                ProfessionalRegistration = document.ProfessionalRegistration,
                CompetencyQualification = document.CompetencyQualification?.OrderBy(x => x),
                KnowledgeQualification = document.KnowledgeQualification?.OrderBy(x => x),
                CombinedQualification = document.CombinedQualification?.OrderBy(x => x)
            };

            return framework;
        }
    }
}
