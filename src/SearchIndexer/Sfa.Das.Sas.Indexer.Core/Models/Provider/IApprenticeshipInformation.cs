﻿using System.Collections.Generic;

namespace Sfa.Das.Sas.Indexer.Core.Models.Provider
{
    public interface IApprenticeshipInformation
    {
        ContactInformation ContactInformation { get; set; }

        string MarketingInfo { get; set; }

        string InfoUrl { get; set; }

        IEnumerable<DeliveryInformation> DeliveryLocations { get; set; }

        int Code { get; set; }

        double? OverallAchievementRate { get; set; }

        double? NationalOverallAchievementRate { get; set; }

        string OverallCohort { get; set; }
    }
}