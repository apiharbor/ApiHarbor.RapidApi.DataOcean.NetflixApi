using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApiHarbor.RapidApi.DataOcean.NetflixApi.Infrastructure
{
    public interface IWebClient
    {
        Task<string> ReadAsStringAsync(string url, Dictionary<string, string> headers);
    }
}
