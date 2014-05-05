﻿using ClubCloud.Social.Facebook.Exceptions;
using ClubCloud.Social.Facebook.Objects;
using ClubCloud.Social.Json;

namespace ClubCloud.Social.Facebook.Responses {

    public class FacebookPostsResponse {

        /// <summary>
        /// Gets an array of all posts in the response.
        /// </summary>
        public FacebookPostSummary[] Data { get; private set; }

        /// <summary>
        /// Gets an array of all posts in the response.
        /// </summary>
        public FacebookPostSummary[] Posts {
            get { return Data; }
        }

        public FacebookPaging Paging {
            get; private set;
        }

        public static FacebookPostsResponse ParseJson(string contents) {
            return Parse(JsonConverter.ParseObject(contents));
        }

        public static FacebookPostsResponse Parse(JsonObject obj) {
            if (obj == null) return null;
            if (obj.HasValue("error")) throw obj.GetObject("error", FacebookException.Parse);
            return new FacebookPostsResponse {
                Data = obj.GetArray("data", FacebookPostSummary.Parse),
                Paging = obj.GetObject("paging", FacebookPaging.Parse)
            };
        }

    }

}
