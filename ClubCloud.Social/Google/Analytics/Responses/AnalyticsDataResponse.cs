﻿using ClubCloud.Social.Google.Analytics.Objects;
using ClubCloud.Social.Google.Exceptions;
using ClubCloud.Social.Json;

namespace ClubCloud.Social.Google.Analytics.Responses {

    public class AnalyticsDataResponse {

        #region Properties

        /// <summary>
        /// Gets the internal JsonObject the object was created from.
        /// </summary>
        public JsonObject JsonObject { get; private set; }
        
        public int TotalResults { get; private set; }
        public int ItemsPerPage { get; private set; }

        public AnalyticsDataQuery Query { get; private set; }
        public AnalyticsDataColumnHeader[] ColumnHeaders { get; private set; }
        public AnalyticsDataRow[] Rows { get; private set; }

        #endregion

        #region Constructors

        private AnalyticsDataResponse() {
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

        /// <summary>
        /// Loads an instance of <var>AnalyticsDataResponse</var> from the JSON file at the
        /// specified <var>path</var>.
        /// </summary>
        /// <param name="path">The path to the JSON file.</param>
        public static AnalyticsDataResponse LoadJson(string path) {
            return JsonObject.LoadJson(path, Parse);
        }

        /// <summary>
        /// Gets an instance of <var>AnalyticsDataResponse</var> from the specified JSON string.
        /// </summary>
        /// <param name="json">The JSON string representation of the object.</param>
        public static AnalyticsDataResponse ParseJson(string json) {
            return Parse(JsonConverter.ParseObject(json));
        }

        /// <summary>
        /// Gets an instance of <var>AnalyticsDataResponse</var> from the specified
        /// <var>JsonObject</var>.
        /// </summary>
        /// <param name="obj">The instance of <var>JsonObject</var> to parse.</param>
        public static AnalyticsDataResponse Parse(JsonObject obj) {
            
            // Check whether "obj" is NULL
            if (obj == null) return null;

            // Check for any API errors
            if (obj.HasValue("error")) {
                JsonObject error = obj.GetObject("error");
                throw new GoogleApiException(error.GetInt("code"), error.GetString("message"));
            }

            // Initialize the response object
            AnalyticsDataResponse response = new AnalyticsDataResponse {
                Query = obj.GetObject("query", AnalyticsDataQuery.Parse),
                ColumnHeaders = obj.GetArray("columnHeaders", AnalyticsDataColumnHeader.Parse)
            };

            // Parse the rows
            JsonArray rows = obj.GetArray("rows");
            if (rows == null) {
                response.Rows = new AnalyticsDataRow[0];
            } else {
                response.Rows = new AnalyticsDataRow[rows.Length];
                for (int i = 0; i < rows.Length; i++) {
                    response.Rows[i] = new AnalyticsDataRow {
                        Index = i,
                        Cells = rows.GetArray(i).Cast<string>()
                    };
                }
            }
            
            return response;

        }

    }

}
