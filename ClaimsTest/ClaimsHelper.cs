using System;
using System.Security.Claims;
using System.Threading;

namespace ClaimsTest
{
    public static class ClaimsHelper
    {
        /// <summary>
        /// Usage: ClaimsHelper.GetCurrentUserClaim("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name").Value
        /// </summary>
        /// <param name="claimType">Claim type</param>
        /// <returns>System.Security.Claims.Claim</returns>
        public static Claim GetCurrentUserClaim(string claimType)
        {
            if (string.IsNullOrEmpty(claimType))
                throw new ArgumentNullException("claimType");

            ClaimsPrincipal claimsPrincipal = Thread.CurrentPrincipal as ClaimsPrincipal;
            if (claimsPrincipal == null)
                throw new ArgumentException("Cannot get current principal.");

            return claimsPrincipal.FindFirst(claimType);        
        }

    }
}