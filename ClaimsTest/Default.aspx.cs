using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClaimsTest
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ClaimsPrincipal claimsPrincipal = Thread.CurrentPrincipal as ClaimsPrincipal;

            if (claimsPrincipal != null)
            {
                signedIn.Text = "You are signed in as " + HttpContext.Current.User.Identity.Name;
                phClaims.Controls.Add(new LiteralControl("<br />"));
                foreach (Claim claim in claimsPrincipal.Claims)
                {
                    string l = string.Format("<ul><li>{0}  ==  {1}</li></ul>", claim.Type, claim.Value);
                    phClaims.Controls.Add(new LiteralControl(l));
                }
            }
            else
            {
                signedIn.Text = "You are not signed in.";
            }
        }
    }
}