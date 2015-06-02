using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ClubCloud.Service.Attributes
{

    public interface IAuthorizationFilter
    {
        void OnAuthorization(HttpContext filterContext);
    }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, Inherited = true, AllowMultiple = true)]
    public class AuthorizeAttribute : FilterAttribute, IAuthorizationFilter
    {
        private readonly object _typeId = new object();

        private string _roles;

        private string[] _rolesSplit = new string[0];

        private string _users;

        private string[] _usersSplit = new string[0];

        public string Roles
        {
            get
            {
                return this._roles ?? string.Empty;
            }
            set
            {
                this._roles = value;
                this._rolesSplit = AuthorizeAttribute.SplitString(value);
            }
        }

        public override object TypeId
        {
            get
            {
                return this._typeId;
            }
        }

        public string Users
        {
            get
            {
                return this._users ?? string.Empty;
            }
            set
            {
                this._users = value;
                this._usersSplit = AuthorizeAttribute.SplitString(value);
            }
        }

        public AuthorizeAttribute()
        {
        }

        protected virtual bool AuthorizeCore(HttpContext httpContext)
        {
            if (httpContext == null)
            {
                throw new ArgumentNullException("httpContext");
            }
            IPrincipal user = httpContext.User;
            if (!user.Identity.IsAuthenticated)
            {
                return false;
            }
            if ((int)this._usersSplit.Length > 0 && !this._usersSplit.Contains<string>(user.Identity.Name, StringComparer.OrdinalIgnoreCase))
            {
                return false;
            }
            if ((int)this._rolesSplit.Length > 0)
            {
                IPrincipal principal = user;
                if (!this._rolesSplit.Any<string>(new Func<string, bool>(principal.IsInRole)))
                {
                    return false;
                }
            }
            return true;
        }

        private void CacheValidateHandler(HttpContext context, object data, ref HttpValidationStatus validationStatus)
        {
            validationStatus = this.OnCacheAuthorization(context);
        }

        protected virtual void HandleUnauthorizedRequest(HttpContext httpContext)
        {
            //filterContext.Result = new HttpUnauthorizedResult();
        }

        public virtual void OnAuthorization(HttpContext httpContext)
        {
            if (httpContext == null)
            {
                throw new ArgumentNullException("filterContext");
            }

            /*
            if ((httpContext.ActionDescriptor.IsDefined(typeof(AllowAnonymousAttribute), true) ? true : filterContext.ActionDescriptor.ControllerDescriptor.IsDefined(typeof(AllowAnonymousAttribute), true)))
            {
                return;
            }
            */

            if (!this.AuthorizeCore(httpContext))
            {
                this.HandleUnauthorizedRequest(httpContext);
                return;
            }
            HttpCachePolicy cache = httpContext.Response.Cache;
            cache.SetProxyMaxAge(new TimeSpan((long)0));
            cache.AddValidationCallback(new HttpCacheValidateHandler(this.CacheValidateHandler), null);
        }

        protected virtual HttpValidationStatus OnCacheAuthorization(HttpContext httpContext)
        {
            if (httpContext == null)
            {
                throw new ArgumentNullException("httpContext");
            }
            if (!this.AuthorizeCore(httpContext))
            {
                return HttpValidationStatus.IgnoreThisRequest;
            }
            return HttpValidationStatus.Valid;
        }

        internal static string[] SplitString(string original)
        {
            if (string.IsNullOrEmpty(original))
            {
                return new string[0];
            }
            char[] chrArray = new char[] { ',' };
            IEnumerable<string> strs =
                from piece in original.Split(chrArray)
                let trimmed = piece.Trim()
                where !string.IsNullOrEmpty(trimmed)
                select trimmed;
            return strs.ToArray<string>();
        }
    }
}
