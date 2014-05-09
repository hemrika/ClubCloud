using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_com_verenigingsdispensatie : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private Lookup sgt_aangevraagd_dooridField;
		private CrmNumber sgt_aantal_banenField;
		private Lookup sgt_afgekeurd_dooridField;
		private Lookup sgt_ander_parkidField;
		private string sgt_com_nameField;
		private Key sgt_com_verenigingsdispensatieidField;
		private Lookup sgt_competitieidField;
		private Picklist sgt_dagField;
		private Picklist sgt_dagdeelField;
		private CrmDateTime sgt_datum_aangevraagdField;
		private CrmDateTime sgt_datum_afgekeurdField;
		private CrmDateTime sgt_datum_goedgekeurdField;
		private Picklist sgt_dispensatietypeField;
		private Lookup sgt_goedgekeurd_dooridField;
		private Lookup sgt_reden_afgekeurdidField;
		private Lookup sgt_verenigingidField;
		private string sgt_verenigingsnummerField;
		private Sgt_com_verenigingsdispensatieStateInfo statecodeField;
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
		public Lookup sgt_aangevraagd_doorid
		{
			get
			{
				return this.sgt_aangevraagd_dooridField;
			}
			set
			{
				this.sgt_aangevraagd_dooridField = value;
				base.RaisePropertyChanged("sgt_aangevraagd_doorid");
			}
		}
		[XmlElement(Order = 9)]
		public CrmNumber sgt_aantal_banen
		{
			get
			{
				return this.sgt_aantal_banenField;
			}
			set
			{
				this.sgt_aantal_banenField = value;
				base.RaisePropertyChanged("sgt_aantal_banen");
			}
		}
		[XmlElement(Order = 10)]
		public Lookup sgt_afgekeurd_doorid
		{
			get
			{
				return this.sgt_afgekeurd_dooridField;
			}
			set
			{
				this.sgt_afgekeurd_dooridField = value;
				base.RaisePropertyChanged("sgt_afgekeurd_doorid");
			}
		}
		[XmlElement(Order = 11)]
		public Lookup sgt_ander_parkid
		{
			get
			{
				return this.sgt_ander_parkidField;
			}
			set
			{
				this.sgt_ander_parkidField = value;
				base.RaisePropertyChanged("sgt_ander_parkid");
			}
		}
		[XmlElement(Order = 12)]
		public string sgt_com_name
		{
			get
			{
				return this.sgt_com_nameField;
			}
			set
			{
				this.sgt_com_nameField = value;
				base.RaisePropertyChanged("sgt_com_name");
			}
		}
		[XmlElement(Order = 13)]
		public Key sgt_com_verenigingsdispensatieid
		{
			get
			{
				return this.sgt_com_verenigingsdispensatieidField;
			}
			set
			{
				this.sgt_com_verenigingsdispensatieidField = value;
				base.RaisePropertyChanged("sgt_com_verenigingsdispensatieid");
			}
		}
		[XmlElement(Order = 14)]
		public Lookup sgt_competitieid
		{
			get
			{
				return this.sgt_competitieidField;
			}
			set
			{
				this.sgt_competitieidField = value;
				base.RaisePropertyChanged("sgt_competitieid");
			}
		}
		[XmlElement(Order = 15)]
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
		[XmlElement(Order = 16)]
		public Picklist sgt_dagdeel
		{
			get
			{
				return this.sgt_dagdeelField;
			}
			set
			{
				this.sgt_dagdeelField = value;
				base.RaisePropertyChanged("sgt_dagdeel");
			}
		}
		[XmlElement(Order = 17)]
		public CrmDateTime sgt_datum_aangevraagd
		{
			get
			{
				return this.sgt_datum_aangevraagdField;
			}
			set
			{
				this.sgt_datum_aangevraagdField = value;
				base.RaisePropertyChanged("sgt_datum_aangevraagd");
			}
		}
		[XmlElement(Order = 18)]
		public CrmDateTime sgt_datum_afgekeurd
		{
			get
			{
				return this.sgt_datum_afgekeurdField;
			}
			set
			{
				this.sgt_datum_afgekeurdField = value;
				base.RaisePropertyChanged("sgt_datum_afgekeurd");
			}
		}
		[XmlElement(Order = 19)]
		public CrmDateTime sgt_datum_goedgekeurd
		{
			get
			{
				return this.sgt_datum_goedgekeurdField;
			}
			set
			{
				this.sgt_datum_goedgekeurdField = value;
				base.RaisePropertyChanged("sgt_datum_goedgekeurd");
			}
		}
		[XmlElement(Order = 20)]
		public Picklist sgt_dispensatietype
		{
			get
			{
				return this.sgt_dispensatietypeField;
			}
			set
			{
				this.sgt_dispensatietypeField = value;
				base.RaisePropertyChanged("sgt_dispensatietype");
			}
		}
		[XmlElement(Order = 21)]
		public Lookup sgt_goedgekeurd_doorid
		{
			get
			{
				return this.sgt_goedgekeurd_dooridField;
			}
			set
			{
				this.sgt_goedgekeurd_dooridField = value;
				base.RaisePropertyChanged("sgt_goedgekeurd_doorid");
			}
		}
		[XmlElement(Order = 22)]
		public Lookup sgt_reden_afgekeurdid
		{
			get
			{
				return this.sgt_reden_afgekeurdidField;
			}
			set
			{
				this.sgt_reden_afgekeurdidField = value;
				base.RaisePropertyChanged("sgt_reden_afgekeurdid");
			}
		}
		[XmlElement(Order = 23)]
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
		[XmlElement(Order = 24)]
		public string sgt_verenigingsnummer
		{
			get
			{
				return this.sgt_verenigingsnummerField;
			}
			set
			{
				this.sgt_verenigingsnummerField = value;
				base.RaisePropertyChanged("sgt_verenigingsnummer");
			}
		}
		[XmlElement(Order = 25)]
		public Sgt_com_verenigingsdispensatieStateInfo statecode
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
		[XmlElement(Order = 26)]
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
		[XmlElement(Order = 27)]
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
		[XmlElement(Order = 28)]
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
