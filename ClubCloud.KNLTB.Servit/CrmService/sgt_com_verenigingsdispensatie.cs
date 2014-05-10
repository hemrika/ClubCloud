using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_com_verenigingsdispensatie : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private Lookup sgt_aangevraagd_dooridField;
		private CrmNumber sgt_aantal_banenField;
		private Lookup sgt_afgekeurd_dooridField;
		private Lookup sgt_ander_parkidField;
		private string sgt_com_nameField;
		private Key sgt_com_verenigingsdispensatieidField;
		private Lookup sgt_competitieidField;
		private Picklist sgt_dagField;
		private Picklist sgt_dagdeelField;
		private CrmDateTime sgt_datum_aangevraagdField;
		private CrmDateTime sgt_datum_afgekeurdField;
		private CrmDateTime sgt_datum_goedgekeurdField;
		private Picklist sgt_dispensatietypeField;
		private Lookup sgt_goedgekeurd_dooridField;
		private Lookup sgt_reden_afgekeurdidField;
		private Lookup sgt_verenigingidField;
		private string sgt_verenigingsnummerField;
		private Sgt_com_verenigingsdispensatieStateInfo statecodeField;
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
		public Lookup sgt_aangevraagd_doorid
		{
			get
			{
				return this.sgt_aangevraagd_dooridField;
			}
			set
			{
				this.sgt_aangevraagd_dooridField = value;
			}
		}
		public CrmNumber sgt_aantal_banen
		{
			get
			{
				return this.sgt_aantal_banenField;
			}
			set
			{
				this.sgt_aantal_banenField = value;
			}
		}
		public Lookup sgt_afgekeurd_doorid
		{
			get
			{
				return this.sgt_afgekeurd_dooridField;
			}
			set
			{
				this.sgt_afgekeurd_dooridField = value;
			}
		}
		public Lookup sgt_ander_parkid
		{
			get
			{
				return this.sgt_ander_parkidField;
			}
			set
			{
				this.sgt_ander_parkidField = value;
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
		public Key sgt_com_verenigingsdispensatieid
		{
			get
			{
				return this.sgt_com_verenigingsdispensatieidField;
			}
			set
			{
				this.sgt_com_verenigingsdispensatieidField = value;
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
		public Picklist sgt_dagdeel
		{
			get
			{
				return this.sgt_dagdeelField;
			}
			set
			{
				this.sgt_dagdeelField = value;
			}
		}
		public CrmDateTime sgt_datum_aangevraagd
		{
			get
			{
				return this.sgt_datum_aangevraagdField;
			}
			set
			{
				this.sgt_datum_aangevraagdField = value;
			}
		}
		public CrmDateTime sgt_datum_afgekeurd
		{
			get
			{
				return this.sgt_datum_afgekeurdField;
			}
			set
			{
				this.sgt_datum_afgekeurdField = value;
			}
		}
		public CrmDateTime sgt_datum_goedgekeurd
		{
			get
			{
				return this.sgt_datum_goedgekeurdField;
			}
			set
			{
				this.sgt_datum_goedgekeurdField = value;
			}
		}
		public Picklist sgt_dispensatietype
		{
			get
			{
				return this.sgt_dispensatietypeField;
			}
			set
			{
				this.sgt_dispensatietypeField = value;
			}
		}
		public Lookup sgt_goedgekeurd_doorid
		{
			get
			{
				return this.sgt_goedgekeurd_dooridField;
			}
			set
			{
				this.sgt_goedgekeurd_dooridField = value;
			}
		}
		public Lookup sgt_reden_afgekeurdid
		{
			get
			{
				return this.sgt_reden_afgekeurdidField;
			}
			set
			{
				this.sgt_reden_afgekeurdidField = value;
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
		public string sgt_verenigingsnummer
		{
			get
			{
				return this.sgt_verenigingsnummerField;
			}
			set
			{
				this.sgt_verenigingsnummerField = value;
			}
		}
		public Sgt_com_verenigingsdispensatieStateInfo statecode
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
