using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_alg_persoonlijke_relatie : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private string sgt_alg_persoonlijke_relatie1Field;
		private Key sgt_alg_persoonlijke_relatieidField;
		private string sgt_beschrijving_1Field;
		private string sgt_beschrijving_2Field;
		private Lookup sgt_betrokkene_1idField;
		private Lookup sgt_betrokkene_2idField;
		private Lookup sgt_rol_1idField;
		private Lookup sgt_rol_2idField;
		private Sgt_alg_persoonlijke_relatieStateInfo statecodeField;
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
		[XmlElement("sgt_alg_persoonlijke_relatie", Order = 8)]
		public string sgt_alg_persoonlijke_relatie1
		{
			get
			{
				return this.sgt_alg_persoonlijke_relatie1Field;
			}
			set
			{
				this.sgt_alg_persoonlijke_relatie1Field = value;
				base.RaisePropertyChanged("sgt_alg_persoonlijke_relatie1");
			}
		}
		[XmlElement(Order = 9)]
		public Key sgt_alg_persoonlijke_relatieid
		{
			get
			{
				return this.sgt_alg_persoonlijke_relatieidField;
			}
			set
			{
				this.sgt_alg_persoonlijke_relatieidField = value;
				base.RaisePropertyChanged("sgt_alg_persoonlijke_relatieid");
			}
		}
		[XmlElement(Order = 10)]
		public string sgt_beschrijving_1
		{
			get
			{
				return this.sgt_beschrijving_1Field;
			}
			set
			{
				this.sgt_beschrijving_1Field = value;
				base.RaisePropertyChanged("sgt_beschrijving_1");
			}
		}
		[XmlElement(Order = 11)]
		public string sgt_beschrijving_2
		{
			get
			{
				return this.sgt_beschrijving_2Field;
			}
			set
			{
				this.sgt_beschrijving_2Field = value;
				base.RaisePropertyChanged("sgt_beschrijving_2");
			}
		}
		[XmlElement(Order = 12)]
		public Lookup sgt_betrokkene_1id
		{
			get
			{
				return this.sgt_betrokkene_1idField;
			}
			set
			{
				this.sgt_betrokkene_1idField = value;
				base.RaisePropertyChanged("sgt_betrokkene_1id");
			}
		}
		[XmlElement(Order = 13)]
		public Lookup sgt_betrokkene_2id
		{
			get
			{
				return this.sgt_betrokkene_2idField;
			}
			set
			{
				this.sgt_betrokkene_2idField = value;
				base.RaisePropertyChanged("sgt_betrokkene_2id");
			}
		}
		[XmlElement(Order = 14)]
		public Lookup sgt_rol_1id
		{
			get
			{
				return this.sgt_rol_1idField;
			}
			set
			{
				this.sgt_rol_1idField = value;
				base.RaisePropertyChanged("sgt_rol_1id");
			}
		}
		[XmlElement(Order = 15)]
		public Lookup sgt_rol_2id
		{
			get
			{
				return this.sgt_rol_2idField;
			}
			set
			{
				this.sgt_rol_2idField = value;
				base.RaisePropertyChanged("sgt_rol_2id");
			}
		}
		[XmlElement(Order = 16)]
		public Sgt_alg_persoonlijke_relatieStateInfo statecode
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
