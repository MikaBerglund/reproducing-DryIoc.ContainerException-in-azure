using FunctionsAppWithDI.Services;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;

namespace FunctionsAppWithDI
{
    public class DataFunctions
    {
        public DataFunctions(DataService service)
        {

        }


        [FunctionName("data")]
        public HttpResponseMessage PingData([HttpTrigger(AuthorizationLevel.Function, "GET")]HttpRequestMessage request)
        {
            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent("OK")
            };
        }
    }
}
