using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_alg_ledenpas_vereniging : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private CrmBoolean sgt_aangemaakt_door_verrijkingField;
		private Key sgt_alg_ledenpas_verenigingidField;
		private string sgt_alg_naamField;
		private Lookup sgt_bericht_passen_naar_idField;
		private CrmNumber sgt_export_aantal_leden_foutField;
		private CrmNumber sgt_export_aantal_leden_goedField;
		private Lookup sgt_ledenpas_logboek_idField;
		private Lookup sgt_vereniging_idField;
		private Sgt_alg_ledenpas_verenigingStateInfo statecodeField;
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
		public CrmBoolean sgt_aangemaakt_door_verrijking
		{
			get
			{
				return this.sgt_aangemaakt_door_verrijkingField;
			}
			set
			{
				this.sgt_aangemaakt_door_verrijkingField = value;
			}
		}
		public Key sgt_alg_ledenpas_verenigingid
		{
			get
			{
				return this.sgt_alg_ledenpas_verenigingidField;
			}
			set
			{
				this.sgt_alg_ledenpas_verenigingidField = value;
			}
		}
		public string sgt_alg_naam
		{
			get
			{
				return this.sgt_alg_naamField;
			}
			set
			{
				this.sgt_alg_naamField = value;
			}
		}
		public Lookup sgt_bericht_passen_naar_id
		{
			get
			{
				return this.sgt_bericht_passen_naar_idField;
			}
			set
			{
				this.sgt_bericht_passen_naar_idField = value;
			}
		}
		public CrmNumber sgt_export_aantal_leden_fout
		{
			get
			{
				return this.sgt_export_aantal_leden_foutField;
			}
			set
			{
				this.sgt_export_aantal_leden_foutField = value;
			}
		}
		public CrmNumber sgt_export_aantal_leden_goed
		{
			get
			{
				return this.sgt_export_aantal_leden_goedField;
			}
			set
			{
				this.sgt_export_aantal_leden_goedField = value;
			}
		}
		public Lookup sgt_ledenpas_logboek_id
		{
			get
			{
				return this.sgt_ledenpas_logboek_idField;
			}
			set
			{
				this.sgt_ledenpas_logboek_idField = value;
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
		public Sgt_alg_ledenpas_verenigingStateInfo statecode
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
