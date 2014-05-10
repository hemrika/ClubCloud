using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
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
		public CrmDecimal sgt_basisgetal_dubbel
		{
			get
			{
				return this.sgt_basisgetal_dubbelField;
			}
			set
			{
				this.sgt_basisgetal_dubbelField = value;
			}
		}
		public CrmDecimal sgt_basisgetal_enkel
		{
			get
			{
				return this.sgt_basisgetal_enkelField;
			}
			set
			{
				this.sgt_basisgetal_enkelField = value;
			}
		}
		public Lookup sgt_beroepsinstantieid
		{
			get
			{
				return this.sgt_beroepsinstantieidField;
			}
			set
			{
				this.sgt_beroepsinstantieidField = value;
			}
		}
		public string sgt_bondsnummer
		{
			get
			{
				return this.sgt_bondsnummerField;
			}
			set
			{
				this.sgt_bondsnummerField = value;
			}
		}
		[XmlElement("sgt_dss_speelsterktemutatie_afhandeling")]
		public string sgt_dss_speelsterktemutatie_afhandeling1
		{
			get
			{
				return this.sgt_dss_speelsterktemutatie_afhandeling1Field;
			}
			set
			{
				this.sgt_dss_speelsterktemutatie_afhandeling1Field = value;
			}
		}
		public Key sgt_dss_speelsterktemutatie_afhandelingid
		{
			get
			{
				return this.sgt_dss_speelsterktemutatie_afhandelingidField;
			}
			set
			{
				this.sgt_dss_speelsterktemutatie_afhandelingidField = value;
			}
		}
		public string sgt_email
		{
			get
			{
				return this.sgt_emailField;
			}
			set
			{
				this.sgt_emailField = value;
			}
		}
		public Lookup sgt_lid_commissieid
		{
			get
			{
				return this.sgt_lid_commissieidField;
			}
			set
			{
				this.sgt_lid_commissieidField = value;
			}
		}
		public string sgt_opmerking_toe_afwijzing
		{
			get
			{
				return this.sgt_opmerking_toe_afwijzingField;
			}
			set
			{
				this.sgt_opmerking_toe_afwijzingField = value;
			}
		}
		public Lookup sgt_reden_toe_afwijzingid
		{
			get
			{
				return this.sgt_reden_toe_afwijzingidField;
			}
			set
			{
				this.sgt_reden_toe_afwijzingidField = value;
			}
		}
		public CrmNumber sgt_speelsterkte_dubbel
		{
			get
			{
				return this.sgt_speelsterkte_dubbelField;
			}
			set
			{
				this.sgt_speelsterkte_dubbelField = value;
			}
		}
		public CrmNumber sgt_speelsterkte_enkel
		{
			get
			{
				return this.sgt_speelsterkte_enkelField;
			}
			set
			{
				this.sgt_speelsterkte_enkelField = value;
			}
		}
		public Lookup sgt_speelsterktemutatie_aanvraag_id
		{
			get
			{
				return this.sgt_speelsterktemutatie_aanvraag_idField;
			}
			set
			{
				this.sgt_speelsterktemutatie_aanvraag_idField = value;
			}
		}
		public string sgt_toelichting
		{
			get
			{
				return this.sgt_toelichtingField;
			}
			set
			{
				this.sgt_toelichtingField = value;
			}
		}
		public string sgt_volgnummer
		{
			get
			{
				return this.sgt_volgnummerField;
			}
			set
			{
				this.sgt_volgnummerField = value;
			}
		}
		public Sgt_dss_speelsterktemutatie_afhandelingStateInfo statecode
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
