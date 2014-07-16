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
	public class SetStateSgt_alg_rol_pers_relatieRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_rol_pers_relatieState sgt_alg_rol_pers_relatieStateField;

		private int sgt_alg_rol_pers_relatieStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_rol_pers_relatieState Sgt_alg_rol_pers_relatieState
		{
			get
			{
				return this.sgt_alg_rol_pers_relatieStateField;
			}
			set
			{
				this.sgt_alg_rol_pers_relatieStateField = value;
				base.RaisePropertyChanged("Sgt_alg_rol_pers_relatieState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_alg_rol_pers_relatieStatus
		{
			get
			{
				return this.sgt_alg_rol_pers_relatieStatusField;
			}
			set
			{
				this.sgt_alg_rol_pers_relatieStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_rol_pers_relatieStatus");
			}
		}

		public SetStateSgt_alg_rol_pers_relatieRequest()
		{
		}
	}
}