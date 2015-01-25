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
	public class sgt_alg_baan : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private CrmDateTime overriddencreatedonField;

		private Owner owneridField;

		private Lookup owningbusinessunitField;

		private Lookup sgt_accommodatieidField;

		private string sgt_alg_baan1Field;

		private Key sgt_alg_baanidField;

		private Lookup sgt_baanblokidField;

		private CrmDateTime sgt_datum_keuringField;

		private CrmBoolean sgt_dispensatie_constructieField;

		private CrmBoolean sgt_dispensatie_maatvoeringField;

		private CrmBoolean sgt_dispensatie_obstakelsField;

		private string sgt_redenField;

		private Picklist sgt_statusField;

		private Lookup sgt_uitgevoerd_dooridField;

		private Sgt_alg_baanStateInfo statecodeField;

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
		public Lookup sgt_accommodatieid
		{
			get
			{
				return this.sgt_accommodatieidField;
			}
			set
			{
				this.sgt_accommodatieidField = value;
				base.RaisePropertyChanged("sgt_accommodatieid");
			}
		}

		[XmlElement("sgt_alg_baan")] //, Order=9)]
		public string sgt_alg_baan1
		{
			get
			{
				return this.sgt_alg_baan1Field;
			}
			set
			{
				this.sgt_alg_baan1Field = value;
				base.RaisePropertyChanged("sgt_alg_baan1");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public Key sgt_alg_baanid
		{
			get
			{
				return this.sgt_alg_baanidField;
			}
			set
			{
				this.sgt_alg_baanidField = value;
				base.RaisePropertyChanged("sgt_alg_baanid");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public Lookup sgt_baanblokid
		{
			get
			{
				return this.sgt_baanblokidField;
			}
			set
			{
				this.sgt_baanblokidField = value;
				base.RaisePropertyChanged("sgt_baanblokid");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public CrmDateTime sgt_datum_keuring
		{
			get
			{
				return this.sgt_datum_keuringField;
			}
			set
			{
				this.sgt_datum_keuringField = value;
				base.RaisePropertyChanged("sgt_datum_keuring");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public CrmBoolean sgt_dispensatie_constructie
		{
			get
			{
				return this.sgt_dispensatie_constructieField;
			}
			set
			{
				this.sgt_dispensatie_constructieField = value;
				base.RaisePropertyChanged("sgt_dispensatie_constructie");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public CrmBoolean sgt_dispensatie_maatvoering
		{
			get
			{
				return this.sgt_dispensatie_maatvoeringField;
			}
			set
			{
				this.sgt_dispensatie_maatvoeringField = value;
				base.RaisePropertyChanged("sgt_dispensatie_maatvoering");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public CrmBoolean sgt_dispensatie_obstakels
		{
			get
			{
				return this.sgt_dispensatie_obstakelsField;
			}
			set
			{
				this.sgt_dispensatie_obstakelsField = value;
				base.RaisePropertyChanged("sgt_dispensatie_obstakels");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public string sgt_reden
		{
			get
			{
				return this.sgt_redenField;
			}
			set
			{
				this.sgt_redenField = value;
				base.RaisePropertyChanged("sgt_reden");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
		public Picklist sgt_status
		{
			get
			{
				return this.sgt_statusField;
			}
			set
			{
				this.sgt_statusField = value;
				base.RaisePropertyChanged("sgt_status");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
		public Lookup sgt_uitgevoerd_doorid
		{
			get
			{
				return this.sgt_uitgevoerd_dooridField;
			}
			set
			{
				this.sgt_uitgevoerd_dooridField = value;
				base.RaisePropertyChanged("sgt_uitgevoerd_doorid");
			}
		}

		[XmlElement] //[XmlElement(Order=19)]
		public Sgt_alg_baanStateInfo statecode
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

		public sgt_alg_baan()
		{
		}
	}
}