using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Provider
{
    public class ZimbraMembershipUser : System.Web.Security.MembershipUser
    {
        public ZimbraMembershipUser()
            : base()
        { }

        public ZimbraMembershipUser(string providername,
                                          string username,
                                          object providerUserKey,
                                          string email,
                                          string passwordQuestion,
                                          string comment,
                                          bool isApproved,
                                          bool isLockedOut,
                                          DateTime creationDate,
                                          DateTime lastLoginDate,
                                          DateTime lastActivityDate,
                                          DateTime lastPasswordChangedDate,
                                          DateTime lastLockedOutDate) :
            base("ZimbraMembershipProvider",
                                                username,
                                                providerUserKey,
                                                email,
                                                passwordQuestion,
                                                comment,
                                                isApproved,
                                                isLockedOut,
                                                creationDate,
                                                lastLoginDate,
                                                lastActivityDate,
                                                lastPasswordChangedDate,
                                                lastLockedOutDate)
        {
        }

        public override string Comment
        {
            get
            {
                return base.Comment;
            }
            set
            {
                base.Comment = value;
            }
        }

        //<a n="zimbraCreateTimestamp">20140328153516Z</a>
        private string _zimbraCreateTimestamp;

        public string zimbraCreateTimestamp
        {
            get { return _zimbraCreateTimestamp; }
            set { _zimbraCreateTimestamp = value; }
        }

        public override DateTime CreationDate
        {
            get
            {
                return base.CreationDate;
            }
        }

        //<a n="zimbraPrefMailForwardingAddress">rutger@hemrika.nl</a>
        private string _zimbraPrefMailForwardingAddress;

        public string zimbraPrefMailForwardingAddress
        {
            get { return _zimbraPrefMailForwardingAddress; }
            set { _zimbraPrefMailForwardingAddress = value; }
        }

        public string EmailForwarding
        {
            get
            {
                return zimbraPrefMailForwardingAddress;
            }
        }

        //<a n="zimbraMailAlias">rutger.hemrika@clubcloud.nl</a>
        private string _zimbraMailAlias;

        public string zimbraMailAlias
        {
            get { return _zimbraMailAlias; }
            set { _zimbraMailAlias = value; }
        }

        public string EmailAlias
        {
            get
            {
                return zimbraMailAlias;
            }
        }

        //<a n="zimbraMailDeliveryAddress">12073385@clubcloud.nl</a>
        private string _zimbraMailDeliveryAddress;

        public string zimbraMailDeliveryAddress
        {
            get { return _zimbraMailDeliveryAddress; }
            set { _zimbraMailDeliveryAddress = value; }
        }

        public override string Email
        {
            get
            {
                return zimbraMailDeliveryAddress;
                //return base.Email;
            }
            set
            {
                base.Email = value;
                zimbraMailDeliveryAddress = value;
            }
        }

        //<a n="zimbraAccountStatus">active</a>
        private string _zimbraAccountStatus;

        public string zimbraAccountStatus
        {
            get { return _zimbraAccountStatus; }
            set { _zimbraAccountStatus = value; }
        }

        public override bool IsApproved
        {
            get
            {
                return (zimbraAccountStatus == "active");
                //return base.IsApproved;
            }
            set
            {
                base.IsApproved = value;
            }
        }


        public override bool IsLockedOut
        {
            get
            {
                return base.IsLockedOut;
            }
        }

        public override bool IsOnline
        {
            get
            {
                return base.IsOnline;
            }
        }

        public override DateTime LastActivityDate
        {
            get
            {
                return base.LastActivityDate;
            }
            set
            {
                base.LastActivityDate = value;
            }
        }

        public override DateTime LastLockoutDate
        {
            get
            {
                return base.LastLockoutDate;
            }
        }

        //<a n="zimbraLastLogonTimestamp">2014 03 25 2150 53 Z</a>
        private string _zimbraLastLogonTimestamp;

        public string zimbraLastLogonTimestamp
        {
            get { return _zimbraLastLogonTimestamp; }
            set { _zimbraLastLogonTimestamp = value; }
        }

        public override DateTime LastLoginDate
        {
            get
            {
                return base.LastLoginDate;
            }
            set
            {
                base.LastLoginDate = value;
            }
        }

        //<a n="zimbraPasswordModifiedTime">2014 03 28 1535 16 Z</a>
        private string _zimbraPasswordModifiedTime;

        public string zimbraPasswordModifiedTime
        {
            get { return _zimbraPasswordModifiedTime; }
            set { _zimbraPasswordModifiedTime = value; }
        }

        public override DateTime LastPasswordChangedDate
        {
            get
            {
                return base.LastPasswordChangedDate;
            }
        }

        public override string ProviderName
        {
            get
            {
                return "ZimbraMembershipProvider";
            }
        }

        //<a n="zimbraId">d0ec1768-02dd-4fd3-b302-1da0cd6e868a</a>
        private SecurityIdentifier zid;
        private string _zimbraId;

        public string zimbraId
        {
            get { return _zimbraId; }
            set { _zimbraId = value; }
        }


        public override object ProviderUserKey
        {
            get
            {
                /*
                if (this.zid == null && this.zimbraId != null)
                {

                    this.zid = new SecurityIdentifier(Encoding.UTF8.GetBytes(this.zimbraId), 0);
                }
                return this.zid;
                */
                return zimbraId;
            }
        }

        public override string UserName
        {
            get
            {
                return base.UserName;
            }
        }

        #region base

        public override string GetPassword()
        {
            return base.GetPassword();
        }

        public override string GetPassword(string passwordAnswer)
        {
            return base.GetPassword(passwordAnswer);
        }


        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override string PasswordQuestion
        {
            get
            {
                return base.PasswordQuestion;
            }
        }

        public override bool ChangePassword(string oldPassword, string newPassword)
        {
            return base.ChangePassword(oldPassword, newPassword);
        }

        public override bool ChangePasswordQuestionAndAnswer(string password, string newPasswordQuestion, string newPasswordAnswer)
        {
            return base.ChangePasswordQuestionAndAnswer(password, newPasswordQuestion, newPasswordAnswer);
        }

        public override string ResetPassword()
        {
            return base.ResetPassword();
        }

        public override string ResetPassword(string passwordAnswer)
        {
            return base.ResetPassword(passwordAnswer);
        }

        public override bool UnlockUser()
        {
            return base.UnlockUser();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
        #endregion

        #region Zimbra Properties

        //<a n="uid">info</a><a n="uid">12073385</a>
        private string _uid;

        public string uid
        {
            get { return _uid; }
            set { _uid = value; }
        }

        //<a n="cn">Rutger Hemrika</a>
        private string _cn;

        public string cn
        {
            get { return _cn; }
            set { _cn = value; }
        }

        //<a n="givenName">Rutger</a>
        private string _givenName;

        public string givenName
        {
            get { return _givenName; }
            set { _givenName = value; }
        }

        //<a n="initials">M</a>
        private string _initials;

        public string initials
        {
            get { return _initials; }
            set { _initials = value; }
        }

        //<a n="sn">Hemrika</a>
        private string _sn;

        public string sn
        {
            get { return _sn; }
            set { _sn = value; }
        }

        //<a n="displayName">Rutger M. Hemrika</a>
        private string _displayName;

        public string displayName
        {
            get { return _displayName; }
            set { _displayName = value; }
        }

        /*
        <a n="telephoneNumber">0645350840</a>
        <a n="mobile">0645350840</a>
        <a n="homePhone">030</a>
        */

        /*
        <a n="street">Hoogstraat 63</a>
        <a n="postalCode">3552XL</a>
        <a n="postalCode">3552XL</a>
        <a n="l">Utrecht</a>
        <a n="co">Nerderland</a>
        <a n="st">Utrecht</a>
        */

        /*
        <a n="title">Eigenaar</a>        
        <a n="company">Hemrika</a>
        */

        /*
        <a n="mail">info@clubcloud.nl</a>
        <a n="mail">hostmaster@clubcloud.nl</a>
        <a n="mail">webmaster@clubcloud.nl</a>
        <a n="mail">root@clubcloud.nl</a>
        <a n="mail">hemrika@clubcloud.nl</a>
                
        <a n="zimbraMailAlias">hostmaster@clubcloud.nl</a>
        <a n="zimbraMailAlias">webmaster@clubcloud.nl</a>
        <a n="zimbraMailAlias">root@clubcloud.nl</a>
        <a n="zimbraMailAlias">hemrika@clubcloud.nl</a>        
        */
        #endregion
    }
}
