using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncfusionPoC.Logger
{
    interface ILogger
    {
        void LogInfo(string message);
        void LogError(string message);
    }
}
