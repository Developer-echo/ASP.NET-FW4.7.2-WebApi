using System.Web.Configuration;

namespace WebHelper.ConfigHelper
{
    public class GetConfigValue
    {
        public static string ConnSettings { get { return WebConfigurationManager.AppSettings["ConnSettings"]; } }
    }
}
