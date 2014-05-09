using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_toe_inschrijfrecht_speler : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private CrmBoolean sgt_altijd_accepterenField;
		private string sgt_geboortejaarField;
		private CrmDateTime sgt_geldig_totField;
		private CrmDateTime sgt_geldig_vanafField;
		private Picklist sgt_geslachtField;
		private Lookup sgt_speleridField;
		private Picklist sgt_spelsoortField;
		private string sgt_toe_inschrijfrecht_speler1Field;
		private Key sgt_toe_inschrijfrecht_speleridField;
		private Lookup sgt_toernooisoortidField;
		private Sgt_toe_inschrijfrecht_spelerStateInfo statecodeField;
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
		[XmlElement(Order = 6)]
		public Owner ownerid
		{
			get
			{
				return this.owneridField;
			}
			set
			{
				this.owneridField = value;
				base.RaisePropertyChanged("ownerid");
			}
		}
		[XmlElement(Order = 7)]
		public Lookup owningbusinessunit
		{
			get
			{
				return this.owningbusinessunitField;
			}
			set
			{
				this.owningbusinessunitField = value;
				base.RaisePropertyChanged("owningbusinessunit");
			}
		}
		[XmlElement(Order = 8)]
		public CrmBoolean sgt_altijd_accepteren
		{
			get
			{
				return this.sgt_altijd_accepterenField;
			}
			set
			{
				this.sgt_altijd_accepterenField = value;
				base.RaisePropertyChanged("sgt_altijd_accepteren");
			}
		}
		[XmlElement(Order = 9)]
		public string sgt_geboortejaar
		{
			get
			{
				return this.sgt_geboortejaarField;
			}
			set
			{
				this.sgt_geboortejaarField = value;
				base.RaisePropertyChanged("sgt_geboortejaar");
			}
		}
		[XmlElement(Order = 10)]
		public CrmDateTime sgt_geldig_tot
		{
			get
			{
				return this.sgt_geldig_totField;
			}
			set
			{
				this.sgt_geldig_totField = value;
				base.RaisePropertyChanged("sgt_geldig_tot");
			}
		}
		[XmlElement(Order = 11)]
		public CrmDateTime sgt_geldig_vanaf
		{
			get
			{
				return this.sgt_geldig_vanafField;
			}
			set
			{
				this.sgt_geldig_vanafField = value;
				base.RaisePropertyChanged("sgt_geldig_vanaf");
			}
		}
		[XmlElement(Order = 12)]
		public Picklist sgt_geslacht
		{
			get
			{
				return this.sgt_geslachtField;
			}
			set
			{
				this.sgt_geslachtField = value;
				base.RaisePropertyChanged("sgt_geslacht");
			}
		}
		[XmlElement(Order = 13)]
		public Lookup sgt_spelerid
		{
			get
			{
				return this.sgt_speleridField;
			}
			set
			{
				this.sgt_speleridField = value;
				base.RaisePropertyChanged("sgt_spelerid");
			}
		}
		[XmlElement(Order = 14)]
		public Picklist sgt_spelsoort
		{
			get
			{
				return this.sgt_spelsoortField;
			}
			set
			{
				this.sgt_spelsoortField = value;
				base.RaisePropertyChanged("sgt_spelsoort");
			}
		}
		[XmlElement("sgt_toe_inschrijfrecht_speler", Order = 15)]
		public string sgt_toe_inschrijfrecht_speler1
		{
			get
			{
				return this.sgt_toe_inschrijfrecht_speler1Field;
			}
			set
			{
				this.sgt_toe_inschrijfrecht_speler1Field = value;
				base.RaisePropertyChanged("sgt_toe_inschrijfrecht_speler1");
			}
		}
		[XmlElement(Order = 16)]
		public Key sgt_toe_inschrijfrecht_spelerid
		{
			get
			{
				return this.sgt_toe_inschrijfrecht_speleridField;
			}
			set
			{
				this.sgt_toe_inschrijfrecht_speleridField = value;
				base.RaisePropertyChanged("sgt_toe_inschrijfrecht_spelerid");
			}
		}
		[XmlElement(Order = 17)]
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
		[XmlElement(Order = 18)]
		public Sgt_toe_inschrijfrecht_spelerStateInfo statecode
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
		[XmlElement(Order = 19)]
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
		[XmlElement(Order = 20)]
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
		[XmlElement(Order = 21)]
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
