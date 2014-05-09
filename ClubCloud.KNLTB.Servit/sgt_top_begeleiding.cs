using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_top_begeleiding : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private CrmDateTime sgt_datum_tmField;
		private CrmDateTime sgt_datum_vanafField;
		private Picklist sgt_functioneert_alsField;
		private string sgt_opmerkingField;
		private Lookup sgt_persoonlijkebegeleideridField;
		private string sgt_rol_andersField;
		private Lookup sgt_tennisseridField;
		private string sgt_top_begeleiding1Field;
		private Key sgt_top_begeleidingidField;
		private Sgt_top_begeleidingStateInfo statecodeField;
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
		public CrmDateTime sgt_datum_tm
		{
			get
			{
				return this.sgt_datum_tmField;
			}
			set
			{
				this.sgt_datum_tmField = value;
				base.RaisePropertyChanged("sgt_datum_tm");
			}
		}
		[XmlElement(Order = 9)]
		public CrmDateTime sgt_datum_vanaf
		{
			get
			{
				return this.sgt_datum_vanafField;
			}
			set
			{
				this.sgt_datum_vanafField = value;
				base.RaisePropertyChanged("sgt_datum_vanaf");
			}
		}
		[XmlElement(Order = 10)]
		public Picklist sgt_functioneert_als
		{
			get
			{
				return this.sgt_functioneert_alsField;
			}
			set
			{
				this.sgt_functioneert_alsField = value;
				base.RaisePropertyChanged("sgt_functioneert_als");
			}
		}
		[XmlElement(Order = 11)]
		public string sgt_opmerking
		{
			get
			{
				return this.sgt_opmerkingField;
			}
			set
			{
				this.sgt_opmerkingField = value;
				base.RaisePropertyChanged("sgt_opmerking");
			}
		}
		[XmlElement(Order = 12)]
		public Lookup sgt_persoonlijkebegeleiderid
		{
			get
			{
				return this.sgt_persoonlijkebegeleideridField;
			}
			set
			{
				this.sgt_persoonlijkebegeleideridField = value;
				base.RaisePropertyChanged("sgt_persoonlijkebegeleiderid");
			}
		}
		[XmlElement(Order = 13)]
		public string sgt_rol_anders
		{
			get
			{
				return this.sgt_rol_andersField;
			}
			set
			{
				this.sgt_rol_andersField = value;
				base.RaisePropertyChanged("sgt_rol_anders");
			}
		}
		[XmlElement(Order = 14)]
		public Lookup sgt_tennisserid
		{
			get
			{
				return this.sgt_tennisseridField;
			}
			set
			{
				this.sgt_tennisseridField = value;
				base.RaisePropertyChanged("sgt_tennisserid");
			}
		}
		[XmlElement("sgt_top_begeleiding", Order = 15)]
		public string sgt_top_begeleiding1
		{
			get
			{
				return this.sgt_top_begeleiding1Field;
			}
			set
			{
				this.sgt_top_begeleiding1Field = value;
				base.RaisePropertyChanged("sgt_top_begeleiding1");
			}
		}
		[XmlElement(Order = 16)]
		public Key sgt_top_begeleidingid
		{
			get
			{
				return this.sgt_top_begeleidingidField;
			}
			set
			{
				this.sgt_top_begeleidingidField = value;
				base.RaisePropertyChanged("sgt_top_begeleidingid");
			}
		}
		[XmlElement(Order = 17)]
		public Sgt_top_begeleidingStateInfo statecode
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
		[XmlElement(Order = 18)]
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
		[XmlElement(Order = 19)]
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
		[XmlElement(Order = 20)]
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
