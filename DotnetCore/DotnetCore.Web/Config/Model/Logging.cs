using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetCore.Web
{
    public class Logging
    {
        public bool IncludeScopes { get; set; }

        public LogLevel LogLevel { get; set; }
    }

    public class LogLevel
    {
        public string Default { get; set; }
    }
}
