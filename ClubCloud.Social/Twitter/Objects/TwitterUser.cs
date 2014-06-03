﻿using System;
using ClubCloud.Social.Json;

namespace ClubCloud.Social.Twitter.Objects {

    /// <see cref="https://dev.twitter.com/docs/platform-objects/users"/>
    public class TwitterUser {

        #region Properties

        /// <summary>
        /// Gets the internal JsonObject the object was created from.
        /// </summary>
        public JsonObject JsonObject { get; private set; }

        /// <summary>
        /// The integer representation of the unique identifier for this User. This number is greater
        /// than 53 bits and some programming languages may have difficulty/silent defects in
        /// interpreting it. Using a signed 64 bit integer for storing this identifier is safe.
        /// Use <var>id_str</var> for fetching the identifier to stay on the safe side.
        /// </summary>
        public long Id { get; private set; }

        /// <summary>
        /// The string representation of the unique identifier for this Tweet.
        /// Implementations should use this rather than the large integer in id.
        /// <a href="http://groups.google.com/group/twitter-development-talk/browse_thread/thread/6a16efa375532182/">Discussion</a>.
        /// </summary>
        public string IdStr { get; private set; }

        /// <summary>
        /// The screen name, handle, or alias that this user identifies themselves with. <var>screen_names</var>
        /// are unique but subject to change. Use <var>id_str</var> as a user identifier whenever possible.
        /// Typically a maximum of 15 characters long, but some historical accounts may exist with longer names.
        /// </summary>
        public string ScreenName { get; private set; }

        /// <summary>
        /// The name of the user, as they've defined it. Not necessarily a person's name. Typically
        /// capped at 20 characters, but subject to change.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// <em>Nullable</em>. The user-defined location for this account's profile. Not necessarily a location
        /// nor parseable. This field will occasionally be fuzzily interpreted by the Search service.
        /// </summary>
        public string Location { get; private set; }

        /// <summary>
        /// <em>Nullable</em>. A URL provided by the user in association with their profile.
        /// </summary>
        public string Url { get; private set; }

        /// <summary>
        /// <em>Nullable</em>. The user-defined UTF-8 string describing their account.
        /// </summary>
        public string Description { get; private set; }

        /// <summary>
        /// When true, indicates that this user has chosen to protect their Tweets.
        /// See <a href="https://support.twitter.com/articles/14016">About Public and Protected Tweets</a>.
        /// </summary>
        public bool IsProtected { get; private set; }

        /// <summary>
        /// The number of followers this account currently has. Under certain conditions of duress,
        /// this field will temporarily indicate "0".
        /// </summary>
        public int FollowersCount { get; private set; }

        /// <summary>
        /// The number of users this account is following (AKA their "followings"). Under certain
        /// conditions of duress, this field will temporarily indicate "0".
        /// </summary>
        public int FriendsCount { get; private set; }

        /// <summary>
        /// The number of public lists that this user is a member of.
        /// </summary>
        public int ListedCount { get; private set; }

        /// <summary>
        /// The UTC datetime that the user account was created on Twitter.
        /// </summary>
        public DateTime CreatedAt { get; private set; }

        /// <summary>
        /// The number of tweets this user has favorited in the account's lifetime. British spelling used
        /// in the field name for historical reasons.
        /// </summary>
        public int FavouritesCount { get; private set; }

        /// <summary>
        /// The number of tweets this user has favorited in the account's lifetime.
        /// </summary>
        public int FavoritesCount {
            get { return FavouritesCount; }
        }

        /// <summary>
        /// <em>Nullable</em>. The offset from GMT/UTC in seconds.
        /// </summary>
        public int? UtcOffset { get; private set; }

        /// <summary>
        /// <em>Nullable</em>. A string describing the Time Zone this user declares themselves within.
        /// </summary>
        public string TimeZone { get; private set; }

        /// <summary>
        /// When true, indicates that the user has enabled the possibility of geotagging their Tweets.
        /// This field must be true for the current user to attach geographic data when using
        /// POST statuses/update.
        /// </summary>
        public bool IsGeoEnabled { get; private set; }

        /// <summary>
        /// When true, indicates that the user has a verified account.
        /// See <a href="https://support.twitter.com/articles/119135">Verified Accounts</a>.
        /// </summary>
        public bool IsVerified { get; private set; }

        /// <summary>
        /// The number of tweets (including retweets) issued by the user.
        /// </summary>
        public int StatusesCount { get; private set; }

        /// <summary>
        /// The <var>BCP 47</var> code for the user's self-declared user interface language.
        /// May or may not have anything to do with the content of their Tweets.
        /// </summary>
        /// <see cref="http://tools.ietf.org/html/bcp47" />
        public string Language { get; private set; }

