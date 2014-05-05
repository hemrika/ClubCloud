﻿using System.Collections.Generic;
using System.Linq;
using ClubCloud.Social.Json;

namespace ClubCloud.Social.Twitter.Entities {

    public class TwitterStatusMessageEntities {

        #region Properties

        public TwitterHashTagEntitity[] HashTags { get; private set; }
        public TwitterUrlEntitity[] Urls { get; private set; }
        public TwitterMentionEntity[] Mentions { get; private set; }
        public TwitterMediaEntity[] Media { get; private set; }

        #endregion

        #region Constructor(s)

        private TwitterStatusMessageEntities() {
            // make constructor private
        }

        #endregion

        #region Member method(s)
        
        public IOrderedEnumerable<TwitterBaseEntity> GetAll() {
            List<TwitterBaseEntity> temp = new List<TwitterBaseEntity>();
            temp.AddRange(HashTags);
            temp.AddRange(Urls);
            temp.AddRange(Mentions);
            temp.AddRange(Media);
            return temp.OrderBy(x => x.StartIndex);
        }

        public IOrderedEnumerable<TwitterBaseEntity> GetAllReversed() {
            List<TwitterBaseEntity> temp = new List<TwitterBaseEntity>();
            temp.AddRange(HashTags);
            temp.AddRange(Urls);
            temp.AddRange(Mentions);
            temp.AddRange(Media);
            return temp.OrderByDescending(x => x.StartIndex);
        }

        #endregion

        #region Static method(s)

        public static TwitterStatusMessageEntities Parse(JsonObject entities) {
            if (entities == null) return null;
            return new TwitterStatusMessageEntities {
                HashTags = TwitterHashTagEntitity.ParseMultiple(entities.GetArray("hashtags")).ToArray(),
                Urls = TwitterUrlEntitity.ParseMultiple(entities.GetArray("urls")).ToArray(),
                Mentions = TwitterMentionEntity.ParseMultiple(entities.GetArray("user_mentions")).ToArray(),
                Media = TwitterMediaEntity.ParseMultiple(entities.GetArray("media")).ToArray()
            };
        }

        #endregion

    }

}
