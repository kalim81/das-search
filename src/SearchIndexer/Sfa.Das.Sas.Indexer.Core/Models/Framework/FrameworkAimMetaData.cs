﻿using System;

namespace Sfa.Das.Sas.Indexer.Core.Models.Framework
{
    public class FrameworkAimMetaData
    {
        public int FworkCode { get; set; }
        public int ProgType { get; set; }
        public int PwayCode { get; set; }
        public string LearnAimRef { get; set; }
        public DateTime EffectiveFrom { get; set; }
        public DateTime? EffectiveTo { get; set; }
        public int FrameworkComponentType { get; set; }
    }
}
