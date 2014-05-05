﻿using System;
using System.Collections.Specialized;
using System.Web;
using ClubCloud.Social.Json;

namespace ClubCloud.Social.Facebook.Objects {
    
    public class FacebookPaging {

        #region Properties

        /// <summary>
        /// A link to the previous page.
        /// </summary>
        public string Previous { get; private set; }

        /// <summary>
        /// A link to the next page.
        /// </summary>
        public string Next { get; private set; }

        /// <summary>
        /// The timestamp used for the <var>Previous</var> link.
        /// </summary>
        public int? Since {
            get {
                if (Previous != null) {
                    NameValueCollection response = HttpUtility.ParseQueryString(Previous);
                    if (response["since"] != null) return Int32.Parse(response["since"]);
                }
                return null;
            }
        }

        /// <summary>
        /// The timestamp used for the <var>Next</var> link.
        /// </summary>
        public int? Until {
            get {
                if (Next != null) {
                    NameValueCollection response = HttpUtility.ParseQueryString(Next);
                    if (response["until"] != null) return Int32.Parse(response["until"]);
                }
                return null;
            }
        }

        #endregion

        #region Constructors

        private FacebookPaging() {
            // Hide default constructor
        }

        #endregion

        #region Static methods

        public static FacebookPaging Parse(JsonObject obj) {
            FacebookPaging paging = new FacebookPaging();
            if (obj != null) {
                paging.Previous = obj.GetString("previous");
                paging.Next = obj.GetString("next");
            }
            return paging;
        }

        #endregion

    }

}