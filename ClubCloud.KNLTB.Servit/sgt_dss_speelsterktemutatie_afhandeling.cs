using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_dss_speelsterktemutatie_afhandeling : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private CrmDecimal sgt_basisgetal_dubbelField;
		private CrmDecimal sgt_basisgetal_enkelField;
		private Lookup sgt_beroepsinstantieidField;
		private string sgt_bondsnummerField;
		private string sgt_dss_speelsterktemutatie_afhandeling1Field;
		private Key sgt_dss_speelsterktemutatie_afhandelingidField;
		private string sgt_emailField;
		private Lookup sgt_lid_commissieidField;
		private string sgt_opmerking_toe_afwijzingField;
		private Lookup sgt_reden_toe_afwijzingidField;
		private CrmNumber sgt_speelsterkte_dubbelField;
		private CrmNumber sgt_speelsterkte_enkelField;
		private Lookup sgt_speelsterktemutatie_aanvraag_idField;
		private string sgt_toelichtingField;
		private string sgt_volgnummerField;
		private Sgt_dss_speelsterktemutatie_afhandelingStateInfo statecodeField;
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
		public CrmDecimal sgt_basisgetal_dubbel
		{
			get
			{
				return this.sgt_basisgetal_dubbelField;
			}
			set
			{
				this.sgt_basisgetal_dubbelField = value;
				base.RaisePropertyChanged("sgt_basisgetal_dubbel");
			}
		}
		[XmlElement(Order = 9)]
		public CrmDecimal sgt_basisgetal_enkel
		{
			get
			{
				return this.sgt_basisgetal_enkelField;
			}
			set
			{
				this.sgt_basisgetal_enkelField = value;
				base.RaisePropertyChanged("sgt_basisgetal_enkel");
			}
		}
		[XmlElement(Order = 10)]
		public Lookup sgt_beroepsinstantieid
		{
			get
			{
				return this.sgt_beroepsinstantieidField;
			}
			set
			{
				this.sgt_beroepsinstantieidField = value;
				base.RaisePropertyChanged("sgt_beroepsinstantieid");
			}
		}
		[XmlElement(Order = 11)]
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
		[XmlElement("sgt_dss_speelsterktemutatie_afhandeling", Order = 12)]
		public string sgt_dss_speelsterktemutatie_afhandeling1
		{
			get
			{
				return this.sgt_dss_speelsterktemutatie_afhandeling1Field;
			}
			set
			{
				this.sgt_dss_speelsterktemutatie_afhandeling1Field = value;
				base.RaisePropertyChanged("sgt_dss_speelsterktemutatie_afhandeling1");
			}
		}
		[XmlElement(Order = 13)]
		public Key sgt_dss_speelsterktemutatie_afhandelingid
		{
			get
			{
				return this.sgt_dss_speelsterktemutatie_afhandelingidField;
			}
			set
			{
				this.sgt_dss_speelsterktemutatie_afhandelingidField = value;
				base.RaisePropertyChanged("sgt_dss_speelsterktemutatie_afhandelingid");
			}
		}
		[XmlElement(Order = 14)]
		public string sgt_email
		{
			get
			{
				return this.sgt_emailField;
			}
			set
			{
				this.sgt_emailField = value;
				base.RaisePropertyChanged("sgt_email");
			}
		}
		[XmlElement(Order = 15)]
		public Lookup sgt_lid_commissieid
		{
			get
			{
				return this.sgt_lid_commissieidField;
			}
			set
			{
				this.sgt_lid_commissieidField = value;
				base.RaisePropertyChanged("sgt_lid_commissieid");
			}
		}
		[XmlElement(Order = 16)]
		public string sgt_opmerking_toe_afwijzing
		{
			get
			{
				return this.sgt_opmerking_toe_afwijzingField;
			}
			set
			{
				this.sgt_opmerking_toe_afwijzingField = value;
				base.RaisePropertyChanged("sgt_opmerking_toe_afwijzing");
			}
		}
		[XmlElement(Order = 17)]
		public Lookup sgt_reden_toe_afwijzingid
		{
			get
			{
				return this.sgt_reden_toe_afwijzingidField;
			}
			set
			{
				this.sgt_reden_toe_afwijzingidField = value;
				base.RaisePropertyChanged("sgt_reden_toe_afwijzingid");
			}
		}
		[XmlElement(Order = 18)]
		public CrmNumber sgt_speelsterkte_dubbel
		{
			get
			{
				return this.sgt_speelsterkte_dubbelField;
			}
			set
			{
				this.sgt_speelsterkte_dubbelField = value;
				base.RaisePropertyChanged("sgt_speelsterkte_dubbel");
			}
		}
		[XmlElement(Order = 19)]
		public CrmNumber sgt_speelsterkte_enkel
		{
			get
			{
				return this.sgt_speelsterkte_enkelField;
			}
			set
			{
				this.sgt_speelsterkte_enkelField = value;
				base.RaisePropertyChanged("sgt_speelsterkte_enkel");
			}
		}
		[XmlElement(Order = 20)]
		public Lookup sgt_speelsterktemutatie_aanvraag_id
		{
			get
			{
				return this.sgt_speelsterktemutatie_aanvraag_idField;
			}
			set
			{
				this.sgt_speelsterktemutatie_aanvraag_idField = value;
				base.RaisePropertyChanged("sgt_speelsterktemutatie_aanvraag_id");
			}
		}
		[XmlElement(Order = 21)]
		public string sgt_toelichting
		{
			get
			{
				return this.sgt_toelichtingField;
			}
			set
			{
				this.sgt_toelichtingField = value;
				base.RaisePropertyChanged("sgt_toelichting");
			}
		}
		[XmlElement(Order = 22)]
		public string sgt_volgnummer
		{
			get
			{
				return this.sgt_volgnummerField;
			}
			set
			{
				this.sgt_volgnummerField = value;
				base.RaisePropertyChanged("sgt_volgnummer");
			}
		}
		[XmlElement(Order = 23)]
		public Sgt_dss_speelsterktemutatie_afhandelingStateInfo statecode
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
		[XmlElement(Order = 24)]
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
		[XmlElement(Order = 25)]
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
		[XmlElement(Order = 26)]
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
