using System;
using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace ClubCloud.KNLTB.ServIt.LedenAdministratieService
{
	[DataContract(Name="PersoonType", Namespace="http://schemas.datacontract.org/2004/07/KNLTB.ServIT2.Services")]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	public enum PersoonType
	{
		[EnumMember]
		Persoon = 1,
		[EnumMember]
		NietKNLTBLid = 2,
		[EnumMember]
		Both = 3,
		[EnumMember]
		None = 4
	}
}