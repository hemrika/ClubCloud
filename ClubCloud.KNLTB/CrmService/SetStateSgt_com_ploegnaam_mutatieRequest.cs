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
	public class SetStateSgt_com_ploegnaam_mutatieRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_com_ploegnaam_mutatieState sgt_com_ploegnaam_mutatieStateField;

		private int sgt_com_ploegnaam_mutatieStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_com_ploegnaam_mutatieState Sgt_com_ploegnaam_mutatieState
		{
			get
			{
				return this.sgt_com_ploegnaam_mutatieStateField;
			}
			set
			{
				this.sgt_com_ploegnaam_mutatieStateField = value;
				base.RaisePropertyChanged("Sgt_com_ploegnaam_mutatieState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_com_ploegnaam_mutatieStatus
		{
			get
			{
				return this.sgt_com_ploegnaam_mutatieStatusField;
			}
			set
			{
				this.sgt_com_ploegnaam_mutatieStatusField = value;
				base.RaisePropertyChanged("Sgt_com_ploegnaam_mutatieStatus");
			}
		}

		public SetStateSgt_com_ploegnaam_mutatieRequest()
		{
		}
	}
}