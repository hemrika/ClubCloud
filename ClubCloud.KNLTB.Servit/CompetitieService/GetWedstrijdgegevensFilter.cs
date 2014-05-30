using System;
using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace ClubCloud.KNLTB.ServIt.CompetitieService
{
	[DataContract(Name="GetWedstrijdgegevensFilter", Namespace="http://schemas.datacontract.org/2004/07/KNLTB.ServIT2.Services")]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public enum GetWedstrijdgegevensFilter
	{
		[EnumMember]
		WedstrijdgegevensForAfdeling = 1,
		[EnumMember]
		WedstrijdgegevensForVereniging = 2,
		[EnumMember]
		WedstrijdgegevensForWedstrijdgegeven = 3
	}
}