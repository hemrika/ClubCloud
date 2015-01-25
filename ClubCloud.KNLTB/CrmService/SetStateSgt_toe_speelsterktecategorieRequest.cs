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
	public class SetStateSgt_toe_speelsterktecategorieRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_speelsterktecategorieState sgt_toe_speelsterktecategorieStateField;

		private int sgt_toe_speelsterktecategorieStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_speelsterktecategorieState Sgt_toe_speelsterktecategorieState
		{
			get
			{
				return this.sgt_toe_speelsterktecategorieStateField;
			}
			set
			{
				this.sgt_toe_speelsterktecategorieStateField = value;
				base.RaisePropertyChanged("Sgt_toe_speelsterktecategorieState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_toe_speelsterktecategorieStatus
		{
			get
			{
				return this.sgt_toe_speelsterktecategorieStatusField;
			}
			set
			{
				this.sgt_toe_speelsterktecategorieStatusField = value;
				base.RaisePropertyChanged("Sgt_toe_speelsterktecategorieStatus");
			}
		}

		public SetStateSgt_toe_speelsterktecategorieRequest()
		{
		}
	}
}