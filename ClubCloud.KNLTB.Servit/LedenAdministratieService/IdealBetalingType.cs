using System;
using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace ClubCloud.KNLTB.ServIt.LedenAdministratieService
{
	[DataContract(Name="IdealBetalingType", Namespace="http://schemas.datacontract.org/2004/07/KNLTB.ServIT2.Generiek.Ideal.Service")]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public enum IdealBetalingType
	{
		[EnumMember]
		Gebeurtenis = 1,
		[EnumMember]
		Opleiding = 2
	}
}