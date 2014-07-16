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
	public class sgt_top_groepsevenement_begeleiding : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private CrmDateTime overriddencreatedonField;

		private Owner owneridField;

		private Lookup owningbusinessunitField;

		private Lookup sgt_begeleideridField;

		private Lookup sgt_groepidField;

		private Lookup sgt_groepsevenementidField;

		private string sgt_opmerkingField;

		private string sgt_top_groepsevenement_begeleiding1Field;

		private Key sgt_top_groepsevenement_begeleidingidField;

		private Sgt_top_groepsevenement_begeleidingStateInfo statecodeField;

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
		public Lookup sgt_begeleiderid
		{
			get
			{
				return this.sgt_begeleideridField;
			}
			set
			{
				this.sgt_begeleideridField = value;
				base.RaisePropertyChanged("sgt_begeleiderid");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public Lookup sgt_groepid
		{
			get
			{
				return this.sgt_groepidField;
			}
			set
			{
				this.sgt_groepidField = value;
				base.RaisePropertyChanged("sgt_groepid");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public Lookup sgt_groepsevenementid
		{
			get
			{
				return this.sgt_groepsevenementidField;
			}
			set
			{
				this.sgt_groepsevenementidField = value;
				base.RaisePropertyChanged("sgt_groepsevenementid");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
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

		[XmlElement("sgt_top_groepsevenement_begeleiding")] //, Order=12)]
		public string sgt_top_groepsevenement_begeleiding1
		{
			get
			{
				return this.sgt_top_groepsevenement_begeleiding1Field;
			}
			set
			{
				this.sgt_top_groepsevenement_begeleiding1Field = value;
				base.RaisePropertyChanged("sgt_top_groepsevenement_begeleiding1");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public Key sgt_top_groepsevenement_begeleidingid
		{
			get
			{
				return this.sgt_top_groepsevenement_begeleidingidField;
			}
			set
			{
				this.sgt_top_groepsevenement_begeleidingidField = value;
				base.RaisePropertyChanged("sgt_top_groepsevenement_begeleidingid");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public Sgt_top_groepsevenement_begeleidingStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=15)]
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

		[XmlElement] //[XmlElement(Order=16)]
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

		[XmlElement] //[XmlElement(Order=17)]
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

		public sgt_top_groepsevenement_begeleiding()
		{
		}
	}
}