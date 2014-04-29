using Microsoft.IdentityModel.Claims;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IdentityModel.Claims;
using System.Security.Principal;
using System.Web.UI.WebControls.WebParts;

namespace ClubCloud.Provider.Webparts
{
    [ToolboxItemAttribute(false)]
    public partial class Claim : WebPart
    {
        // Uncomment the following SecurityPermission attribute only when doing Performance Profiling on a farm solution
        // using the Instrumentation method, and then remove the SecurityPermission attribute when the code is ready
        // for production. Because the SecurityPermission attribute bypasses the security check for callers of
        // your constructor, it's not recommended for production purposes.
        // [System.Security.Permissions.SecurityPermission(System.Security.Permissions.SecurityAction.Assert, UnmanagedCode = true)]
        public Claim()
        {
        }

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            InitializeControl();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected override void OnPreRender(EventArgs e)
        {
            IClaimsPrincipal claimsPrincipal = Page.User as IClaimsPrincipal;
            IClaimsIdentity claimsIdentity = (IClaimsIdentity)claimsPrincipal.Identity;
            bool isLid = Page.User.IsInRole("Leden");
            //List<Claim> UserClaims = new List<Claim>();

            IIdentity identity = this.Page.User.Identity;
            /*
            if (identity is IClaimsIdentity)
            {
                IClaimsIdentity claimsIdentity = (IClaimsIdentity)identity;
                foreach (var claim in claimsIdentity.Claims)
                {
                    UserClaims.Add(
                      new ClaimTypeListItem
                      {
                          ClaimType = claim.ClaimType,
                          ClaimValue = claim.Value
                      });
                }
            }
            */

            grdClaims.DataSource = claimsIdentity.Claims;
            grdClaims.DataBind();

            //base.OnPreRender(e);
        }
    }
}
