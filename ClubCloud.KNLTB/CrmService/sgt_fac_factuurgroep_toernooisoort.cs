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
	public class sgt_fac_factuurgroep_toernooisoort : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private CrmDateTime overriddencreatedonField;

		private Owner owneridField;

		private Lookup owningbusinessunitField;

		private Key sgt_fac_factuurgroep_toernooisoortidField;

		private string sgt_fac_nameField;

		private CrmBoolean sgt_facturatie_vrijstellingField;

		private Lookup sgt_factuurgroepidField;

		private Lookup sgt_toernooisoortidField;

		private Sgt_fac_factuurgroep_toernooisoortStateInfo statecodeField;

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
		public Key sgt_fac_factuurgroep_toernooisoortid
		{
			get
			{
				return this.sgt_fac_factuurgroep_toernooisoortidField;
			}
			set
			{
				this.sgt_fac_factuurgroep_toernooisoortidField = value;
				base.RaisePropertyChanged("sgt_fac_factuurgroep_toernooisoortid");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public string sgt_fac_name
		{
			get
			{
				return this.sgt_fac_nameField;
			}
			set
			{
				this.sgt_fac_nameField = value;
				base.RaisePropertyChanged("sgt_fac_name");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public CrmBoolean sgt_facturatie_vrijstelling
		{
			get
			{
				return this.sgt_facturatie_vrijstellingField;
			}
			set
			{
				this.sgt_facturatie_vrijstellingField = value;
				base.RaisePropertyChanged("sgt_facturatie_vrijstelling");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public Lookup sgt_factuurgroepid
		{
			get
			{
				return this.sgt_factuurgroepidField;
			}
			set
			{
				this.sgt_factuurgroepidField = value;
				base.RaisePropertyChanged("sgt_factuurgroepid");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
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

		[XmlElement] //[XmlElement(Order=13)]
		public Sgt_fac_factuurgroep_toernooisoortStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=14)]
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

		[XmlElement] //[XmlElement(Order=15)]
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

		[XmlElement] //[XmlElement(Order=16)]
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

		public sgt_fac_factuurgroep_toernooisoort()
		{
		}
	}
}