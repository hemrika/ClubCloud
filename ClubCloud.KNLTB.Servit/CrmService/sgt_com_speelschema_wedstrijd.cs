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
	public class sgt_com_speelschema_wedstrijd : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private Lookup organizationidField;

		private CrmDateTime overriddencreatedonField;

		private string sgt_com_naamField;

		private Key sgt_com_speelschema_wedstrijdidField;

		private CrmNumber sgt_ploeg_thuisField;

		private CrmNumber sgt_ploeg_uitField;

		private Lookup sgt_speelschema_standaardidField;

		private CrmNumber sgt_wedstrijddagField;

		private Sgt_com_speelschema_wedstrijdStateInfo statecodeField;

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
		public Lookup organizationid
		{
			get
			{
				return this.organizationidField;
			}
			set
			{
				this.organizationidField = value;
				base.RaisePropertyChanged("organizationid");
			}
		}

		[XmlElement] //[XmlElement(Order=6)]
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

		[XmlElement] //[XmlElement(Order=7)]
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

		[XmlElement] //[XmlElement(Order=8)]
		public Key sgt_com_speelschema_wedstrijdid
		{
			get
			{
				return this.sgt_com_speelschema_wedstrijdidField;
			}
			set
			{
				this.sgt_com_speelschema_wedstrijdidField = value;
				base.RaisePropertyChanged("sgt_com_speelschema_wedstrijdid");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public CrmNumber sgt_ploeg_thuis
		{
			get
			{
				return this.sgt_ploeg_thuisField;
			}
			set
			{
				this.sgt_ploeg_thuisField = value;
				base.RaisePropertyChanged("sgt_ploeg_thuis");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public CrmNumber sgt_ploeg_uit
		{
			get
			{
				return this.sgt_ploeg_uitField;
			}
			set
			{
				this.sgt_ploeg_uitField = value;
				base.RaisePropertyChanged("sgt_ploeg_uit");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
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

		[XmlElement] //[XmlElement(Order=12)]
		public CrmNumber sgt_wedstrijddag
		{
			get
			{
				return this.sgt_wedstrijddagField;
			}
			set
			{
				this.sgt_wedstrijddagField = value;
				base.RaisePropertyChanged("sgt_wedstrijddag");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public Sgt_com_speelschema_wedstrijdStateInfo statecode
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

		public sgt_com_speelschema_wedstrijd()
		{
		}
	}
}