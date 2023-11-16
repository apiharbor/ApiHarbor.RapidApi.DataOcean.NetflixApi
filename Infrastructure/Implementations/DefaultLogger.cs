using System;
using System.Collections.Generic;
using System.Text;

namespace ApiHarbor.RapidApi.DataOcean.NetflixApi.Infrastructure.Implementations
{
    internal class DefaultLogger : ILogger
    {
        public void Info(string message)
        {
            Console.WriteLine($"[INFO]{message}");
        }

        public void Error(string message, Exception exception = null)
        {
            Console.WriteLine($"[ERR]{message}");
            if (exception != null)
            {
                Console.WriteLine(exception.Message);
                Console.WriteLine(exception.StackTrace);
            }
        }
    }
}
