﻿using ClubCloud.Social.Json;

namespace ClubCloud.Social.Vimeo.Advanced.Objects {

    public class VimeoVideoOwner {

        public int Id { get; private set; }
        public string Username { get; private set; }
        public string DisplayName { get; private set; }
        public bool IsPlus { get; private set; }
        public bool IsPro { get; private set; }
        public bool IsStaff { get; private set; }
        public string ProfileUrl { get; private set; }
        public string VideosUrl { get; private set; }
        public VimeoThumbnail[] Portraits { get; private set; }

        public static VimeoVideoOwner Parse(JsonObject obj) {
            if (obj == null) return null;
            return new VimeoVideoOwner {
                Id = obj.GetInt("id"),
                Username = obj.GetString("username"),
                DisplayName = obj.GetString("display_name"),
                IsPlus = obj.GetString("is_plus") == "1",
                IsPro = obj.GetString("is_pro") == "1",
                IsStaff = obj.GetString("is_staff") == "1",
                ProfileUrl = obj.GetString("profileurl"),
                VideosUrl = obj.GetString("videosurl"),
                Portraits = VimeoUtils.ParseFromParent(obj, "portraits", "portrait", VimeoThumbnail.Parse)
            };
        }

    }

}
