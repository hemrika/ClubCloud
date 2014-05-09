using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_gebeurtenisgespreksonderwerpRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_gebeurtenisgespreksonderwerpState sgt_alg_gebeurtenisgespreksonderwerpStateField;
		private int sgt_alg_gebeurtenisgespreksonderwerpStatusField;
		[XmlElement(Order = 0)]
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
		[XmlElement(Order = 1)]
		public Sgt_alg_gebeurtenisgespreksonderwerpState Sgt_alg_gebeurtenisgespreksonderwerpState
		{
			get
			{
				return this.sgt_alg_gebeurtenisgespreksonderwerpStateField;
			}
			set
			{
				this.sgt_alg_gebeurtenisgespreksonderwerpStateField = value;
				base.RaisePropertyChanged("Sgt_alg_gebeurtenisgespreksonderwerpState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_alg_gebeurtenisgespreksonderwerpStatus
		{
			get
			{
				return this.sgt_alg_gebeurtenisgespreksonderwerpStatusField;
			}
			set
			{
				this.sgt_alg_gebeurtenisgespreksonderwerpStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_gebeurtenisgespreksonderwerpStatus");
			}
		}
	}
}
