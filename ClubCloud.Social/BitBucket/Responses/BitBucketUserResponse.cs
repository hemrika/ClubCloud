using ClubCloud.Social.BitBucket.Objects;
using ClubCloud.Social.Json;

namespace ClubCloud.Social.BitBucket.Responses {

    public class BitBucketUserResponse {

        private JsonObject _json;

        #region Properties

        public BitBucketUser User { get; private set; }

        #endregion

        #region Constructor

        internal BitBucketUserResponse() {
            // Hide default constructor
        }

        #endregion

        #region Member methods

        public string ToJson() {
            return _json == null ? null : _json.ToJson();
        }

        #endregion

        #region Static methods

        public static BitBucketUserResponse ParseJson(string str) {
            return Parse(JsonConverter.ParseObject(str));
        }

        public static BitBucketUserResponse Parse(JsonObject obj) {
            if (obj == null) return null;
            return new BitBucketUserResponse {
                _json = obj,
                User = obj.GetObject("user", BitBucketUser.Parse)
            };
        }

        #endregion

    }

}
