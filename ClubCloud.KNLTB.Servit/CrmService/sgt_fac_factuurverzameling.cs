using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_fac_factuurverzameling : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private Lookup sgt_administratieidField;
		private string sgt_bovenschrift_factuurField;
		private string sgt_fac_factuurverzameling1Field;
		private Key sgt_fac_factuurverzamelingidField;
		private CrmDateTime sgt_fac_totenmetField;
		private CrmDateTime sgt_fac_vanafField;
		private Lookup sgt_factuurtypeidField;
		private Picklist sgt_periodeField;
		private Picklist sgt_periode_jaarField;
		private Picklist sgt_periode_kwartaalField;
		private Picklist sgt_periode_maandField;
		private Lookup sgt_prijslijstidField;
		private Picklist sgt_status_factuurverzamelingField;
		private CrmDateTime sgt_uitvoerdatumField;
		private Lookup sgt_valutaidField;
		private Sgt_fac_factuurverzamelingStateInfo statecodeField;
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
		public Lookup sgt_administratieid
		{
			get
			{
				return this.sgt_administratieidField;
			}
			set
			{
				this.sgt_administratieidField = value;
			}
		}
		public string sgt_bovenschrift_factuur
		{
			get
			{
				return this.sgt_bovenschrift_factuurField;
			}
			set
			{
				this.sgt_bovenschrift_factuurField = value;
			}
		}
		[XmlElement("sgt_fac_factuurverzameling")]
		public string sgt_fac_factuurverzameling1
		{
			get
			{
				return this.sgt_fac_factuurverzameling1Field;
			}
			set
			{
				this.sgt_fac_factuurverzameling1Field = value;
			}
		}
		public Key sgt_fac_factuurverzamelingid
		{
			get
			{
				return this.sgt_fac_factuurverzamelingidField;
			}
			set
			{
				this.sgt_fac_factuurverzamelingidField = value;
			}
		}
		public CrmDateTime sgt_fac_totenmet
		{
			get
			{
				return this.sgt_fac_totenmetField;
			}
			set
			{
				this.sgt_fac_totenmetField = value;
			}
		}
		public CrmDateTime sgt_fac_vanaf
		{
			get
			{
				return this.sgt_fac_vanafField;
			}
			set
			{
				this.sgt_fac_vanafField = value;
			}
		}
		public Lookup sgt_factuurtypeid
		{
			get
			{
				return this.sgt_factuurtypeidField;
			}
			set
			{
				this.sgt_factuurtypeidField = value;
			}
		}
		public Picklist sgt_periode
		{
			get
			{
				return this.sgt_periodeField;
			}
			set
			{
				this.sgt_periodeField = value;
			}
		}
		public Picklist sgt_periode_jaar
		{
			get
			{
				return this.sgt_periode_jaarField;
			}
			set
			{
				this.sgt_periode_jaarField = value;
			}
		}
		public Picklist sgt_periode_kwartaal
		{
			get
			{
				return this.sgt_periode_kwartaalField;
			}
			set
			{
				this.sgt_periode_kwartaalField = value;
			}
		}
		public Picklist sgt_periode_maand
		{
			get
			{
				return this.sgt_periode_maandField;
			}
			set
			{
				this.sgt_periode_maandField = value;
			}
		}
		public Lookup sgt_prijslijstid
		{
			get
			{
				return this.sgt_prijslijstidField;
			}
			set
			{
				this.sgt_prijslijstidField = value;
			}
		}
		public Picklist sgt_status_factuurverzameling
		{
			get
			{
				return this.sgt_status_factuurverzamelingField;
			}
			set
			{
				this.sgt_status_factuurverzamelingField = value;
			}
		}
		public CrmDateTime sgt_uitvoerdatum
		{
			get
			{
				return this.sgt_uitvoerdatumField;
			}
			set
			{
				this.sgt_uitvoerdatumField = value;
			}
		}
		public Lookup sgt_valutaid
		{
			get
			{
				return this.sgt_valutaidField;
			}
			set
			{
				this.sgt_valutaidField = value;
			}
		}
		public Sgt_fac_factuurverzamelingStateInfo statecode
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
