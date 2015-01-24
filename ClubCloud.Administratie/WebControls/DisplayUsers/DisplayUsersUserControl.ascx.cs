using Microsoft.SharePoint;
using Microsoft.SharePoint.Utilities;
using System;
using System.ComponentModel;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace ClubCloud.Administratie.WebControls
{
    public partial class DisplayUsersUserControl : UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UserDataSource.ViewName = this.ViewName;
            UserDataSource.Assembly = typeof(DisplayUsersUserControl).Assembly;
        }

        //
        // Summary:
        //     Gets or sets a Boolean value indicating whether themes apply to the control
        //     that is derived from the System.Web.UI.TemplateControl class.
        //
        // Returns:
        //     true to use themes; otherwise, false. The default is true.
        [Browsable(true)]
        public string ViewName { get; set; }
    }
}
