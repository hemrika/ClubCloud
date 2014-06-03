using System.Linq;
using ClubCloud.Social.Json;
using ClubCloud.Social.Vimeo.Advanced.Objects;

namespace ClubCloud.Social.Vimeo.Advanced.Responses {
    
    public class VimeoVideoResponse : VimeoApiResponse {

        public VimeoVideo Video { get; private set; }

        public static VimeoVideoResponse Parse(JsonObject obj) {
            if (obj == null) return null;
            VimeoVideoResponse response = new VimeoVideoResponse();
            response.ParseResponse(obj);
            response.Video = obj.GetArray("video", VimeoVideo.Parse).FirstOrDefault();
            return response;
        }

    }

}