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
	public class SetStateSgt_toe_ranglijstpuntenRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_ranglijstpuntenState sgt_toe_ranglijstpuntenStateField;

		private int sgt_toe_ranglijstpuntenStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_ranglijstpuntenState Sgt_toe_ranglijstpuntenState
		{
			get
			{
				return this.sgt_toe_ranglijstpuntenStateField;
			}
			set
			{
				this.sgt_toe_ranglijstpuntenStateField = value;
				base.RaisePropertyChanged("Sgt_toe_ranglijstpuntenState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_toe_ranglijstpuntenStatus
		{
			get
			{
				return this.sgt_toe_ranglijstpuntenStatusField;
			}
			set
			{
				this.sgt_toe_ranglijstpuntenStatusField = value;
				base.RaisePropertyChanged("Sgt_toe_ranglijstpuntenStatus");
			}
		}

		public SetStateSgt_toe_ranglijstpuntenRequest()
		{
		}
	}
}