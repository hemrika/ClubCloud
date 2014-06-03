﻿using ClubCloud.Social.Json;

namespace ClubCloud.Social.BitBucket.Objects {
    
    public class BitBucketAuthor {

        public string Raw { get; private set; }

        public BitBucketAuthorUser User { get; private set; }

        public static BitBucketAuthor Parse(JsonObject obj) {

            // Check if NULL
            if (obj == null) return null;

            // Initialize the author object
            return new BitBucketAuthor {
                Raw = obj.GetString("raw"),
                User = obj.GetObject("user", BitBucketAuthorUser.Parse)
            };

        }

    }

}
