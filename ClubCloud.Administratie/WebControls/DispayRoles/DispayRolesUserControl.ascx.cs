using System;
using System.ComponentModel;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace ClubCloud.Administratie.WebControls
{
    public partial class DispayRolesUserControl : UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
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
