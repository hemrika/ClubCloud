﻿using System;
using ClubCloud.Social.Json;

namespace ClubCloud.Social.Google.Analytics.Objects {
    
    /// <summary>
    /// Class representing a web profile in a Google Analytics context.
    /// </summary>
    public class AnalyticsProfile {

        #region Properties

        /// <summary>
        /// Gets the internal JsonObject the object was created from.
        /// </summary>
        public JsonObject JsonObject { get; private set; }
        
        public string Id { get; private set; }
        public string AccountId { get; private set; }
        public string WebPropertyId { get; private set; }
        public string InternalWebPropertyId { get; private set; }
        public string Name { get; private set; }
        public string Currency { get; private set; }
        public string Timezone { get; private set; }
        public string WebsiteUrl { get; private set; }
        public string Type { get; private set; }
        public DateTime Created { get; private set; }
        public DateTime Updated { get; private set; }

        #endregion

        #region Constructors

        private AnalyticsProfile() {
            // Hide default constructor
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Gets a JSON string representing the object.
        /// </summary>
        public string ToJson() {
            return JsonObject == null ? null : JsonObject.ToJson();
        }

        /// <summary>
        /// Saves the object to a JSON file at the specified <var>path</var>.
        /// </summary>
        /// <param name="path">The path to save the file.</param>
        public void SaveJson(string path) {
            if (JsonObject != null) JsonObject.SaveJson(path);
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Loads a profile from the JSON file at the specified <var>path</var>.
        /// </summary>
        /// <param name="path">The path to the file.</param>
        public static AnalyticsProfile LoadJson(string path) {
            return JsonObject.LoadJson(path, Parse);
        }

        /// <summary>
        /// Gets a profile from the specified JSON string.
        /// </summary>
        /// <param name="json">The JSON string representation of the object.</param>
        public static AnalyticsProfile ParseJson(string json) {
            return JsonObject.ParseJson(json, Parse);
        }

        /// <summary>
        /// Gets a profile from the specified <var>JsonObject</var>.
        /// </summary>
        /// <param name="obj">The instance of <var>JsonObject</var> to parse.</param>
        public static AnalyticsProfile Parse(JsonObject obj) {
            return new AnalyticsProfile {
                JsonObject = obj,
                Id = obj.GetString("id"),
                AccountId = obj.GetString("accountId"),
                WebPropertyId = obj.GetString("webPropertyId"),
                InternalWebPropertyId = obj.GetString("internalWebPropertyId"),
                Name = obj.GetString("name"),
                Currency = obj.GetString("currency"),
                Timezone = obj.GetString("timezone"),
                WebsiteUrl = obj.GetString("websiteUrl"),
                Type = obj.GetString("type"),
                Created = obj.GetDateTime("created"),
                Updated = obj.GetDateTime("updated")
            };
        }

        #endregion

    }

}
