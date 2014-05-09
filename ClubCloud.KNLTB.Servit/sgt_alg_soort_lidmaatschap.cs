using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_alg_soort_lidmaatschap : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private Lookup organizationidField;
		private CrmDateTime overriddencreatedonField;
		private string sgt_alg_soort_lidmaatschap1Field;
		private Key sgt_alg_soort_lidmaatschapidField;
		private string sgt_beschrijvingField;
		private CrmBoolean sgt_bijdrage_bkhField;
		private CrmBoolean sgt_buitenlandse_bondspelerField;
		private CrmBoolean sgt_contributieField;
		private string sgt_meervoudsnaamField;
		private string sgt_omschrijvingField;
		private string sgt_verkorte_codeField;
		private Sgt_alg_soort_lidmaatschapStateInfo statecodeField;
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
		[XmlElement("sgt_alg_soort_lidmaatschap", Order = 7)]
		public string sgt_alg_soort_lidmaatschap1
		{
			get
			{
				return this.sgt_alg_soort_lidmaatschap1Field;
			}
			set
			{
				this.sgt_alg_soort_lidmaatschap1Field = value;
				base.RaisePropertyChanged("sgt_alg_soort_lidmaatschap1");
			}
		}
		[XmlElement(Order = 8)]
		public Key sgt_alg_soort_lidmaatschapid
		{
			get
			{
				return this.sgt_alg_soort_lidmaatschapidField;
			}
			set
			{
				this.sgt_alg_soort_lidmaatschapidField = value;
				base.RaisePropertyChanged("sgt_alg_soort_lidmaatschapid");
			}
		}
		[XmlElement(Order = 9)]
		public string sgt_beschrijving
		{
			get
			{
				return this.sgt_beschrijvingField;
			}
			set
			{
				this.sgt_beschrijvingField = value;
				base.RaisePropertyChanged("sgt_beschrijving");
			}
		}
		[XmlElement(Order = 10)]
		public CrmBoolean sgt_bijdrage_bkh
		{
			get
			{
				return this.sgt_bijdrage_bkhField;
			}
			set
			{
				this.sgt_bijdrage_bkhField = value;
				base.RaisePropertyChanged("sgt_bijdrage_bkh");
			}
		}
		[XmlElement(Order = 11)]
		public CrmBoolean sgt_buitenlandse_bondspeler
		{
			get
			{
				return this.sgt_buitenlandse_bondspelerField;
			}
			set
			{
				this.sgt_buitenlandse_bondspelerField = value;
				base.RaisePropertyChanged("sgt_buitenlandse_bondspeler");
			}
		}
		[XmlElement(Order = 12)]
		public CrmBoolean sgt_contributie
		{
			get
			{
				return this.sgt_contributieField;
			}
			set
			{
				this.sgt_contributieField = value;
				base.RaisePropertyChanged("sgt_contributie");
			}
		}
		[XmlElement(Order = 13)]
		public string sgt_meervoudsnaam
		{
			get
			{
				return this.sgt_meervoudsnaamField;
			}
			set
			{
				this.sgt_meervoudsnaamField = value;
				base.RaisePropertyChanged("sgt_meervoudsnaam");
			}
		}
		[XmlElement(Order = 14)]
		public string sgt_omschrijving
		{
			get
			{
				return this.sgt_omschrijvingField;
			}
			set
			{
				this.sgt_omschrijvingField = value;
				base.RaisePropertyChanged("sgt_omschrijving");
			}
		}
		[XmlElement(Order = 15)]
		public string sgt_verkorte_code
		{
			get
			{
				return this.sgt_verkorte_codeField;
			}
			set
			{
				this.sgt_verkorte_codeField = value;
				base.RaisePropertyChanged("sgt_verkorte_code");
			}
		}
		[XmlElement(Order = 16)]
		public Sgt_alg_soort_lidmaatschapStateInfo statecode
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
		[XmlElement(Order = 17)]
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
		[XmlElement(Order = 18)]
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
		[XmlElement(Order = 19)]
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
