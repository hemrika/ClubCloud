using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_arb_arbitragebehoefte_competitie : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private CrmNumber sgt_aantal_bgField;
		private CrmNumber sgt_aantal_hoofdscheidsrechterField;
		private CrmNumber sgt_aantal_lrField;
		private CrmNumber sgt_aantal_srField;
		private CrmNumber sgt_aantal_tzField;
		private string sgt_arb_arbitragebehoefte_competitie1Field;
		private Key sgt_arb_arbitragebehoefte_competitieidField;
		private Lookup sgt_competitieidField;
		private Picklist sgt_functie_statusField;
		private Lookup sgt_klassegroepidField;
		private Lookup sgt_piramideidField;
		private CrmDateTime sgt_speeldag_datumField;
		private CrmBoolean sgt_speeldag_inhaaldagField;
		private CrmNumber sgt_verwacht_begeleiderField;
		private CrmNumber sgt_verwacht_hoofdscheidsrechterField;
		private CrmNumber sgt_verwacht_lijnrechterField;
		private CrmNumber sgt_verwacht_stoelscheidsrechterField;
		private CrmNumber sgt_verwacht_toezichthouderField;
		private Sgt_arb_arbitragebehoefte_competitieStateInfo statecodeField;
		private Status statuscodeField;
		private CrmNumber timezoneruleversionnumberField;
		private CrmNumber utcconversiontimezonecodeField;
		public Lookup createdby
		{
			get
			{
				return this.createdbyField;
			}
			set
			{
				this.createdbyField = value;
			}
		}
		public CrmDateTime createdon
		{
			get
			{
				return this.createdonField;
			}
			set
			{
				this.createdonField = value;
			}
		}
		public CrmNumber importsequencenumber
		{
			get
			{
				return this.importsequencenumberField;
			}
			set
			{
				this.importsequencenumberField = value;
			}
		}
		public Lookup modifiedby
		{
			get
			{
				return this.modifiedbyField;
			}
			set
			{
				this.modifiedbyField = value;
			}
		}
		public CrmDateTime modifiedon
		{
			get
			{
				return this.modifiedonField;
			}
			set
			{
				this.modifiedonField = value;
			}
		}
		public CrmDateTime overriddencreatedon
		{
			get
			{
				return this.overriddencreatedonField;
			}
			set
			{
				this.overriddencreatedonField = value;
			}
		}
		public Owner ownerid
		{
			get
			{
				return this.owneridField;
			}
			set
			{
				this.owneridField = value;
			}
		}
		public Lookup owningbusinessunit
		{
			get
			{
				return this.owningbusinessunitField;
			}
			set
			{
				this.owningbusinessunitField = value;
			}
		}
		public CrmNumber sgt_aantal_bg
		{
			get
			{
				return this.sgt_aantal_bgField;
			}
			set
			{
				this.sgt_aantal_bgField = value;
			}
		}
		public CrmNumber sgt_aantal_hoofdscheidsrechter
		{
			get
			{
				return this.sgt_aantal_hoofdscheidsrechterField;
			}
			set
			{
				this.sgt_aantal_hoofdscheidsrechterField = value;
			}
		}
		public CrmNumber sgt_aantal_lr
		{
			get
			{
				return this.sgt_aantal_lrField;
			}
			set
			{
				this.sgt_aantal_lrField = value;
			}
		}
		public CrmNumber sgt_aantal_sr
		{
			get
			{
				return this.sgt_aantal_srField;
			}
			set
			{
				this.sgt_aantal_srField = value;
			}
		}
		public CrmNumber sgt_aantal_tz
		{
			get
			{
				return this.sgt_aantal_tzField;
			}
			set
			{
				this.sgt_aantal_tzField = value;
			}
		}
		[XmlElement("sgt_arb_arbitragebehoefte_competitie")]
		public string sgt_arb_arbitragebehoefte_competitie1
		{
			get
			{
				return this.sgt_arb_arbitragebehoefte_competitie1Field;
			}
			set
			{
				this.sgt_arb_arbitragebehoefte_competitie1Field = value;
			}
		}
		public Key sgt_arb_arbitragebehoefte_competitieid
		{
			get
			{
				return this.sgt_arb_arbitragebehoefte_competitieidField;
			}
			set
			{
				this.sgt_arb_arbitragebehoefte_competitieidField = value;
			}
		}
		public Lookup sgt_competitieid
		{
			get
			{
				return this.sgt_competitieidField;
			}
			set
			{
				this.sgt_competitieidField = value;
			}
		}
		public Picklist sgt_functie_status
		{
			get
			{
				return this.sgt_functie_statusField;
			}
			set
			{
				this.sgt_functie_statusField = value;
			}
		}
		public Lookup sgt_klassegroepid
		{
			get
			{
				return this.sgt_klassegroepidField;
			}
			set
			{
				this.sgt_klassegroepidField = value;
			}
		}
		public Lookup sgt_piramideid
		{
			get
			{
				return this.sgt_piramideidField;
			}
			set
			{
				this.sgt_piramideidField = value;
			}
		}
		public CrmDateTime sgt_speeldag_datum
		{
			get
			{
				return this.sgt_speeldag_datumField;
			}
			set
			{
				this.sgt_speeldag_datumField = value;
			}
		}
		public CrmBoolean sgt_speeldag_inhaaldag
		{
			get
			{
				return this.sgt_speeldag_inhaaldagField;
			}
			set
			{
				this.sgt_speeldag_inhaaldagField = value;
			}
		}
		public CrmNumber sgt_verwacht_begeleider
		{
			get
			{
				return this.sgt_verwacht_begeleiderField;
			}
			set
			{
				this.sgt_verwacht_begeleiderField = value;
			}
		}
		public CrmNumber sgt_verwacht_hoofdscheidsrechter
		{
			get
			{
				return this.sgt_verwacht_hoofdscheidsrechterField;
			}
			set
			{
				this.sgt_verwacht_hoofdscheidsrechterField = value;
			}
		}
		public CrmNumber sgt_verwacht_lijnrechter
		{
			get
			{
				return this.sgt_verwacht_lijnrechterField;
			}
			set
			{
				this.sgt_verwacht_lijnrechterField = value;
			}
		}
		public CrmNumber sgt_verwacht_stoelscheidsrechter
		{
			get
			{
				return this.sgt_verwacht_stoelscheidsrechterField;
			}
			set
			{
				this.sgt_verwacht_stoelscheidsrechterField = value;
			}
		}
		public CrmNumber sgt_verwacht_toezichthouder
		{
			get
			{
				return this.sgt_verwacht_toezichthouderField;
			}
			set
			{
				this.sgt_verwacht_toezichthouderField = value;
			}
		}
		public Sgt_arb_arbitragebehoefte_competitieStateInfo statecode
		{
			get
			{
				return this.statecodeField;
			}
			set
			{
				this.statecodeField = value;
			}
		}
		public Status statuscode
		{
			get
			{
				return this.statuscodeField;
			}
			set
			{
				this.statuscodeField = value;
			}
		}
		public CrmNumber timezoneruleversionnumber
		{
			get
			{
				return this.timezoneruleversionnumberField;
			}
			set
			{
				this.timezoneruleversionnumberField = value;
			}
		}
		public CrmNumber utcconversiontimezonecode
		{
			get
			{
				return this.utcconversiontimezonecodeField;
			}
			set
			{
				this.utcconversiontimezonecodeField = value;
			}
		}
	}
}
