using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Social.LinkedIn
{
    internal class LinkedInToken
    {
        public string access_token
        {
            get;
            set;
        }

        public long expires_in
        {
            get;
            set;
        }

        public LinkedInToken()
        {
        }
    }
}
