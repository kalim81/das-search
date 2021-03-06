﻿namespace Sfa.Das.Sas.Web.Services
{
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    using Sfa.Das.Sas.Core.Logging;

    public class Validation : IValidation
    {
        private readonly ILog _logger;

        public Validation(ILog logger)
        {
            _logger = logger;
        }

        public bool ValidatePostcode(string postCode)
        {
            var match = Regex.Match(postCode ?? string.Empty, @"^[A-Z]{1,2}[0-9][A-Z0-9]?\s?[0-9][ABD-HJLNP-UW-Z]{2}$", RegexOptions.IgnoreCase);
            if (!match.Success)
            {
                var dict = new Dictionary<string, object> { { "Postcode", postCode }, { "Identifier", "Postcodes-ValidationFail" } };
                _logger.Info("Postcode not validate", dict);
            }

            return match.Success;
        }
    }
}