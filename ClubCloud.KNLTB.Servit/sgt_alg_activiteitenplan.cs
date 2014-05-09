using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_alg_activiteitenplan : BusinessEntity
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
		private CrmNumber sgt_aantal_deelnemers_activiteitField;
		private string sgt_alg_activiteitenplan1Field;
		private Key sgt_alg_activiteitenplanidField;
		private Lookup sgt_districtidField;
		private CrmDateTime sgt_einddatumField;
		private Lookup sgt_gebeurtenistypeidField;
		private CrmDateTime sgt_startdatumField;
		private Sgt_alg_activiteitenplanStateInfo statecodeField;
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
		public CrmNumber sgt_aantal_deelnemers_activiteit
		{
			get
			{
				return this.sgt_aantal_deelnemers_activiteitField;
			}
			set
			{
				this.sgt_aantal_deelnemers_activiteitField = value;
				base.RaisePropertyChanged("sgt_aantal_deelnemers_activiteit");
			}
		}
		[XmlElement("sgt_alg_activiteitenplan", Order = 10)]
		public string sgt_alg_activiteitenplan1
		{
			get
			{
				return this.sgt_alg_activiteitenplan1Field;
			}
			set
			{
				this.sgt_alg_activiteitenplan1Field = value;
				base.RaisePropertyChanged("sgt_alg_activiteitenplan1");
			}
		}
		[XmlElement(Order = 11)]
		public Key sgt_alg_activiteitenplanid
		{
			get
			{
				return this.sgt_alg_activiteitenplanidField;
			}
			set
			{
				this.sgt_alg_activiteitenplanidField = value;
				base.RaisePropertyChanged("sgt_alg_activiteitenplanid");
			}
		}
		[XmlElement(Order = 12)]
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
		[XmlElement(Order = 13)]
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
		[XmlElement(Order = 14)]
		public Lookup sgt_gebeurtenistypeid
		{
			get
			{
				return this.sgt_gebeurtenistypeidField;
			}
			set
			{
				this.sgt_gebeurtenistypeidField = value;
				base.RaisePropertyChanged("sgt_gebeurtenistypeid");
			}
		}
		[XmlElement(Order = 15)]
		public CrmDateTime sgt_startdatum
		{
			get
			{
				return this.sgt_startdatumField;
			}
			set
			{
				this.sgt_startdatumField = value;
				base.RaisePropertyChanged("sgt_startdatum");
			}
		}
		[XmlElement(Order = 16)]
		public Sgt_alg_activiteitenplanStateInfo statecode
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
