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
	public class sgt_toe_administratieve_overtr_strafmaat : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmDecimal exchangerateField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private Lookup organizationidField;

		private CrmDateTime overriddencreatedonField;

		private Lookup sgt_constaterings_moment_idField;

		private CrmNumber sgt_overtreding_herhalingField;

		private CrmNumber sgt_overtreding_verstreken_periodeField;

		private Lookup sgt_straf_idField;

		private Lookup sgt_strafbepaling_idField;

		private CrmMoney sgt_strafmaat_boetebedragField;

		private CrmMoney sgt_strafmaat_boetebedrag_baseField;

		private Picklist sgt_strafmaat_junior_seniorField;

		private CrmNumber sgt_strafmaat_schorsingsperiodeField;

		private string sgt_strafmaat_toelichtingField;

		private string sgt_strafmaatregel_kenmerkField;

		private Key sgt_toe_administratieve_overtr_strafmaatidField;

		private Picklist sgt_type_evenementField;

		private Sgt_toe_administratieve_overtr_strafmaatStateInfo statecodeField;

		private Status statuscodeField;

		private CrmNumber timezoneruleversionnumberField;

		private Lookup transactioncurrencyidField;

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
		public CrmDecimal exchangerate
		{
			get
			{
				return this.exchangerateField;
			}
			set
			{
				this.exchangerateField = value;
				base.RaisePropertyChanged("exchangerate");
			}
		}

		[XmlElement] //[XmlElement(Order=3)]
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

		[XmlElement] //[XmlElement(Order=4)]
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

		[XmlElement] //[XmlElement(Order=5)]
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

		[XmlElement] //[XmlElement(Order=6)]
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

		[XmlElement] //[XmlElement(Order=7)]
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

		[XmlElement] //[XmlElement(Order=8)]
		public Lookup sgt_constaterings_moment_id
		{
			get
			{
				return this.sgt_constaterings_moment_idField;
			}
			set
			{
				this.sgt_constaterings_moment_idField = value;
				base.RaisePropertyChanged("sgt_constaterings_moment_id");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public CrmNumber sgt_overtreding_herhaling
		{
			get
			{
				return this.sgt_overtreding_herhalingField;
			}
			set
			{
				this.sgt_overtreding_herhalingField = value;
				base.RaisePropertyChanged("sgt_overtreding_herhaling");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public CrmNumber sgt_overtreding_verstreken_periode
		{
			get
			{
				return this.sgt_overtreding_verstreken_periodeField;
			}
			set
			{
				this.sgt_overtreding_verstreken_periodeField = value;
				base.RaisePropertyChanged("sgt_overtreding_verstreken_periode");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public Lookup sgt_straf_id
		{
			get
			{
				return this.sgt_straf_idField;
			}
			set
			{
				this.sgt_straf_idField = value;
				base.RaisePropertyChanged("sgt_straf_id");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public Lookup sgt_strafbepaling_id
		{
			get
			{
				return this.sgt_strafbepaling_idField;
			}
			set
			{
				this.sgt_strafbepaling_idField = value;
				base.RaisePropertyChanged("sgt_strafbepaling_id");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public CrmMoney sgt_strafmaat_boetebedrag
		{
			get
			{
				return this.sgt_strafmaat_boetebedragField;
			}
			set
			{
				this.sgt_strafmaat_boetebedragField = value;
				base.RaisePropertyChanged("sgt_strafmaat_boetebedrag");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public CrmMoney sgt_strafmaat_boetebedrag_base
		{
			get
			{
				return this.sgt_strafmaat_boetebedrag_baseField;
			}
			set
			{
				this.sgt_strafmaat_boetebedrag_baseField = value;
				base.RaisePropertyChanged("sgt_strafmaat_boetebedrag_base");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public Picklist sgt_strafmaat_junior_senior
		{
			get
			{
				return this.sgt_strafmaat_junior_seniorField;
			}
			set
			{
				this.sgt_strafmaat_junior_seniorField = value;
				base.RaisePropertyChanged("sgt_strafmaat_junior_senior");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public CrmNumber sgt_strafmaat_schorsingsperiode
		{
			get
			{
				return this.sgt_strafmaat_schorsingsperiodeField;
			}
			set
			{
				this.sgt_strafmaat_schorsingsperiodeField = value;
				base.RaisePropertyChanged("sgt_strafmaat_schorsingsperiode");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
		public string sgt_strafmaat_toelichting
		{
			get
			{
				return this.sgt_strafmaat_toelichtingField;
			}
			set
			{
				this.sgt_strafmaat_toelichtingField = value;
				base.RaisePropertyChanged("sgt_strafmaat_toelichting");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
		public string sgt_strafmaatregel_kenmerk
		{
			get
			{
				return this.sgt_strafmaatregel_kenmerkField;
			}
			set
			{
				this.sgt_strafmaatregel_kenmerkField = value;
				base.RaisePropertyChanged("sgt_strafmaatregel_kenmerk");
			}
		}

		[XmlElement] //[XmlElement(Order=19)]
		public Key sgt_toe_administratieve_overtr_strafmaatid
		{
			get
			{
				return this.sgt_toe_administratieve_overtr_strafmaatidField;
			}
			set
			{
				this.sgt_toe_administratieve_overtr_strafmaatidField = value;
				base.RaisePropertyChanged("sgt_toe_administratieve_overtr_strafmaatid");
			}
		}

		[XmlElement] //[XmlElement(Order=20)]
		public Picklist sgt_type_evenement
		{
			get
			{
				return this.sgt_type_evenementField;
			}
			set
			{
				this.sgt_type_evenementField = value;
				base.RaisePropertyChanged("sgt_type_evenement");
			}
		}

		[XmlElement] //[XmlElement(Order=21)]
		public Sgt_toe_administratieve_overtr_strafmaatStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=22)]
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

		[XmlElement] //[XmlElement(Order=23)]
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

		[XmlElement] //[XmlElement(Order=24)]
		public Lookup transactioncurrencyid
		{
			get
			{
				return this.transactioncurrencyidField;
			}
			set
			{
				this.transactioncurrencyidField = value;
				base.RaisePropertyChanged("transactioncurrencyid");
			}
		}

		[XmlElement] //[XmlElement(Order=25)]
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

		public sgt_toe_administratieve_overtr_strafmaat()
		{
		}
	}
}