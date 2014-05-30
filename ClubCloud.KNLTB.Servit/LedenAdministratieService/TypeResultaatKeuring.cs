using System;
using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace ClubCloud.KNLTB.ServIt.LedenAdministratieService
{
	[DataContract(Name="TypeResultaatKeuring", Namespace="http://schemas.datacontract.org/2004/07/KNLTB.ServIT2.Services")]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public enum TypeResultaatKeuring
	{
		[EnumMember]
		NietGekeurd = 1,
		[EnumMember]
		Goedgekeurd = 2,
		[EnumMember]
		Afgekeurd = 3
	}
}