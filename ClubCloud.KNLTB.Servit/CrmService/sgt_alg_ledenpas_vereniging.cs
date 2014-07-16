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
	public class sgt_alg_ledenpas_vereniging : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private CrmDateTime overriddencreatedonField;

		private Owner owneridField;

		private Lookup owningbusinessunitField;

		private CrmBoolean sgt_aangemaakt_door_verrijkingField;

		private Key sgt_alg_ledenpas_verenigingidField;

		private string sgt_alg_naamField;

		private Lookup sgt_bericht_passen_naar_idField;

		private CrmNumber sgt_export_aantal_leden_foutField;

		private CrmNumber sgt_export_aantal_leden_goedField;

		private Lookup sgt_ledenpas_logboek_idField;

		private Lookup sgt_vereniging_idField;

		private Sgt_alg_ledenpas_verenigingStateInfo statecodeField;

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
		public CrmBoolean sgt_aangemaakt_door_verrijking
		{
			get
			{
				return this.sgt_aangemaakt_door_verrijkingField;
			}
			set
			{
				this.sgt_aangemaakt_door_verrijkingField = value;
				base.RaisePropertyChanged("sgt_aangemaakt_door_verrijking");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public Key sgt_alg_ledenpas_verenigingid
		{
			get
			{
				return this.sgt_alg_ledenpas_verenigingidField;
			}
			set
			{
				this.sgt_alg_ledenpas_verenigingidField = value;
				base.RaisePropertyChanged("sgt_alg_ledenpas_verenigingid");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public string sgt_alg_naam
		{
			get
			{
				return this.sgt_alg_naamField;
			}
			set
			{
				this.sgt_alg_naamField = value;
				base.RaisePropertyChanged("sgt_alg_naam");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public Lookup sgt_bericht_passen_naar_id
		{
			get
			{
				return this.sgt_bericht_passen_naar_idField;
			}
			set
			{
				this.sgt_bericht_passen_naar_idField = value;
				base.RaisePropertyChanged("sgt_bericht_passen_naar_id");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public CrmNumber sgt_export_aantal_leden_fout
		{
			get
			{
				return this.sgt_export_aantal_leden_foutField;
			}
			set
			{
				this.sgt_export_aantal_leden_foutField = value;
				base.RaisePropertyChanged("sgt_export_aantal_leden_fout");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public CrmNumber sgt_export_aantal_leden_goed
		{
			get
			{
				return this.sgt_export_aantal_leden_goedField;
			}
			set
			{
				this.sgt_export_aantal_leden_goedField = value;
				base.RaisePropertyChanged("sgt_export_aantal_leden_goed");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public Lookup sgt_ledenpas_logboek_id
		{
			get
			{
				return this.sgt_ledenpas_logboek_idField;
			}
			set
			{
				this.sgt_ledenpas_logboek_idField = value;
				base.RaisePropertyChanged("sgt_ledenpas_logboek_id");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public Lookup sgt_vereniging_id
		{
			get
			{
				return this.sgt_vereniging_idField;
			}
			set
			{
				this.sgt_vereniging_idField = value;
				base.RaisePropertyChanged("sgt_vereniging_id");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public Sgt_alg_ledenpas_verenigingStateInfo statecode
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

		public sgt_alg_ledenpas_vereniging()
		{
		}
	}
}