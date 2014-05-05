﻿using ClubCloud.Social.Facebook.Exceptions;
using ClubCloud.Social.Facebook.Objects;
using ClubCloud.Social.Json;

namespace ClubCloud.Social.Facebook.Responses {
    
    public class FacebookAccountsResponse {

        public FacebookAccount[] Data { get; private set;}
        public FacebookPaging Paging { get; private set; }

        public static FacebookAccountsResponse ParseJson(string contents) {
            return Parse(JsonConverter.ParseObject(contents));
        }

        public static FacebookAccountsResponse Parse(JsonObject obj) {
            if (obj == null) return null;
            if (obj.HasValue("error")) throw obj.GetObject("error", FacebookException.Parse);
            return new FacebookAccountsResponse {
                Data = obj.GetArray("data", FacebookAccount.Parse),
                Paging = obj.GetObject("paging", FacebookPaging.Parse)
            };
        }

    }

}
