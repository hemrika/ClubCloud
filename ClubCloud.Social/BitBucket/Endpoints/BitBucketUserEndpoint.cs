﻿using ClubCloud.Social.BitBucket.Endpoints.Raw;
using ClubCloud.Social.BitBucket.Responses;

namespace ClubCloud.Social.BitBucket.Endpoints {
    
    public class BitBucketUserEndpoint {

        public BitBucketService Service { get; private set; }

        /// <summary>
        /// The implementation of the endpoint for getting the raw server response.
        /// </summary>
        public BitBucketUserRawEndpoint Raw {
            get { return Service.Client.User; }
        }

        internal BitBucketUserEndpoint(BitBucketService service) {
            Service = service;
        }

        public BitBucketCurrentUserResponse GetInfo() {
            return BitBucketCurrentUserResponse.ParseJson(Raw.GetInfo());
        }
    
    }

}
