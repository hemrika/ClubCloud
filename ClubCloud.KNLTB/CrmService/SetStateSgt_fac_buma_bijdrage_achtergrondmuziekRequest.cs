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
	public class SetStateSgt_fac_buma_bijdrage_achtergrondmuziekRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_fac_buma_bijdrage_achtergrondmuziekState sgt_fac_buma_bijdrage_achtergrondmuziekStateField;

		private int sgt_fac_buma_bijdrage_achtergrondmuziekStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_fac_buma_bijdrage_achtergrondmuziekState Sgt_fac_buma_bijdrage_achtergrondmuziekState
		{
			get
			{
				return this.sgt_fac_buma_bijdrage_achtergrondmuziekStateField;
			}
			set
			{
				this.sgt_fac_buma_bijdrage_achtergrondmuziekStateField = value;
				base.RaisePropertyChanged("Sgt_fac_buma_bijdrage_achtergrondmuziekState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_fac_buma_bijdrage_achtergrondmuziekStatus
		{
			get
			{
				return this.sgt_fac_buma_bijdrage_achtergrondmuziekStatusField;
			}
			set
			{
				this.sgt_fac_buma_bijdrage_achtergrondmuziekStatusField = value;
				base.RaisePropertyChanged("Sgt_fac_buma_bijdrage_achtergrondmuziekStatus");
			}
		}

		public SetStateSgt_fac_buma_bijdrage_achtergrondmuziekRequest()
		{
		}
	}
}