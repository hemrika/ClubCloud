using Microsoft.Owin;
using Microsoft.SharePoint;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.SignalR
{
    public class SPMiddleware : OwinMiddleware
    {
        public SPMiddleware(OwinMiddleware next)
            : base(next)
        {
        }

        public override Task Invoke(IOwinContext context)
        {
            if (SPContext.Current != null && SPContext.Current.Web != null && SPContext.Current.Web.CurrentUser != null)
            {

            }
            /*
            string username = context.Request.Headers.Get("username");

            if (!String.IsNullOrEmpty(username))
            {
                var authenticated = username == "john" ? "true" : "false";

                var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Authentication, authenticated)
                    };

                var claimsIdentity = new ClaimsIdentity(claims);
                context.Request.User = new ClaimsPrincipal(claimsIdentity);
            }
            */
            return Next.Invoke(context);
        }
    }
}
