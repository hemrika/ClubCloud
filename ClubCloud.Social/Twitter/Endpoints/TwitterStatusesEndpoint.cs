﻿using ClubCloud.Social.Twitter.Endpoints.Raw;
using ClubCloud.Social.Twitter.Objects;
using ClubCloud.Social.Twitter.Options;

namespace ClubCloud.Social.Twitter.Endpoints {

    public class TwitterStatusesEndpoint {

        #region Properties

        /// <summary>
        /// A reference to the Twitter service.
        /// </summary>
        public TwitterService Service { get; private set; }

        /// <summary>
        /// A reference to the raw endpoint.
        /// </summary>
        public TwitterStatusesRawEndpoint Raw {
            get { return Service.Client.Statuses; }
        }

        #endregion

        #region Constructor(s)

        internal TwitterStatusesEndpoint(TwitterService service) {
            Service = service;
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Alias of GetStatusMessage(). Gets information about a status message (tweet) with the specified ID.
        /// </summary>
        /// <param name="statusId">The ID of the status message.</param>
        /// <param name="options">Options affecting the response from the Twitter API.</param>
        public TwitterStatusMessage GetTweet(long statusId, TwitterStatusMessageOptions options = null) {
            return GetStatusMessage(statusId, options);
        }

        /// <summary>
        /// Gets information about a status message (tweet) with the specified ID.
        /// </summary>
        /// <param name="statusId">The ID of the status message.</param>
        /// <param name="options">Options affecting the response from the Twitter API.</param>
        public TwitterStatusMessage GetStatusMessage(long statusId, TwitterStatusMessageOptions options = null) {
            return TwitterStatusMessage.ParseJson(Raw.GetStatusMessage(statusId, options));
        }

        public TwitterTimeline UserTimeline(long userId, int count) {
            return TwitterTimeline.ParseJson(Raw.GetUserTimeline(userId, new TwitterTimelineOptions(count)));
        }

        public TwitterTimeline UserTimeline(long userId, TwitterTimelineOptions options = null) {
            return TwitterTimeline.ParseJson(Raw.GetUserTimeline(userId, options));
        }

        public TwitterTimeline UserTimeline(string screenName, int count) {
            return TwitterTimeline.ParseJson(Raw.GetUserTimeline(screenName, new TwitterTimelineOptions(count)));
        }

        public TwitterTimeline UserTimeline(string screenName, TwitterTimelineOptions options = null) {
            return TwitterTimeline.ParseJson(Raw.GetUserTimeline(screenName, options));
        }

        #region Write

        /// <summary>
        /// Posts the specified status message.
        /// </summary>
        /// <param name="status">The status message to send.</param>
        public TwitterStatusMessage PostStatusMessage(string status) {
            return PostStatusMessage(status, null);
        }

        /// <summary>
        /// Posts the specified status message.
        /// </summary>
        /// <param name="status">The status message to send.</param>
        /// <param name="replyTo">The ID of the status message to reply to.</param>
        public TwitterStatusMessage PostStatusMessage(string status, long? replyTo) {
            return TwitterStatusMessage.ParseJson(Raw.PostStatusMessage(status, replyTo));
        }

        #endregion

        #endregion

    }

}
