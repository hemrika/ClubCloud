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
    public class RolesSecurityTrimmedControl : WebControl, IDesignerEventAccessor
    {
        private readonly static string RolesKeyName = "Roles";
        
        private SPContext m_renderContext;

        private bool m_shouldRenderInitialized;

        private bool m_shouldRender;

        public RolesSecurityTrimmedControl()
        {
        }

        internal RolesSecurityTrimmedControl(HtmlTextWriterTag tag)
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

        #region MembershipProvider

        private ZimbraRoleProvider m_roleProvider;

        internal ZimbraRoleProvider RoleProvider
        {
            get
            {
                if (this.m_roleProvider == null)
                {
                    this.m_roleProvider = System.Web.Security.Roles.Providers["ZimbraRoleProvider"] as ZimbraRoleProvider;
                }
                return this.m_roleProvider;
            }
        }

        #endregion
        [Category("Behavior")]
        [DefaultValue(false)]
        public bool EmitDiv
        {
            get;
            set;
        }

        /// <summary>Gets or sets the Roles.</summary>
        [TypeConverter(typeof(RolesConverter))]
        [Category("Important")]
        [DefaultValue("")]
        public List<string> Roles
        {
            get
            {
                return GetRoles();
            }
            set
            {
                this.ViewState[RolesKeyName] = value;
                this.m_shouldRenderInitialized = false;
            }
        }

        /// <summary>Gets or sets the RolesString.</summary>
        [Category("Behavior")]
        [DefaultValue("")]
        public string RolesString
        {
            get
            {
                return this.Roles.ToString();
            }
            set
            {
                this.Roles = ParseRoles(value);
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
                    string[] userRoles = RoleProvider.GetRolesForUser(SPContext.Current.Web.CurrentUser.UserId.NameId);
                    this.m_shouldRender = (Roles.Intersect(userRoles).ToArray().Length > 0);
                    //RoleProvider.IsUserInRole(SPContext.Current.Web.CurrentUser.LoginName, "All Authenticated Users");
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

        internal List<string> GetRoles()
        {
            object item = this.ViewState[RolesKeyName];
            if (item == null)
            {
                return new List<string>();
            }
            return (List<string>)item;
        }

        internal List<string> ParseRoles(string RolesString)
        {
            List<string> roles = new List<string>();
            string[] roleArray = RolesString.Split(new char[] { ',' });

            for (int i = 0; i < (int)roleArray.Length; i++)
            {
                roles.Add(roleArray[i]);
            }

            return roles;
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
