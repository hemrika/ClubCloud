using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_alg_kenmerk : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private Lookup sgt_accommodatie_idField;
		private Key sgt_alg_kenmerkidField;
		private Lookup sgt_basisorganisatie_idField;
		private Lookup sgt_flexibel_kenmerk_idField;
		private Lookup sgt_flexibel_kenmerk_type_idField;
		private string sgt_kenmerkField;
		private Lookup sgt_persoon_idField;
		private string sgt_waardeField;
		private Sgt_alg_kenmerkStateInfo statecodeField;
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
		public Lookup sgt_accommodatie_id
		{
			get
			{
				return this.sgt_accommodatie_idField;
			}
			set
			{
				this.sgt_accommodatie_idField = value;
				base.RaisePropertyChanged("sgt_accommodatie_id");
			}
		}
		[XmlElement(Order = 9)]
		public Key sgt_alg_kenmerkid
		{
			get
			{
				return this.sgt_alg_kenmerkidField;
			}
			set
			{
				this.sgt_alg_kenmerkidField = value;
				base.RaisePropertyChanged("sgt_alg_kenmerkid");
			}
		}
		[XmlElement(Order = 10)]
		public Lookup sgt_basisorganisatie_id
		{
			get
			{
				return this.sgt_basisorganisatie_idField;
			}
			set
			{
				this.sgt_basisorganisatie_idField = value;
				base.RaisePropertyChanged("sgt_basisorganisatie_id");
			}
		}
		[XmlElement(Order = 11)]
		public Lookup sgt_flexibel_kenmerk_id
		{
			get
			{
				return this.sgt_flexibel_kenmerk_idField;
			}
			set
			{
				this.sgt_flexibel_kenmerk_idField = value;
				base.RaisePropertyChanged("sgt_flexibel_kenmerk_id");
			}
		}
		[XmlElement(Order = 12)]
		public Lookup sgt_flexibel_kenmerk_type_id
		{
			get
			{
				return this.sgt_flexibel_kenmerk_type_idField;
			}
			set
			{
				this.sgt_flexibel_kenmerk_type_idField = value;
				base.RaisePropertyChanged("sgt_flexibel_kenmerk_type_id");
			}
		}
		[XmlElement(Order = 13)]
		public string sgt_kenmerk
		{
			get
			{
				return this.sgt_kenmerkField;
			}
			set
			{
				this.sgt_kenmerkField = value;
				base.RaisePropertyChanged("sgt_kenmerk");
			}
		}
		[XmlElement(Order = 14)]
		public Lookup sgt_persoon_id
		{
			get
			{
				return this.sgt_persoon_idField;
			}
			set
			{
				this.sgt_persoon_idField = value;
				base.RaisePropertyChanged("sgt_persoon_id");
			}
		}
		[XmlElement(Order = 15)]
		public string sgt_waarde
		{
			get
			{
				return this.sgt_waardeField;
			}
			set
			{
				this.sgt_waardeField = value;
				base.RaisePropertyChanged("sgt_waarde");
			}
		}
		[XmlElement(Order = 16)]
		public Sgt_alg_kenmerkStateInfo statecode
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