        /// <summary>
        /// Indicates that the user has an account with "contributor mode" enabled, allowing for
        /// Tweets issued by the user to be co-authored by another account. Rarely <var>true</var>.
        /// </summary>
        public bool ContributorsEnabled { get; private set; }

        /// <summary>
        /// When true, indicates that the user is a participant in Twitter's translator community.
        /// </summary>
        public bool IsTranslator { get; private set; }

        /// <summary>
        /// <em>Nullable</em>. <em>Perspectival</em>. <em>Deprecated</em>. When true, indicates that the authenticating user is
        /// following this user. Some false negatives are possible when set to "false", but these
        /// false negatives are increasingly being represented as "null" instead.
        /// </summary>
        [Obsolete("Deprecated in the Twitter API")]
        public bool? IsFollowing { get; private set; }

        /// <summary>
        /// <em>Nullable</em>. <em>Perspectival</em>. When true, indicates that the authenticating user has issued a
        /// follow request to this protected user account.
        /// </summary>
        public bool? FollowRequestSent { get; private set; }

        /// <summary>
        /// <em>Nullable</em>. <em>Deprecated</em>. May incorrectly report "false" at times. Indicates whether the
        /// authenticated user has chosen to receive this user's tweets by SMS.
        /// </summary>
        [Obsolete("Deprecated in the Twitter API")]
        public bool? Notifications { get; private set; }

        /// <summary>
        /// The hexadecimal color chosen by the user for their background.
        /// </summary>
        public string ProfileBackgroundColor { get; private set; }

        /// <summary>
        /// A HTTP-based URL pointing to the background image the user has uploaded for their
        /// profile.
        /// </summary>
        public string ProfileBackgroundImageUrl { get; private set; }

        /// <summary>
        /// A HTTPS-based URL pointing to the background image the user has uploaded for their
        /// profile.
        /// </summary>
        public string ProfileBackgroundImageUrlHttps { get; private set; }

        /// <summary>
        /// When true, indicates that the user's <var>profile_background_image_url</var> should be tiled
        /// when displayed.
        /// </summary>
        public bool ProfileBackgroundTile { get; private set; }

        /// <summary>
        /// The HTTPS-based URL pointing to the standard web representation of the user's uploaded
        /// profile banner. By adding a final path element of the URL, you can obtain different
        /// image sizes optimized for specific displays. In the future, an API method will be
        /// provided to serve these URLs so that you need not modify the original URL. For size
        /// variations, please see <a href="https://dev.twitter.com/docs/user-profile-images-and-banners">User Profile Images and Banners</a>.
        /// </summary>
        public string ProfileBannerUrl { get; private set; }

        /// <summary>
        /// A HTTP-based URL pointing to the user's avatar image. See <a href="https://dev.twitter.com/docs/user-profile-images-and-banners">User Profile Images and Banners</a>.
        /// </summary>
        public string ProfileImageUrl { get; private set; }

        /// <summary>
        /// A HTTPS-based URL pointing to the user's avatar image.
        /// </summary>
        public string ProfileImageUrlHttps { get; private set; }

        /// <summary>
        /// The hexadecimal color the user has chosen to display links with in their Twitter UI.
        /// </summary>
        public string ProfileLinkColor { get; private set; }

        /// <summary>
        /// The hexadecimal color the user has chosen to display sidebar borders with in their Twitter UI.
        /// </summary>
        public string ProfileSidebarBorderColor { get; private set; }

        /// <summary>
        /// The hexadecimal color the user has chosen to display sidebar backgrounds with in their Twitter UI.
        /// </summary>
        public string ProfileSidebarFillColor { get; private set; }

        /// <summary>
        /// The hexadecimal color the user has chosen to display text with in their Twitter UI.
        /// </summary>
        public string ProfileTextColor { get; private set; }

        /// <summary>
        /// When true, indicates the user wants their uploaded background image to be used.
        /// </summary>
        public bool ProfileUseBackgroundImage { get; private set; }

        /// <summary>
        /// Indicates that the user would like to see media inline. Somewhat disused.
        /// </summary>
        public bool ShowAllInlineMedia { get; private set; }

        /// <summary>
        /// Boolean	When true, indicates that the user has not altered the theme or background of their user profile.
        /// </summary>
        public bool HasDefaultProfile { get; private set; }

        /// <summary>
        /// When true, indicates that the user has not uploaded their own avatar and a default egg avatar is used instead.
        /// </summary>
        public bool HasDefaultProfileImage { get; private set; }

