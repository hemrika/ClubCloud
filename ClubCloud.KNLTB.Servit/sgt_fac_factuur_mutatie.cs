using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_fac_factuur_mutatie : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private CrmNumber sgt_aantalField;
		private Lookup sgt_administratieidField;
		private Lookup sgt_basisorganisatieidField;
		private string sgt_entiteitnaamField;
		private Key sgt_fac_factuur_mutatieidField;
		private string sgt_fac_nameField;
		private Picklist sgt_factuurtypeField;
		private string sgt_idrecordField;
		private Lookup sgt_persoonidField;
		private string sgt_productbeschrijvingField;
		private Picklist sgt_productcodeField;
		private Picklist sgt_statusField;
		private Sgt_fac_factuur_mutatieStateInfo statecodeField;
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
		public CrmNumber sgt_aantal
		{
			get
			{
				return this.sgt_aantalField;
			}
			set
			{
				this.sgt_aantalField = value;
				base.RaisePropertyChanged("sgt_aantal");
			}
		}
		[XmlElement(Order = 9)]
		public Lookup sgt_administratieid
		{
			get
			{
				return this.sgt_administratieidField;
			}
			set
			{
				this.sgt_administratieidField = value;
				base.RaisePropertyChanged("sgt_administratieid");
			}
		}
		[XmlElement(Order = 10)]
		public Lookup sgt_basisorganisatieid
		{
			get
			{
				return this.sgt_basisorganisatieidField;
			}
			set
			{
				this.sgt_basisorganisatieidField = value;
				base.RaisePropertyChanged("sgt_basisorganisatieid");
			}
		}
		[XmlElement(Order = 11)]
		public string sgt_entiteitnaam
		{
			get
			{
				return this.sgt_entiteitnaamField;
			}
			set
			{
				this.sgt_entiteitnaamField = value;
				base.RaisePropertyChanged("sgt_entiteitnaam");
			}
		}
		[XmlElement(Order = 12)]
		public Key sgt_fac_factuur_mutatieid
		{
			get
			{
				return this.sgt_fac_factuur_mutatieidField;
			}
			set
			{
				this.sgt_fac_factuur_mutatieidField = value;
				base.RaisePropertyChanged("sgt_fac_factuur_mutatieid");
			}
		}
		[XmlElement(Order = 13)]
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
		[XmlElement(Order = 14)]
		public Picklist sgt_factuurtype
		{
			get
			{
				return this.sgt_factuurtypeField;
			}
			set
			{
				this.sgt_factuurtypeField = value;
				base.RaisePropertyChanged("sgt_factuurtype");
			}
		}
		[XmlElement(Order = 15)]
		public string sgt_idrecord
		{
			get
			{
				return this.sgt_idrecordField;
			}
			set
			{
				this.sgt_idrecordField = value;
				base.RaisePropertyChanged("sgt_idrecord");
			}
		}
		[XmlElement(Order = 16)]
		public Lookup sgt_persoonid
		{
			get
			{
				return this.sgt_persoonidField;
			}
			set
			{
				this.sgt_persoonidField = value;
				base.RaisePropertyChanged("sgt_persoonid");
			}
		}
		[XmlElement(Order = 17)]
		public string sgt_productbeschrijving
		{
			get
			{
				return this.sgt_productbeschrijvingField;
			}
			set
			{
				this.sgt_productbeschrijvingField = value;
				base.RaisePropertyChanged("sgt_productbeschrijving");
			}
		}
		[XmlElement(Order = 18)]
		public Picklist sgt_productcode
		{
			get
			{
				return this.sgt_productcodeField;
			}
			set
			{
				this.sgt_productcodeField = value;
				base.RaisePropertyChanged("sgt_productcode");
			}
		}
		[XmlElement(Order = 19)]
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
		[XmlElement(Order = 20)]
		public Sgt_fac_factuur_mutatieStateInfo statecode
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
		[XmlElement(Order = 21)]
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
		[XmlElement(Order = 22)]
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
		[XmlElement(Order = 23)]
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
