using System;
using System.CodeDom.Compiler;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace ClubCloud.KNLTB.ServIt.UserService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public interface IUserServiceChannel : IUserService, IClientChannel, IContextChannel, IChannel, ICommunicationObject, IExtensibleObject<IContextChannel>, IDisposable
	{
	}
}