using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using LCU.State.API.Devices.ConfigManager.Models;
using LCU.State.API.Devices.ConfigManager.Harness;

namespace LCU.State.API.Devices.ConfigManager
{
    public static class Refresh
    {
        [FunctionName("Refresh")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Admin, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            return await req.Manage<dynamic, DevicesConfigManagerState, DevicesConfigManagerStateHarness>(log, async (mgr, reqData) =>
            {
                await mgr.Ensure();

                log.LogInformation("Refreshing.");

                return await mgr.WhenAll(
                    
                );
            });
        }
    }
}
