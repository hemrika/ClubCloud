using System;
using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace ClubCloud.KNLTB.ServIt.LedenAdministratieService
{
	[DataContract(Name="TypeInschrijving", Namespace="http://schemas.datacontract.org/2004/07/KNLTB.ServIT2.Services")]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public enum TypeInschrijving
	{
		[EnumMember]
		Standaard = 1,
		[EnumMember]
		Wildcard = 2
	}
}