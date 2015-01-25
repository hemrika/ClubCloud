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
	public class SetStateSgt_com_reden_niet_gespeeldRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_com_reden_niet_gespeeldState sgt_com_reden_niet_gespeeldStateField;

		private int sgt_com_reden_niet_gespeeldStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_com_reden_niet_gespeeldState Sgt_com_reden_niet_gespeeldState
		{
			get
			{
				return this.sgt_com_reden_niet_gespeeldStateField;
			}
			set
			{
				this.sgt_com_reden_niet_gespeeldStateField = value;
				base.RaisePropertyChanged("Sgt_com_reden_niet_gespeeldState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_com_reden_niet_gespeeldStatus
		{
			get
			{
				return this.sgt_com_reden_niet_gespeeldStatusField;
			}
			set
			{
				this.sgt_com_reden_niet_gespeeldStatusField = value;
				base.RaisePropertyChanged("Sgt_com_reden_niet_gespeeldStatus");
			}
		}

		public SetStateSgt_com_reden_niet_gespeeldRequest()
		{
		}
	}
}