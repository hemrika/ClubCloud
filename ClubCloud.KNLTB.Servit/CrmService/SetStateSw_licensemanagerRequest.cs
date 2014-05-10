using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSw_licensemanagerRequest : Request
	{
		private Guid entityIdField;
		private Sw_licensemanagerState sw_licensemanagerStateField;
		private int sw_licensemanagerStatusField;
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
		public Sw_licensemanagerState Sw_licensemanagerState
		{
			get
			{
				return this.sw_licensemanagerStateField;
			}
			set
			{
				this.sw_licensemanagerStateField = value;
			}
		}
		public int Sw_licensemanagerStatus
		{
			get
			{
				return this.sw_licensemanagerStatusField;
			}
			set
			{
				this.sw_licensemanagerStatusField = value;
			}
		}
	}
}
