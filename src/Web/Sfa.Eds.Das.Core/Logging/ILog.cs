﻿using System;

namespace Sfa.Eds.Das.Core.Logging
{
    using System.Collections.Generic;

    public interface ILog
    {
        void Info(string msg);

        void Info(string msg, Dictionary<string, object> properties);

        void Debug(string msg);

        void Debug(string msg, Dictionary<string, object> properties);

        void Warn(string msg);

        void Error(string msg);

        void Error(Exception ex, string msg);

        void Fatal(string msg);
    }
}
