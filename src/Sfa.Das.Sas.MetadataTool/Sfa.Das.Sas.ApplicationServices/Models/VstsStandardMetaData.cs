﻿namespace Sfa.Das.Sas.ApplicationServices.Models
{
    using System.Collections.Generic;

    using Core.Models;

    public class VstsStandardMetaData
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public IEnumerable<string> JobRoles { get; set; }

        public IEnumerable<string> Keywords { get; set; }

        public int NotionalEndLevel { get; set; }

        public string StandardPdfUrl { get; set; }

        public string AssessmentPlanPdfUrl { get; set; }

        public TypicalLength TypicalLength { get; set; }

        public string IntroductoryText { get; set; }

        public string OverviewOfRole { get; set; }

        public string EntryRequirements { get; set; }

        public string WhatApprenticesWillLearn { get; set; }

        public string Qualifications { get; set; }

        public string ProfessionalRegistration { get; set; }

    }
}
