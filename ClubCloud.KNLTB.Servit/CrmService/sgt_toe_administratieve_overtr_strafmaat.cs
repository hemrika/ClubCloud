using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
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
		public Lookup organizationid
		{
			get
			{
				return this.organizationidField;
			}
			set
			{
				this.organizationidField = value;
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
		public Lookup sgt_constaterings_moment_id
		{
			get
			{
				return this.sgt_constaterings_moment_idField;
			}
			set
			{
				this.sgt_constaterings_moment_idField = value;
			}
		}
		public CrmNumber sgt_overtreding_herhaling
		{
			get
			{
				return this.sgt_overtreding_herhalingField;
			}
			set
			{
				this.sgt_overtreding_herhalingField = value;
			}
		}
		public CrmNumber sgt_overtreding_verstreken_periode
		{
			get
			{
				return this.sgt_overtreding_verstreken_periodeField;
			}
			set
			{
				this.sgt_overtreding_verstreken_periodeField = value;
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
		public Lookup sgt_strafbepaling_id
		{
			get
			{
				return this.sgt_strafbepaling_idField;
			}
			set
			{
				this.sgt_strafbepaling_idField = value;
			}
		}
		public CrmMoney sgt_strafmaat_boetebedrag
		{
			get
			{
				return this.sgt_strafmaat_boetebedragField;
			}
			set
			{
				this.sgt_strafmaat_boetebedragField = value;
			}
		}
		public CrmMoney sgt_strafmaat_boetebedrag_base
		{
			get
			{
				return this.sgt_strafmaat_boetebedrag_baseField;
			}
			set
			{
				this.sgt_strafmaat_boetebedrag_baseField = value;
			}
		}
		public Picklist sgt_strafmaat_junior_senior
		{
			get
			{
				return this.sgt_strafmaat_junior_seniorField;
			}
			set
			{
				this.sgt_strafmaat_junior_seniorField = value;
			}
		}
		public CrmNumber sgt_strafmaat_schorsingsperiode
		{
			get
			{
				return this.sgt_strafmaat_schorsingsperiodeField;
			}
			set
			{
				this.sgt_strafmaat_schorsingsperiodeField = value;
			}
		}
		public string sgt_strafmaat_toelichting
		{
			get
			{
				return this.sgt_strafmaat_toelichtingField;
			}
			set
			{
				this.sgt_strafmaat_toelichtingField = value;
			}
		}
		public string sgt_strafmaatregel_kenmerk
		{
			get
			{
				return this.sgt_strafmaatregel_kenmerkField;
			}
			set
			{
				this.sgt_strafmaatregel_kenmerkField = value;
			}
		}
		public Key sgt_toe_administratieve_overtr_strafmaatid
		{
			get
			{
				return this.sgt_toe_administratieve_overtr_strafmaatidField;
			}
			set
			{
				this.sgt_toe_administratieve_overtr_strafmaatidField = value;
			}
		}
		public Picklist sgt_type_evenement
		{
			get
			{
				return this.sgt_type_evenementField;
			}
			set
			{
				this.sgt_type_evenementField = value;
			}
		}
		public Sgt_toe_administratieve_overtr_strafmaatStateInfo statecode
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
