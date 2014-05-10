using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_alg_functionaris : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private Key sgt_alg_functionarisidField;
		private string sgt_alg_nameField;
		private Lookup sgt_arbitragefunctionarisidField;
		private CrmBoolean sgt_autorisatie_gezetField;
		private Lookup sgt_basisorganisatieidField;
		private Lookup sgt_bestuursorgaanidField;
		private Lookup sgt_competentieidField;
		private Lookup sgt_districtidField;
		private Lookup sgt_functieidField;
		private Lookup sgt_functionarisidField;
		private CrmBoolean sgt_mailingField;
		private CrmBoolean sgt_tennis_magazineField;
		private CrmDateTime sgt_termijn_begintField;
		private CrmDateTime sgt_termijn_loopt_afField;
		private Sgt_alg_functionarisStateInfo statecodeField;
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
		public Key sgt_alg_functionarisid
		{
			get
			{
				return this.sgt_alg_functionarisidField;
			}
			set
			{
				this.sgt_alg_functionarisidField = value;
			}
		}
		public string sgt_alg_name
		{
			get
			{
				return this.sgt_alg_nameField;
			}
			set
			{
				this.sgt_alg_nameField = value;
			}
		}
		public Lookup sgt_arbitragefunctionarisid
		{
			get
			{
				return this.sgt_arbitragefunctionarisidField;
			}
			set
			{
				this.sgt_arbitragefunctionarisidField = value;
			}
		}
		public CrmBoolean sgt_autorisatie_gezet
		{
			get
			{
				return this.sgt_autorisatie_gezetField;
			}
			set
			{
				this.sgt_autorisatie_gezetField = value;
			}
		}
		public Lookup sgt_basisorganisatieid
		{
			get
			{
				return this.sgt_basisorganisatieidField;
			}
			set
			{
				this.sgt_basisorganisatieidField = value;
			}
		}
		public Lookup sgt_bestuursorgaanid
		{
			get
			{
				return this.sgt_bestuursorgaanidField;
			}
			set
			{
				this.sgt_bestuursorgaanidField = value;
			}
		}
		public Lookup sgt_competentieid
		{
			get
			{
				return this.sgt_competentieidField;
			}
			set
			{
				this.sgt_competentieidField = value;
			}
		}
		public Lookup sgt_districtid
		{
			get
			{
				return this.sgt_districtidField;
			}
			set
			{
				this.sgt_districtidField = value;
			}
		}
		public Lookup sgt_functieid
		{
			get
			{
				return this.sgt_functieidField;
			}
			set
			{
				this.sgt_functieidField = value;
			}
		}
		public Lookup sgt_functionarisid
		{
			get
			{
				return this.sgt_functionarisidField;
			}
			set
			{
				this.sgt_functionarisidField = value;
			}
		}
		public CrmBoolean sgt_mailing
		{
			get
			{
				return this.sgt_mailingField;
			}
			set
			{
				this.sgt_mailingField = value;
			}
		}
		public CrmBoolean sgt_tennis_magazine
		{
			get
			{
				return this.sgt_tennis_magazineField;
			}
			set
			{
				this.sgt_tennis_magazineField = value;
			}
		}
		public CrmDateTime sgt_termijn_begint
		{
			get
			{
				return this.sgt_termijn_begintField;
			}
			set
			{
				this.sgt_termijn_begintField = value;
			}
		}
		public CrmDateTime sgt_termijn_loopt_af
		{
			get
			{
				return this.sgt_termijn_loopt_afField;
			}
			set
			{
				this.sgt_termijn_loopt_afField = value;
			}
		}
		public Sgt_alg_functionarisStateInfo statecode
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
