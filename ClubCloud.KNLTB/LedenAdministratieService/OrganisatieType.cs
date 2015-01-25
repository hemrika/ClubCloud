using System;
using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace ClubCloud.KNLTB.ServIt.LedenAdministratieService
{
	[DataContract(Name="OrganisatieType", Namespace="http://schemas.datacontract.org/2004/07/KNLTB.ServIT2.Services")]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public enum OrganisatieType
	{
		[EnumMember]
		Landelijk = 1,
		[EnumMember]
		Regio = 2,
		[EnumMember]
		District = 3,
		[EnumMember]
		Vereniging = 4
	}
}