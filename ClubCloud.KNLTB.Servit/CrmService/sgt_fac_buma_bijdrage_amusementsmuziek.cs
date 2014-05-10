using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_fac_buma_bijdrage_amusementsmuziek : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmDecimal exchangerateField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private Lookup organizationidField;
		private CrmDateTime overriddencreatedonField;
		private CrmNumber sgt_aantal_dagen_tmField;
		private CrmNumber sgt_aantal_dagen_vanafField;
		private string sgt_alg_nameField;
		private Key sgt_fac_buma_bijdrage_amusementsmuziekidField;
		private CrmMoney sgt_prijs_extra_50m2Field;
		private CrmMoney sgt_prijs_extra_50m2_baseField;
		private CrmMoney sgt_prijs_tm_50m2Field;
		private CrmMoney sgt_prijs_tm_50m2_baseField;
		private Sgt_fac_buma_bijdrage_amusementsmuziekStateInfo statecodeField;
		private Status statuscodeField;
		private CrmNumber timezoneruleversionnumberField;
		private Lookup transactioncurrencyidField;
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
		public CrmDecimal exchangerate
		{
			get
			{
				return this.exchangerateField;
			}
			set
			{
				this.exchangerateField = value;
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
		public CrmNumber sgt_aantal_dagen_tm
		{
			get
			{
				return this.sgt_aantal_dagen_tmField;
			}
			set
			{
				this.sgt_aantal_dagen_tmField = value;
			}
		}
		public CrmNumber sgt_aantal_dagen_vanaf
		{
			get
			{
				return this.sgt_aantal_dagen_vanafField;
			}
			set
			{
				this.sgt_aantal_dagen_vanafField = value;
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
		public Key sgt_fac_buma_bijdrage_amusementsmuziekid
		{
			get
			{
				return this.sgt_fac_buma_bijdrage_amusementsmuziekidField;
			}
			set
			{
				this.sgt_fac_buma_bijdrage_amusementsmuziekidField = value;
			}
		}
		public CrmMoney sgt_prijs_extra_50m2
		{
			get
			{
				return this.sgt_prijs_extra_50m2Field;
			}
			set
			{
				this.sgt_prijs_extra_50m2Field = value;
			}
		}
		public CrmMoney sgt_prijs_extra_50m2_base
		{
			get
			{
				return this.sgt_prijs_extra_50m2_baseField;
			}
			set
			{
				this.sgt_prijs_extra_50m2_baseField = value;
			}
		}
		public CrmMoney sgt_prijs_tm_50m2
		{
			get
			{
				return this.sgt_prijs_tm_50m2Field;
			}
			set
			{
				this.sgt_prijs_tm_50m2Field = value;
			}
		}
		public CrmMoney sgt_prijs_tm_50m2_base
		{
			get
			{
				return this.sgt_prijs_tm_50m2_baseField;
			}
			set
			{
				this.sgt_prijs_tm_50m2_baseField = value;
			}
		}
		public Sgt_fac_buma_bijdrage_amusementsmuziekStateInfo statecode
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
		public Lookup transactioncurrencyid
		{
			get
			{
				return this.transactioncurrencyidField;
			}
			set
			{
				this.transactioncurrencyidField = value;
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
