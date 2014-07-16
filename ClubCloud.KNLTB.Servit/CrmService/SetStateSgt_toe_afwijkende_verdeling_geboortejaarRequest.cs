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
	public class SetStateSgt_toe_afwijkende_verdeling_geboortejaarRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_afwijkende_verdeling_geboortejaarState sgt_toe_afwijkende_verdeling_geboortejaarStateField;

		private int sgt_toe_afwijkende_verdeling_geboortejaarStatusField;

		[XmlElement] //[XmlElement(Order=0)]
		public Guid EntityId
		{
			get
			{
				return this.entityIdField;
			}
			set
			{
				this.entityIdField = value;
				base.RaisePropertyChanged("EntityId");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_afwijkende_verdeling_geboortejaarState Sgt_toe_afwijkende_verdeling_geboortejaarState
		{
			get
			{
				return this.sgt_toe_afwijkende_verdeling_geboortejaarStateField;
			}
			set
			{
				this.sgt_toe_afwijkende_verdeling_geboortejaarStateField = value;
				base.RaisePropertyChanged("Sgt_toe_afwijkende_verdeling_geboortejaarState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_toe_afwijkende_verdeling_geboortejaarStatus
		{
			get
			{
				return this.sgt_toe_afwijkende_verdeling_geboortejaarStatusField;
			}
			set
			{
				this.sgt_toe_afwijkende_verdeling_geboortejaarStatusField = value;
				base.RaisePropertyChanged("Sgt_toe_afwijkende_verdeling_geboortejaarStatus");
			}
		}

		public SetStateSgt_toe_afwijkende_verdeling_geboortejaarRequest()
		{
		}
	}
}