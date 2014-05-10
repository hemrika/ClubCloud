using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_top_groep : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private Lookup sgt_bondsorganisatieidField;
		private CrmDateTime sgt_datum_tmField;
		private CrmDateTime sgt_datum_vanafField;
		private Lookup sgt_groepsoortidField;
		private string sgt_omschrijvingField;
		private Lookup sgt_productidField;
		private string sgt_top_groep1Field;
		private Key sgt_top_groepidField;
		private Sgt_top_groepStateInfo statecodeField;
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
		public Lookup sgt_bondsorganisatieid
		{
			get
			{
				return this.sgt_bondsorganisatieidField;
			}
			set
			{
				this.sgt_bondsorganisatieidField = value;
			}
		}
		public CrmDateTime sgt_datum_tm
		{
			get
			{
				return this.sgt_datum_tmField;
			}
			set
			{
				this.sgt_datum_tmField = value;
			}
		}
		public CrmDateTime sgt_datum_vanaf
		{
			get
			{
				return this.sgt_datum_vanafField;
			}
			set
			{
				this.sgt_datum_vanafField = value;
			}
		}
		public Lookup sgt_groepsoortid
		{
			get
			{
				return this.sgt_groepsoortidField;
			}
			set
			{
				this.sgt_groepsoortidField = value;
			}
		}
		public string sgt_omschrijving
		{
			get
			{
				return this.sgt_omschrijvingField;
			}
			set
			{
				this.sgt_omschrijvingField = value;
			}
		}
		public Lookup sgt_productid
		{
			get
			{
				return this.sgt_productidField;
			}
			set
			{
				this.sgt_productidField = value;
			}
		}
		[XmlElement("sgt_top_groep")]
		public string sgt_top_groep1
		{
			get
			{
				return this.sgt_top_groep1Field;
			}
			set
			{
				this.sgt_top_groep1Field = value;
			}
		}
		public Key sgt_top_groepid
		{
			get
			{
				return this.sgt_top_groepidField;
			}
			set
			{
				this.sgt_top_groepidField = value;
			}
		}
		public Sgt_top_groepStateInfo statecode
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
