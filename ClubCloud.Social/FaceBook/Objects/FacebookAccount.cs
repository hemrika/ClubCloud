﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClubCloud.Social.Json;

namespace ClubCloud.Social.Facebook.Objects {

    public class FacebookAccount {
    
        /// <summary>
        /// The ID of the account.
        /// </summary>
        public long Id { get; internal set; }

        /// <summary>
        /// Then name of the account.
        /// </summary>
        public string Name { get; internal set; }

        /// <summary>
        /// The category of the account.
        /// </summary>
        public string Category { get; internal set; }

        /// <summary>
        /// The access token associated with the current user and the account.
        /// The access token may be <var>NULL</var> depending on the permissions.
        /// </summary>
        public string AccessToken { get; internal set; }

        /// <summary>
        /// The permissions given to manage the account. Permissions may not be
        /// specified for all types of accounts.
        /// </summary>
        public string[] Permissions { get; internal set; }

        /// <summary>
        /// Parse the JSON object of an account.
        /// </summary>
        /// <param name="obj">The JSON object.</param>
        /// <returns></returns>
        public static FacebookAccount Parse(JsonObject obj) {
            if (obj == null) return null;
            return new FacebookAccount {
                Id = obj.GetLong("id"),
                Name = obj.GetString("name"),
                Category = obj.GetString("category"),
                AccessToken = obj.GetString("access_token"),
                Permissions = obj.GetArray<string>("perms") ?? new string[0]
            };
        }
        
        public static FacebookAccount[] ParseMultiple(JsonArray array) {
            return array == null ? new FacebookAccount[0] : array.ParseMultiple(Parse);
        }
    
    }

}
