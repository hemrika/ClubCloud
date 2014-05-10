using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_com_baan_gereserveerd_competitie : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private Lookup sgt_accomodatieidField;
		private CrmNumber sgt_binnen_avondField;
		private CrmNumber sgt_binnen_middagField;
		private CrmNumber sgt_binnen_morgenField;
		private CrmNumber sgt_buiten_avondField;
		private CrmNumber sgt_buiten_middagField;
		private CrmNumber sgt_buiten_morgenField;
		private Key sgt_com_baan_gereserveerd_competitieidField;
		private string sgt_com_nameField;
		private Lookup sgt_competitieidField;
		private Lookup sgt_competitieinschrijvingidField;
		private Picklist sgt_dagField;
		private string sgt_dagnrField;
		private Lookup sgt_verenigingidField;
		private CrmBoolean sgt_verlichtingField;
		private Sgt_com_baan_gereserveerd_competitieStateInfo statecodeField;
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
		public Lookup sgt_accomodatieid
		{
			get
			{
				return this.sgt_accomodatieidField;
			}
			set
			{
				this.sgt_accomodatieidField = value;
			}
		}
		public CrmNumber sgt_binnen_avond
		{
			get
			{
				return this.sgt_binnen_avondField;
			}
			set
			{
				this.sgt_binnen_avondField = value;
			}
		}
		public CrmNumber sgt_binnen_middag
		{
			get
			{
				return this.sgt_binnen_middagField;
			}
			set
			{
				this.sgt_binnen_middagField = value;
			}
		}
		public CrmNumber sgt_binnen_morgen
		{
			get
			{
				return this.sgt_binnen_morgenField;
			}
			set
			{
				this.sgt_binnen_morgenField = value;
			}
		}
		public CrmNumber sgt_buiten_avond
		{
			get
			{
				return this.sgt_buiten_avondField;
			}
			set
			{
				this.sgt_buiten_avondField = value;
			}
		}
		public CrmNumber sgt_buiten_middag
		{
			get
			{
				return this.sgt_buiten_middagField;
			}
			set
			{
				this.sgt_buiten_middagField = value;
			}
		}
		public CrmNumber sgt_buiten_morgen
		{
			get
			{
				return this.sgt_buiten_morgenField;
			}
			set
			{
				this.sgt_buiten_morgenField = value;
			}
		}
		public Key sgt_com_baan_gereserveerd_competitieid
		{
			get
			{
				return this.sgt_com_baan_gereserveerd_competitieidField;
			}
			set
			{
				this.sgt_com_baan_gereserveerd_competitieidField = value;
			}
		}
		public string sgt_com_name
		{
			get
			{
				return this.sgt_com_nameField;
			}
			set
			{
				this.sgt_com_nameField = value;
			}
		}
		public Lookup sgt_competitieid
		{
			get
			{
				return this.sgt_competitieidField;
			}
			set
			{
				this.sgt_competitieidField = value;
			}
		}
		public Lookup sgt_competitieinschrijvingid
		{
			get
			{
				return this.sgt_competitieinschrijvingidField;
			}
			set
			{
				this.sgt_competitieinschrijvingidField = value;
			}
		}
		public Picklist sgt_dag
		{
			get
			{
				return this.sgt_dagField;
			}
			set
			{
				this.sgt_dagField = value;
			}
		}
		public string sgt_dagnr
		{
			get
			{
				return this.sgt_dagnrField;
			}
			set
			{
				this.sgt_dagnrField = value;
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
		public CrmBoolean sgt_verlichting
		{
			get
			{
				return this.sgt_verlichtingField;
			}
			set
			{
				this.sgt_verlichtingField = value;
			}
		}
		public Sgt_com_baan_gereserveerd_competitieStateInfo statecode
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
