using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_dss_partijresultaat : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private string sgt_achternaamField;
		private CrmBoolean sgt_afwijkend_basisresultaatField;
		private string sgt_bondsnummerField;
		private Lookup sgt_competitieidField;
		private CrmDateTime sgt_datum_aangemaaktField;
		private string sgt_dss_partijresultaat1Field;
		private Key sgt_dss_partijresultaatidField;
		private CrmDecimal sgt_gebruikte_ratingField;
		private CrmBoolean sgt_is_dssField;
		private CrmDecimal sgt_oud_partijresultaatField;
		private CrmDateTime sgt_partij_datumField;
		private Picklist sgt_partij_typeField;
		private Lookup sgt_partij_uitslag_toernooiidField;
		private Lookup sgt_partij_uitslagidField;
		private CrmDecimal sgt_partijresultaatField;
		private string sgt_redenField;
		private Lookup sgt_speleridField;
		private CrmBoolean sgt_telt_mee_voor_dssField;
		private Lookup sgt_toernooi_idField;
		private Sgt_dss_partijresultaatStateInfo statecodeField;
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
		public string sgt_achternaam
		{
			get
			{
				return this.sgt_achternaamField;
			}
			set
			{
				this.sgt_achternaamField = value;
				base.RaisePropertyChanged("sgt_achternaam");
			}
		}
		[XmlElement(Order = 9)]
		public CrmBoolean sgt_afwijkend_basisresultaat
		{
			get
			{
				return this.sgt_afwijkend_basisresultaatField;
			}
			set
			{
				this.sgt_afwijkend_basisresultaatField = value;
				base.RaisePropertyChanged("sgt_afwijkend_basisresultaat");
			}
		}
		[XmlElement(Order = 10)]
		public string sgt_bondsnummer
		{
			get
			{
				return this.sgt_bondsnummerField;
			}
			set
			{
				this.sgt_bondsnummerField = value;
				base.RaisePropertyChanged("sgt_bondsnummer");
			}
		}
		[XmlElement(Order = 11)]
		public Lookup sgt_competitieid
		{
			get
			{
				return this.sgt_competitieidField;
			}
			set
			{
				this.sgt_competitieidField = value;
				base.RaisePropertyChanged("sgt_competitieid");
			}
		}
		[XmlElement(Order = 12)]
		public CrmDateTime sgt_datum_aangemaakt
		{
			get
			{
				return this.sgt_datum_aangemaaktField;
			}
			set
			{
				this.sgt_datum_aangemaaktField = value;
				base.RaisePropertyChanged("sgt_datum_aangemaakt");
			}
		}
		[XmlElement("sgt_dss_partijresultaat", Order = 13)]
		public string sgt_dss_partijresultaat1
		{
			get
			{
				return this.sgt_dss_partijresultaat1Field;
			}
			set
			{
				this.sgt_dss_partijresultaat1Field = value;
				base.RaisePropertyChanged("sgt_dss_partijresultaat1");
			}
		}
		[XmlElement(Order = 14)]
		public Key sgt_dss_partijresultaatid
		{
			get
			{
				return this.sgt_dss_partijresultaatidField;
			}
			set
			{
				this.sgt_dss_partijresultaatidField = value;
				base.RaisePropertyChanged("sgt_dss_partijresultaatid");
			}
		}
		[XmlElement(Order = 15)]
		public CrmDecimal sgt_gebruikte_rating
		{
			get
			{
				return this.sgt_gebruikte_ratingField;
			}
			set
			{
				this.sgt_gebruikte_ratingField = value;
				base.RaisePropertyChanged("sgt_gebruikte_rating");
			}
		}
		[XmlElement(Order = 16)]
		public CrmBoolean sgt_is_dss
		{
			get
			{
				return this.sgt_is_dssField;
			}
			set
			{
				this.sgt_is_dssField = value;
				base.RaisePropertyChanged("sgt_is_dss");
			}
		}
		[XmlElement(Order = 17)]
		public CrmDecimal sgt_oud_partijresultaat
		{
			get
			{
				return this.sgt_oud_partijresultaatField;
			}
			set
			{
				this.sgt_oud_partijresultaatField = value;
				base.RaisePropertyChanged("sgt_oud_partijresultaat");
			}
		}
		[XmlElement(Order = 18)]
		public CrmDateTime sgt_partij_datum
		{
			get
			{
				return this.sgt_partij_datumField;
			}
			set
			{
				this.sgt_partij_datumField = value;
				base.RaisePropertyChanged("sgt_partij_datum");
			}
		}
		[XmlElement(Order = 19)]
		public Picklist sgt_partij_type
		{
			get
			{
				return this.sgt_partij_typeField;
			}
			set
			{
				this.sgt_partij_typeField = value;
				base.RaisePropertyChanged("sgt_partij_type");
			}
		}
		[XmlElement(Order = 20)]
		public Lookup sgt_partij_uitslag_toernooiid
		{
			get
			{
				return this.sgt_partij_uitslag_toernooiidField;
			}
			set
			{
				this.sgt_partij_uitslag_toernooiidField = value;
				base.RaisePropertyChanged("sgt_partij_uitslag_toernooiid");
			}
		}
		[XmlElement(Order = 21)]
		public Lookup sgt_partij_uitslagid
		{
			get
			{
				return this.sgt_partij_uitslagidField;
			}
			set
			{
				this.sgt_partij_uitslagidField = value;
				base.RaisePropertyChanged("sgt_partij_uitslagid");
			}
		}
		[XmlElement(Order = 22)]
		public CrmDecimal sgt_partijresultaat
		{
			get
			{
				return this.sgt_partijresultaatField;
			}
			set
			{
				this.sgt_partijresultaatField = value;
				base.RaisePropertyChanged("sgt_partijresultaat");
			}
		}
		[XmlElement(Order = 23)]
		public string sgt_reden
		{
			get
			{
				return this.sgt_redenField;
			}
			set
			{
				this.sgt_redenField = value;
				base.RaisePropertyChanged("sgt_reden");
			}
		}
		[XmlElement(Order = 24)]
		public Lookup sgt_spelerid
		{
			get
			{
				return this.sgt_speleridField;
			}
			set
			{
				this.sgt_speleridField = value;
				base.RaisePropertyChanged("sgt_spelerid");
			}
		}
		[XmlElement(Order = 25)]
		public CrmBoolean sgt_telt_mee_voor_dss
		{
			get
			{
				return this.sgt_telt_mee_voor_dssField;
			}
			set
			{
				this.sgt_telt_mee_voor_dssField = value;
				base.RaisePropertyChanged("sgt_telt_mee_voor_dss");
			}
		}
		[XmlElement(Order = 26)]
		public Lookup sgt_toernooi_id
		{
			get
			{
				return this.sgt_toernooi_idField;
			}
			set
			{
				this.sgt_toernooi_idField = value;
				base.RaisePropertyChanged("sgt_toernooi_id");
			}
		}
		[XmlElement(Order = 27)]
		public Sgt_dss_partijresultaatStateInfo statecode
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
		[XmlElement(Order = 28)]
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
		[XmlElement(Order = 29)]
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
		[XmlElement(Order = 30)]
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
