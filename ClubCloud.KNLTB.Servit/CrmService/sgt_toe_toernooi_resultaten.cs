using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_toe_toernooi_resultaten : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private string sgt_bondsnummer_speler1Field;
		private string sgt_bondsnummer_speler2Field;
		private Lookup sgt_kwalificatiecode_idField;
		private string sgt_speler1Field;
		private string sgt_speler2Field;
		private Picklist sgt_spelsoortField;
		private string sgt_toe_toernooi_resultaatField;
		private Key sgt_toe_toernooi_resultatenidField;
		private Lookup sgt_toernooiidField;
		private Lookup sgt_toernooionderdeelField;
		private Lookup sgt_toernooispelerField;
		private CrmNumber sgt_tot_en_met_plaatsField;
		private CrmNumber sgt_vanaf_plaatsField;
		private Sgt_toe_toernooi_resultatenStateInfo statecodeField;
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
		public string sgt_bondsnummer_speler1
		{
			get
			{
				return this.sgt_bondsnummer_speler1Field;
			}
			set
			{
				this.sgt_bondsnummer_speler1Field = value;
			}
		}
		public string sgt_bondsnummer_speler2
		{
			get
			{
				return this.sgt_bondsnummer_speler2Field;
			}
			set
			{
				this.sgt_bondsnummer_speler2Field = value;
			}
		}
		public Lookup sgt_kwalificatiecode_id
		{
			get
			{
				return this.sgt_kwalificatiecode_idField;
			}
			set
			{
				this.sgt_kwalificatiecode_idField = value;
			}
		}
		public string sgt_speler1
		{
			get
			{
				return this.sgt_speler1Field;
			}
			set
			{
				this.sgt_speler1Field = value;
			}
		}
		public string sgt_speler2
		{
			get
			{
				return this.sgt_speler2Field;
			}
			set
			{
				this.sgt_speler2Field = value;
			}
		}
		public Picklist sgt_spelsoort
		{
			get
			{
				return this.sgt_spelsoortField;
			}
			set
			{
				this.sgt_spelsoortField = value;
			}
		}
		public string sgt_toe_toernooi_resultaat
		{
			get
			{
				return this.sgt_toe_toernooi_resultaatField;
			}
			set
			{
				this.sgt_toe_toernooi_resultaatField = value;
			}
		}
		public Key sgt_toe_toernooi_resultatenid
		{
			get
			{
				return this.sgt_toe_toernooi_resultatenidField;
			}
			set
			{
				this.sgt_toe_toernooi_resultatenidField = value;
			}
		}
		public Lookup sgt_toernooiid
		{
			get
			{
				return this.sgt_toernooiidField;
			}
			set
			{
				this.sgt_toernooiidField = value;
			}
		}
		public Lookup sgt_toernooionderdeel
		{
			get
			{
				return this.sgt_toernooionderdeelField;
			}
			set
			{
				this.sgt_toernooionderdeelField = value;
			}
		}
		public Lookup sgt_toernooispeler
		{
			get
			{
				return this.sgt_toernooispelerField;
			}
			set
			{
				this.sgt_toernooispelerField = value;
			}
		}
		public CrmNumber sgt_tot_en_met_plaats
		{
			get
			{
				return this.sgt_tot_en_met_plaatsField;
			}
			set
			{
				this.sgt_tot_en_met_plaatsField = value;
			}
		}
		public CrmNumber sgt_vanaf_plaats
		{
			get
			{
				return this.sgt_vanaf_plaatsField;
			}
			set
			{
				this.sgt_vanaf_plaatsField = value;
			}
		}
		public Sgt_toe_toernooi_resultatenStateInfo statecode
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
