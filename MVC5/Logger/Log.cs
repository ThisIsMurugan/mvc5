using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NLog;
using NLog.Config;
using NLog.Targets;

namespace MVC5.Logger
{
    internal static class Log
    {
        public static NLog.Logger Instance { get; private set; }
        static Log()
        {
            LogManager.ReconfigExistingLoggers();
            Instance = LogManager.GetCurrentClassLogger();
        }
    }
}