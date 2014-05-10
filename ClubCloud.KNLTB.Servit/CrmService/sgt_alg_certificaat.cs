using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_alg_certificaat : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private Key sgt_alg_certificaatidField;
		private Lookup sgt_certificaatidField;
		private string sgt_certificaatnummerField;
		private Lookup sgt_cursistidField;
		private CrmDateTime sgt_geldig_tot_en_metField;
		private CrmDateTime sgt_geldig_vanafField;
		private CrmNumber sgt_geldigheidsduurField;
		private string sgt_nameField;
		private Lookup sgt_opleidingidField;
		private string sgt_opmerkingField;
		private Lookup sgt_verenigingidField;
		private CrmNumber sgt_volgordenummerField;
		private Sgt_alg_certificaatStateInfo statecodeField;
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
		public Key sgt_alg_certificaatid
		{
			get
			{
				return this.sgt_alg_certificaatidField;
			}
			set
			{
				this.sgt_alg_certificaatidField = value;
			}
		}
		public Lookup sgt_certificaatid
		{
			get
			{
				return this.sgt_certificaatidField;
			}
			set
			{
				this.sgt_certificaatidField = value;
			}
		}
		public string sgt_certificaatnummer
		{
			get
			{
				return this.sgt_certificaatnummerField;
			}
			set
			{
				this.sgt_certificaatnummerField = value;
			}
		}
		public Lookup sgt_cursistid
		{
			get
			{
				return this.sgt_cursistidField;
			}
			set
			{
				this.sgt_cursistidField = value;
			}
		}
		public CrmDateTime sgt_geldig_tot_en_met
		{
			get
			{
				return this.sgt_geldig_tot_en_metField;
			}
			set
			{
				this.sgt_geldig_tot_en_metField = value;
			}
		}
		public CrmDateTime sgt_geldig_vanaf
		{
			get
			{
				return this.sgt_geldig_vanafField;
			}
			set
			{
				this.sgt_geldig_vanafField = value;
			}
		}
		public CrmNumber sgt_geldigheidsduur
		{
			get
			{
				return this.sgt_geldigheidsduurField;
			}
			set
			{
				this.sgt_geldigheidsduurField = value;
			}
		}
		public string sgt_name
		{
			get
			{
				return this.sgt_nameField;
			}
			set
			{
				this.sgt_nameField = value;
			}
		}
		public Lookup sgt_opleidingid
		{
			get
			{
				return this.sgt_opleidingidField;
			}
			set
			{
				this.sgt_opleidingidField = value;
			}
		}
		public string sgt_opmerking
		{
			get
			{
				return this.sgt_opmerkingField;
			}
			set
			{
				this.sgt_opmerkingField = value;
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
		public CrmNumber sgt_volgordenummer
		{
			get
			{
				return this.sgt_volgordenummerField;
			}
			set
			{
				this.sgt_volgordenummerField = value;
			}
		}
		public Sgt_alg_certificaatStateInfo statecode
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
