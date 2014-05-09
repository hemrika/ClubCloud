using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
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
		[XmlElement(Order = 0)]
		public Lookup createdby
		{
			get
			{
				return this.createdbyField;
			}
			set
			{
				this.createdbyField = value;
				base.RaisePropertyChanged("createdby");
			}
		}
		[XmlElement(Order = 1)]
		public CrmDateTime createdon
		{
			get
			{
				return this.createdonField;
			}
			set
			{
				this.createdonField = value;
				base.RaisePropertyChanged("createdon");
			}
		}
		[XmlElement(Order = 2)]
		public CrmNumber importsequencenumber
		{
			get
			{
				return this.importsequencenumberField;
			}
			set
			{
				this.importsequencenumberField = value;
				base.RaisePropertyChanged("importsequencenumber");
			}
		}
		[XmlElement(Order = 3)]
		public Lookup modifiedby
		{
			get
			{
				return this.modifiedbyField;
			}
			set
			{
				this.modifiedbyField = value;
				base.RaisePropertyChanged("modifiedby");
			}
		}
		[XmlElement(Order = 4)]
		public CrmDateTime modifiedon
		{
			get
			{
				return this.modifiedonField;
			}
			set
			{
				this.modifiedonField = value;
				base.RaisePropertyChanged("modifiedon");
			}
		}
		[XmlElement(Order = 5)]
		public CrmDateTime overriddencreatedon
		{
			get
			{
				return this.overriddencreatedonField;
			}
			set
			{
				this.overriddencreatedonField = value;
				base.RaisePropertyChanged("overriddencreatedon");
			}
		}
		[XmlElement(Order = 6)]
		public Owner ownerid
		{
			get
			{
				return this.owneridField;
			}
			set
			{
				this.owneridField = value;
				base.RaisePropertyChanged("ownerid");
			}
		}
		[XmlElement(Order = 7)]
		public Lookup owningbusinessunit
		{
			get
			{
				return this.owningbusinessunitField;
			}
			set
			{
				this.owningbusinessunitField = value;
				base.RaisePropertyChanged("owningbusinessunit");
			}
		}
		[XmlElement(Order = 8)]
		public CrmBoolean sgt_genereren_resultaat
		{
			get
			{
				return this.sgt_genereren_resultaatField;
			}
			set
			{
				this.sgt_genereren_resultaatField = value;
				base.RaisePropertyChanged("sgt_genereren_resultaat");
			}
		}
		[XmlElement(Order = 9)]
		public CrmBoolean sgt_kwalificatietoernooi
		{
			get
			{
				return this.sgt_kwalificatietoernooiField;
			}
			set
			{
				this.sgt_kwalificatietoernooiField = value;
				base.RaisePropertyChanged("sgt_kwalificatietoernooi");
			}
		}
		[XmlElement(Order = 10)]
		public Key sgt_toe_wedstrijdschemaid
		{
			get
			{
				return this.sgt_toe_wedstrijdschemaidField;
			}
			set
			{
				this.sgt_toe_wedstrijdschemaidField = value;
				base.RaisePropertyChanged("sgt_toe_wedstrijdschemaid");
			}
		}
		[XmlElement(Order = 11)]
		public Lookup sgt_toernooi_afhandelingid
		{
			get
			{
				return this.sgt_toernooi_afhandelingidField;
			}
			set
			{
				this.sgt_toernooi_afhandelingidField = value;
				base.RaisePropertyChanged("sgt_toernooi_afhandelingid");
			}
		}
		[XmlElement(Order = 12)]
		public Lookup sgt_toernooionderdeel_id
		{
			get
			{
				return this.sgt_toernooionderdeel_idField;
			}
			set
			{
				this.sgt_toernooionderdeel_idField = value;
				base.RaisePropertyChanged("sgt_toernooionderdeel_id");
			}
		}
		[XmlElement(Order = 13)]
		public Picklist sgt_type_schema
		{
			get
			{
				return this.sgt_type_schemaField;
			}
			set
			{
				this.sgt_type_schemaField = value;
				base.RaisePropertyChanged("sgt_type_schema");
			}
		}
		[XmlElement(Order = 14)]
		public string sgt_volgnummer_wedstrijdschema
		{
			get
			{
				return this.sgt_volgnummer_wedstrijdschemaField;
			}
			set
			{
				this.sgt_volgnummer_wedstrijdschemaField = value;
				base.RaisePropertyChanged("sgt_volgnummer_wedstrijdschema");
			}
		}
		[XmlElement(Order = 15)]
		public string sgt_wedstrijdschema_omschrijving
		{
			get
			{
				return this.sgt_wedstrijdschema_omschrijvingField;
			}
			set
			{
				this.sgt_wedstrijdschema_omschrijvingField = value;
				base.RaisePropertyChanged("sgt_wedstrijdschema_omschrijving");
			}
		}
		[XmlElement(Order = 16)]
		public Sgt_toe_wedstrijdschemaStateInfo statecode
		{
			get
			{
				return this.statecodeField;
			}
			set
			{
				this.statecodeField = value;
				base.RaisePropertyChanged("statecode");
			}
		}
		[XmlElement(Order = 17)]
		public Status statuscode
		{
			get
			{
				return this.statuscodeField;
			}
			set
			{
				this.statuscodeField = value;
				base.RaisePropertyChanged("statuscode");
			}
		}
		[XmlElement(Order = 18)]
		public CrmNumber timezoneruleversionnumber
		{
			get
			{
				return this.timezoneruleversionnumberField;
			}
			set
			{
				this.timezoneruleversionnumberField = value;
				base.RaisePropertyChanged("timezoneruleversionnumber");
			}
		}
		[XmlElement(Order = 19)]
		public CrmNumber utcconversiontimezonecode
		{
			get
			{
				return this.utcconversiontimezonecodeField;
			}
			set
			{
				this.utcconversiontimezonecodeField = value;
				base.RaisePropertyChanged("utcconversiontimezonecode");
			}
		}
	}
}
