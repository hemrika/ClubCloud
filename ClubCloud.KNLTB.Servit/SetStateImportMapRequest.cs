using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateImportMapRequest : Request
	{
		private Guid entityIdField;
		private ImportMapState importMapStateField;
		private int importMapStatusField;
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
		public ImportMapState ImportMapState
		{
			get
			{
				return this.importMapStateField;
			}
			set
			{
				this.importMapStateField = value;
				base.RaisePropertyChanged("ImportMapState");
			}
		}
		[XmlElement(Order = 2)]
		public int ImportMapStatus
		{
			get
			{
				return this.importMapStatusField;
			}
			set
			{
				this.importMapStatusField = value;
				base.RaisePropertyChanged("ImportMapStatus");
			}
		}
	}
}
