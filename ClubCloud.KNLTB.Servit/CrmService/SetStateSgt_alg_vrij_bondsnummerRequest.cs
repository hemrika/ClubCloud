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
	public class SetStateSgt_alg_vrij_bondsnummerRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_vrij_bondsnummerState sgt_alg_vrij_bondsnummerStateField;

		private int sgt_alg_vrij_bondsnummerStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_vrij_bondsnummerState Sgt_alg_vrij_bondsnummerState
		{
			get
			{
				return this.sgt_alg_vrij_bondsnummerStateField;
			}
			set
			{
				this.sgt_alg_vrij_bondsnummerStateField = value;
				base.RaisePropertyChanged("Sgt_alg_vrij_bondsnummerState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_alg_vrij_bondsnummerStatus
		{
			get
			{
				return this.sgt_alg_vrij_bondsnummerStatusField;
			}
			set
			{
				this.sgt_alg_vrij_bondsnummerStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_vrij_bondsnummerStatus");
			}
		}

		public SetStateSgt_alg_vrij_bondsnummerRequest()
		{
		}
	}
}