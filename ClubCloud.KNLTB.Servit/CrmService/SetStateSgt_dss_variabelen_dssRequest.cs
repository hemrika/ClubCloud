using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_dss_variabelen_dssRequest : Request
	{
		private Guid entityIdField;
		private Sgt_dss_variabelen_dssState sgt_dss_variabelen_dssStateField;
		private int sgt_dss_variabelen_dssStatusField;
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
		public Sgt_dss_variabelen_dssState Sgt_dss_variabelen_dssState
		{
			get
			{
				return this.sgt_dss_variabelen_dssStateField;
			}
			set
			{
				this.sgt_dss_variabelen_dssStateField = value;
			}
		}
		public int Sgt_dss_variabelen_dssStatus
		{
			get
			{
				return this.sgt_dss_variabelen_dssStatusField;
			}
			set
			{
				this.sgt_dss_variabelen_dssStatusField = value;
			}
		}
	}
}
