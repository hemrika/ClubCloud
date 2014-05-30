using System;
using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace ClubCloud.KNLTB.ServIt.LedenAdministratieService
{
	[DataContract(Name="IdealPaymentFormulierType", Namespace="http://schemas.datacontract.org/2004/07/KNLTB.ServIT2.Generiek.Ideal.Service")]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public enum IdealPaymentFormulierType
	{
		[EnumMember]
		Applicatie = 1,
		[EnumMember]
		Examen = 2,
		[EnumMember]
		Licentie = 3,
		[EnumMember]
		Opleiding = 4,
		[EnumMember]
		Testdag = 5
	}
}