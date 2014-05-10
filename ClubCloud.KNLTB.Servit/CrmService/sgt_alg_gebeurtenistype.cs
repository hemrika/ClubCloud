using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_alg_gebeurtenistype : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private Lookup organizationidField;
		private CrmDateTime overriddencreatedonField;
		private CrmBoolean sgt_alg_campagnezichtbaarField;
		private string sgt_alg_gebeurtenistype1Field;
		private Key sgt_alg_gebeurtenistypeidField;
		private CrmBoolean sgt_alg_in_gesprek_metField;
		private CrmBoolean sgt_deelnemerslijst_tonenField;
		private CrmBoolean sgt_gebeurtenisnaam_automatisch_bepalenField;
		private CrmBoolean sgt_gesprokenField;
		private CrmBoolean sgt_inschrijfsectieField;
		private Sgt_alg_gebeurtenistypeStateInfo statecodeField;
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
		public CrmBoolean sgt_alg_campagnezichtbaar
		{
			get
			{
				return this.sgt_alg_campagnezichtbaarField;
			}
			set
			{
				this.sgt_alg_campagnezichtbaarField = value;
			}
		}
		[XmlElement("sgt_alg_gebeurtenistype")]
		public string sgt_alg_gebeurtenistype1
		{
			get
			{
				return this.sgt_alg_gebeurtenistype1Field;
			}
			set
			{
				this.sgt_alg_gebeurtenistype1Field = value;
			}
		}
		public Key sgt_alg_gebeurtenistypeid
		{
			get
			{
				return this.sgt_alg_gebeurtenistypeidField;
			}
			set
			{
				this.sgt_alg_gebeurtenistypeidField = value;
			}
		}
		public CrmBoolean sgt_alg_in_gesprek_met
		{
			get
			{
				return this.sgt_alg_in_gesprek_metField;
			}
			set
			{
				this.sgt_alg_in_gesprek_metField = value;
			}
		}
		public CrmBoolean sgt_deelnemerslijst_tonen
		{
			get
			{
				return this.sgt_deelnemerslijst_tonenField;
			}
			set
			{
				this.sgt_deelnemerslijst_tonenField = value;
			}
		}
		public CrmBoolean sgt_gebeurtenisnaam_automatisch_bepalen
		{
			get
			{
				return this.sgt_gebeurtenisnaam_automatisch_bepalenField;
			}
			set
			{
				this.sgt_gebeurtenisnaam_automatisch_bepalenField = value;
			}
		}
		public CrmBoolean sgt_gesproken
		{
			get
			{
				return this.sgt_gesprokenField;
			}
			set
			{
				this.sgt_gesprokenField = value;
			}
		}
		public CrmBoolean sgt_inschrijfsectie
		{
			get
			{
				return this.sgt_inschrijfsectieField;
			}
			set
			{
				this.sgt_inschrijfsectieField = value;
			}
		}
		public Sgt_alg_gebeurtenistypeStateInfo statecode
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
