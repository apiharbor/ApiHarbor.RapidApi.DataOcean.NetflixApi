using System;
using System.Collections.Generic;
using System.Text;

namespace ApiHarbor.RapidApi.DataOcean.NetflixApi.Infrastructure
{
    public interface ILogger
    {
        void Info(string message);
        void Error(string message, Exception exception = null);
    }
}
