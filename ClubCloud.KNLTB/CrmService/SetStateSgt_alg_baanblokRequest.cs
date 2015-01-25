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
	public class SetStateSgt_alg_baanblokRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_baanblokState sgt_alg_baanblokStateField;

		private int sgt_alg_baanblokStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_baanblokState Sgt_alg_baanblokState
		{
			get
			{
				return this.sgt_alg_baanblokStateField;
			}
			set
			{
				this.sgt_alg_baanblokStateField = value;
				base.RaisePropertyChanged("Sgt_alg_baanblokState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_alg_baanblokStatus
		{
			get
			{
				return this.sgt_alg_baanblokStatusField;
			}
			set
			{
				this.sgt_alg_baanblokStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_baanblokStatus");
			}
		}

		public SetStateSgt_alg_baanblokRequest()
		{
		}
	}
}