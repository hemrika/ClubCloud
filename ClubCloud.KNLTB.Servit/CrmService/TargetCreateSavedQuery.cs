using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSavedQuery : TargetCreate
	{
		private savedquery savedQueryField;
		public savedquery SavedQuery
		{
			get
			{
				return this.savedQueryField;
			}
			set
			{
				this.savedQueryField = value;
			}
		}
	}
}
