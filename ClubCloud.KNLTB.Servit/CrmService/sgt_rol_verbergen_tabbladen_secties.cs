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
	public class sgt_rol_verbergen_tabbladen_secties : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private CrmDateTime overriddencreatedonField;

		private Owner owneridField;

		private Lookup owningbusinessunitField;

		private string sgt_naam_entiteitField;

		private string sgt_naam_sectieField;

		private string sgt_naam_tabbladField;

		private string sgt_nameField;

		private Lookup sgt_primaire_rolidField;

		private Lookup sgt_rol_verbergen_entiteitidField;

		private Key sgt_rol_verbergen_tabbladen_sectiesidField;

		private Lookup sgt_rolnaamidField;

		private Sgt_rol_verbergen_tabbladen_sectiesStateInfo statecodeField;

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
		public string sgt_naam_entiteit
		{
			get
			{
				return this.sgt_naam_entiteitField;
			}
			set
			{
				this.sgt_naam_entiteitField = value;
				base.RaisePropertyChanged("sgt_naam_entiteit");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public string sgt_naam_sectie
		{
			get
			{
				return this.sgt_naam_sectieField;
			}
			set
			{
				this.sgt_naam_sectieField = value;
				base.RaisePropertyChanged("sgt_naam_sectie");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public string sgt_naam_tabblad
		{
			get
			{
				return this.sgt_naam_tabbladField;
			}
			set
			{
				this.sgt_naam_tabbladField = value;
				base.RaisePropertyChanged("sgt_naam_tabblad");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public string sgt_name
		{
			get
			{
				return this.sgt_nameField;
			}
			set
			{
				this.sgt_nameField = value;
				base.RaisePropertyChanged("sgt_name");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public Lookup sgt_primaire_rolid
		{
			get
			{
				return this.sgt_primaire_rolidField;
			}
			set
			{
				this.sgt_primaire_rolidField = value;
				base.RaisePropertyChanged("sgt_primaire_rolid");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public Lookup sgt_rol_verbergen_entiteitid
		{
			get
			{
				return this.sgt_rol_verbergen_entiteitidField;
			}
			set
			{
				this.sgt_rol_verbergen_entiteitidField = value;
				base.RaisePropertyChanged("sgt_rol_verbergen_entiteitid");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public Key sgt_rol_verbergen_tabbladen_sectiesid
		{
			get
			{
				return this.sgt_rol_verbergen_tabbladen_sectiesidField;
			}
			set
			{
				this.sgt_rol_verbergen_tabbladen_sectiesidField = value;
				base.RaisePropertyChanged("sgt_rol_verbergen_tabbladen_sectiesid");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public Lookup sgt_rolnaamid
		{
			get
			{
				return this.sgt_rolnaamidField;
			}
			set
			{
				this.sgt_rolnaamidField = value;
				base.RaisePropertyChanged("sgt_rolnaamid");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public Sgt_rol_verbergen_tabbladen_sectiesStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=17)]
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

		[XmlElement] //[XmlElement(Order=18)]
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

		[XmlElement] //[XmlElement(Order=19)]
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

		public sgt_rol_verbergen_tabbladen_secties()
		{
		}
	}
}