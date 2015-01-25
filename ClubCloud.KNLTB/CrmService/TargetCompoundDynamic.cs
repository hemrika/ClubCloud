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
	public class TargetCompoundDynamic : TargetCompound
	{
		private DynamicEntity entityField;

		private DynamicEntity[] childEntitiesField;

		[XmlArray] //[XmlArray(Order=1)]
		[XmlArrayItem(IsNullable=false)]
		public DynamicEntity[] ChildEntities
		{
			get
			{
				return this.childEntitiesField;
			}
			set
			{
				this.childEntitiesField = value;
				base.RaisePropertyChanged("ChildEntities");
			}
		}

		[XmlElement] //[XmlElement(Order=0)]
		public DynamicEntity Entity
		{
			get
			{
				return this.entityField;
			}
			set
			{
				this.entityField = value;
				base.RaisePropertyChanged("Entity");
			}
		}

		public TargetCompoundDynamic()
		{
		}
	}
}