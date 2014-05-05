﻿using ClubCloud.Social.Json;

namespace ClubCloud.Social.Twitter.Objects {
    
    public class TwitterBoundingBox {

        /// <summary>
        /// The type of the bounding box
        /// </summary>
        public string Type { get; private set; }

        /// <summary>
        /// The set of coordinates describing the bounding box
        /// </summary>
        public TwitterCoordinates[][] Coordinates { get; private set; }

        public static TwitterBoundingBox Parse(JsonObject obj) {

            // Check whether "obj" is NULL
            if (obj == null) return null;

            // Get the array
            JsonArray coordinates = obj.GetArray("coordinates");

            // Initialize the bounding box
            TwitterBoundingBox boundingBox = new TwitterBoundingBox {
                Type = obj.GetString("type"),
                Coordinates = new TwitterCoordinates[coordinates.Length][]
            };

            // Parse the coordinates
            for (int i = 0; i < coordinates.Length; i++) {
                boundingBox.Coordinates[i] = TwitterCoordinates.ParseMultiple(coordinates.GetArray(i));
            }

            // Return the building box
            return boundingBox;
        
        }

    }

}