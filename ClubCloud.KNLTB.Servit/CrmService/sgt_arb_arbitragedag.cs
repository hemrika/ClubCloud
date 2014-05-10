using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_arb_arbitragedag : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private Key sgt_arb_arbitragedagidField;
		private string sgt_arb_nameField;
		private CrmNumber sgt_begeleiderField;
		private CrmNumber sgt_bronze_badge_stoelscheidsrechterField;
		private Picklist sgt_district_nationaalField;
		private CrmNumber sgt_hoofdscheidsrechterField;
		private CrmNumber sgt_kandidaat_nationaal_1_2Field;
		private CrmNumber sgt_lijnrechterField;
		private Lookup sgt_rapporthsidField;
		private CrmNumber sgt_stoelscheidsrechterField;
		private CrmNumber sgt_toezichthouderField;
		private CrmNumber sgt_totaalField;
		private CrmNumber sgt_white_badge_hoofdscheidsrechterField;
		private CrmNumber sgt_white_badge_stoelscheidsrechterField;
		private Sgt_arb_arbitragedagStateInfo statecodeField;
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
		public Key sgt_arb_arbitragedagid
		{
			get
			{
				return this.sgt_arb_arbitragedagidField;
			}
			set
			{
				this.sgt_arb_arbitragedagidField = value;
			}
		}
		public string sgt_arb_name
		{
			get
			{
				return this.sgt_arb_nameField;
			}
			set
			{
				this.sgt_arb_nameField = value;
			}
		}
		public CrmNumber sgt_begeleider
		{
			get
			{
				return this.sgt_begeleiderField;
			}
			set
			{
				this.sgt_begeleiderField = value;
			}
		}
		public CrmNumber sgt_bronze_badge_stoelscheidsrechter
		{
			get
			{
				return this.sgt_bronze_badge_stoelscheidsrechterField;
			}
			set
			{
				this.sgt_bronze_badge_stoelscheidsrechterField = value;
			}
		}
		public Picklist sgt_district_nationaal
		{
			get
			{
				return this.sgt_district_nationaalField;
			}
			set
			{
				this.sgt_district_nationaalField = value;
			}
		}
		public CrmNumber sgt_hoofdscheidsrechter
		{
			get
			{
				return this.sgt_hoofdscheidsrechterField;
			}
			set
			{
				this.sgt_hoofdscheidsrechterField = value;
			}
		}
		public CrmNumber sgt_kandidaat_nationaal_1_2
		{
			get
			{
				return this.sgt_kandidaat_nationaal_1_2Field;
			}
			set
			{
				this.sgt_kandidaat_nationaal_1_2Field = value;
			}
		}
		public CrmNumber sgt_lijnrechter
		{
			get
			{
				return this.sgt_lijnrechterField;
			}
			set
			{
				this.sgt_lijnrechterField = value;
			}
		}
		public Lookup sgt_rapporthsid
		{
			get
			{
				return this.sgt_rapporthsidField;
			}
			set
			{
				this.sgt_rapporthsidField = value;
			}
		}
		public CrmNumber sgt_stoelscheidsrechter
		{
			get
			{
				return this.sgt_stoelscheidsrechterField;
			}
			set
			{
				this.sgt_stoelscheidsrechterField = value;
			}
		}
		public CrmNumber sgt_toezichthouder
		{
			get
			{
				return this.sgt_toezichthouderField;
			}
			set
			{
				this.sgt_toezichthouderField = value;
			}
		}
		public CrmNumber sgt_totaal
		{
			get
			{
				return this.sgt_totaalField;
			}
			set
			{
				this.sgt_totaalField = value;
			}
		}
		public CrmNumber sgt_white_badge_hoofdscheidsrechter
		{
			get
			{
				return this.sgt_white_badge_hoofdscheidsrechterField;
			}
			set
			{
				this.sgt_white_badge_hoofdscheidsrechterField = value;
			}
		}
		public CrmNumber sgt_white_badge_stoelscheidsrechter
		{
			get
			{
				return this.sgt_white_badge_stoelscheidsrechterField;
			}
			set
			{
				this.sgt_white_badge_stoelscheidsrechterField = value;
			}
		}
		public Sgt_arb_arbitragedagStateInfo statecode
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
