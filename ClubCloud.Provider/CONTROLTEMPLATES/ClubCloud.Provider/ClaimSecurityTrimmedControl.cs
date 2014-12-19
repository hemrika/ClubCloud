using Microsoft.IdentityModel.Claims;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Security;
using Microsoft.SharePoint.WebControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Permissions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClubCloud.Provider.Controls
{
    [AspNetHostingPermission(SecurityAction.InheritanceDemand, Level = AspNetHostingPermissionLevel.Minimal)]
    [AspNetHostingPermission(SecurityAction.LinkDemand, Level = AspNetHostingPermissionLevel.Minimal)]
    [Designer(typeof(SPControlDesigner))]
    [ParseChildren(false)]
    [SharePointPermission(SecurityAction.InheritanceDemand, ObjectModel = true)]
    [SharePointPermission(SecurityAction.LinkDemand, ObjectModel = true)]
    //[ToolboxData("<{0}:CCTrimmmedControl runat=server></{0}:CCTrimmmedControl>")]
    public class ClaimSecurityTrimmedControl : WebControl, IDesignerEventAccessor
    {
        private readonly static string ClaimsKeyName = "Claims";
        
        private SPContext m_renderContext;

        private bool m_shouldRenderInitialized;

        private bool m_shouldRender;

        public ClaimSecurityTrimmedControl()
        {
        }

        internal ClaimSecurityTrimmedControl(HtmlTextWriterTag tag)
            : base(tag)
        {
        }

        /// <param name="e">The HtmlTextWriter object that receives the server control content.</param>
        [SharePointPermission(SecurityAction.Demand, ObjectModel = true)]
        void Microsoft.SharePoint.WebControls.IDesignerEventAccessor.OnDesignerLoad(EventArgs e)
        {
            this.OnLoad(e);
        }

        /// <param name="e">An EventArgs object that contains the OnDesignerPreRender data. </param>
        [SharePointPermission(SecurityAction.Demand, ObjectModel = true)]
        void Microsoft.SharePoint.WebControls.IDesignerEventAccessor.OnDesignerPreRender(EventArgs e)
        {
            this.EnsureChildControls();
            this.OnPreRender(e);
        }

        public override string AccessKey
        {
            [SharePointPermission(SecurityAction.Demand, ObjectModel = true)]
            get
            {
                return base.AccessKey;
            }
            [SharePointPermission(SecurityAction.Demand, ObjectModel = true)]
            set
            {
                if (value == null || value.Length <= 1 || !value.StartsWith("<%$Resources:"))
                {
                    base.AccessKey = value;
                    return;
                }
                this.ViewState["AccessKey"] = value;
            }
        }

        [Category("Behavior")]
        [DefaultValue(false)]
        public bool EmitDiv
        {
            get;
            set;
        }

        /// <summary>Gets or sets the Roles.</summary>
        [TypeConverter(typeof(ClaimsConverter))]
        [Category("Important")]
        //[DefaultValue( new List<Microsoft.IdentityModel.Claims.Claim>() { new Microsoft.IdentityModel.Claims.Claim("http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "All Authenticated Users", "http://www.w3.org/2001/XMLSchema#string", "SharePoint", "Forms:ZimbraRoleProvider")})]
        [DefaultValue("")]
        public List<Microsoft.IdentityModel.Claims.Claim> Claims
        {
            get
            {
                //SPContext.Current.Web.CurrentUser.Roles
                return GetClaims();
            }
            set
            {
                this.ViewState[ClaimsKeyName] = value;
                this.m_shouldRenderInitialized = false;
            }
        }

        /// <summary>Gets or sets the RolesString.</summary>
        [Category("Behavior")]
        [DefaultValue("")]
        public string ClaimsString
        {
            get
            {
                return this.Claims.ToString();
            }
            set
            {
                this.Claims = ParseClaims(value);
                this.m_shouldRenderInitialized = false;
            }
        }

        internal bool ShouldRender
        {
            get
            {
                if (!this.m_shouldRenderInitialized)
                {
                    this.m_shouldRenderInitialized = true;
                    IClaimsPrincipal claimsPrincipal = Page.User as IClaimsPrincipal;
                    IClaimsIdentity claimsIdentity = (IClaimsIdentity)claimsPrincipal.Identity;
                    ClaimCollection collection = claimsIdentity.Claims;
                    this.m_shouldRender = (Claims.Intersect(collection).ToArray().Length > 0);

                    //this.m_shouldRender = (base.DesignMode ? true : Provider.IsUserInRole
                    /*
                    if (this.HideFromSearchCrawler)
                    {
                        this.m_shouldRender = (!this.m_shouldRender ? false : !SPUtility.IsSearchCrawlerRequest(this.Page.Request));
                    }
                    */
                }
                return this.m_shouldRender;
            }
        }

        /*
        if (RightsSensitiveVisibilityHelper.UserHasRights(permissionContext, permissions, permissionMode, renderContext, null, contextList) && RightsSensitiveVisibilityHelper.PageIsInMode(pageModes) && RightsSensitiveVisibilityHelper.AuthenticationRestrictionMatchesCurrentRequest(authenticationRestrictions))
        {
            return true;
        }
            return false;
        }
        */

        internal List<Microsoft.IdentityModel.Claims.Claim> GetClaims()
        {
            object item = this.ViewState[ClaimsKeyName];
            if (item == null)
            {
                return new List<Microsoft.IdentityModel.Claims.Claim>();// { new Microsoft.IdentityModel.Claims.Claim("http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "All Authenticated Users", "http://www.w3.org/2001/XMLSchema#string", "SharePoint", "Forms:ZimbraRoleProvider") };
            }

            return (List<Microsoft.IdentityModel.Claims.Claim>)item;
        }

        internal List<Claim> ParseClaims(string ClaimsString)
        {
            List<Claim> claims = new List<Claim>();
            string[] claimArray = ClaimsString.Split(new char[] { ',' });

            for (int i = 0; i < (int)claimArray.Length; i++)
            {
                claims.Add(new Claim("http://schemas.microsoft.com/ws/2008/06/identity/claims/role", claimArray[i], "http://www.w3.org/2001/XMLSchema#string", "SharePoint", "Forms:ZimbraRoleProvider"));
            }

            return claims;
        }

        protected override HtmlTextWriterTag TagKey
        {
            get
            {
                if (this.EmitDiv)
                {
                    return HtmlTextWriterTag.Div;
                }
                return base.TagKey;
            }
        }

        /// <summary>Gets or sets the Boolean Visible property.</summary>
        public override bool Visible
        {
            [SharePointPermission(SecurityAction.Demand, ObjectModel = true)]
            get
            {
                if (base.Visible && this.ShouldRender)
                {
                    return true;
                }
                return false;
            }
            [SharePointPermission(SecurityAction.Demand, ObjectModel = true)]
            set
            {
                base.Visible = value;
            }
        }

        [SharePointPermission(SecurityAction.Demand, ObjectModel = true)]
        protected override void Render(HtmlTextWriter output)
        {
            if (this.ShouldRender)
            {
                base.Render(output);
            }
        }

    }
}
