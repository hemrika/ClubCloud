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
    [XmlInclude(typeof(Customer))]
	[XmlInclude(typeof(Lookup))]
	[XmlInclude(typeof(Owner))]
    */
    [XmlSerializerAssembly(AssemblyName = "ClubCloud.KNLTB.XmlSerializers")]
	[XmlType(Namespace="http://schemas.microsoft.com/crm/2006/WebServices")]
	public abstract class CrmReference : INotifyPropertyChanged
	{
		private bool isNullField;

		private bool isNullFieldSpecified;

		private string nameField;

		private string typeField;

		private int dscField;

		private bool dscFieldSpecified;

		private Guid valueField;

		[XmlAttribute]
		public int dsc
		{
			get
			{
				return this.dscField;
			}
			set
			{
				this.dscField = value;
				this.RaisePropertyChanged("dsc");
			}
		}

		[XmlIgnore]
		public bool dscSpecified
		{
			get
			{
				return this.dscFieldSpecified;
			}
			set
			{
				this.dscFieldSpecified = value;
				this.RaisePropertyChanged("dscSpecified");
			}
		}

		[XmlAttribute]
		public bool IsNull
		{
			get
			{
				return this.isNullField;
			}
			set
			{
				this.isNullField = value;
				this.RaisePropertyChanged("IsNull");
			}
		}

		[XmlIgnore]
		public bool IsNullSpecified
		{
			get
			{
				return this.isNullFieldSpecified;
			}
			set
			{
				this.isNullFieldSpecified = value;
				this.RaisePropertyChanged("IsNullSpecified");
			}
		}

		[XmlAttribute]
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
				this.RaisePropertyChanged("name");
			}
		}

		[XmlAttribute]
		public string type
		{
			get
			{
				return this.typeField;
			}
			set
			{
				this.typeField = value;
				this.RaisePropertyChanged("type");
			}
		}

		[XmlText]
		public Guid Value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				this.valueField = value;
				this.RaisePropertyChanged("Value");
			}
		}

		protected CrmReference()
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