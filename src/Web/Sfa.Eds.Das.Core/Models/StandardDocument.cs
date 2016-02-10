﻿namespace Sfa.Eds.Das.Core.Models
{
    public class StandardDocument
    {
        public int StandardId { get; set; }
        public string Title { get; set; }
        public int NotionalEndLevel { get; set; }
        public int NotionalEntryLevel { get; set; }
        public string PdfFileName { get; set; }
        public string PdfUrl { get; set; }
        public Attachment File { get; set; }
        public string MinimumLength { get; set; }
    }
}