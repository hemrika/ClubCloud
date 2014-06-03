﻿using ClubCloud.Social.BitBucket.OAuth;

namespace ClubCloud.Social.BitBucket.Endpoints.Raw {
    
    public class BitBucketUserRawEndpoint {

        public BitBucketOAuthClient Client { get; private set; }

        public BitBucketUserRawEndpoint(BitBucketOAuthClient client) {
            Client = client;
        }
        
        public string GetInfo() {
            return Client.DoHttpRequestAsString("GET", "https://bitbucket.org/api/1.0/user");
        }
    
    }

}
