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
	public class SetStateSgt_alg_nationaliteitRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_nationaliteitState sgt_alg_nationaliteitStateField;

		private int sgt_alg_nationaliteitStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_nationaliteitState Sgt_alg_nationaliteitState
		{
			get
			{
				return this.sgt_alg_nationaliteitStateField;
			}
			set
			{
				this.sgt_alg_nationaliteitStateField = value;
				base.RaisePropertyChanged("Sgt_alg_nationaliteitState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_alg_nationaliteitStatus
		{
			get
			{
				return this.sgt_alg_nationaliteitStatusField;
			}
			set
			{
				this.sgt_alg_nationaliteitStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_nationaliteitStatus");
			}
		}

		public SetStateSgt_alg_nationaliteitRequest()
		{
		}
	}
}