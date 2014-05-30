using System;
using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace ClubCloud.KNLTB.ServIt.LedenAdministratieService
{
	[DataContract(Name="TypeOrganisatie", Namespace="http://schemas.datacontract.org/2004/07/KNLTB.ServIT2.Services")]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public enum TypeOrganisatie
	{
		[EnumMember]
		Vereniging = 1,
		[EnumMember]
		Wedstrijdcommite = 2,
		[EnumMember]
		Toernooiorganisator = 3
	}
}