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
	public class SetStateSgt_com_ploegmutatieRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_com_ploegmutatieState sgt_com_ploegmutatieStateField;

		private int sgt_com_ploegmutatieStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_com_ploegmutatieState Sgt_com_ploegmutatieState
		{
			get
			{
				return this.sgt_com_ploegmutatieStateField;
			}
			set
			{
				this.sgt_com_ploegmutatieStateField = value;
				base.RaisePropertyChanged("Sgt_com_ploegmutatieState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_com_ploegmutatieStatus
		{
			get
			{
				return this.sgt_com_ploegmutatieStatusField;
			}
			set
			{
				this.sgt_com_ploegmutatieStatusField = value;
				base.RaisePropertyChanged("Sgt_com_ploegmutatieStatus");
			}
		}

		public SetStateSgt_com_ploegmutatieRequest()
		{
		}
	}
}