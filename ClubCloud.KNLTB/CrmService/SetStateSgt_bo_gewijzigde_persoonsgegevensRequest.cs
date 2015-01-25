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
	public class SetStateSgt_bo_gewijzigde_persoonsgegevensRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_bo_gewijzigde_persoonsgegevensState sgt_bo_gewijzigde_persoonsgegevensStateField;

		private int sgt_bo_gewijzigde_persoonsgegevensStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_bo_gewijzigde_persoonsgegevensState Sgt_bo_gewijzigde_persoonsgegevensState
		{
			get
			{
				return this.sgt_bo_gewijzigde_persoonsgegevensStateField;
			}
			set
			{
				this.sgt_bo_gewijzigde_persoonsgegevensStateField = value;
				base.RaisePropertyChanged("Sgt_bo_gewijzigde_persoonsgegevensState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_bo_gewijzigde_persoonsgegevensStatus
		{
			get
			{
				return this.sgt_bo_gewijzigde_persoonsgegevensStatusField;
			}
			set
			{
				this.sgt_bo_gewijzigde_persoonsgegevensStatusField = value;
				base.RaisePropertyChanged("Sgt_bo_gewijzigde_persoonsgegevensStatus");
			}
		}

		public SetStateSgt_bo_gewijzigde_persoonsgegevensRequest()
		{
		}
	}
}