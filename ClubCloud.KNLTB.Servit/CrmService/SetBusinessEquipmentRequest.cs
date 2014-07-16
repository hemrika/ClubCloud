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
	public class SetBusinessEquipmentRequest : Request
	{
		private Guid equipmentIdField;

		private Guid businessUnitIdField;

		[XmlElement] //[XmlElement(Order=1)]
		public Guid BusinessUnitId
		{
			get
			{
				return this.businessUnitIdField;
			}
			set
			{
				this.businessUnitIdField = value;
				base.RaisePropertyChanged("BusinessUnitId");
			}
		}

		[XmlElement] //[XmlElement(Order=0)]
		public Guid EquipmentId
		{
			get
			{
				return this.equipmentIdField;
			}
			set
			{
				this.equipmentIdField = value;
				base.RaisePropertyChanged("EquipmentId");
			}
		}

		public SetBusinessEquipmentRequest()
		{
		}
	}
}