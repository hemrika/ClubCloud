using System;
using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace ClubCloud.KNLTB.ServIt.LedenAdministratieService
{
	[DataContract(Name="TypeRating", Namespace="http://schemas.datacontract.org/2004/07/KNLTB.ServIT2.Services")]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public enum TypeRating
	{
		[EnumMember]
		Actueel = 1,
		[EnumMember]
		Eindejaarsrating = 2
	}
}