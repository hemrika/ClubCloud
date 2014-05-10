using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_toe_inschrijfmethode_per_toernooisoort : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private Lookup organizationidField;
		private CrmDateTime overriddencreatedonField;
		private CrmBoolean sgt_1e_keus_1Field;
		private CrmBoolean sgt_1e_keus_2Field;
		private CrmBoolean sgt_1e_keus_3Field;
		private CrmBoolean sgt_1e_keus_iField;
		private CrmBoolean sgt_2e_keus_1Field;
		private CrmBoolean sgt_2e_keus_2Field;
		private CrmBoolean sgt_2e_keus_3Field;
		private CrmBoolean sgt_2e_keus_iField;
		private CrmBoolean sgt_3e_keus_1Field;
		private CrmBoolean sgt_3e_keus_2Field;
		private CrmBoolean sgt_3e_keus_3Field;
		private CrmBoolean sgt_3e_keus_iField;
		private string sgt_beschrijvingField;
		private Lookup sgt_bij_inschrijving_opidField;
		private CrmBoolean sgt_controle_gelijke_keuzeField;
		private CrmBoolean sgt_inschrijving_1Field;
		private CrmBoolean sgt_inschrijving_2Field;
		private CrmBoolean sgt_inschrijving_3Field;
		private CrmBoolean sgt_inschrijving_iField;
		private string sgt_omschrijvingField;
		private CrmBoolean sgt_periode_moet_gelijk_zijnField;
		private string sgt_toe_inschrijfmethodeField;
		private Key sgt_toe_inschrijfmethode_per_toernooisoortidField;
		private CrmBoolean sgt_toernooiorganisatie_moet_gelijk_zijnField;
		private Lookup sgt_toernooisoortidField;
		private Sgt_toe_inschrijfmethode_per_toernooisoortStateInfo statecodeField;
		private Status statuscodeField;
		private CrmNumber timezoneruleversionnumberField;
		private CrmNumber utcconversiontimezonecodeField;
		public Lookup createdby
		{
			get
			{
				return this.createdbyField;
			}
			set
			{
				this.createdbyField = value;
			}
		}
		public CrmDateTime createdon
		{
			get
			{
				return this.createdonField;
			}
			set
			{
				this.createdonField = value;
			}
		}
		public CrmNumber importsequencenumber
		{
			get
			{
				return this.importsequencenumberField;
			}
			set
			{
				this.importsequencenumberField = value;
			}
		}
		public Lookup modifiedby
		{
			get
			{
				return this.modifiedbyField;
			}
			set
			{
				this.modifiedbyField = value;
			}
		}
		public CrmDateTime modifiedon
		{
			get
			{
				return this.modifiedonField;
			}
			set
			{
				this.modifiedonField = value;
			}
		}
		public Lookup organizationid
		{
			get
			{
				return this.organizationidField;
			}
			set
			{
				this.organizationidField = value;
			}
		}
		public CrmDateTime overriddencreatedon
		{
			get
			{
				return this.overriddencreatedonField;
			}
			set
			{
				this.overriddencreatedonField = value;
			}
		}
		public CrmBoolean sgt_1e_keus_1
		{
			get
			{
				return this.sgt_1e_keus_1Field;
			}
			set
			{
				this.sgt_1e_keus_1Field = value;
			}
		}
		public CrmBoolean sgt_1e_keus_2
		{
			get
			{
				return this.sgt_1e_keus_2Field;
			}
			set
			{
				this.sgt_1e_keus_2Field = value;
			}
		}
		public CrmBoolean sgt_1e_keus_3
		{
			get
			{
				return this.sgt_1e_keus_3Field;
			}
			set
			{
				this.sgt_1e_keus_3Field = value;
			}
		}
		public CrmBoolean sgt_1e_keus_i
		{
			get
			{
				return this.sgt_1e_keus_iField;
			}
			set
			{
				this.sgt_1e_keus_iField = value;
			}
		}
		public CrmBoolean sgt_2e_keus_1
		{
			get
			{
				return this.sgt_2e_keus_1Field;
			}
			set
			{
				this.sgt_2e_keus_1Field = value;
			}
		}
		public CrmBoolean sgt_2e_keus_2
		{
			get
			{
				return this.sgt_2e_keus_2Field;
			}
			set
			{
				this.sgt_2e_keus_2Field = value;
			}
		}
		public CrmBoolean sgt_2e_keus_3
		{
			get
			{
				return this.sgt_2e_keus_3Field;
			}
			set
			{
				this.sgt_2e_keus_3Field = value;
			}
		}
		public CrmBoolean sgt_2e_keus_i
		{
			get
			{
				return this.sgt_2e_keus_iField;
			}
			set
			{
				this.sgt_2e_keus_iField = value;
			}
		}
		public CrmBoolean sgt_3e_keus_1
		{
			get
			{
				return this.sgt_3e_keus_1Field;
			}
			set
			{
				this.sgt_3e_keus_1Field = value;
			}
		}
		public CrmBoolean sgt_3e_keus_2
		{
			get
			{
				return this.sgt_3e_keus_2Field;
			}
			set
			{
				this.sgt_3e_keus_2Field = value;
			}
		}
		public CrmBoolean sgt_3e_keus_3
		{
			get
			{
				return this.sgt_3e_keus_3Field;
			}
			set
			{
				this.sgt_3e_keus_3Field = value;
			}
		}
		public CrmBoolean sgt_3e_keus_i
		{
			get
			{
				return this.sgt_3e_keus_iField;
			}
			set
			{
				this.sgt_3e_keus_iField = value;
			}
		}
		public string sgt_beschrijving
		{
			get
			{
				return this.sgt_beschrijvingField;
			}
			set
			{
				this.sgt_beschrijvingField = value;
			}
		}
		public Lookup sgt_bij_inschrijving_opid
		{
			get
			{
				return this.sgt_bij_inschrijving_opidField;
			}
			set
			{
				this.sgt_bij_inschrijving_opidField = value;
			}
		}
		public CrmBoolean sgt_controle_gelijke_keuze
		{
			get
			{
				return this.sgt_controle_gelijke_keuzeField;
			}
			set
			{
				this.sgt_controle_gelijke_keuzeField = value;
			}
		}
		public CrmBoolean sgt_inschrijving_1
		{
			get
			{
				return this.sgt_inschrijving_1Field;
			}
			set
			{
				this.sgt_inschrijving_1Field = value;
			}
		}
		public CrmBoolean sgt_inschrijving_2
		{
			get
			{
				return this.sgt_inschrijving_2Field;
			}
			set
			{
				this.sgt_inschrijving_2Field = value;
			}
		}
		public CrmBoolean sgt_inschrijving_3
		{
			get
			{
				return this.sgt_inschrijving_3Field;
			}
			set
			{
				this.sgt_inschrijving_3Field = value;
			}
		}
		public CrmBoolean sgt_inschrijving_i
		{
			get
			{
				return this.sgt_inschrijving_iField;
			}
			set
			{
				this.sgt_inschrijving_iField = value;
			}
		}
		public string sgt_omschrijving
		{
			get
			{
				return this.sgt_omschrijvingField;
			}
			set
			{
				this.sgt_omschrijvingField = value;
			}
		}
		public CrmBoolean sgt_periode_moet_gelijk_zijn
		{
			get
			{
				return this.sgt_periode_moet_gelijk_zijnField;
			}
			set
			{
				this.sgt_periode_moet_gelijk_zijnField = value;
			}
		}
		public string sgt_toe_inschrijfmethode
		{
			get
			{
				return this.sgt_toe_inschrijfmethodeField;
			}
			set
			{
				this.sgt_toe_inschrijfmethodeField = value;
			}
		}
		public Key sgt_toe_inschrijfmethode_per_toernooisoortid
		{
			get
			{
				return this.sgt_toe_inschrijfmethode_per_toernooisoortidField;
			}
			set
			{
				this.sgt_toe_inschrijfmethode_per_toernooisoortidField = value;
			}
		}
		public CrmBoolean sgt_toernooiorganisatie_moet_gelijk_zijn
		{
			get
			{
				return this.sgt_toernooiorganisatie_moet_gelijk_zijnField;
			}
			set
			{
				this.sgt_toernooiorganisatie_moet_gelijk_zijnField = value;
			}
		}
		public Lookup sgt_toernooisoortid
		{
			get
			{
				return this.sgt_toernooisoortidField;
			}
			set
			{
				this.sgt_toernooisoortidField = value;
			}
		}
		public Sgt_toe_inschrijfmethode_per_toernooisoortStateInfo statecode
		{
			get
			{
				return this.statecodeField;
			}
			set
			{
				this.statecodeField = value;
			}
		}
		public Status statuscode
		{
			get
			{
				return this.statuscodeField;
			}
			set
			{
				this.statuscodeField = value;
			}
		}
		public CrmNumber timezoneruleversionnumber
		{
			get
			{
				return this.timezoneruleversionnumberField;
			}
			set
			{
				this.timezoneruleversionnumberField = value;
			}
		}
		public CrmNumber utcconversiontimezonecode
		{
			get
			{
				return this.utcconversiontimezonecodeField;
			}
			set
			{
				this.utcconversiontimezonecodeField = value;
			}
		}
	}
}
