﻿namespace Sfa.Deds.Settings
{
    public interface ILarsSettings
    {
        string SearchEndpointConfigurationName { get; }
        string DatasetName { get; }
        string StandardDescriptorName { get; }
    }
}