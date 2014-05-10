using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_wt_inschrijfformulier_vcl_vtl : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private string sgt_bondsnummer1Field;
		private string sgt_bondsnummer2Field;
		private string sgt_bondsnummer3Field;
		private Lookup sgt_cursist1idField;
		private Lookup sgt_cursist2idField;
		private Lookup sgt_cursist3idField;
		private string sgt_emailadres1Field;
		private string sgt_emailadres2Field;
		private string sgt_emailadres3Field;
		private Lookup sgt_opleidingidField;
		private Picklist sgt_statusformulierField;
		private Lookup sgt_verenigingidField;
		private Lookup sgt_voorkeur11idField;
		private Lookup sgt_voorkeur12idField;
		private Lookup sgt_voorkeur13idField;
		private Lookup sgt_voorkeur21idField;
		private Lookup sgt_voorkeur22idField;
		private Lookup sgt_voorkeur23idField;
		private Lookup sgt_voorkeur31idField;
		private Lookup sgt_voorkeur32idField;
		private Lookup sgt_voorkeur33idField;
		private string sgt_wt_inschrijfformulier_vcl_vtl1Field;
		private Key sgt_wt_inschrijfformulier_vcl_vtlidField;
		private Sgt_wt_inschrijfformulier_vcl_vtlStateInfo statecodeField;
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
		public string sgt_bondsnummer1
		{
			get
			{
				return this.sgt_bondsnummer1Field;
			}
			set
			{
				this.sgt_bondsnummer1Field = value;
			}
		}
		public string sgt_bondsnummer2
		{
			get
			{
				return this.sgt_bondsnummer2Field;
			}
			set
			{
				this.sgt_bondsnummer2Field = value;
			}
		}
		public string sgt_bondsnummer3
		{
			get
			{
				return this.sgt_bondsnummer3Field;
			}
			set
			{
				this.sgt_bondsnummer3Field = value;
			}
		}
		public Lookup sgt_cursist1id
		{
			get
			{
				return this.sgt_cursist1idField;
			}
			set
			{
				this.sgt_cursist1idField = value;
			}
		}
		public Lookup sgt_cursist2id
		{
			get
			{
				return this.sgt_cursist2idField;
			}
			set
			{
				this.sgt_cursist2idField = value;
			}
		}
		public Lookup sgt_cursist3id
		{
			get
			{
				return this.sgt_cursist3idField;
			}
			set
			{
				this.sgt_cursist3idField = value;
			}
		}
		public string sgt_emailadres1
		{
			get
			{
				return this.sgt_emailadres1Field;
			}
			set
			{
				this.sgt_emailadres1Field = value;
			}
		}
		public string sgt_emailadres2
		{
			get
			{
				return this.sgt_emailadres2Field;
			}
			set
			{
				this.sgt_emailadres2Field = value;
			}
		}
		public string sgt_emailadres3
		{
			get
			{
				return this.sgt_emailadres3Field;
			}
			set
			{
				this.sgt_emailadres3Field = value;
			}
		}
		public Lookup sgt_opleidingid
		{
			get
			{
				return this.sgt_opleidingidField;
			}
			set
			{
				this.sgt_opleidingidField = value;
			}
		}
		public Picklist sgt_statusformulier
		{
			get
			{
				return this.sgt_statusformulierField;
			}
			set
			{
				this.sgt_statusformulierField = value;
			}
		}
		public Lookup sgt_verenigingid
		{
			get
			{
				return this.sgt_verenigingidField;
			}
			set
			{
				this.sgt_verenigingidField = value;
			}
		}
		public Lookup sgt_voorkeur11id
		{
			get
			{
				return this.sgt_voorkeur11idField;
			}
			set
			{
				this.sgt_voorkeur11idField = value;
			}
		}
		public Lookup sgt_voorkeur12id
		{
			get
			{
				return this.sgt_voorkeur12idField;
			}
			set
			{
				this.sgt_voorkeur12idField = value;
			}
		}
		public Lookup sgt_voorkeur13id
		{
			get
			{
				return this.sgt_voorkeur13idField;
			}
			set
			{
				this.sgt_voorkeur13idField = value;
			}
		}
		public Lookup sgt_voorkeur21id
		{
			get
			{
				return this.sgt_voorkeur21idField;
			}
			set
			{
				this.sgt_voorkeur21idField = value;
			}
		}
		public Lookup sgt_voorkeur22id
		{
			get
			{
				return this.sgt_voorkeur22idField;
			}
			set
			{
				this.sgt_voorkeur22idField = value;
			}
		}
		public Lookup sgt_voorkeur23id
		{
			get
			{
				return this.sgt_voorkeur23idField;
			}
			set
			{
				this.sgt_voorkeur23idField = value;
			}
		}
		public Lookup sgt_voorkeur31id
		{
			get
			{
				return this.sgt_voorkeur31idField;
			}
			set
			{
				this.sgt_voorkeur31idField = value;
			}
		}
		public Lookup sgt_voorkeur32id
		{
			get
			{
				return this.sgt_voorkeur32idField;
			}
			set
			{
				this.sgt_voorkeur32idField = value;
			}
		}
		public Lookup sgt_voorkeur33id
		{
			get
			{
				return this.sgt_voorkeur33idField;
			}
			set
			{
				this.sgt_voorkeur33idField = value;
			}
		}
		[XmlElement("sgt_wt_inschrijfformulier_vcl_vtl")]
		public string sgt_wt_inschrijfformulier_vcl_vtl1
		{
			get
			{
				return this.sgt_wt_inschrijfformulier_vcl_vtl1Field;
			}
			set
			{
				this.sgt_wt_inschrijfformulier_vcl_vtl1Field = value;
			}
		}
		public Key sgt_wt_inschrijfformulier_vcl_vtlid
		{
			get
			{
				return this.sgt_wt_inschrijfformulier_vcl_vtlidField;
			}
			set
			{
				this.sgt_wt_inschrijfformulier_vcl_vtlidField = value;
			}
		}
		public Sgt_wt_inschrijfformulier_vcl_vtlStateInfo statecode
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
