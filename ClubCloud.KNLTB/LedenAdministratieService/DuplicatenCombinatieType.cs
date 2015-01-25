using System;
using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace ClubCloud.KNLTB.ServIt.LedenAdministratieService
{
	[DataContract(Name="DuplicatenCombinatieType", Namespace="http://schemas.datacontract.org/2004/07/KNLTB.ServIT2.Services")]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public enum DuplicatenCombinatieType
	{
		[EnumMember]
		Combinatie1 = 1,
		[EnumMember]
		Combinatie2 = 2,
		[EnumMember]
		Combinatie3 = 3,
		[EnumMember]
		Combinatie4 = 4
	}
}