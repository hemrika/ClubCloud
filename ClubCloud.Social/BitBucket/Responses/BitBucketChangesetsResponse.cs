using System;
using ClubCloud.Social.BitBucket.Objects;
using ClubCloud.Social.Json;

namespace ClubCloud.Social.BitBucket.Responses {
    
    public class BitBucketChangesetsResponse {

        #region Properties

        public BitBucketChangeset[] Changesets { get; private set; }

        #endregion

        #region Constructor

        internal BitBucketChangesetsResponse() {
            // Hide default constructor
        }

        #endregion

        #region Methods

        public static BitBucketChangesetsResponse ParseJson(string str) {
            return Parse(JsonConverter.ParseObject(str));
        }

        public static BitBucketChangesetsResponse Parse(JsonObject obj) {
            return new BitBucketChangesetsResponse {
                Changesets = obj.GetArray("changesets", BitBucketChangeset.Parse)
            };
        }

        #endregion

    }

}
