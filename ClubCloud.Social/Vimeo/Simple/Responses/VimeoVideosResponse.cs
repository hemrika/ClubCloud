﻿using System.Xml.Linq;
using ClubCloud.Social.Json;
using ClubCloud.Social.Vimeo.Simple.Objects;

namespace ClubCloud.Social.Vimeo.Simple.Responses {

    public class VimeoChannelVideosResponse {

        public VimeoVideo[] Videos { get; private set; }

        public static VimeoChannelVideosResponse Parse(XElement xVideos) {
            if (xVideos == null || xVideos.Name != "videos") return null;
            VimeoChannelVideosResponse response = new VimeoChannelVideosResponse {
                Videos = VimeoVideo.ParseMultiple(xVideos) ?? new VimeoVideo[0]
            };
            return response;
        }

        public static VimeoChannelVideosResponse Parse(JsonArray array) {
            VimeoChannelVideosResponse response = new VimeoChannelVideosResponse {
                Videos = VimeoVideo.ParseMultiple(array) ?? new VimeoVideo[0]
            };
            return response;
        }

    }

}
