using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[GeneratedCode("System.Xml", "4.0.30319.33440")]
	[Serializable]
	[XmlType(Namespace="http://schemas.microsoft.com/crm/2007/WebServices")]
	public class sgt_com_ploegsamenstelling : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private CrmDateTime overriddencreatedonField;

		private Owner owneridField;

		private Lookup owningbusinessunitField;

		private string sgt_bondsnummerField;

		private Key sgt_com_ploegsamenstellingidField;

		private CrmDateTime sgt_geboortedatumField;

		private Picklist sgt_geslachtField;

		private Lookup sgt_ingedeelde_ploeg_idField;

		private Lookup sgt_lidmaatschap_idField;

		private string sgt_nameField;

		private Lookup sgt_niet_knltb_lid_idField;

		private CrmBoolean sgt_niet_knltb_lid_jnField;

		private CrmNumber sgt_speelsterkte_dubbelField;

		private CrmNumber sgt_speelsterkte_enkelField;

		private Sgt_com_ploegsamenstellingStateInfo statecodeField;

		private Status statuscodeField;

		private CrmNumber timezoneruleversionnumberField;

		private CrmNumber utcconversiontimezonecodeField;

		[XmlElement] //[XmlElement(Order=0)]
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

		[XmlElement] //[XmlElement(Order=1)]
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

		[XmlElement] //[XmlElement(Order=2)]
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

		[XmlElement] //[XmlElement(Order=3)]
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

		[XmlElement] //[XmlElement(Order=4)]
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

		[XmlElement] //[XmlElement(Order=5)]
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

		[XmlElement] //[XmlElement(Order=6)]
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

		[XmlElement] //[XmlElement(Order=7)]
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

		[XmlElement] //[XmlElement(Order=8)]
		public string sgt_bondsnummer
		{
			get
			{
				return this.sgt_bondsnummerField;
			}
			set
			{
				this.sgt_bondsnummerField = value;
				base.RaisePropertyChanged("sgt_bondsnummer");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public Key sgt_com_ploegsamenstellingid
		{
			get
			{
				return this.sgt_com_ploegsamenstellingidField;
			}
			set
			{
				this.sgt_com_ploegsamenstellingidField = value;
				base.RaisePropertyChanged("sgt_com_ploegsamenstellingid");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public CrmDateTime sgt_geboortedatum
		{
			get
			{
				return this.sgt_geboortedatumField;
			}
			set
			{
				this.sgt_geboortedatumField = value;
				base.RaisePropertyChanged("sgt_geboortedatum");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
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

		[XmlElement] //[XmlElement(Order=12)]
		public Lookup sgt_ingedeelde_ploeg_id
		{
			get
			{
				return this.sgt_ingedeelde_ploeg_idField;
			}
			set
			{
				this.sgt_ingedeelde_ploeg_idField = value;
				base.RaisePropertyChanged("sgt_ingedeelde_ploeg_id");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public Lookup sgt_lidmaatschap_id
		{
			get
			{
				return this.sgt_lidmaatschap_idField;
			}
			set
			{
				this.sgt_lidmaatschap_idField = value;
				base.RaisePropertyChanged("sgt_lidmaatschap_id");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public string sgt_name
		{
			get
			{
				return this.sgt_nameField;
			}
			set
			{
				this.sgt_nameField = value;
				base.RaisePropertyChanged("sgt_name");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public Lookup sgt_niet_knltb_lid_id
		{
			get
			{
				return this.sgt_niet_knltb_lid_idField;
			}
			set
			{
				this.sgt_niet_knltb_lid_idField = value;
				base.RaisePropertyChanged("sgt_niet_knltb_lid_id");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public CrmBoolean sgt_niet_knltb_lid_jn
		{
			get
			{
				return this.sgt_niet_knltb_lid_jnField;
			}
			set
			{
				this.sgt_niet_knltb_lid_jnField = value;
				base.RaisePropertyChanged("sgt_niet_knltb_lid_jn");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
		public CrmNumber sgt_speelsterkte_dubbel
		{
			get
			{
				return this.sgt_speelsterkte_dubbelField;
			}
			set
			{
				this.sgt_speelsterkte_dubbelField = value;
				base.RaisePropertyChanged("sgt_speelsterkte_dubbel");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
		public CrmNumber sgt_speelsterkte_enkel
		{
			get
			{
				return this.sgt_speelsterkte_enkelField;
			}
			set
			{
				this.sgt_speelsterkte_enkelField = value;
				base.RaisePropertyChanged("sgt_speelsterkte_enkel");
			}
		}

		[XmlElement] //[XmlElement(Order=19)]
		public Sgt_com_ploegsamenstellingStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=20)]
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

		[XmlElement] //[XmlElement(Order=21)]
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

		[XmlElement] //[XmlElement(Order=22)]
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

		public sgt_com_ploegsamenstelling()
		{
		}
	}
}