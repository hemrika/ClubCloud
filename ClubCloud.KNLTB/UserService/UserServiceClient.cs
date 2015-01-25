using ClubCloud.KNLTB.ServIt.LedenAdministratieService;
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Net;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;

namespace ClubCloud.KNLTB.ServIt.UserService
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
    public class UserServiceClient : ChannelFactory<ClubCloud.KNLTB.ServIt.UserService.IUserService>, IUserService// ClientBase<IUserService>, IUserService
	{
        private static Uri serverUri = new Uri("https://servit.mijnknltb.nl/ISV/KNLTB.ServIT2/KNLTB/Services/UserService.svc");
        private static BasicHttpsSecurity security = new BasicHttpsSecurity { Mode = BasicHttpsSecurityMode.Transport, Transport = new HttpTransportSecurity { ClientCredentialType = HttpClientCredentialType.Basic, Realm = "servit.mijnknltb.nl" } };

        public UserServiceClient(CookieContainer cookiecontainer, string bondsnummer)
            : this(new BasicHttpsBinding() { Security = security, AllowCookies = true, HostNameComparisonMode = HostNameComparisonMode.WeakWildcard }, new EndpointAddress(serverUri))
		{
            cookieContainer = cookiecontainer;
            this.Credentials.UserName.UserName = bondsnummer;
		}

        private UserServiceClient(Binding binding, EndpointAddress remoteAddress)
            : base(binding, remoteAddress)
        {
        }

        private static CookieContainer _cookieContainer;
        private CookieContainer cookieContainer
        {
            get
            {
                return _cookieContainer;
                //return this.CookieContainer;
            }
            set
            {
                _cookieContainer = value;
                //this.CookieContainer = value;
            }
        }

        private static IUserService userService;

        private IUserService UserService
        {
            get
            {
                if (userService == null)
                {
                    userService = this.CreateChannel();
                    GetProperty<IHttpCookieContainerManager>().CookieContainer = cookieContainer;
                }
                return userService;
            }
        }

		public HandleChangeEmailResponse HandleChangeEmail(HandleChangeEmailRequest request)
		{
            return UserService.HandleChangeEmail(request);
		}

		public Task<HandleChangeEmailResponse> HandleChangeEmailAsync(HandleChangeEmailRequest request)
		{
            return UserService.HandleChangeEmailAsync(request);
		}

		public HandleChangePasswordResponse HandleChangePassword(HandleChangePasswordRequest request)
		{
            return UserService.HandleChangePassword(request);
		}

		public Task<HandleChangePasswordResponse> HandleChangePasswordAsync(HandleChangePasswordRequest request)
		{
            return UserService.HandleChangePasswordAsync(request);
		}

		public HasAccessToCrmResponse HasAccessToCrm(HasAccessToCrmRequest request)
		{
            return UserService.HasAccessToCrm(request);
		}

		public Task<HasAccessToCrmResponse> HasAccessToCrmAsync(HasAccessToCrmRequest request)
		{
            return UserService.HasAccessToCrmAsync(request);
		}
    }
}