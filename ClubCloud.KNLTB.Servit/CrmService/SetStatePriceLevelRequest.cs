using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStatePriceLevelRequest : Request
	{
		private Guid entityIdField;
		private PriceLevelState priceLevelStateField;
		private int priceLevelStatusField;
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
		public PriceLevelState PriceLevelState
		{
			get
			{
				return this.priceLevelStateField;
			}
			set
			{
				this.priceLevelStateField = value;
			}
		}
		public int PriceLevelStatus
		{
			get
			{
				return this.priceLevelStatusField;
			}
			set
			{
				this.priceLevelStatusField = value;
			}
		}
	}
}
