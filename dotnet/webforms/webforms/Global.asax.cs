using System.Web;
using System.Web.Configuration;
using Stripe;

namespace webforms
{
    public class Global : HttpApplication
    {
        protected void Application_Start()
        {
            var secretKey = WebConfigurationManager.AppSettings["StripeSecretKey"];
            StripeConfiguration.SetApiKey(secretKey);
        }
    }
}
