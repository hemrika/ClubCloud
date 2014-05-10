using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_toe_inschrijf_functie_toernooisoort : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private Lookup organizationidField;
		private CrmDateTime overriddencreatedonField;
		private Lookup sgt_functieidField;
		private CrmBoolean sgt_meerdere_personen_inschrijvenField;
		private CrmBoolean sgt_standaardField;
		private Key sgt_toe_inschrijf_functie_toernooisoortidField;
		private string sgt_toe_nameField;
		private Lookup sgt_toernooisoortidField;
		private CrmBoolean sgt_wildcardsField;
		private Sgt_toe_inschrijf_functie_toernooisoortStateInfo statecodeField;
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
		public Lookup sgt_functieid
		{
			get
			{
				return this.sgt_functieidField;
			}
			set
			{
				this.sgt_functieidField = value;
			}
		}
		public CrmBoolean sgt_meerdere_personen_inschrijven
		{
			get
			{
				return this.sgt_meerdere_personen_inschrijvenField;
			}
			set
			{
				this.sgt_meerdere_personen_inschrijvenField = value;
			}
		}
		public CrmBoolean sgt_standaard
		{
			get
			{
				return this.sgt_standaardField;
			}
			set
			{
				this.sgt_standaardField = value;
			}
		}
		public Key sgt_toe_inschrijf_functie_toernooisoortid
		{
			get
			{
				return this.sgt_toe_inschrijf_functie_toernooisoortidField;
			}
			set
			{
				this.sgt_toe_inschrijf_functie_toernooisoortidField = value;
			}
		}
		public string sgt_toe_name
		{
			get
			{
				return this.sgt_toe_nameField;
			}
			set
			{
				this.sgt_toe_nameField = value;
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
		public CrmBoolean sgt_wildcards
		{
			get
			{
				return this.sgt_wildcardsField;
			}
			set
			{
				this.sgt_wildcardsField = value;
			}
		}
		public Sgt_toe_inschrijf_functie_toernooisoortStateInfo statecode
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
