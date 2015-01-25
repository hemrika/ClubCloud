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
	public class SetStateSgt_com_toegepast_speelschemaRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_com_toegepast_speelschemaState sgt_com_toegepast_speelschemaStateField;

		private int sgt_com_toegepast_speelschemaStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_com_toegepast_speelschemaState Sgt_com_toegepast_speelschemaState
		{
			get
			{
				return this.sgt_com_toegepast_speelschemaStateField;
			}
			set
			{
				this.sgt_com_toegepast_speelschemaStateField = value;
				base.RaisePropertyChanged("Sgt_com_toegepast_speelschemaState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_com_toegepast_speelschemaStatus
		{
			get
			{
				return this.sgt_com_toegepast_speelschemaStatusField;
			}
			set
			{
				this.sgt_com_toegepast_speelschemaStatusField = value;
				base.RaisePropertyChanged("Sgt_com_toegepast_speelschemaStatus");
			}
		}

		public SetStateSgt_com_toegepast_speelschemaRequest()
		{
		}
	}
}