﻿using ClubCloud.Social.Json;

namespace ClubCloud.Social.Twitter.Objects {

    public class TwitterPlace {

        #region Properties

        /// <summary>
        /// Gets the internal JsonObject the object was created from.
        /// </summary>
        public JsonObject JsonObject { get; private set; }

        /// <summary>
        /// The ID of the place.
        /// </summary>
        public string Id { get; private set; }

        /// <summary>
        /// The URL for the place in the Twitter API.
        /// </summary>
        public string Url { get; private set; }

        /// <summary>
        /// The type of the place.
        /// </summary>
        public string Type { get; private set; }

        /// <summary>
        /// The name of the place.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// The full name of the place.
        /// </summary>
        public string FullName { get; private set; }

        /// <summary>
        /// The country code of the place.
        /// </summary>
        public string CountryCode { get; private set; }

        /// <summary>
        /// The country of the place.
        /// </summary>
        public string Country { get; private set; }

        /// <summary>
        /// The bounding box describing the place.
        /// </summary>
        public TwitterBoundingBox BoundingBox { get; private set; }

        #endregion

        #region Constructor(s)

        private TwitterPlace() {
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
        /// Loads a place from the JSON file at the specified <var>path</var>.
        /// </summary>
        /// <param name="path">The path to the file.</param>
        public static TwitterPlace LoadJson(string path) {
            return JsonObject.LoadJson(path, Parse);
        }

        /// <summary>
        /// Gets a place from the specified JSON string.
        /// </summary>
        /// <param name="json">The JSON string representation of the object.</param>
        public static TwitterPlace ParseJson(string json) {
            return JsonObject.ParseJson(json, Parse);
        }

        /// <summary>
        /// Gets a place from the specified <var>JsonObject</var>.
        /// </summary>
        /// <param name="obj">The instance of <var>JsonObject</var> to parse.</param>
        public static TwitterPlace Parse(JsonObject obj) {
            if (obj == null) return null;
            return new TwitterPlace {
                JsonObject = obj,
                Id = obj.GetString("id"),
                Url = obj.GetString("url"),
                Type = obj.GetString("place_type"),
                Name = obj.GetString("name"),
                FullName = obj.GetString("full_name"),
                CountryCode = obj.GetString("country_code"),
                Country = obj.GetString("country"),
                BoundingBox = TwitterBoundingBox.Parse(obj.GetObject("bounding_box"))
            };
        }

        public static TwitterPlace[] ParseMultiple(JsonArray array) {
            return array == null ? new TwitterPlace[0] : array.ParseMultiple(Parse);
        }

        #endregion

    }

}
