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
	public class SetStateSgt_rol_verbergen_entiteitRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_rol_verbergen_entiteitState sgt_rol_verbergen_entiteitStateField;

		private int sgt_rol_verbergen_entiteitStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_rol_verbergen_entiteitState Sgt_rol_verbergen_entiteitState
		{
			get
			{
				return this.sgt_rol_verbergen_entiteitStateField;
			}
			set
			{
				this.sgt_rol_verbergen_entiteitStateField = value;
				base.RaisePropertyChanged("Sgt_rol_verbergen_entiteitState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_rol_verbergen_entiteitStatus
		{
			get
			{
				return this.sgt_rol_verbergen_entiteitStatusField;
			}
			set
			{
				this.sgt_rol_verbergen_entiteitStatusField = value;
				base.RaisePropertyChanged("Sgt_rol_verbergen_entiteitStatus");
			}
		}

		public SetStateSgt_rol_verbergen_entiteitRequest()
		{
		}
	}
}