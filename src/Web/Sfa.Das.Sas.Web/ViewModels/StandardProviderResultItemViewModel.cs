﻿using System.Collections.Generic;
using Sfa.Das.Sas.Core.Domain.Model;

namespace Sfa.Das.Sas.Web.ViewModels
{
    public class StandardProviderResultItemViewModel
    {
        public string Id { get; set; }

        public string UkPrn { get; set; }

        public string Name { get; set; }

        public int StandardCode { get; set; }

        public int LocationId { get; set; }

        public string LocationName { get; set; }

        public string MarketingName { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string ContactUsUrl { get; set; }

        public List<string> DeliveryModes { get; set; }

        public string Website { get; set; }

        public Address Address { get; set; }

        public double Distance { get; set; }

        public string EmployerSatisfactionMessage { get; set; }

        public string LearnerSatisfactionMessage { get; set; }

        public bool IsShortlisted { get; set; }
    }
}