using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[GeneratedCode("System.Xml", "4.0.30319.33440")]
	[Serializable]
	[XmlType(Namespace="http://schemas.microsoft.com/crm/2007/WebServices")]
	public class sgt_toe_leeftijdscat_aanvraagformulier : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private CrmDateTime overriddencreatedonField;

		private Owner owneridField;

		private Lookup owningbusinessunitField;

		private Lookup sgt_aanvr_formulier_dagtoernooi_idField;

		private Lookup sgt_aanvr_formulier_toernooi_idField;

		private Lookup sgt_leeftijdscategorie_idField;

		private Key sgt_toe_leeftijdscat_aanvraagformulieridField;

		private string sgt_toe_nameField;

		private Sgt_toe_leeftijdscat_aanvraagformulierStateInfo statecodeField;

		private Status statuscodeField;

		private CrmNumber timezoneruleversionnumberField;

		private CrmNumber utcconversiontimezonecodeField;

		[XmlElement] //[XmlElement(Order=0)]
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

		[XmlElement] //[XmlElement(Order=1)]
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

		[XmlElement] //[XmlElement(Order=2)]
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

		[XmlElement] //[XmlElement(Order=3)]
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

		[XmlElement] //[XmlElement(Order=4)]
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

		[XmlElement] //[XmlElement(Order=5)]
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

		[XmlElement] //[XmlElement(Order=6)]
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

		[XmlElement] //[XmlElement(Order=7)]
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

		[XmlElement] //[XmlElement(Order=8)]
		public Lookup sgt_aanvr_formulier_dagtoernooi_id
		{
			get
			{
				return this.sgt_aanvr_formulier_dagtoernooi_idField;
			}
			set
			{
				this.sgt_aanvr_formulier_dagtoernooi_idField = value;
				base.RaisePropertyChanged("sgt_aanvr_formulier_dagtoernooi_id");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public Lookup sgt_aanvr_formulier_toernooi_id
		{
			get
			{
				return this.sgt_aanvr_formulier_toernooi_idField;
			}
			set
			{
				this.sgt_aanvr_formulier_toernooi_idField = value;
				base.RaisePropertyChanged("sgt_aanvr_formulier_toernooi_id");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public Lookup sgt_leeftijdscategorie_id
		{
			get
			{
				return this.sgt_leeftijdscategorie_idField;
			}
			set
			{
				this.sgt_leeftijdscategorie_idField = value;
				base.RaisePropertyChanged("sgt_leeftijdscategorie_id");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public Key sgt_toe_leeftijdscat_aanvraagformulierid
		{
			get
			{
				return this.sgt_toe_leeftijdscat_aanvraagformulieridField;
			}
			set
			{
				this.sgt_toe_leeftijdscat_aanvraagformulieridField = value;
				base.RaisePropertyChanged("sgt_toe_leeftijdscat_aanvraagformulierid");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public string sgt_toe_name
		{
			get
			{
				return this.sgt_toe_nameField;
			}
			set
			{
				this.sgt_toe_nameField = value;
				base.RaisePropertyChanged("sgt_toe_name");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public Sgt_toe_leeftijdscat_aanvraagformulierStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=14)]
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

		[XmlElement] //[XmlElement(Order=15)]
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

		[XmlElement] //[XmlElement(Order=16)]
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

		public sgt_toe_leeftijdscat_aanvraagformulier()
		{
		}
	}
}