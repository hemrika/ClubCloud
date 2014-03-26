using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Provider
{
    public class ZimbraMembershipUser : System.Web.Security.MembershipUser
    {
public ZimbraMembershipUser () : base()
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
                                  DateTime lastLockedOutDate,
                                  bool isSubscriber,
                                  string customerID) :
                                  base(providername,
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
            this.IsSubscriber = isSubscriber;
            this.CustomerID = customerID;
        }


        public override bool ChangePassword(string oldPassword, string newPassword)
        {
            return base.ChangePassword(oldPassword, newPassword);
        }

        public override bool ChangePasswordQuestionAndAnswer(string password, string newPasswordQuestion, string newPasswordAnswer)
        {
            return base.ChangePasswordQuestionAndAnswer(password, newPasswordQuestion, newPasswordAnswer);
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

        public override DateTime CreationDate
        {
            get
            {
                return base.CreationDate;
            }
        }

        public override string Email
        {
            get
            {
                return base.Email;
            }
            set
            {
                base.Email = value;
            }
        }

        public override string GetPassword()
        {
            return base.GetPassword();
        }

        public override string GetPassword(string passwordAnswer)
        {
            return base.GetPassword(passwordAnswer);
        }

        public override bool IsApproved
        {
            get
            {
                return base.IsApproved;
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

        public override DateTime LastPasswordChangedDate
        {
            get
            {
                return base.LastPasswordChangedDate;
            }
        }

        public override string PasswordQuestion
        {
            get
            {
                return base.PasswordQuestion;
            }
        }

        public override string ProviderName
        {
            get
            {
                return base.ProviderName;
            }
        }

        public override object ProviderUserKey
        {
            get
            {
                return base.ProviderUserKey;
            }
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

        public override string UserName
        {
            get
            {
                return base.UserName;
            }
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
