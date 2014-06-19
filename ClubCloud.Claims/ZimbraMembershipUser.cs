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
                try
                {
                    DateTime cd = DateTime.ParseExact(zimbraCreateTimestamp, "yyyyMMddHHmmssZ", null);
                    return cd;
                }

                catch
                {
                    return base.CreationDate;
                }

            }
        }

        private string _zimbraPrefMailForwardingAddress;

        /// <summary>
        /// Forwarding Mail Adress
        /// </summary>
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


        private List<string> _zimbraMail;

        public List<string> zimbraMail
        {
            get
            {
                if (_zimbraMail == null)
                {
                    _zimbraMail = new List<string>();
                }
                return _zimbraMail;
            }
            set { _zimbraMail = value; }
        }

        private List<string> _zimbraMailAlias;

        public List<string> zimbraMailAlias
        {
            get
            {
                if (_zimbraMailAlias == null)
                {
                    _zimbraMailAlias = new List<string>();
                }
                return _zimbraMailAlias;
            }
            set { _zimbraMailAlias = value; }
        }
        public List<string> EmailAlias
        {
            get
            {
                return zimbraMailAlias;
            }
        }
 
        private string _zimbraMailDeliveryAddress;

        public string zimbraMailDeliveryAddress
        {
            get { return _zimbraMailDeliveryAddress; }
            set
            {
                base.Email = value;
                _zimbraMailDeliveryAddress = value;
            }
        }

        public override string Email
        {
            get
            {
                return zimbraMailDeliveryAddress;
            }
            set
            {
                base.Email = value;
            }
        }

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
                try
                {
                    DateTime lld = DateTime.ParseExact(zimbraLastLogonTimestamp, "yyyyMMddHHmmssZ", null);
                    return lld;
                }

                catch
                {
                    return base.LastLoginDate;
                }
            }
            set
            {
                base.LastLoginDate = value;
            }
        }

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
                try
                {
                    DateTime lpcd = DateTime.ParseExact(zimbraPasswordModifiedTime, "yyyyMMddHHmmssZ", null);
                    return lpcd;
                }

                catch
                {
                    return base.LastPasswordChangedDate;
                }
            }
        }

        public override string ProviderName
        {
            get
            {
                return "ZimbraMembershipProvider";
            }
        }

        private string _zimbraId;

        /// <summary>
        /// Zimbra Guid
        /// </summary>
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
                return uid;
            }
        }

        public override string UserName
        {
            get
            {
                return uid;
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

        private string _uid;

        /// <summary>
        /// Unique identifier
        /// </summary>
        public string uid
        {
            get { return _uid; }
            set { _uid = value; }
        }

        private string _cn;

        /// <summary>
        /// Full name
        /// </summary>
        public string cn
        {
            get { return _cn; }
            set { _cn = value; }
        }

        private string _givenName;

        /// <summary>
        /// First Name
        /// </summary>
        public string givenName
        {
            get { return _givenName; }
            set { _givenName = value; }
        }

        private string _initials;

        /// <summary>
        /// Initials
        /// </summary>
        public string initials
        {
            get { return _initials; }
            set { _initials = value; }
        }

        private string _sn;

        /// <summary>
        /// Family Name
        /// </summary>
        public string sn
        {
            get { return _sn; }
            set { _sn = value; }
        }

        private string _displayName;

        /// <summary>
        /// Diplay name
        /// </summary>
        public string displayName
        {
            get { return _displayName; }
            set { _displayName = value; }
        }

        private string _telephoneNumber;

        /// <summary>
        /// Telephone
        /// </summary>
        public string telephoneNumber
        {
            get { return _telephoneNumber; }
            set { _telephoneNumber = value; }
        }

        private string _mobile;

        /// <summary>
        /// Mobile Phone
        /// </summary>
        public string mobile
        {
            get { return _mobile; }
            set { _mobile = value; }
        }

        private string _homePhone;

        /// <summary>
        /// Home Phone
        /// </summary>
        public string homePhone
        {
            get { return _homePhone; }
            set { _homePhone = value; }
        }

        private string _street;

        /// <summary>
        /// Street
        /// </summary>
        public string street
        {
            get { return _street; }
            set { _street = value; }
        }

        private string _postalCode;

        /// <summary>
        /// Postal Code
        /// </summary>
        public string postalCode
        {
            get { return _postalCode; }
            set { _postalCode = value; }
        }

        private string _l;

        /// <summary>
        /// City
        /// </summary>
        public string l
        {
            get { return _l; }
            set { _l = value; }
        }

        private string _co;

        /// <summary>
        /// Country
        /// </summary>
        public string co
        {
            get { return _co; }
            set { _co = value; }
        }

        private string _st;

        /// <summary>
        /// State
        /// </summary>
        public string st
        {
            get { return _st; }
            set { _st = value; }
        }

        private string _departmentNumber;

        /// <summary>
        /// Department Number
        /// </summary>
        public string departmentNumber
        {
            get { return _departmentNumber; }
            set { _departmentNumber = value; }
        }

        private string _employeeNumber;

        /// <summary>
        /// Employee Number
        /// </summary>
        public string employeeNumber
        {
            get { return _employeeNumber; }
            set { _employeeNumber = value; }
        }

        private string _homePostalAddress;

        /// <summary>
        /// Home post
        /// </summary>
        public string homePostalAddress
        {
            get { return _homePostalAddress; }
            set { _homePostalAddress = value; }
        }

        private string _o;

        /// <summary>
        /// Organization
        /// </summary>
        public string o
        {
            get { return _o; }
            set { _o = value; }
        }

        private string _postalAddress;

        /// <summary>
        /// Post
        /// </summary>
        public string postalAddress
        {
            get { return _postalAddress; }
            set { _postalAddress = value; }
        }

        private string _company;

        /// <summary>
        /// Company
        /// </summary>
        public string company
        {
            get { return _company; }
            set { _company = value; }
        }

        #endregion
    }
}
