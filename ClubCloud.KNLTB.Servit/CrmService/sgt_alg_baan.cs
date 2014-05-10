using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_alg_baan : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private Lookup sgt_accommodatieidField;
		private string sgt_alg_baan1Field;
		private Key sgt_alg_baanidField;
		private Lookup sgt_baanblokidField;
		private CrmDateTime sgt_datum_keuringField;
		private CrmBoolean sgt_dispensatie_constructieField;
		private CrmBoolean sgt_dispensatie_maatvoeringField;
		private CrmBoolean sgt_dispensatie_obstakelsField;
		private string sgt_redenField;
		private Picklist sgt_statusField;
		private Lookup sgt_uitgevoerd_dooridField;
		private Sgt_alg_baanStateInfo statecodeField;
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
		public Lookup sgt_accommodatieid
		{
			get
			{
				return this.sgt_accommodatieidField;
			}
			set
			{
				this.sgt_accommodatieidField = value;
			}
		}
		[XmlElement("sgt_alg_baan")]
		public string sgt_alg_baan1
		{
			get
			{
				return this.sgt_alg_baan1Field;
			}
			set
			{
				this.sgt_alg_baan1Field = value;
			}
		}
		public Key sgt_alg_baanid
		{
			get
			{
				return this.sgt_alg_baanidField;
			}
			set
			{
				this.sgt_alg_baanidField = value;
			}
		}
		public Lookup sgt_baanblokid
		{
			get
			{
				return this.sgt_baanblokidField;
			}
			set
			{
				this.sgt_baanblokidField = value;
			}
		}
		public CrmDateTime sgt_datum_keuring
		{
			get
			{
				return this.sgt_datum_keuringField;
			}
			set
			{
				this.sgt_datum_keuringField = value;
			}
		}
		public CrmBoolean sgt_dispensatie_constructie
		{
			get
			{
				return this.sgt_dispensatie_constructieField;
			}
			set
			{
				this.sgt_dispensatie_constructieField = value;
			}
		}
		public CrmBoolean sgt_dispensatie_maatvoering
		{
			get
			{
				return this.sgt_dispensatie_maatvoeringField;
			}
			set
			{
				this.sgt_dispensatie_maatvoeringField = value;
			}
		}
		public CrmBoolean sgt_dispensatie_obstakels
		{
			get
			{
				return this.sgt_dispensatie_obstakelsField;
			}
			set
			{
				this.sgt_dispensatie_obstakelsField = value;
			}
		}
		public string sgt_reden
		{
			get
			{
				return this.sgt_redenField;
			}
			set
			{
				this.sgt_redenField = value;
			}
		}
		public Picklist sgt_status
		{
			get
			{
				return this.sgt_statusField;
			}
			set
			{
				this.sgt_statusField = value;
			}
		}
		public Lookup sgt_uitgevoerd_doorid
		{
			get
			{
				return this.sgt_uitgevoerd_dooridField;
			}
			set
			{
				this.sgt_uitgevoerd_dooridField = value;
			}
		}
		public Sgt_alg_baanStateInfo statecode
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
