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
	public class SetStateSgt_rol_verbergen_tabbladen_sectiesRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_rol_verbergen_tabbladen_sectiesState sgt_rol_verbergen_tabbladen_sectiesStateField;

		private int sgt_rol_verbergen_tabbladen_sectiesStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_rol_verbergen_tabbladen_sectiesState Sgt_rol_verbergen_tabbladen_sectiesState
		{
			get
			{
				return this.sgt_rol_verbergen_tabbladen_sectiesStateField;
			}
			set
			{
				this.sgt_rol_verbergen_tabbladen_sectiesStateField = value;
				base.RaisePropertyChanged("Sgt_rol_verbergen_tabbladen_sectiesState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_rol_verbergen_tabbladen_sectiesStatus
		{
			get
			{
				return this.sgt_rol_verbergen_tabbladen_sectiesStatusField;
			}
			set
			{
				this.sgt_rol_verbergen_tabbladen_sectiesStatusField = value;
				base.RaisePropertyChanged("Sgt_rol_verbergen_tabbladen_sectiesStatus");
			}
		}

		public SetStateSgt_rol_verbergen_tabbladen_sectiesRequest()
		{
		}
	}
}