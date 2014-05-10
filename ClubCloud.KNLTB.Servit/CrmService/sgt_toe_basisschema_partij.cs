using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_toe_basisschema_partij : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private string sgt_baanField;
		private Lookup sgt_basisschema_idField;
		private string sgt_basisschema_partij_kenmerkField;
		private Lookup sgt_basisschema_ronde_idField;
		private string sgt_plaatsing_bij_verlies_schemaspelers_thuisField;
		private string sgt_plaatsing_bij_verlies_schemaspelers_uitField;
		private string sgt_plaatsing_bij_verlies_speler_thuis_pwField;
		private string sgt_plaatsing_bij_verlies_speler_uit_pwField;
		private string sgt_plaatsing_bij_winst_schemaspeler_thuis_pwField;
		private string sgt_plaatsing_bij_winst_schemaspeler_uit_pwField;
		private string sgt_plaatsing_bij_winst_schemaspelers_thuisField;
		private string sgt_plaatsing_bij_winst_schemaspelers_uitField;
		private string sgt_schemaspeler_thuis_partnerwisselField;
		private string sgt_schemaspeler_uit_partnerwisselField;
		private string sgt_schemaspelers_thuisField;
		private string sgt_schemaspelers_uitField;
		private CrmNumber sgt_speeldagField;
		private string sgt_tijdField;
		private Key sgt_toe_basisschema_partijidField;
		private string sgt_volgnummer_partijField;
		private Sgt_toe_basisschema_partijStateInfo statecodeField;
		private Status statuscodeField;
		private CrmNumber timezoneruleversionnumberField;
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
		public string sgt_baan
		{
			get
			{
				return this.sgt_baanField;
			}
			set
			{
				this.sgt_baanField = value;
			}
		}
		public Lookup sgt_basisschema_id
		{
			get
			{
				return this.sgt_basisschema_idField;
			}
			set
			{
				this.sgt_basisschema_idField = value;
			}
		}
		public string sgt_basisschema_partij_kenmerk
		{
			get
			{
				return this.sgt_basisschema_partij_kenmerkField;
			}
			set
			{
				this.sgt_basisschema_partij_kenmerkField = value;
			}
		}
		public Lookup sgt_basisschema_ronde_id
		{
			get
			{
				return this.sgt_basisschema_ronde_idField;
			}
			set
			{
				this.sgt_basisschema_ronde_idField = value;
			}
		}
		public string sgt_plaatsing_bij_verlies_schemaspelers_thuis
		{
			get
			{
				return this.sgt_plaatsing_bij_verlies_schemaspelers_thuisField;
			}
			set
			{
				this.sgt_plaatsing_bij_verlies_schemaspelers_thuisField = value;
			}
		}
		public string sgt_plaatsing_bij_verlies_schemaspelers_uit
		{
			get
			{
				return this.sgt_plaatsing_bij_verlies_schemaspelers_uitField;
			}
			set
			{
				this.sgt_plaatsing_bij_verlies_schemaspelers_uitField = value;
			}
		}
		public string sgt_plaatsing_bij_verlies_speler_thuis_pw
		{
			get
			{
				return this.sgt_plaatsing_bij_verlies_speler_thuis_pwField;
			}
			set
			{
				this.sgt_plaatsing_bij_verlies_speler_thuis_pwField = value;
			}
		}
		public string sgt_plaatsing_bij_verlies_speler_uit_pw
		{
			get
			{
				return this.sgt_plaatsing_bij_verlies_speler_uit_pwField;
			}
			set
			{
				this.sgt_plaatsing_bij_verlies_speler_uit_pwField = value;
			}
		}
		public string sgt_plaatsing_bij_winst_schemaspeler_thuis_pw
		{
			get
			{
				return this.sgt_plaatsing_bij_winst_schemaspeler_thuis_pwField;
			}
			set
			{
				this.sgt_plaatsing_bij_winst_schemaspeler_thuis_pwField = value;
			}
		}
		public string sgt_plaatsing_bij_winst_schemaspeler_uit_pw
		{
			get
			{
				return this.sgt_plaatsing_bij_winst_schemaspeler_uit_pwField;
			}
			set
			{
				this.sgt_plaatsing_bij_winst_schemaspeler_uit_pwField = value;
			}
		}
		public string sgt_plaatsing_bij_winst_schemaspelers_thuis
		{
			get
			{
				return this.sgt_plaatsing_bij_winst_schemaspelers_thuisField;
			}
			set
			{
				this.sgt_plaatsing_bij_winst_schemaspelers_thuisField = value;
			}
		}
		public string sgt_plaatsing_bij_winst_schemaspelers_uit
		{
			get
			{
				return this.sgt_plaatsing_bij_winst_schemaspelers_uitField;
			}
			set
			{
				this.sgt_plaatsing_bij_winst_schemaspelers_uitField = value;
			}
		}
		public string sgt_schemaspeler_thuis_partnerwissel
		{
			get
			{
				return this.sgt_schemaspeler_thuis_partnerwisselField;
			}
			set
			{
				this.sgt_schemaspeler_thuis_partnerwisselField = value;
			}
		}
		public string sgt_schemaspeler_uit_partnerwissel
		{
			get
			{
				return this.sgt_schemaspeler_uit_partnerwisselField;
			}
			set
			{
				this.sgt_schemaspeler_uit_partnerwisselField = value;
			}
		}
		public string sgt_schemaspelers_thuis
		{
			get
			{
				return this.sgt_schemaspelers_thuisField;
			}
			set
			{
				this.sgt_schemaspelers_thuisField = value;
			}
		}
		public string sgt_schemaspelers_uit
		{
			get
			{
				return this.sgt_schemaspelers_uitField;
			}
			set
			{
				this.sgt_schemaspelers_uitField = value;
			}
		}
		public CrmNumber sgt_speeldag
		{
			get
			{
				return this.sgt_speeldagField;
			}
			set
			{
				this.sgt_speeldagField = value;
			}
		}
		public string sgt_tijd
		{
			get
			{
				return this.sgt_tijdField;
			}
			set
			{
				this.sgt_tijdField = value;
			}
		}
		public Key sgt_toe_basisschema_partijid
		{
			get
			{
				return this.sgt_toe_basisschema_partijidField;
			}
			set
			{
				this.sgt_toe_basisschema_partijidField = value;
			}
		}
		public string sgt_volgnummer_partij
		{
			get
			{
				return this.sgt_volgnummer_partijField;
			}
			set
			{
				this.sgt_volgnummer_partijField = value;
			}
		}
		public Sgt_toe_basisschema_partijStateInfo statecode
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
