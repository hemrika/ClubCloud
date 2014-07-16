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
	public class SetStatePriceLevelRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.PriceLevelState priceLevelStateField;

		private int priceLevelStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.PriceLevelState PriceLevelState
		{
			get
			{
				return this.priceLevelStateField;
			}
			set
			{
				this.priceLevelStateField = value;
				base.RaisePropertyChanged("PriceLevelState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int PriceLevelStatus
		{
			get
			{
				return this.priceLevelStatusField;
			}
			set
			{
				this.priceLevelStatusField = value;
				base.RaisePropertyChanged("PriceLevelStatus");
			}
		}

		public SetStatePriceLevelRequest()
		{
		}
	}
}