        /// <summary>
        /// <em>Nullable</em>. If possible, the user's most recent tweet or retweet. In some circumstances,
        /// this data cannot be provided and this field will be omitted, null, or empty. Perspectival
        /// attributes within tweets embedded within users cannot always be relied upon.
        /// See <a href="https://dev.twitter.com/docs/faq/#6981">Why areembedded objects stale or inaccurate?</a>.
        /// </summary>
        public object Status { get; private set; }

        /// <summary>
        /// Entities which have been parsed out of the url or description fields defined by the user.
        /// Read more about <a href="https://dev.twitter.com/docs/platform-objects/entities#user_entities">User Entities</a>.
        /// </summary>
        public object Entities { get; private set; }

        #endregion

        #region Constructor(s)

        private TwitterUser() {
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
        /// Loads a user from the JSON file at the specified <var>path</var>.
        /// </summary>
        /// <param name="path">The path to the file.</param>
        public static TwitterUser LoadJson(string path) {
            return JsonObject.LoadJson(path, Parse);
        }

        /// <summary>
        /// Gets a user from the specified JSON string.
        /// </summary>
        /// <param name="json">The JSON string representation of the object.</param>
        public static TwitterUser ParseJson(string json) {
            return JsonObject.ParseJson(json, Parse);
        }

        /// <summary>
        /// Gets a user from the specified <var>JsonObject</var>.
        /// </summary>
        /// <param name="obj">The instance of <var>JsonObject</var> to parse.</param>
        public static TwitterUser Parse(JsonObject obj) {
            
            // Error checking
            if (obj == null) return null;
            if (obj.HasValue("error")) throw TwitterException.Parse(obj.GetArray("error"));
            
            TwitterUser user = new TwitterUser();

            #region Basic properties
            
            user.JsonObject = obj;
            user.Id = obj.GetLong("id");
            user.IdStr = obj.GetString("id_str");
            user.Name = obj.GetString("name");
            user.ScreenName = obj.GetString("screen_name");
            user.Location = obj.GetString("location");
            user.Url = obj.GetString("url");
            user.Description = obj.GetString("description");
            user.IsProtected = obj.GetBoolean("protected");
            user.FollowersCount = obj.GetInt("followers_count");
            user.FriendsCount = obj.GetInt("friends_count");
            user.ListedCount = obj.GetInt("listed_count");
            user.CreatedAt = TwitterUtils.ParseDateTime(obj.GetString("created_at"));
            user.FavouritesCount = obj.GetInt("favourites_count");
            if (obj.HasValue("utc_offset")) user.UtcOffset = obj.GetInt("utc_offset");
            user.TimeZone = obj.GetString("time_zone");
            user.IsGeoEnabled = obj.GetBoolean("geo_enabled");
            user.IsVerified = obj.GetBoolean("verified");
            user.StatusesCount = obj.GetInt("statuses_count");
            user.Language = obj.GetString("lang");
            user.ContributorsEnabled = obj.GetBoolean("contributors_enabled");
            user.IsTranslator = obj.GetBoolean("is_translator");
            user.IsFollowing = obj.HasValue("following") && obj.GetBoolean("following");
            user.FollowRequestSent = obj.HasValue("follow_request_sent") && obj.GetBoolean("follow_request_sent");
            user.Notifications = obj.HasValue("notifications") && obj.GetBoolean("notifications");
            user.Status = obj.GetObject("status", TwitterStatusMessage.Parse);
           
            #endregion

            #region Profile properties
            
            user.HasDefaultProfile = obj.GetBoolean("default_profile");
            user.HasDefaultProfileImage = obj.GetBoolean("default_profile_image");
            user.ProfileBackgroundColor = obj.GetString("profile_background_color");
            user.ProfileBackgroundImageUrl = obj.GetString("profile_background_image_url");
            user.ProfileBackgroundImageUrlHttps = obj.GetString("profile_background_image_url_https");
            user.ProfileBackgroundTile = obj.GetBoolean("profile_background_tile");
            user.ProfileBannerUrl = obj.GetString("profile_banner_url");
            user.ProfileImageUrl = obj.GetString("profile_image_url");
            user.ProfileImageUrlHttps = obj.GetString("profile_image_url_https");
            user.ProfileLinkColor = obj.GetString("profile_link_color");
            user.ProfileSidebarBorderColor = obj.GetString("profile_sidebar_border_color");
            user.ProfileSidebarFillColor = obj.GetString("profile_sidebar_fill_color");
            user.ProfileTextColor = obj.GetString("profile_text_color");
            user.ProfileUseBackgroundImage = obj.GetBoolean("profile_use_background_image");
            
            #endregion

            return user;

        }

        #endregion

    }

}
