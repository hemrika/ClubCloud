using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_alg_baan_gereserveerd : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private Lookup sgt_accomodatieidField;
		private Key sgt_alg_baan_gereserveerdidField;
		private string sgt_alg_nameField;
		private Lookup sgt_baan_gereserveerd_verenigingidField;
		private CrmNumber sgt_binnen_avondField;
		private CrmNumber sgt_binnen_middagField;
		private CrmNumber sgt_binnen_morgenField;
		private CrmNumber sgt_buiten_avondField;
		private CrmNumber sgt_buiten_middagField;
		private CrmNumber sgt_buiten_morgenField;
		private Picklist sgt_dagField;
		private Lookup sgt_verenigingidField;
		private CrmBoolean sgt_verlichtingField;
		private Sgt_alg_baan_gereserveerdStateInfo statecodeField;
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
		public Lookup sgt_accomodatieid
		{
			get
			{
				return this.sgt_accomodatieidField;
			}
			set
			{
				this.sgt_accomodatieidField = value;
				base.RaisePropertyChanged("sgt_accomodatieid");
			}
		}
		[XmlElement(Order = 9)]
		public Key sgt_alg_baan_gereserveerdid
		{
			get
			{
				return this.sgt_alg_baan_gereserveerdidField;
			}
			set
			{
				this.sgt_alg_baan_gereserveerdidField = value;
				base.RaisePropertyChanged("sgt_alg_baan_gereserveerdid");
			}
		}
		[XmlElement(Order = 10)]
		public string sgt_alg_name
		{
			get
			{
				return this.sgt_alg_nameField;
			}
			set
			{
				this.sgt_alg_nameField = value;
				base.RaisePropertyChanged("sgt_alg_name");
			}
		}
		[XmlElement(Order = 11)]
		public Lookup sgt_baan_gereserveerd_verenigingid
		{
			get
			{
				return this.sgt_baan_gereserveerd_verenigingidField;
			}
			set
			{
				this.sgt_baan_gereserveerd_verenigingidField = value;
				base.RaisePropertyChanged("sgt_baan_gereserveerd_verenigingid");
			}
		}
		[XmlElement(Order = 12)]
		public CrmNumber sgt_binnen_avond
		{
			get
			{
				return this.sgt_binnen_avondField;
			}
			set
			{
				this.sgt_binnen_avondField = value;
				base.RaisePropertyChanged("sgt_binnen_avond");
			}
		}
		[XmlElement(Order = 13)]
		public CrmNumber sgt_binnen_middag
		{
			get
			{
				return this.sgt_binnen_middagField;
			}
			set
			{
				this.sgt_binnen_middagField = value;
				base.RaisePropertyChanged("sgt_binnen_middag");
			}
		}
		[XmlElement(Order = 14)]
		public CrmNumber sgt_binnen_morgen
		{
			get
			{
				return this.sgt_binnen_morgenField;
			}
			set
			{
				this.sgt_binnen_morgenField = value;
				base.RaisePropertyChanged("sgt_binnen_morgen");
			}
		}
		[XmlElement(Order = 15)]
		public CrmNumber sgt_buiten_avond
		{
			get
			{
				return this.sgt_buiten_avondField;
			}
			set
			{
				this.sgt_buiten_avondField = value;
				base.RaisePropertyChanged("sgt_buiten_avond");
			}
		}
		[XmlElement(Order = 16)]
		public CrmNumber sgt_buiten_middag
		{
			get
			{
				return this.sgt_buiten_middagField;
			}
			set
			{
				this.sgt_buiten_middagField = value;
				base.RaisePropertyChanged("sgt_buiten_middag");
			}
		}
		[XmlElement(Order = 17)]
		public CrmNumber sgt_buiten_morgen
		{
			get
			{
				return this.sgt_buiten_morgenField;
			}
			set
			{
				this.sgt_buiten_morgenField = value;
				base.RaisePropertyChanged("sgt_buiten_morgen");
			}
		}
		[XmlElement(Order = 18)]
		public Picklist sgt_dag
		{
			get
			{
				return this.sgt_dagField;
			}
			set
			{
				this.sgt_dagField = value;
				base.RaisePropertyChanged("sgt_dag");
			}
		}
		[XmlElement(Order = 19)]
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
		[XmlElement(Order = 20)]
		public CrmBoolean sgt_verlichting
		{
			get
			{
				return this.sgt_verlichtingField;
			}
			set
			{
				this.sgt_verlichtingField = value;
				base.RaisePropertyChanged("sgt_verlichting");
			}
		}
		[XmlElement(Order = 21)]
		public Sgt_alg_baan_gereserveerdStateInfo statecode
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
		[XmlElement(Order = 22)]
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
		[XmlElement(Order = 23)]
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
		[XmlElement(Order = 24)]
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
