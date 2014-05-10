using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSw_licenseRequest : Request
	{
		private Guid entityIdField;
		private Sw_licenseState sw_licenseStateField;
		private int sw_licenseStatusField;
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
		public Sw_licenseState Sw_licenseState
		{
			get
			{
				return this.sw_licenseStateField;
			}
			set
			{
				this.sw_licenseStateField = value;
			}
		}
		public int Sw_licenseStatus
		{
			get
			{
				return this.sw_licenseStatusField;
			}
			set
			{
				this.sw_licenseStatusField = value;
			}
		}
	}
}
