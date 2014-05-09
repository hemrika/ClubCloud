using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2006/WebServices")]
	[Serializable]
	public class CrmDateTime : INotifyPropertyChanged
	{
		private bool isNullField;
		private bool isNullFieldSpecified;
		private string dateField;
		private string timeField;
		private string valueField;
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
		public string date
		{
			get
			{
				return this.dateField;
			}
			set
			{
				this.dateField = value;
				this.RaisePropertyChanged("date");
			}
		}
		[XmlAttribute]
		public string time
		{
			get
			{
				return this.timeField;
			}
			set
			{
				this.timeField = value;
				this.RaisePropertyChanged("time");
			}
		}
		[XmlText]
		public string Value
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
