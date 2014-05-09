using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_com_toegepast_speelschema : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private CrmNumber sgt_aantal_dagenField;
		private CrmNumber sgt_aantal_ploegenField;
		private string sgt_com_naamField;
		private Key sgt_com_toegepast_speelschemaidField;
		private Lookup sgt_competitieidField;
		private Picklist sgt_soort_speelschemaField;
		private Lookup sgt_speelschema_standaardidField;
		private Sgt_com_toegepast_speelschemaStateInfo statecodeField;
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
		public CrmNumber sgt_aantal_dagen
		{
			get
			{
				return this.sgt_aantal_dagenField;
			}
			set
			{
				this.sgt_aantal_dagenField = value;
				base.RaisePropertyChanged("sgt_aantal_dagen");
			}
		}
		[XmlElement(Order = 9)]
		public CrmNumber sgt_aantal_ploegen
		{
			get
			{
				return this.sgt_aantal_ploegenField;
			}
			set
			{
				this.sgt_aantal_ploegenField = value;
				base.RaisePropertyChanged("sgt_aantal_ploegen");
			}
		}
		[XmlElement(Order = 10)]
		public string sgt_com_naam
		{
			get
			{
				return this.sgt_com_naamField;
			}
			set
			{
				this.sgt_com_naamField = value;
				base.RaisePropertyChanged("sgt_com_naam");
			}
		}
		[XmlElement(Order = 11)]
		public Key sgt_com_toegepast_speelschemaid
		{
			get
			{
				return this.sgt_com_toegepast_speelschemaidField;
			}
			set
			{
				this.sgt_com_toegepast_speelschemaidField = value;
				base.RaisePropertyChanged("sgt_com_toegepast_speelschemaid");
			}
		}
		[XmlElement(Order = 12)]
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
		[XmlElement(Order = 13)]
		public Picklist sgt_soort_speelschema
		{
			get
			{
				return this.sgt_soort_speelschemaField;
			}
			set
			{
				this.sgt_soort_speelschemaField = value;
				base.RaisePropertyChanged("sgt_soort_speelschema");
			}
		}
		[XmlElement(Order = 14)]
		public Lookup sgt_speelschema_standaardid
		{
			get
			{
				return this.sgt_speelschema_standaardidField;
			}
			set
			{
				this.sgt_speelschema_standaardidField = value;
				base.RaisePropertyChanged("sgt_speelschema_standaardid");
			}
		}
		[XmlElement(Order = 15)]
		public Sgt_com_toegepast_speelschemaStateInfo statecode
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
		[XmlElement(Order = 16)]
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
		[XmlElement(Order = 17)]
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
		[XmlElement(Order = 18)]
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
