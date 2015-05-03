using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.Xml.Serialization;

namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[GeneratedCode("System.Xml", "4.0.30319.33440")]
	[Serializable]
	/*
    [XmlInclude(typeof(QueryByAttribute))]
	[XmlInclude(typeof(QueryExpression))]
    */
    [XmlSerializerAssembly(AssemblyName = "ClubCloud.KNLTB.XmlSerializers")]
	[XmlType(Namespace="http://schemas.microsoft.com/crm/2006/Query")]
	public abstract class QueryBase : INotifyPropertyChanged
	{
		private string entityNameField;

		private ColumnSetBase columnSetField;

		[XmlElement] //[XmlElement(Order=1)]
		public ColumnSetBase ColumnSet
		{
			get
			{
				return this.columnSetField;
			}
			set
			{
				this.columnSetField = value;
				this.RaisePropertyChanged("ColumnSet");
			}
		}

		[XmlElement] //[XmlElement(Order=0)]
		public string EntityName
		{
			get
			{
				return this.entityNameField;
			}
			set
			{
				this.entityNameField = value;
				this.RaisePropertyChanged("EntityName");
			}
		}

		protected QueryBase()
		{
		}

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.PropertyChanged;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;
	}
}