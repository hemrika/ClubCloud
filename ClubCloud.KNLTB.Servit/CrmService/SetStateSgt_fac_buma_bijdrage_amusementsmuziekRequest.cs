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
	public class SetStateSgt_fac_buma_bijdrage_amusementsmuziekRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_fac_buma_bijdrage_amusementsmuziekState sgt_fac_buma_bijdrage_amusementsmuziekStateField;

		private int sgt_fac_buma_bijdrage_amusementsmuziekStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_fac_buma_bijdrage_amusementsmuziekState Sgt_fac_buma_bijdrage_amusementsmuziekState
		{
			get
			{
				return this.sgt_fac_buma_bijdrage_amusementsmuziekStateField;
			}
			set
			{
				this.sgt_fac_buma_bijdrage_amusementsmuziekStateField = value;
				base.RaisePropertyChanged("Sgt_fac_buma_bijdrage_amusementsmuziekState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_fac_buma_bijdrage_amusementsmuziekStatus
		{
			get
			{
				return this.sgt_fac_buma_bijdrage_amusementsmuziekStatusField;
			}
			set
			{
				this.sgt_fac_buma_bijdrage_amusementsmuziekStatusField = value;
				base.RaisePropertyChanged("Sgt_fac_buma_bijdrage_amusementsmuziekStatus");
			}
		}

		public SetStateSgt_fac_buma_bijdrage_amusementsmuziekRequest()
		{
		}
	}
}