using System.CodeDom.Compiler;
using System.ServiceModel;
using System.Threading.Tasks;
using System.Web;

namespace ClubCloud.KNLTB.ServIt.UserService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	[ServiceContract(Namespace="http://knltb.nl/services", ConfigurationName="ClubCloud.KNLTB.Servit.UserService.IUserService")]
	public interface IUserService
	{
		[OperationContract(Action="http://knltb.nl/services/IUserService/HandleChangeEmail", ReplyAction="http://knltb.nl/services/IUserService/HandleChangeEmailResponse")]
		HandleChangeEmailResponse HandleChangeEmail(HandleChangeEmailRequest request);

		[OperationContract(Action="http://knltb.nl/services/IUserService/HandleChangeEmail", ReplyAction="http://knltb.nl/services/IUserService/HandleChangeEmailResponse")]
		Task<HandleChangeEmailResponse> HandleChangeEmailAsync(HandleChangeEmailRequest request);

		[OperationContract(Action="http://knltb.nl/services/IUserService/HandleChangePassword", ReplyAction="http://knltb.nl/services/IUserService/HandleChangePasswordResponse")]
		HandleChangePasswordResponse HandleChangePassword(HandleChangePasswordRequest request);

		[OperationContract(Action="http://knltb.nl/services/IUserService/HandleChangePassword", ReplyAction="http://knltb.nl/services/IUserService/HandleChangePasswordResponse")]
		Task<HandleChangePasswordResponse> HandleChangePasswordAsync(HandleChangePasswordRequest request);

		[OperationContract(Action="http://knltb.nl/services/IUserService/HasAccessToCrm", ReplyAction="http://knltb.nl/services/IUserService/HasAccessToCrmResponse")]
		HasAccessToCrmResponse HasAccessToCrm(HasAccessToCrmRequest request);

		[OperationContract(Action="http://knltb.nl/services/IUserService/HasAccessToCrm", ReplyAction="http://knltb.nl/services/IUserService/HasAccessToCrmResponse")]
		Task<HasAccessToCrmResponse> HasAccessToCrmAsync(HasAccessToCrmRequest request);
	}
}