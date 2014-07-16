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
	public class SetStateSgt_dss_variabelen_dssRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_dss_variabelen_dssState sgt_dss_variabelen_dssStateField;

		private int sgt_dss_variabelen_dssStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_dss_variabelen_dssState Sgt_dss_variabelen_dssState
		{
			get
			{
				return this.sgt_dss_variabelen_dssStateField;
			}
			set
			{
				this.sgt_dss_variabelen_dssStateField = value;
				base.RaisePropertyChanged("Sgt_dss_variabelen_dssState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_dss_variabelen_dssStatus
		{
			get
			{
				return this.sgt_dss_variabelen_dssStatusField;
			}
			set
			{
				this.sgt_dss_variabelen_dssStatusField = value;
				base.RaisePropertyChanged("Sgt_dss_variabelen_dssStatus");
			}
		}

		public SetStateSgt_dss_variabelen_dssRequest()
		{
		}
	}
}