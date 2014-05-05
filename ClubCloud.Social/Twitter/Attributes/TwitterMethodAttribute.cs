using System;
using ClubCloud.Social.Twitter.Enums;

namespace ClubCloud.Social.Twitter.Attributes {
    
    public class TwitterMethodAttribute : Attribute {

        public readonly bool IsRateLimited;
        public readonly TwitterAuthentication Authentication;
        public readonly string RequestRate;

        public TwitterMethodAttribute(bool rateLimited = false, string rate = "none", TwitterAuthentication authentication = TwitterAuthentication.None) {
            IsRateLimited = rateLimited;
            Authentication = authentication;
            RequestRate = rate;
        }

    }

}