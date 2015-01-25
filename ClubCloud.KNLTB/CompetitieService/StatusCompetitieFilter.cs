using System;
using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace ClubCloud.KNLTB.ServIt.CompetitieService
{
	[DataContract(Name="StatusCompetitieFilter", Namespace="http://schemas.datacontract.org/2004/07/KNLTB.ServIT2.Services")]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public enum StatusCompetitieFilter
	{
		[EnumMember]
		InschrijvingGeopend = 1,
		[EnumMember]
		InschrijvingGeopendEnGesloten = 2
	}
}