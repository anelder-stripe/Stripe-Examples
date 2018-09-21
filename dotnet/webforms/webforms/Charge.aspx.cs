using System;
using System.Web;
using System.Web.UI;
using Stripe;

namespace webforms
{

    public partial class Charge : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e) {
            if (Request.Form["stripeToken"] != null)
            {
                var customers = new StripeCustomerService();
                var charges = new StripeChargeService();

                var customer = customers.Create(new StripeCustomerCreateOptions
                {
                    Email = Request.Form["stripeEmail"],
                    SourceToken = Request.Form["stripeToken"]
                });

                var charge = charges.Create(new StripeChargeCreateOptions
                {
                    Amount = 500,
                    Description = "Sample Charge",
                    Currency = "usd",
                    CustomerId = customer.Id
                });

                Console.WriteLine(charge.Id);
            }

        }
    }
}
