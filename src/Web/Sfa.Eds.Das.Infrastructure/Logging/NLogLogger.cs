﻿using System;
using Microsoft.ApplicationInsights.NLogTarget;
using NLog;
using NLog.Targets.ElasticSearch;
using Sfa.Eds.Das.Core.Logging;

namespace Sfa.Eds.Das.Infrastructure.Logging
{
    using System.Collections.Generic;

    using NLog.Config;

    public class NLogLogger : ILog
    {
        private readonly string _loggerType;

        private readonly Dictionary<string, object> defaultProperties = new Dictionary<string, object>(); 
#pragma warning disable S1144, 0169// Unused private types or members should be removed
        private ElasticSearchTarget dummy; // Reference so assembly is copied to Primary output.
        private ApplicationInsightsTarget dummy2; // Reference so assembly is copied to Primary output.
#pragma warning restore S1144, 0169 // Unused private types or members should be removed

        public NLogLogger(Type loggerType)
        {
            _loggerType = loggerType?.ToString() ?? "DefaultWebLogger";
        }

        public LoggingConfiguration LoggingConfiguration { get; set; }

        public void Info(string msg)
        {
            SendLog(msg, LogLevel.Info);
        }

        public void Info(string msg, Dictionary<string, object> properties)
        {
            SendLog(msg, LogLevel.Info, properties);
        }

        public void Debug(string msg)
        {
            SendLog(msg, LogLevel.Debug);
        }

        public void Error(string msg)
        {
            SendLog(msg, LogLevel.Error);
        }

        public void Error(Exception ex, string msg)
        {
            SendLog(msg, LogLevel.Error, defaultProperties, ex);
        }

        public void Warn(string msg)
        {
            SendLog(msg, LogLevel.Warn);
        }

        public void Fatal(string msg)
        {
            SendLog(msg, LogLevel.Fatal);
        }

        private void SendLog(string msg, LogLevel level, Dictionary<string, object> properties = null, Exception exception = null)
        {
            var propertiesLocal = new Dictionary<string, object>();
            if (properties != null)
            {
                propertiesLocal = properties;
            }

            propertiesLocal.Add("Application", "Sfa.Das.Web");
            propertiesLocal.Add("LoggerType", _loggerType);

            var logEvent = new LogEventInfo(level, _loggerType, msg) { Exception = exception };

            foreach (var property in propertiesLocal)
            {
                logEvent.Properties[property.Key] = property.Value;
            }

            ILogger log = LogManager.GetCurrentClassLogger();
            log.Log(logEvent);
        }
    }
}
