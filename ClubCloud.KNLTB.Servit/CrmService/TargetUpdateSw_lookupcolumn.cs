using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSw_lookupcolumn : TargetUpdate
	{
		private sw_lookupcolumn sw_lookupcolumnField;
		public sw_lookupcolumn Sw_lookupcolumn
		{
			get
			{
				return this.sw_lookupcolumnField;
			}
			set
			{
				this.sw_lookupcolumnField = value;
			}
		}
	}
}