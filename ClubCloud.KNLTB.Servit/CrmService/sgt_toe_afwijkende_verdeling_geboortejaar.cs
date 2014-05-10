using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_toe_afwijkende_verdeling_geboortejaar : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private Lookup organizationidField;
		private CrmDateTime overriddencreatedonField;
		private Lookup sgt__automatische_acceptatieidField;
		private CrmNumber sgt_aantal_deelnemersField;
		private string sgt_geboortejaarField;
		private Lookup sgt_ranglijst_logboekidField;
		private Lookup sgt_ranglijstidField;
		private Key sgt_toe_afwijkende_verdeling_geboortejaaridField;
		private string sgt_toe_nameField;
		private Sgt_toe_afwijkende_verdeling_geboortejaarStateInfo statecodeField;
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
		public Lookup sgt__automatische_acceptatieid
		{
			get
			{
				return this.sgt__automatische_acceptatieidField;
			}
			set
			{
				this.sgt__automatische_acceptatieidField = value;
			}
		}
		public CrmNumber sgt_aantal_deelnemers
		{
			get
			{
				return this.sgt_aantal_deelnemersField;
			}
			set
			{
				this.sgt_aantal_deelnemersField = value;
			}
		}
		public string sgt_geboortejaar
		{
			get
			{
				return this.sgt_geboortejaarField;
			}
			set
			{
				this.sgt_geboortejaarField = value;
			}
		}
		public Lookup sgt_ranglijst_logboekid
		{
			get
			{
				return this.sgt_ranglijst_logboekidField;
			}
			set
			{
				this.sgt_ranglijst_logboekidField = value;
			}
		}
		public Lookup sgt_ranglijstid
		{
			get
			{
				return this.sgt_ranglijstidField;
			}
			set
			{
				this.sgt_ranglijstidField = value;
			}
		}
		public Key sgt_toe_afwijkende_verdeling_geboortejaarid
		{
			get
			{
				return this.sgt_toe_afwijkende_verdeling_geboortejaaridField;
			}
			set
			{
				this.sgt_toe_afwijkende_verdeling_geboortejaaridField = value;
			}
		}
		public string sgt_toe_name
		{
			get
			{
				return this.sgt_toe_nameField;
			}
			set
			{
				this.sgt_toe_nameField = value;
			}
		}
		public Sgt_toe_afwijkende_verdeling_geboortejaarStateInfo statecode
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
