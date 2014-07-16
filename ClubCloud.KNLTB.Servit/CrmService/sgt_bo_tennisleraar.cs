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
	public class sgt_bo_tennisleraar : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private CrmDateTime overriddencreatedonField;

		private Owner owneridField;

		private Lookup owningbusinessunitField;

		private CrmDateTime sgt_begindatumField;

		private CrmBoolean sgt_betaaldField;

		private CrmBoolean sgt_bijzondere_licentieField;

		private string sgt_bo_tennisleraar1Field;

		private Key sgt_bo_tennisleraaridField;

		private Lookup sgt_districtidField;

		private CrmDateTime sgt_einddatumField;

		private CrmBoolean sgt_email_verlopen_lic_tennisleraar_verstuurdField;

		private CrmBoolean sgt_erkend_diplomaField;

		private CrmBoolean sgt_gratis_licentieField;

		private CrmBoolean sgt_leraren_in_buitenlandField;

		private CrmDateTime sgt_licentie_aangevraagdField;

		private Lookup sgt_licentieidField;

		private CrmBoolean sgt_lid_vntField;

		private Picklist sgt_statusField;

		private Lookup sgt_tennisleraaridField;

		private CrmBoolean sgt_verlengenField;

		private CrmDateTime sgt_verstrekkingsdatumField;

		private Sgt_bo_tennisleraarStateInfo statecodeField;

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
		public CrmDateTime sgt_begindatum
		{
			get
			{
				return this.sgt_begindatumField;
			}
			set
			{
				this.sgt_begindatumField = value;
				base.RaisePropertyChanged("sgt_begindatum");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public CrmBoolean sgt_betaald
		{
			get
			{
				return this.sgt_betaaldField;
			}
			set
			{
				this.sgt_betaaldField = value;
				base.RaisePropertyChanged("sgt_betaald");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public CrmBoolean sgt_bijzondere_licentie
		{
			get
			{
				return this.sgt_bijzondere_licentieField;
			}
			set
			{
				this.sgt_bijzondere_licentieField = value;
				base.RaisePropertyChanged("sgt_bijzondere_licentie");
			}
		}

		[XmlElement("sgt_bo_tennisleraar")] //, Order=11)]
		public string sgt_bo_tennisleraar1
		{
			get
			{
				return this.sgt_bo_tennisleraar1Field;
			}
			set
			{
				this.sgt_bo_tennisleraar1Field = value;
				base.RaisePropertyChanged("sgt_bo_tennisleraar1");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public Key sgt_bo_tennisleraarid
		{
			get
			{
				return this.sgt_bo_tennisleraaridField;
			}
			set
			{
				this.sgt_bo_tennisleraaridField = value;
				base.RaisePropertyChanged("sgt_bo_tennisleraarid");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public Lookup sgt_districtid
		{
			get
			{
				return this.sgt_districtidField;
			}
			set
			{
				this.sgt_districtidField = value;
				base.RaisePropertyChanged("sgt_districtid");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public CrmDateTime sgt_einddatum
		{
			get
			{
				return this.sgt_einddatumField;
			}
			set
			{
				this.sgt_einddatumField = value;
				base.RaisePropertyChanged("sgt_einddatum");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public CrmBoolean sgt_email_verlopen_lic_tennisleraar_verstuurd
		{
			get
			{
				return this.sgt_email_verlopen_lic_tennisleraar_verstuurdField;
			}
			set
			{
				this.sgt_email_verlopen_lic_tennisleraar_verstuurdField = value;
				base.RaisePropertyChanged("sgt_email_verlopen_lic_tennisleraar_verstuurd");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public CrmBoolean sgt_erkend_diploma
		{
			get
			{
				return this.sgt_erkend_diplomaField;
			}
			set
			{
				this.sgt_erkend_diplomaField = value;
				base.RaisePropertyChanged("sgt_erkend_diploma");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
		public CrmBoolean sgt_gratis_licentie
		{
			get
			{
				return this.sgt_gratis_licentieField;
			}
			set
			{
				this.sgt_gratis_licentieField = value;
				base.RaisePropertyChanged("sgt_gratis_licentie");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
		public CrmBoolean sgt_leraren_in_buitenland
		{
			get
			{
				return this.sgt_leraren_in_buitenlandField;
			}
			set
			{
				this.sgt_leraren_in_buitenlandField = value;
				base.RaisePropertyChanged("sgt_leraren_in_buitenland");
			}
		}

		[XmlElement] //[XmlElement(Order=19)]
		public CrmDateTime sgt_licentie_aangevraagd
		{
			get
			{
				return this.sgt_licentie_aangevraagdField;
			}
			set
			{
				this.sgt_licentie_aangevraagdField = value;
				base.RaisePropertyChanged("sgt_licentie_aangevraagd");
			}
		}

		[XmlElement] //[XmlElement(Order=20)]
		public Lookup sgt_licentieid
		{
			get
			{
				return this.sgt_licentieidField;
			}
			set
			{
				this.sgt_licentieidField = value;
				base.RaisePropertyChanged("sgt_licentieid");
			}
		}

		[XmlElement] //[XmlElement(Order=21)]
		public CrmBoolean sgt_lid_vnt
		{
			get
			{
				return this.sgt_lid_vntField;
			}
			set
			{
				this.sgt_lid_vntField = value;
				base.RaisePropertyChanged("sgt_lid_vnt");
			}
		}

		[XmlElement] //[XmlElement(Order=22)]
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

		[XmlElement] //[XmlElement(Order=23)]
		public Lookup sgt_tennisleraarid
		{
			get
			{
				return this.sgt_tennisleraaridField;
			}
			set
			{
				this.sgt_tennisleraaridField = value;
				base.RaisePropertyChanged("sgt_tennisleraarid");
			}
		}

		[XmlElement] //[XmlElement(Order=24)]
		public CrmBoolean sgt_verlengen
		{
			get
			{
				return this.sgt_verlengenField;
			}
			set
			{
				this.sgt_verlengenField = value;
				base.RaisePropertyChanged("sgt_verlengen");
			}
		}

		[XmlElement] //[XmlElement(Order=25)]
		public CrmDateTime sgt_verstrekkingsdatum
		{
			get
			{
				return this.sgt_verstrekkingsdatumField;
			}
			set
			{
				this.sgt_verstrekkingsdatumField = value;
				base.RaisePropertyChanged("sgt_verstrekkingsdatum");
			}
		}

		[XmlElement] //[XmlElement(Order=26)]
		public Sgt_bo_tennisleraarStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=27)]
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

		[XmlElement] //[XmlElement(Order=28)]
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

		[XmlElement] //[XmlElement(Order=29)]
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

		public sgt_bo_tennisleraar()
		{
		}
	}
}