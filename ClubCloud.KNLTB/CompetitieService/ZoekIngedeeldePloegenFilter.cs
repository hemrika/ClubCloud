using System;
using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace ClubCloud.KNLTB.ServIt.CompetitieService
{
	[DataContract(Name="ZoekIngedeeldePloegenFilter", Namespace="http://schemas.datacontract.org/2004/07/KNLTB.ServIT2.Services")]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public enum ZoekIngedeeldePloegenFilter
	{
		[EnumMember]
		ZoekOpVerenigingsnaam = 1,
		[EnumMember]
		ZoekOpVerenigingsnummer = 2,
		[EnumMember]
		ZoekOpAfdelingnaam = 3,
		[EnumMember]
		ZoekOpPloegnaam = 4,
		[EnumMember]
		ZoekOpVereningsnummerEnPloegnummer = 5
	}
}