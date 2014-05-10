using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_toe_wedstrijdschema : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private CrmBoolean sgt_genereren_resultaatField;
		private CrmBoolean sgt_kwalificatietoernooiField;
		private Key sgt_toe_wedstrijdschemaidField;
		private Lookup sgt_toernooi_afhandelingidField;
		private Lookup sgt_toernooionderdeel_idField;
		private Picklist sgt_type_schemaField;
		private string sgt_volgnummer_wedstrijdschemaField;
		private string sgt_wedstrijdschema_omschrijvingField;
		private Sgt_toe_wedstrijdschemaStateInfo statecodeField;
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
		public CrmBoolean sgt_genereren_resultaat
		{
			get
			{
				return this.sgt_genereren_resultaatField;
			}
			set
			{
				this.sgt_genereren_resultaatField = value;
			}
		}
		public CrmBoolean sgt_kwalificatietoernooi
		{
			get
			{
				return this.sgt_kwalificatietoernooiField;
			}
			set
			{
				this.sgt_kwalificatietoernooiField = value;
			}
		}
		public Key sgt_toe_wedstrijdschemaid
		{
			get
			{
				return this.sgt_toe_wedstrijdschemaidField;
			}
			set
			{
				this.sgt_toe_wedstrijdschemaidField = value;
			}
		}
		public Lookup sgt_toernooi_afhandelingid
		{
			get
			{
				return this.sgt_toernooi_afhandelingidField;
			}
			set
			{
				this.sgt_toernooi_afhandelingidField = value;
			}
		}
		public Lookup sgt_toernooionderdeel_id
		{
			get
			{
				return this.sgt_toernooionderdeel_idField;
			}
			set
			{
				this.sgt_toernooionderdeel_idField = value;
			}
		}
		public Picklist sgt_type_schema
		{
			get
			{
				return this.sgt_type_schemaField;
			}
			set
			{
				this.sgt_type_schemaField = value;
			}
		}
		public string sgt_volgnummer_wedstrijdschema
		{
			get
			{
				return this.sgt_volgnummer_wedstrijdschemaField;
			}
			set
			{
				this.sgt_volgnummer_wedstrijdschemaField = value;
			}
		}
		public string sgt_wedstrijdschema_omschrijving
		{
			get
			{
				return this.sgt_wedstrijdschema_omschrijvingField;
			}
			set
			{
				this.sgt_wedstrijdschema_omschrijvingField = value;
			}
		}
		public Sgt_toe_wedstrijdschemaStateInfo statecode
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
