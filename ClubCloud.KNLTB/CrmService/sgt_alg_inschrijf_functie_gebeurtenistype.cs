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
	public class sgt_alg_inschrijf_functie_gebeurtenistype : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private Lookup organizationidField;

		private CrmDateTime overriddencreatedonField;

		private Key sgt_alg_inschrijf_functie_gebeurtenistypeidField;

		private string sgt_alg_nameField;

		private CrmBoolean sgt_andere_personen_inschrijvenField;

		private Lookup sgt_functie_idField;

		private Lookup sgt_gebeurtenistype_idField;

		private Picklist sgt_vereniging_of_iedereenField;

		private Sgt_alg_inschrijf_functie_gebeurtenistypeStateInfo statecodeField;

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
		public Lookup organizationid
		{
			get
			{
				return this.organizationidField;
			}
			set
			{
				this.organizationidField = value;
				base.RaisePropertyChanged("organizationid");
			}
		}

		[XmlElement] //[XmlElement(Order=6)]
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

		[XmlElement] //[XmlElement(Order=7)]
		public Key sgt_alg_inschrijf_functie_gebeurtenistypeid
		{
			get
			{
				return this.sgt_alg_inschrijf_functie_gebeurtenistypeidField;
			}
			set
			{
				this.sgt_alg_inschrijf_functie_gebeurtenistypeidField = value;
				base.RaisePropertyChanged("sgt_alg_inschrijf_functie_gebeurtenistypeid");
			}
		}

		[XmlElement] //[XmlElement(Order=8)]
		public string sgt_alg_name
		{
			get
			{
				return this.sgt_alg_nameField;
			}
			set
			{
				this.sgt_alg_nameField = value;
				base.RaisePropertyChanged("sgt_alg_name");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public CrmBoolean sgt_andere_personen_inschrijven
		{
			get
			{
				return this.sgt_andere_personen_inschrijvenField;
			}
			set
			{
				this.sgt_andere_personen_inschrijvenField = value;
				base.RaisePropertyChanged("sgt_andere_personen_inschrijven");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public Lookup sgt_functie_id
		{
			get
			{
				return this.sgt_functie_idField;
			}
			set
			{
				this.sgt_functie_idField = value;
				base.RaisePropertyChanged("sgt_functie_id");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public Lookup sgt_gebeurtenistype_id
		{
			get
			{
				return this.sgt_gebeurtenistype_idField;
			}
			set
			{
				this.sgt_gebeurtenistype_idField = value;
				base.RaisePropertyChanged("sgt_gebeurtenistype_id");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public Picklist sgt_vereniging_of_iedereen
		{
			get
			{
				return this.sgt_vereniging_of_iedereenField;
			}
			set
			{
				this.sgt_vereniging_of_iedereenField = value;
				base.RaisePropertyChanged("sgt_vereniging_of_iedereen");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public Sgt_alg_inschrijf_functie_gebeurtenistypeStateInfo statecode
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

		public sgt_alg_inschrijf_functie_gebeurtenistype()
		{
		}
	}
}