using System;
using System.Security.Claims;
using System.Threading;

namespace ClaimsTest
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            signedIn.InnerText = "You are not signed in.";
            
            ClaimsPrincipal claimsPrincipal = Thread.CurrentPrincipal as ClaimsPrincipal;
            if (claimsPrincipal != null)
            {
                string claims = string.Empty;
                signedIn.InnerText = "Your user identity is " + User.Identity.Name;
                foreach (Claim claim in claimsPrincipal.Claims)
                    claims += string.Format("<li>{0} <span class='claimValue'>{1}</span></li>", claim.Type, claim.Value);

                claimsList.InnerHtml = claims;
            }
        }
    }
}