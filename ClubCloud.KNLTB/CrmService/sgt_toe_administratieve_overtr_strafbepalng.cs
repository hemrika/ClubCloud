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
	public class sgt_toe_administratieve_overtr_strafbepalng : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private Lookup organizationidField;

		private CrmDateTime overriddencreatedonField;

		private string sgt_strafbepaling_kenmerkField;

		private string sgt_strafbepaling_omschrijvingField;

		private string sgt_strafbepaling_toelichtingField;

		private Key sgt_toe_administratieve_overtr_strafbepalngidField;

		private Picklist sgt_wedstrijdleiding_deelnemerField;

		private Sgt_toe_administratieve_overtr_strafbepalngStateInfo statecodeField;

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
		public string sgt_strafbepaling_kenmerk
		{
			get
			{
				return this.sgt_strafbepaling_kenmerkField;
			}
			set
			{
				this.sgt_strafbepaling_kenmerkField = value;
				base.RaisePropertyChanged("sgt_strafbepaling_kenmerk");
			}
		}

		[XmlElement] //[XmlElement(Order=8)]
		public string sgt_strafbepaling_omschrijving
		{
			get
			{
				return this.sgt_strafbepaling_omschrijvingField;
			}
			set
			{
				this.sgt_strafbepaling_omschrijvingField = value;
				base.RaisePropertyChanged("sgt_strafbepaling_omschrijving");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public string sgt_strafbepaling_toelichting
		{
			get
			{
				return this.sgt_strafbepaling_toelichtingField;
			}
			set
			{
				this.sgt_strafbepaling_toelichtingField = value;
				base.RaisePropertyChanged("sgt_strafbepaling_toelichting");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public Key sgt_toe_administratieve_overtr_strafbepalngid
		{
			get
			{
				return this.sgt_toe_administratieve_overtr_strafbepalngidField;
			}
			set
			{
				this.sgt_toe_administratieve_overtr_strafbepalngidField = value;
				base.RaisePropertyChanged("sgt_toe_administratieve_overtr_strafbepalngid");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public Picklist sgt_wedstrijdleiding_deelnemer
		{
			get
			{
				return this.sgt_wedstrijdleiding_deelnemerField;
			}
			set
			{
				this.sgt_wedstrijdleiding_deelnemerField = value;
				base.RaisePropertyChanged("sgt_wedstrijdleiding_deelnemer");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public Sgt_toe_administratieve_overtr_strafbepalngStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=13)]
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

		[XmlElement] //[XmlElement(Order=14)]
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

		[XmlElement] //[XmlElement(Order=15)]
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

		public sgt_toe_administratieve_overtr_strafbepalng()
		{
		}
	}
}