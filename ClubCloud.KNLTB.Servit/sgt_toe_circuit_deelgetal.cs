using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_toe_circuit_deelgetal : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private Lookup organizationidField;
		private CrmDateTime overriddencreatedonField;
		private Lookup sgt_circuitidField;
		private CrmDecimal sgt_deelgetalField;
		private string sgt_toe_circuit_deelgetal1Field;
		private Key sgt_toe_circuit_deelgetalidField;
		private CrmNumber sgt_toernooien_tmField;
		private CrmNumber sgt_toernooien_vanafField;
		private Sgt_toe_circuit_deelgetalStateInfo statecodeField;
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
		[XmlElement(Order = 6)]
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
		[XmlElement(Order = 7)]
		public Lookup sgt_circuitid
		{
			get
			{
				return this.sgt_circuitidField;
			}
			set
			{
				this.sgt_circuitidField = value;
				base.RaisePropertyChanged("sgt_circuitid");
			}
		}
		[XmlElement(Order = 8)]
		public CrmDecimal sgt_deelgetal
		{
			get
			{
				return this.sgt_deelgetalField;
			}
			set
			{
				this.sgt_deelgetalField = value;
				base.RaisePropertyChanged("sgt_deelgetal");
			}
		}
		[XmlElement("sgt_toe_circuit_deelgetal", Order = 9)]
		public string sgt_toe_circuit_deelgetal1
		{
			get
			{
				return this.sgt_toe_circuit_deelgetal1Field;
			}
			set
			{
				this.sgt_toe_circuit_deelgetal1Field = value;
				base.RaisePropertyChanged("sgt_toe_circuit_deelgetal1");
			}
		}
		[XmlElement(Order = 10)]
		public Key sgt_toe_circuit_deelgetalid
		{
			get
			{
				return this.sgt_toe_circuit_deelgetalidField;
			}
			set
			{
				this.sgt_toe_circuit_deelgetalidField = value;
				base.RaisePropertyChanged("sgt_toe_circuit_deelgetalid");
			}
		}
		[XmlElement(Order = 11)]
		public CrmNumber sgt_toernooien_tm
		{
			get
			{
				return this.sgt_toernooien_tmField;
			}
			set
			{
				this.sgt_toernooien_tmField = value;
				base.RaisePropertyChanged("sgt_toernooien_tm");
			}
		}
		[XmlElement(Order = 12)]
		public CrmNumber sgt_toernooien_vanaf
		{
			get
			{
				return this.sgt_toernooien_vanafField;
			}
			set
			{
				this.sgt_toernooien_vanafField = value;
				base.RaisePropertyChanged("sgt_toernooien_vanaf");
			}
		}
		[XmlElement(Order = 13)]
		public Sgt_toe_circuit_deelgetalStateInfo statecode
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
		[XmlElement(Order = 14)]
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
		[XmlElement(Order = 15)]
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
		[XmlElement(Order = 16)]
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
