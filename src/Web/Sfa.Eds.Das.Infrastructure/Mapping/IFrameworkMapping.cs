﻿using Sfa.Das.ApplicationServices.Models;
using Sfa.Eds.Das.Core.Domain.Model;

namespace Sfa.Eds.Das.Infrastructure.Mapping
{
    public interface IFrameworkMapping
    {
        Framework MapToFramework(FrameworkSearchResultsItem document);
    }
}