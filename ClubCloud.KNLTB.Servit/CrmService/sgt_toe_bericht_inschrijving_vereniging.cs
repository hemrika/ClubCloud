using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_toe_bericht_inschrijving_vereniging : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private CrmDateTime sgt_datum_bericht_versturenField;
		private CrmDateTime sgt_datum_bericht_verstuurtField;
		private CrmDateTime sgt_datum_herinnering_verstuurtField;
		private string sgt_toe_bericht_inschrijving_vereniging1Field;
		private Key sgt_toe_bericht_inschrijving_verenigingidField;
		private Lookup sgt_toernooi_aanvraag_verwerking_idField;
		private Lookup sgt_toernooiidField;
		private Lookup sgt_verenigingidField;
		private Sgt_toe_bericht_inschrijving_verenigingStateInfo statecodeField;
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
		public CrmDateTime sgt_datum_bericht_versturen
		{
			get
			{
				return this.sgt_datum_bericht_versturenField;
			}
			set
			{
				this.sgt_datum_bericht_versturenField = value;
			}
		}
		public CrmDateTime sgt_datum_bericht_verstuurt
		{
			get
			{
				return this.sgt_datum_bericht_verstuurtField;
			}
			set
			{
				this.sgt_datum_bericht_verstuurtField = value;
			}
		}
		public CrmDateTime sgt_datum_herinnering_verstuurt
		{
			get
			{
				return this.sgt_datum_herinnering_verstuurtField;
			}
			set
			{
				this.sgt_datum_herinnering_verstuurtField = value;
			}
		}
		[XmlElement("sgt_toe_bericht_inschrijving_vereniging")]
		public string sgt_toe_bericht_inschrijving_vereniging1
		{
			get
			{
				return this.sgt_toe_bericht_inschrijving_vereniging1Field;
			}
			set
			{
				this.sgt_toe_bericht_inschrijving_vereniging1Field = value;
			}
		}
		public Key sgt_toe_bericht_inschrijving_verenigingid
		{
			get
			{
				return this.sgt_toe_bericht_inschrijving_verenigingidField;
			}
			set
			{
				this.sgt_toe_bericht_inschrijving_verenigingidField = value;
			}
		}
		public Lookup sgt_toernooi_aanvraag_verwerking_id
		{
			get
			{
				return this.sgt_toernooi_aanvraag_verwerking_idField;
			}
			set
			{
				this.sgt_toernooi_aanvraag_verwerking_idField = value;
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
		public Sgt_toe_bericht_inschrijving_verenigingStateInfo statecode
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
