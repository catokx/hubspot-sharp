using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Net.Http;
using System.Configuration;

namespace HubSpotSharp
{
    public class HubSpotSharpConfiguration
    {
        public string ApiKey
        {
            get
            {
                try
                {
                    return System.Configuration.ConfigurationManager.AppSettings["StripeApiKey"];
                }
                catch (Exception)
                {
                    throw;
                }
            }
            set
            {
                System.Configuration.ConfigurationManager.AppSettings["StripeApiKey"] = value;
            }
        }

    }
}
