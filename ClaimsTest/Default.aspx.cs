using System;
using System.Security.Claims;
using System.Threading;

namespace ClaimsTest
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ClaimsPrincipal claimsPrincipal = Page.User as ClaimsPrincipal;
            if (claimsPrincipal != null)
                signedIn.InnerText = "You've signed in as " + User.Identity.Name;
            this.ClaimsGridView.DataSource = claimsPrincipal.Claims;
            this.ClaimsGridView.DataBind();
        }
    }
}
