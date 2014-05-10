using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSw_lookupviewtranslationRequest : Request
	{
		private Guid entityIdField;
		private Sw_lookupviewtranslationState sw_lookupviewtranslationStateField;
		private int sw_lookupviewtranslationStatusField;
		public Guid EntityId
		{
			get
			{
				return this.entityIdField;
			}
			set
			{
				this.entityIdField = value;
			}
		}
		public Sw_lookupviewtranslationState Sw_lookupviewtranslationState
		{
			get
			{
				return this.sw_lookupviewtranslationStateField;
			}
			set
			{
				this.sw_lookupviewtranslationStateField = value;
			}
		}
		public int Sw_lookupviewtranslationStatus
		{
			get
			{
				return this.sw_lookupviewtranslationStatusField;
			}
			set
			{
				this.sw_lookupviewtranslationStatusField = value;
			}
		}
	}
}
