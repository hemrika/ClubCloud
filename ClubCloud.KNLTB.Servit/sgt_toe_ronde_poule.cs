using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_toe_ronde_poule : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private Lookup sgt_accommodatieidField;
		private CrmBoolean sgt_eerste_wedstrijdField;
		private string sgt_pouleField;
		private Lookup sgt_speelschemaidField;
		private string sgt_toe_ronde_poule1Field;
		private Key sgt_toe_ronde_pouleidField;
		private Picklist sgt_type_rondeField;
		private string sgt_volgnummer_ronde_pouleField;
		private Sgt_toe_ronde_pouleStateInfo statecodeField;
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
		public Lookup sgt_accommodatieid
		{
			get
			{
				return this.sgt_accommodatieidField;
			}
			set
			{
				this.sgt_accommodatieidField = value;
				base.RaisePropertyChanged("sgt_accommodatieid");
			}
		}
		[XmlElement(Order = 9)]
		public CrmBoolean sgt_eerste_wedstrijd
		{
			get
			{
				return this.sgt_eerste_wedstrijdField;
			}
			set
			{
				this.sgt_eerste_wedstrijdField = value;
				base.RaisePropertyChanged("sgt_eerste_wedstrijd");
			}
		}
		[XmlElement(Order = 10)]
		public string sgt_poule
		{
			get
			{
				return this.sgt_pouleField;
			}
			set
			{
				this.sgt_pouleField = value;
				base.RaisePropertyChanged("sgt_poule");
			}
		}
		[XmlElement(Order = 11)]
		public Lookup sgt_speelschemaid
		{
			get
			{
				return this.sgt_speelschemaidField;
			}
			set
			{
				this.sgt_speelschemaidField = value;
				base.RaisePropertyChanged("sgt_speelschemaid");
			}
		}
		[XmlElement("sgt_toe_ronde_poule", Order = 12)]
		public string sgt_toe_ronde_poule1
		{
			get
			{
				return this.sgt_toe_ronde_poule1Field;
			}
			set
			{
				this.sgt_toe_ronde_poule1Field = value;
				base.RaisePropertyChanged("sgt_toe_ronde_poule1");
			}
		}
		[XmlElement(Order = 13)]
		public Key sgt_toe_ronde_pouleid
		{
			get
			{
				return this.sgt_toe_ronde_pouleidField;
			}
			set
			{
				this.sgt_toe_ronde_pouleidField = value;
				base.RaisePropertyChanged("sgt_toe_ronde_pouleid");
			}
		}
		[XmlElement(Order = 14)]
		public Picklist sgt_type_ronde
		{
			get
			{
				return this.sgt_type_rondeField;
			}
			set
			{
				this.sgt_type_rondeField = value;
				base.RaisePropertyChanged("sgt_type_ronde");
			}
		}
		[XmlElement(Order = 15)]
		public string sgt_volgnummer_ronde_poule
		{
			get
			{
				return this.sgt_volgnummer_ronde_pouleField;
			}
			set
			{
				this.sgt_volgnummer_ronde_pouleField = value;
				base.RaisePropertyChanged("sgt_volgnummer_ronde_poule");
			}
		}
		[XmlElement(Order = 16)]
		public Sgt_toe_ronde_pouleStateInfo statecode
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
