﻿using System;
using ClubCloud.Social.Twitter.Endpoints;
using ClubCloud.Social.Twitter.OAuth;

namespace ClubCloud.Social.Twitter {

    public class TwitterService {

        public TwitterOAuthClient Client { get; private set; }

        public TwitterAccountEndpoint Account { get; private set; }
        public TwitterGeoEndpoint Geo { get; private set; }
        public TwitterStatusesEndpoint Statuses { get; private set; }
        public TwitterUsersEndpoint Users { get; private set; }

        private TwitterService() {
            // make constructor private
        }

        [Obsolete("Made obsolete to have consistent naming across framework. Use CreateFromAccessInformation or CreateFromOAuthClient instead.")]
        public static TwitterService GetFromAccessInformation(TwitterAccessInformation info) {
            return CreateFromOAuthClient(new TwitterOAuthClient {
                ConsumerKey = info.ConsumerKey,
                ConsumerSecret = info.ConsumerSecret,
                Token = info.AccessToken,
                TokenSecret = info.AccessTokenSecret
            });
        }
        
        public static TwitterService CreateFromAccessInformation(TwitterAccessInformation info) {
            return CreateFromOAuthClient(new TwitterOAuthClient {
                ConsumerKey = info.ConsumerKey,
                ConsumerSecret = info.ConsumerSecret,
                Token = info.AccessToken,
                TokenSecret = info.AccessTokenSecret
            });
        }

        public static TwitterService CreateFromOAuthClient(TwitterOAuthClient client) {

            // This should never be null
            if (client == null) throw new ArgumentNullException("client");

            // Initialize the service
            TwitterService service = new TwitterService {
                Client = client
            };

            // Set the endpoints etc.
            service.Account = new TwitterAccountEndpoint(service);
            service.Geo = new TwitterGeoEndpoint(service);
            service.Statuses = new TwitterStatusesEndpoint(service);
            service.Users = new TwitterUsersEndpoint(service);

            // Return the service
            return service;

        }

    }

}
