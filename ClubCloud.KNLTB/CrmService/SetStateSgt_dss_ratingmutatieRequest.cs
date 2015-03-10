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
	public class SetStateSgt_dss_ratingmutatieRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_dss_ratingmutatieState sgt_dss_ratingmutatieStateField;

		private int sgt_dss_ratingmutatieStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_dss_ratingmutatieState Sgt_dss_ratingmutatieState
		{
			get
			{
				return this.sgt_dss_ratingmutatieStateField;
			}
			set
			{
				this.sgt_dss_ratingmutatieStateField = value;
				base.RaisePropertyChanged("Sgt_dss_ratingmutatieState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_dss_ratingmutatieStatus
		{
			get
			{
				return this.sgt_dss_ratingmutatieStatusField;
			}
			set
			{
				this.sgt_dss_ratingmutatieStatusField = value;
				base.RaisePropertyChanged("Sgt_dss_ratingmutatieStatus");
			}
		}

		public SetStateSgt_dss_ratingmutatieRequest()
		{
		}
	}
}