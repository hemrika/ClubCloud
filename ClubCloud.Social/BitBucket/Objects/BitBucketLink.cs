﻿using System.Collections.Generic;
using ClubCloud.Social.Json;

namespace ClubCloud.Social.BitBucket.Objects {
    
    public class BitBucketLink {

        public string Name { get; private set; }
        public string Href { get; private set; }

        public static Dictionary<string, BitBucketLink> ParseMultiple(JsonObject obj) {

            // Check if NULL
            if (obj == null) return null;

            // Initialize the dictionary
            Dictionary<string, BitBucketLink> links = new Dictionary<string, BitBucketLink>();

            // Iterate through the specified object
            foreach (string key in obj.Dictionary.Keys) {
                JsonObject value = obj.GetObject(key);
                if (value == null) continue;
                links.Add(key, new BitBucketLink {
                    Name = key,
                    Href = value.GetString("href")
                });
            }
            
            // Return the dictionary
            return links;

        }

    }

}