namespace ClubCloud.Administratie.WebControls
{
    using System;
    using System.Web.DynamicData;
    
    public partial class ClubCloud_Accommodatie_Template : EntityTemplateUserControl
    {
        protected void DynamicControl_Init(object sender, EventArgs e)
        {
            DynamicControl dynamicControl = (DynamicControl)sender;
            dynamicControl.Mode = this.Mode;
        }
    }
    
}

