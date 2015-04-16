namespace ClubCloud.Service
{
    using ClubCloud.Model;
    using System;
    using System.Collections.Generic;
    using System.Net.Mail;
    using System.ServiceModel;
    using System.ServiceModel.Description;
    using System.Web.UI;
    using System.Web.UI.WebControls;

    public partial class ClubCloudServiceClient //: BaseServiceClient
    {
        /*
        public bool SendMessage(MailMessage message, ClubCloud_Setting settings = null)
        {

            bool response = false;

            this.ExecuteOnChannel<IClubCloudApplicationService>(
                delegate(IClubCloudApplicationService channel)
                {
                    response = channel.SendMessage(message, settings);
                },
                false);

            return response;

        }
        */
    }
}