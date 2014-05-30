using System;
using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace ClubCloud.KNLTB.ServIt.CompetitieService
{
	[DataContract(Name="GetStandenRequestFilter", Namespace="http://schemas.datacontract.org/2004/07/KNLTB.ServIT2.Services")]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public enum GetStandenRequestFilter
	{
		[EnumMember]
		GetStandenForCompetitieAndVereniging = 1,
		[EnumMember]
		GetStandenForCompetitieAndAfdeling = 2,
		[EnumMember]
		GetStandenForCompetitieAndPloeg = 3
	}
}