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
	public class sgt_alg_certificaat : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private CrmDateTime overriddencreatedonField;

		private Owner owneridField;

		private Lookup owningbusinessunitField;

		private Key sgt_alg_certificaatidField;

		private Lookup sgt_certificaatidField;

		private string sgt_certificaatnummerField;

		private Lookup sgt_cursistidField;

		private CrmBoolean sgt_email_reminder_certificering_verstuurdField;

		private CrmDateTime sgt_geldig_tot_en_metField;

		private CrmDateTime sgt_geldig_vanafField;

		private CrmNumber sgt_geldigheidsduurField;

		private string sgt_nameField;

		private Lookup sgt_opleidingidField;

		private string sgt_opmerkingField;

		private Lookup sgt_verenigingidField;

		private CrmNumber sgt_volgordenummerField;

		private Sgt_alg_certificaatStateInfo statecodeField;

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
		public Key sgt_alg_certificaatid
		{
			get
			{
				return this.sgt_alg_certificaatidField;
			}
			set
			{
				this.sgt_alg_certificaatidField = value;
				base.RaisePropertyChanged("sgt_alg_certificaatid");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public Lookup sgt_certificaatid
		{
			get
			{
				return this.sgt_certificaatidField;
			}
			set
			{
				this.sgt_certificaatidField = value;
				base.RaisePropertyChanged("sgt_certificaatid");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public string sgt_certificaatnummer
		{
			get
			{
				return this.sgt_certificaatnummerField;
			}
			set
			{
				this.sgt_certificaatnummerField = value;
				base.RaisePropertyChanged("sgt_certificaatnummer");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public Lookup sgt_cursistid
		{
			get
			{
				return this.sgt_cursistidField;
			}
			set
			{
				this.sgt_cursistidField = value;
				base.RaisePropertyChanged("sgt_cursistid");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public CrmBoolean sgt_email_reminder_certificering_verstuurd
		{
			get
			{
				return this.sgt_email_reminder_certificering_verstuurdField;
			}
			set
			{
				this.sgt_email_reminder_certificering_verstuurdField = value;
				base.RaisePropertyChanged("sgt_email_reminder_certificering_verstuurd");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public CrmDateTime sgt_geldig_tot_en_met
		{
			get
			{
				return this.sgt_geldig_tot_en_metField;
			}
			set
			{
				this.sgt_geldig_tot_en_metField = value;
				base.RaisePropertyChanged("sgt_geldig_tot_en_met");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
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

		[XmlElement] //[XmlElement(Order=15)]
		public CrmNumber sgt_geldigheidsduur
		{
			get
			{
				return this.sgt_geldigheidsduurField;
			}
			set
			{
				this.sgt_geldigheidsduurField = value;
				base.RaisePropertyChanged("sgt_geldigheidsduur");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
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

		[XmlElement] //[XmlElement(Order=17)]
		public Lookup sgt_opleidingid
		{
			get
			{
				return this.sgt_opleidingidField;
			}
			set
			{
				this.sgt_opleidingidField = value;
				base.RaisePropertyChanged("sgt_opleidingid");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
		public string sgt_opmerking
		{
			get
			{
				return this.sgt_opmerkingField;
			}
			set
			{
				this.sgt_opmerkingField = value;
				base.RaisePropertyChanged("sgt_opmerking");
			}
		}

		[XmlElement] //[XmlElement(Order=19)]
		public Lookup sgt_verenigingid
		{
			get
			{
				return this.sgt_verenigingidField;
			}
			set
			{
				this.sgt_verenigingidField = value;
				base.RaisePropertyChanged("sgt_verenigingid");
			}
		}

		[XmlElement] //[XmlElement(Order=20)]
		public CrmNumber sgt_volgordenummer
		{
			get
			{
				return this.sgt_volgordenummerField;
			}
			set
			{
				this.sgt_volgordenummerField = value;
				base.RaisePropertyChanged("sgt_volgordenummer");
			}
		}

		[XmlElement] //[XmlElement(Order=21)]
		public Sgt_alg_certificaatStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=22)]
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

		[XmlElement] //[XmlElement(Order=23)]
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

		[XmlElement] //[XmlElement(Order=24)]
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

		public sgt_alg_certificaat()
		{
		}
	}
}