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
	public class SetStateSgt_toe_afwezigheid_bondsgedelegeerdeRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_afwezigheid_bondsgedelegeerdeState sgt_toe_afwezigheid_bondsgedelegeerdeStateField;

		private int sgt_toe_afwezigheid_bondsgedelegeerdeStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_afwezigheid_bondsgedelegeerdeState Sgt_toe_afwezigheid_bondsgedelegeerdeState
		{
			get
			{
				return this.sgt_toe_afwezigheid_bondsgedelegeerdeStateField;
			}
			set
			{
				this.sgt_toe_afwezigheid_bondsgedelegeerdeStateField = value;
				base.RaisePropertyChanged("Sgt_toe_afwezigheid_bondsgedelegeerdeState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_toe_afwezigheid_bondsgedelegeerdeStatus
		{
			get
			{
				return this.sgt_toe_afwezigheid_bondsgedelegeerdeStatusField;
			}
			set
			{
				this.sgt_toe_afwezigheid_bondsgedelegeerdeStatusField = value;
				base.RaisePropertyChanged("Sgt_toe_afwezigheid_bondsgedelegeerdeStatus");
			}
		}

		public SetStateSgt_toe_afwezigheid_bondsgedelegeerdeRequest()
		{
		}
	}
}