using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
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
		[XmlElement(Order = 0)]
		public Lookup createdby
		{
			get
			{
				return this.createdbyField;
			}
			set
			{
				this.createdbyField = value;
				base.RaisePropertyChanged("createdby");
			}
		}
		[XmlElement(Order = 1)]
		public CrmDateTime createdon
		{
			get
			{
				return this.createdonField;
			}
			set
			{
				this.createdonField = value;
				base.RaisePropertyChanged("createdon");
			}
		}
		[XmlElement(Order = 2)]
		public CrmNumber importsequencenumber
		{
			get
			{
				return this.importsequencenumberField;
			}
			set
			{
				this.importsequencenumberField = value;
				base.RaisePropertyChanged("importsequencenumber");
			}
		}
		[XmlElement(Order = 3)]
		public Lookup modifiedby
		{
			get
			{
				return this.modifiedbyField;
			}
			set
			{
				this.modifiedbyField = value;
				base.RaisePropertyChanged("modifiedby");
			}
		}
		[XmlElement(Order = 4)]
		public CrmDateTime modifiedon
		{
			get
			{
				return this.modifiedonField;
			}
			set
			{
				this.modifiedonField = value;
				base.RaisePropertyChanged("modifiedon");
			}
		}
		[XmlElement(Order = 5)]
		public Lookup organizationid
		{
			get
			{
				return this.organizationidField;
			}
			set
			{
				this.organizationidField = value;
				base.RaisePropertyChanged("organizationid");
			}
		}
		[XmlElement(Order = 6)]
		public CrmDateTime overriddencreatedon
		{
			get
			{
				return this.overriddencreatedonField;
			}
			set
			{
				this.overriddencreatedonField = value;
				base.RaisePropertyChanged("overriddencreatedon");
			}
		}
		[XmlElement(Order = 7)]
		public Lookup sgt_functieid
		{
			get
			{
				return this.sgt_functieidField;
			}
			set
			{
				this.sgt_functieidField = value;
				base.RaisePropertyChanged("sgt_functieid");
			}
		}
		[XmlElement(Order = 8)]
		public CrmBoolean sgt_meerdere_personen_inschrijven
		{
			get
			{
				return this.sgt_meerdere_personen_inschrijvenField;
			}
			set
			{
				this.sgt_meerdere_personen_inschrijvenField = value;
				base.RaisePropertyChanged("sgt_meerdere_personen_inschrijven");
			}
		}
		[XmlElement(Order = 9)]
		public CrmBoolean sgt_standaard
		{
			get
			{
				return this.sgt_standaardField;
			}
			set
			{
				this.sgt_standaardField = value;
				base.RaisePropertyChanged("sgt_standaard");
			}
		}
		[XmlElement(Order = 10)]
		public Key sgt_toe_inschrijf_functie_toernooisoortid
		{
			get
			{
				return this.sgt_toe_inschrijf_functie_toernooisoortidField;
			}
			set
			{
				this.sgt_toe_inschrijf_functie_toernooisoortidField = value;
				base.RaisePropertyChanged("sgt_toe_inschrijf_functie_toernooisoortid");
			}
		}
		[XmlElement(Order = 11)]
		public string sgt_toe_name
		{
			get
			{
				return this.sgt_toe_nameField;
			}
			set
			{
				this.sgt_toe_nameField = value;
				base.RaisePropertyChanged("sgt_toe_name");
			}
		}
		[XmlElement(Order = 12)]
		public Lookup sgt_toernooisoortid
		{
			get
			{
				return this.sgt_toernooisoortidField;
			}
			set
			{
				this.sgt_toernooisoortidField = value;
				base.RaisePropertyChanged("sgt_toernooisoortid");
			}
		}
		[XmlElement(Order = 13)]
		public CrmBoolean sgt_wildcards
		{
			get
			{
				return this.sgt_wildcardsField;
			}
			set
			{
				this.sgt_wildcardsField = value;
				base.RaisePropertyChanged("sgt_wildcards");
			}
		}
		[XmlElement(Order = 14)]
		public Sgt_toe_inschrijf_functie_toernooisoortStateInfo statecode
		{
			get
			{
				return this.statecodeField;
			}
			set
			{
				this.statecodeField = value;
				base.RaisePropertyChanged("statecode");
			}
		}
		[XmlElement(Order = 15)]
		public Status statuscode
		{
			get
			{
				return this.statuscodeField;
			}
			set
			{
				this.statuscodeField = value;
				base.RaisePropertyChanged("statuscode");
			}
		}
		[XmlElement(Order = 16)]
		public CrmNumber timezoneruleversionnumber
		{
			get
			{
				return this.timezoneruleversionnumberField;
			}
			set
			{
				this.timezoneruleversionnumberField = value;
				base.RaisePropertyChanged("timezoneruleversionnumber");
			}
		}
		[XmlElement(Order = 17)]
		public CrmNumber utcconversiontimezonecode
		{
			get
			{
				return this.utcconversiontimezonecodeField;
			}
			set
			{
				this.utcconversiontimezonecodeField = value;
				base.RaisePropertyChanged("utcconversiontimezonecode");
			}
		}
	}
}
