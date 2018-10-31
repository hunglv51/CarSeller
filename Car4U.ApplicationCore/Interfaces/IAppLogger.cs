using System;
using System.Collections.Generic;
using System.Text;

namespace Car4U.ApplicationCore.Interfaces
{
    public interface IAppLogger<T>
    {
        void LogInfo(string msg, params object[] args);
        void LogError(string msg, params object[] args);
    }
}
