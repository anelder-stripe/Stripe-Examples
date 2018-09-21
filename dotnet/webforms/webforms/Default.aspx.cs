using System;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;

namespace webforms
{

    public partial class Default : System.Web.UI.Page
    {
        public string stripePublishableKey = WebConfigurationManager.AppSettings["StripePublishableKey"];
    }
}
