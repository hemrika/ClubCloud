using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSw_licensemanagerRequest : Request
	{
		private Guid entityIdField;
		private Sw_licensemanagerState sw_licensemanagerStateField;
		private int sw_licensemanagerStatusField;
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
		public Sw_licensemanagerState Sw_licensemanagerState
		{
			get
			{
				return this.sw_licensemanagerStateField;
			}
			set
			{
				this.sw_licensemanagerStateField = value;
				base.RaisePropertyChanged("Sw_licensemanagerState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sw_licensemanagerStatus
		{
			get
			{
				return this.sw_licensemanagerStatusField;
			}
			set
			{
				this.sw_licensemanagerStatusField = value;
				base.RaisePropertyChanged("Sw_licensemanagerStatus");
			}
		}
	}
}
