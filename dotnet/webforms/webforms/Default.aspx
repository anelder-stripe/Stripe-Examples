<%@ Page Language="C#" Inherits="webforms.Default" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<title>Default</title>
</head>
<body>
    <form action="/Charge.aspx" method="POST">
        <script
            src="https://checkout.stripe.com/checkout.js" class="stripe-button"
            data-key="<%= stripePublishableKey %>"
            data-amount="500"
            data-name="Stripe.com"
            data-description="Sample Charge"
            data-locale="auto"
            data-zip-code="true">
        </script>
    </form>
</body>
</html>
