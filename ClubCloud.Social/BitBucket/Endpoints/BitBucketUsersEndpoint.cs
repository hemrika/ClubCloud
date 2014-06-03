﻿using ClubCloud.Social.BitBucket.Endpoints.Raw;
using ClubCloud.Social.BitBucket.Responses;

namespace ClubCloud.Social.BitBucket.Endpoints {
    
    public class BitBucketUsersEndpoint {

        public BitBucketService Service { get; private set; }

        /// <summary>
        /// The implementation of the endpoint for getting the raw server response.
        /// </summary>
        public BitBucketUsersRawEndpoint Raw {
            get { return Service.Client.Users; }
        }

        internal BitBucketUsersEndpoint(BitBucketService service) {
            Service = service;
        }

        public BitBucketUserResponse GetProfile(string accountName) {
            return BitBucketUserResponse.ParseJson(Raw.GetProfile(accountName));
        }
    
    }

}
