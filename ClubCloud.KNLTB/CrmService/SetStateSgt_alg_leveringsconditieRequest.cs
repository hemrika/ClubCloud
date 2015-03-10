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
	public class SetStateSgt_alg_leveringsconditieRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_leveringsconditieState sgt_alg_leveringsconditieStateField;

		private int sgt_alg_leveringsconditieStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_leveringsconditieState Sgt_alg_leveringsconditieState
		{
			get
			{
				return this.sgt_alg_leveringsconditieStateField;
			}
			set
			{
				this.sgt_alg_leveringsconditieStateField = value;
				base.RaisePropertyChanged("Sgt_alg_leveringsconditieState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_alg_leveringsconditieStatus
		{
			get
			{
				return this.sgt_alg_leveringsconditieStatusField;
			}
			set
			{
				this.sgt_alg_leveringsconditieStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_leveringsconditieStatus");
			}
		}

		public SetStateSgt_alg_leveringsconditieRequest()
		{
		}
	}
}