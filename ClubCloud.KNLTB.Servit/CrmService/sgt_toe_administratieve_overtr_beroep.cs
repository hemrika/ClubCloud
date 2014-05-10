using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_toe_administratieve_overtr_beroep : BusinessEntity
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
		private Lookup sgt_beroep_aantekenaar_idField;
		private Picklist sgt_beroep_aanvraag_statusField;
		private CrmMoney sgt_boetebedragField;
		private CrmMoney sgt_boetebedrag_baseField;
		private Lookup sgt_contact_deelnemer_idField;
		private CrmDateTime sgt_datum_ontvangenField;
		private string sgt_deelnemer_bondsnummerField;
		private Picklist sgt_deelnemer_wedstrijdleidingField;
		private string sgt_nameField;
		private CrmNumber sgt_schorsingsperiodeField;
		private Lookup sgt_straf_idField;
		private Key sgt_toe_administratieve_overtr_beroepidField;
		private string sgt_toelichting_beroepsaanvraagField;
		private string sgt_toelichting_commissieField;
		private Lookup sgt_vereniging_idField;
		private string sgt_volgnummer_beroep_aanvraagField;
		private Sgt_toe_administratieve_overtr_beroepStateInfo statecodeField;
		private Status statuscodeField;
		private CrmNumber timezoneruleversionnumberField;
		private Lookup transactioncurrencyidField;
		private CrmNumber utcconversiontimezonecodeField;
		public Lookup createdby
		{
			get
			{
				return this.createdbyField;
			}
			set
			{
				this.createdbyField = value;
			}
		}
		public CrmDateTime createdon
		{
			get
			{
				return this.createdonField;
			}
			set
			{
				this.createdonField = value;
			}
		}
		public CrmDecimal exchangerate
		{
			get
			{
				return this.exchangerateField;
			}
			set
			{
				this.exchangerateField = value;
			}
		}
		public CrmNumber importsequencenumber
		{
			get
			{
				return this.importsequencenumberField;
			}
			set
			{
				this.importsequencenumberField = value;
			}
		}
		public Lookup modifiedby
		{
			get
			{
				return this.modifiedbyField;
			}
			set
			{
				this.modifiedbyField = value;
			}
		}
		public CrmDateTime modifiedon
		{
			get
			{
				return this.modifiedonField;
			}
			set
			{
				this.modifiedonField = value;
			}
		}
		public CrmDateTime overriddencreatedon
		{
			get
			{
				return this.overriddencreatedonField;
			}
			set
			{
				this.overriddencreatedonField = value;
			}
		}
		public Owner ownerid
		{
			get
			{
				return this.owneridField;
			}
			set
			{
				this.owneridField = value;
			}
		}
		public Lookup owningbusinessunit
		{
			get
			{
				return this.owningbusinessunitField;
			}
			set
			{
				this.owningbusinessunitField = value;
			}
		}
		public Lookup sgt_administratieve_overtreding_id
		{
			get
			{
				return this.sgt_administratieve_overtreding_idField;
			}
			set
			{
				this.sgt_administratieve_overtreding_idField = value;
			}
		}
		public Lookup sgt_beroep_aantekenaar_id
		{
			get
			{
				return this.sgt_beroep_aantekenaar_idField;
			}
			set
			{
				this.sgt_beroep_aantekenaar_idField = value;
			}
		}
		public Picklist sgt_beroep_aanvraag_status
		{
			get
			{
				return this.sgt_beroep_aanvraag_statusField;
			}
			set
			{
				this.sgt_beroep_aanvraag_statusField = value;
			}
		}
		public CrmMoney sgt_boetebedrag
		{
			get
			{
				return this.sgt_boetebedragField;
			}
			set
			{
				this.sgt_boetebedragField = value;
			}
		}
		public CrmMoney sgt_boetebedrag_base
		{
			get
			{
				return this.sgt_boetebedrag_baseField;
			}
			set
			{
				this.sgt_boetebedrag_baseField = value;
			}
		}
		public Lookup sgt_contact_deelnemer_id
		{
			get
			{
				return this.sgt_contact_deelnemer_idField;
			}
			set
			{
				this.sgt_contact_deelnemer_idField = value;
			}
		}
		public CrmDateTime sgt_datum_ontvangen
		{
			get
			{
				return this.sgt_datum_ontvangenField;
			}
			set
			{
				this.sgt_datum_ontvangenField = value;
			}
		}
		public string sgt_deelnemer_bondsnummer
		{
			get
			{
				return this.sgt_deelnemer_bondsnummerField;
			}
			set
			{
				this.sgt_deelnemer_bondsnummerField = value;
			}
		}
		public Picklist sgt_deelnemer_wedstrijdleiding
		{
			get
			{
				return this.sgt_deelnemer_wedstrijdleidingField;
			}
			set
			{
				this.sgt_deelnemer_wedstrijdleidingField = value;
			}
		}
		public string sgt_name
		{
			get
			{
				return this.sgt_nameField;
			}
			set
			{
				this.sgt_nameField = value;
			}
		}
		public CrmNumber sgt_schorsingsperiode
		{
			get
			{
				return this.sgt_schorsingsperiodeField;
			}
			set
			{
				this.sgt_schorsingsperiodeField = value;
			}
		}
		public Lookup sgt_straf_id
		{
			get
			{
				return this.sgt_straf_idField;
			}
			set
			{
				this.sgt_straf_idField = value;
			}
		}
		public Key sgt_toe_administratieve_overtr_beroepid
		{
			get
			{
				return this.sgt_toe_administratieve_overtr_beroepidField;
			}
			set
			{
				this.sgt_toe_administratieve_overtr_beroepidField = value;
			}
		}
		public string sgt_toelichting_beroepsaanvraag
		{
			get
			{
				return this.sgt_toelichting_beroepsaanvraagField;
			}
			set
			{
				this.sgt_toelichting_beroepsaanvraagField = value;
			}
		}
		public string sgt_toelichting_commissie
		{
			get
			{
				return this.sgt_toelichting_commissieField;
			}
			set
			{
				this.sgt_toelichting_commissieField = value;
			}
		}
		public Lookup sgt_vereniging_id
		{
			get
			{
				return this.sgt_vereniging_idField;
			}
			set
			{
				this.sgt_vereniging_idField = value;
			}
		}
		public string sgt_volgnummer_beroep_aanvraag
		{
			get
			{
				return this.sgt_volgnummer_beroep_aanvraagField;
			}
			set
			{
				this.sgt_volgnummer_beroep_aanvraagField = value;
			}
		}
		public Sgt_toe_administratieve_overtr_beroepStateInfo statecode
		{
			get
			{
				return this.statecodeField;
			}
			set
			{
				this.statecodeField = value;
			}
		}
		public Status statuscode
		{
			get
			{
				return this.statuscodeField;
			}
			set
			{
				this.statuscodeField = value;
			}
		}
		public CrmNumber timezoneruleversionnumber
		{
			get
			{
				return this.timezoneruleversionnumberField;
			}
			set
			{
				this.timezoneruleversionnumberField = value;
			}
		}
		public Lookup transactioncurrencyid
		{
			get
			{
				return this.transactioncurrencyidField;
			}
			set
			{
				this.transactioncurrencyidField = value;
			}
		}
		public CrmNumber utcconversiontimezonecode
		{
			get
			{
				return this.utcconversiontimezonecodeField;
			}
			set
			{
				this.utcconversiontimezonecodeField = value;
			}
		}
	}
}
