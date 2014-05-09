using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_toe_toernooi_aanvraagrecht : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private Lookup sgt_aanvraagformulier_dagtoernooi_idField;
		private Lookup sgt_aanvraagformulieridField;
		private Lookup sgt_bondsorganisatieidField;
		private string sgt_toe_toernooi_aanvraagrecht1Field;
		private Key sgt_toe_toernooi_aanvraagrechtidField;
		private Lookup sgt_toernooiorganisatieidField;
		private Lookup sgt_toernooisoortidField;
		private CrmBoolean sgt_vorig_jaarField;
		private Sgt_toe_toernooi_aanvraagrechtStateInfo statecodeField;
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
		public Lookup sgt_aanvraagformulier_dagtoernooi_id
		{
			get
			{
				return this.sgt_aanvraagformulier_dagtoernooi_idField;
			}
			set
			{
				this.sgt_aanvraagformulier_dagtoernooi_idField = value;
				base.RaisePropertyChanged("sgt_aanvraagformulier_dagtoernooi_id");
			}
		}
		[XmlElement(Order = 9)]
		public Lookup sgt_aanvraagformulierid
		{
			get
			{
				return this.sgt_aanvraagformulieridField;
			}
			set
			{
				this.sgt_aanvraagformulieridField = value;
				base.RaisePropertyChanged("sgt_aanvraagformulierid");
			}
		}
		[XmlElement(Order = 10)]
		public Lookup sgt_bondsorganisatieid
		{
			get
			{
				return this.sgt_bondsorganisatieidField;
			}
			set
			{
				this.sgt_bondsorganisatieidField = value;
				base.RaisePropertyChanged("sgt_bondsorganisatieid");
			}
		}
		[XmlElement("sgt_toe_toernooi_aanvraagrecht", Order = 11)]
		public string sgt_toe_toernooi_aanvraagrecht1
		{
			get
			{
				return this.sgt_toe_toernooi_aanvraagrecht1Field;
			}
			set
			{
				this.sgt_toe_toernooi_aanvraagrecht1Field = value;
				base.RaisePropertyChanged("sgt_toe_toernooi_aanvraagrecht1");
			}
		}
		[XmlElement(Order = 12)]
		public Key sgt_toe_toernooi_aanvraagrechtid
		{
			get
			{
				return this.sgt_toe_toernooi_aanvraagrechtidField;
			}
			set
			{
				this.sgt_toe_toernooi_aanvraagrechtidField = value;
				base.RaisePropertyChanged("sgt_toe_toernooi_aanvraagrechtid");
			}
		}
		[XmlElement(Order = 13)]
		public Lookup sgt_toernooiorganisatieid
		{
			get
			{
				return this.sgt_toernooiorganisatieidField;
			}
			set
			{
				this.sgt_toernooiorganisatieidField = value;
				base.RaisePropertyChanged("sgt_toernooiorganisatieid");
			}
		}
		[XmlElement(Order = 14)]
		public Lookup sgt_toernooisoortid
		{
			get
			{
				return this.sgt_toernooisoortidField;
			}
			set
			{
				this.sgt_toernooisoortidField = value;
				base.RaisePropertyChanged("sgt_toernooisoortid");
			}
		}
		[XmlElement(Order = 15)]
		public CrmBoolean sgt_vorig_jaar
		{
			get
			{
				return this.sgt_vorig_jaarField;
			}
			set
			{
				this.sgt_vorig_jaarField = value;
				base.RaisePropertyChanged("sgt_vorig_jaar");
			}
		}
		[XmlElement(Order = 16)]
		public Sgt_toe_toernooi_aanvraagrechtStateInfo statecode
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
