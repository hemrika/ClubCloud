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
	public class sgt_toe_administratieve_overtr_beroep_mut : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmDecimal exchangerateField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private CrmDateTime overriddencreatedonField;

		private Owner owneridField;

		private Lookup owningbusinessunitField;

		private Lookup sgt_administratieve_overtreding_idField;

		private Picklist sgt_beroep_aanvraag_status_mutField;

		private Lookup sgt_beroep_idField;

		private CrmMoney sgt_boetebedragField;

		private CrmMoney sgt_boetebedrag_baseField;

		private string sgt_nameField;

		private string sgt_samengesteld_volgnummerField;

		private CrmNumber sgt_schorsingsperiode_mutField;

		private Lookup sgt_straf_idField;

		private Key sgt_toe_administratieve_overtr_beroep_mutidField;

		private string sgt_toelichting_commissie_mutField;

		private Sgt_toe_administratieve_overtr_beroep_mutStateInfo statecodeField;

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

		[XmlElement] //[XmlElement(Order=8)]
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

		[XmlElement] //[XmlElement(Order=9)]
		public Lookup sgt_administratieve_overtreding_id
		{
			get
			{
				return this.sgt_administratieve_overtreding_idField;
			}
			set
			{
				this.sgt_administratieve_overtreding_idField = value;
				base.RaisePropertyChanged("sgt_administratieve_overtreding_id");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public Picklist sgt_beroep_aanvraag_status_mut
		{
			get
			{
				return this.sgt_beroep_aanvraag_status_mutField;
			}
			set
			{
				this.sgt_beroep_aanvraag_status_mutField = value;
				base.RaisePropertyChanged("sgt_beroep_aanvraag_status_mut");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public Lookup sgt_beroep_id
		{
			get
			{
				return this.sgt_beroep_idField;
			}
			set
			{
				this.sgt_beroep_idField = value;
				base.RaisePropertyChanged("sgt_beroep_id");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public CrmMoney sgt_boetebedrag
		{
			get
			{
				return this.sgt_boetebedragField;
			}
			set
			{
				this.sgt_boetebedragField = value;
				base.RaisePropertyChanged("sgt_boetebedrag");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public CrmMoney sgt_boetebedrag_base
		{
			get
			{
				return this.sgt_boetebedrag_baseField;
			}
			set
			{
				this.sgt_boetebedrag_baseField = value;
				base.RaisePropertyChanged("sgt_boetebedrag_base");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public string sgt_name
		{
			get
			{
				return this.sgt_nameField;
			}
			set
			{
				this.sgt_nameField = value;
				base.RaisePropertyChanged("sgt_name");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public string sgt_samengesteld_volgnummer
		{
			get
			{
				return this.sgt_samengesteld_volgnummerField;
			}
			set
			{
				this.sgt_samengesteld_volgnummerField = value;
				base.RaisePropertyChanged("sgt_samengesteld_volgnummer");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public CrmNumber sgt_schorsingsperiode_mut
		{
			get
			{
				return this.sgt_schorsingsperiode_mutField;
			}
			set
			{
				this.sgt_schorsingsperiode_mutField = value;
				base.RaisePropertyChanged("sgt_schorsingsperiode_mut");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
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

		[XmlElement] //[XmlElement(Order=18)]
		public Key sgt_toe_administratieve_overtr_beroep_mutid
		{
			get
			{
				return this.sgt_toe_administratieve_overtr_beroep_mutidField;
			}
			set
			{
				this.sgt_toe_administratieve_overtr_beroep_mutidField = value;
				base.RaisePropertyChanged("sgt_toe_administratieve_overtr_beroep_mutid");
			}
		}

		[XmlElement] //[XmlElement(Order=19)]
		public string sgt_toelichting_commissie_mut
		{
			get
			{
				return this.sgt_toelichting_commissie_mutField;
			}
			set
			{
				this.sgt_toelichting_commissie_mutField = value;
				base.RaisePropertyChanged("sgt_toelichting_commissie_mut");
			}
		}

		[XmlElement] //[XmlElement(Order=20)]
		public Sgt_toe_administratieve_overtr_beroep_mutStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=21)]
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

		[XmlElement] //[XmlElement(Order=22)]
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

		[XmlElement] //[XmlElement(Order=23)]
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

		[XmlElement] //[XmlElement(Order=24)]
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

		public sgt_toe_administratieve_overtr_beroep_mut()
		{
		}
	}
}