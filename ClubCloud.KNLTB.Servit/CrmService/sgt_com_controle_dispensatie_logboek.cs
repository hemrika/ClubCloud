using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_com_controle_dispensatie_logboek : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private Key sgt_com_controle_dispensatie_logboekidField;
		private string sgt_com_naamField;
		private CrmDateTime sgt_controle_tmField;
		private CrmDateTime sgt_controle_vanafField;
		private CrmNumber sgt_min_aantal_wedstrijdenField;
		private Picklist sgt_soort_controleField;
		private Picklist sgt_statusField;
		private Sgt_com_controle_dispensatie_logboekStateInfo statecodeField;
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
		public Key sgt_com_controle_dispensatie_logboekid
		{
			get
			{
				return this.sgt_com_controle_dispensatie_logboekidField;
			}
			set
			{
				this.sgt_com_controle_dispensatie_logboekidField = value;
			}
		}
		public string sgt_com_naam
		{
			get
			{
				return this.sgt_com_naamField;
			}
			set
			{
				this.sgt_com_naamField = value;
			}
		}
		public CrmDateTime sgt_controle_tm
		{
			get
			{
				return this.sgt_controle_tmField;
			}
			set
			{
				this.sgt_controle_tmField = value;
			}
		}
		public CrmDateTime sgt_controle_vanaf
		{
			get
			{
				return this.sgt_controle_vanafField;
			}
			set
			{
				this.sgt_controle_vanafField = value;
			}
		}
		public CrmNumber sgt_min_aantal_wedstrijden
		{
			get
			{
				return this.sgt_min_aantal_wedstrijdenField;
			}
			set
			{
				this.sgt_min_aantal_wedstrijdenField = value;
			}
		}
		public Picklist sgt_soort_controle
		{
			get
			{
				return this.sgt_soort_controleField;
			}
			set
			{
				this.sgt_soort_controleField = value;
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
		public Sgt_com_controle_dispensatie_logboekStateInfo statecode
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
