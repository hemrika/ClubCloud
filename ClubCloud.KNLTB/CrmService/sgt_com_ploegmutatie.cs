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
	public class sgt_com_ploegmutatie : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private CrmDateTime overriddencreatedonField;

		private Owner owneridField;

		private Lookup owningbusinessunitField;

		private Lookup sgt_afdelinga_ploegidField;

		private Lookup sgt_afdelingaidField;

		private Lookup sgt_afdelingb_ploegidField;

		private Lookup sgt_afdelingbidField;

		private string sgt_com_naamField;

		private Key sgt_com_ploegmutatieidField;

		private Lookup sgt_competitieidField;

		private Lookup sgt_klassegroepidField;

		private Picklist sgt_mutatietypeField;

		private Lookup sgt_piramideidField;

		private Sgt_com_ploegmutatieStateInfo statecodeField;

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
		public Lookup sgt_afdelinga_ploegid
		{
			get
			{
				return this.sgt_afdelinga_ploegidField;
			}
			set
			{
				this.sgt_afdelinga_ploegidField = value;
				base.RaisePropertyChanged("sgt_afdelinga_ploegid");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public Lookup sgt_afdelingaid
		{
			get
			{
				return this.sgt_afdelingaidField;
			}
			set
			{
				this.sgt_afdelingaidField = value;
				base.RaisePropertyChanged("sgt_afdelingaid");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public Lookup sgt_afdelingb_ploegid
		{
			get
			{
				return this.sgt_afdelingb_ploegidField;
			}
			set
			{
				this.sgt_afdelingb_ploegidField = value;
				base.RaisePropertyChanged("sgt_afdelingb_ploegid");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public Lookup sgt_afdelingbid
		{
			get
			{
				return this.sgt_afdelingbidField;
			}
			set
			{
				this.sgt_afdelingbidField = value;
				base.RaisePropertyChanged("sgt_afdelingbid");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public string sgt_com_naam
		{
			get
			{
				return this.sgt_com_naamField;
			}
			set
			{
				this.sgt_com_naamField = value;
				base.RaisePropertyChanged("sgt_com_naam");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public Key sgt_com_ploegmutatieid
		{
			get
			{
				return this.sgt_com_ploegmutatieidField;
			}
			set
			{
				this.sgt_com_ploegmutatieidField = value;
				base.RaisePropertyChanged("sgt_com_ploegmutatieid");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public Lookup sgt_competitieid
		{
			get
			{
				return this.sgt_competitieidField;
			}
			set
			{
				this.sgt_competitieidField = value;
				base.RaisePropertyChanged("sgt_competitieid");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public Lookup sgt_klassegroepid
		{
			get
			{
				return this.sgt_klassegroepidField;
			}
			set
			{
				this.sgt_klassegroepidField = value;
				base.RaisePropertyChanged("sgt_klassegroepid");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public Picklist sgt_mutatietype
		{
			get
			{
				return this.sgt_mutatietypeField;
			}
			set
			{
				this.sgt_mutatietypeField = value;
				base.RaisePropertyChanged("sgt_mutatietype");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
		public Lookup sgt_piramideid
		{
			get
			{
				return this.sgt_piramideidField;
			}
			set
			{
				this.sgt_piramideidField = value;
				base.RaisePropertyChanged("sgt_piramideid");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
		public Sgt_com_ploegmutatieStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=19)]
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

		[XmlElement] //[XmlElement(Order=20)]
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

		[XmlElement] //[XmlElement(Order=21)]
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

		public sgt_com_ploegmutatie()
		{
		}
	}
}