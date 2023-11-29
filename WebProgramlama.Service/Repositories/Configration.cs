using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace WebProgramlama.Service.Repositories
{
    static class Configuration
    {
        static public string ConnectionString
        {
            get
            {
                ConfigurationManager configurationManager = new();
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../WebProgramlama.Web"));
                configurationManager.AddJsonFile("appsettings.json");

                return configurationManager.GetConnectionString("WebProgramlamaProjeDb");
            }
        }
    }
}
