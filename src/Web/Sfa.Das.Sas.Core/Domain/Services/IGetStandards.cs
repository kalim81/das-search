﻿using System.Collections.Generic;
using Sfa.Das.Sas.Core.Domain.Model;

namespace Sfa.Das.Sas.Core.Domain.Services
{
    public interface IGetStandards
    {
        Standard GetStandardById(int id);
        IEnumerable<Standard> GetStandardsByIds(IEnumerable<int> ids);
    }
}
