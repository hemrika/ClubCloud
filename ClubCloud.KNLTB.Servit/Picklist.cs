using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2006/WebServices")]
	[Serializable]
	public class Picklist : INotifyPropertyChanged
	{
		private bool isNullField;
		private bool isNullFieldSpecified;
		private string nameField;
		private int valueField;
		public event PropertyChangedEventHandler PropertyChanged;
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
		[XmlText]
		public int Value
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
		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
