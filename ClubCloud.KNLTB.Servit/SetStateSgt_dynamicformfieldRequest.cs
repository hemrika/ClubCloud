using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_dynamicformfieldRequest : Request
	{
		private Guid entityIdField;
		private Sgt_dynamicformfieldState sgt_dynamicformfieldStateField;
		private int sgt_dynamicformfieldStatusField;
		[XmlElement(Order = 0)]
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
		[XmlElement(Order = 1)]
		public Sgt_dynamicformfieldState Sgt_dynamicformfieldState
		{
			get
			{
				return this.sgt_dynamicformfieldStateField;
			}
			set
			{
				this.sgt_dynamicformfieldStateField = value;
				base.RaisePropertyChanged("Sgt_dynamicformfieldState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_dynamicformfieldStatus
		{
			get
			{
				return this.sgt_dynamicformfieldStatusField;
			}
			set
			{
				this.sgt_dynamicformfieldStatusField = value;
				base.RaisePropertyChanged("Sgt_dynamicformfieldStatus");
			}
		}
	}
}
