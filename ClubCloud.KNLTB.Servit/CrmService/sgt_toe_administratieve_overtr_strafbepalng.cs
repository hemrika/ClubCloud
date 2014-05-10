using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_toe_administratieve_overtr_strafbepalng : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private Lookup organizationidField;
		private CrmDateTime overriddencreatedonField;
		private string sgt_strafbepaling_kenmerkField;
		private string sgt_strafbepaling_omschrijvingField;
		private string sgt_strafbepaling_toelichtingField;
		private Key sgt_toe_administratieve_overtr_strafbepalngidField;
		private Picklist sgt_wedstrijdleiding_deelnemerField;
		private Sgt_toe_administratieve_overtr_strafbepalngStateInfo statecodeField;
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
		public string sgt_strafbepaling_kenmerk
		{
			get
			{
				return this.sgt_strafbepaling_kenmerkField;
			}
			set
			{
				this.sgt_strafbepaling_kenmerkField = value;
			}
		}
		public string sgt_strafbepaling_omschrijving
		{
			get
			{
				return this.sgt_strafbepaling_omschrijvingField;
			}
			set
			{
				this.sgt_strafbepaling_omschrijvingField = value;
			}
		}
		public string sgt_strafbepaling_toelichting
		{
			get
			{
				return this.sgt_strafbepaling_toelichtingField;
			}
			set
			{
				this.sgt_strafbepaling_toelichtingField = value;
			}
		}
		public Key sgt_toe_administratieve_overtr_strafbepalngid
		{
			get
			{
				return this.sgt_toe_administratieve_overtr_strafbepalngidField;
			}
			set
			{
				this.sgt_toe_administratieve_overtr_strafbepalngidField = value;
			}
		}
		public Picklist sgt_wedstrijdleiding_deelnemer
		{
			get
			{
				return this.sgt_wedstrijdleiding_deelnemerField;
			}
			set
			{
				this.sgt_wedstrijdleiding_deelnemerField = value;
			}
		}
		public Sgt_toe_administratieve_overtr_strafbepalngStateInfo statecode
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
