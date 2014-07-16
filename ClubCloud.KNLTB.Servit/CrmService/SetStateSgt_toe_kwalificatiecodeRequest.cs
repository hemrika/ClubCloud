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
	public class SetStateSgt_toe_kwalificatiecodeRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_kwalificatiecodeState sgt_toe_kwalificatiecodeStateField;

		private int sgt_toe_kwalificatiecodeStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_kwalificatiecodeState Sgt_toe_kwalificatiecodeState
		{
			get
			{
				return this.sgt_toe_kwalificatiecodeStateField;
			}
			set
			{
				this.sgt_toe_kwalificatiecodeStateField = value;
				base.RaisePropertyChanged("Sgt_toe_kwalificatiecodeState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_toe_kwalificatiecodeStatus
		{
			get
			{
				return this.sgt_toe_kwalificatiecodeStatusField;
			}
			set
			{
				this.sgt_toe_kwalificatiecodeStatusField = value;
				base.RaisePropertyChanged("Sgt_toe_kwalificatiecodeStatus");
			}
		}

		public SetStateSgt_toe_kwalificatiecodeRequest()
		{
		}
	}
}