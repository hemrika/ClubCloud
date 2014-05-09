using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SdkMessageProcessingStepImageRegistration : INotifyPropertyChanged
	{
		private string messagePropertyNameField;
		private string[] attributesField;
		private string entityAliasField;
		private int imageTypeField;
		public event PropertyChangedEventHandler PropertyChanged;
		[XmlElement(Order = 0)]
		public string MessagePropertyName
		{
			get
			{
				return this.messagePropertyNameField;
			}
			set
			{
				this.messagePropertyNameField = value;
				this.RaisePropertyChanged("MessagePropertyName");
			}
		}
		[XmlArray(Order = 1)]
		public string[] Attributes
		{
			get
			{
				return this.attributesField;
			}
			set
			{
				this.attributesField = value;
				this.RaisePropertyChanged("Attributes");
			}
		}
		[XmlElement(Order = 2)]
		public string EntityAlias
		{
			get
			{
				return this.entityAliasField;
			}
			set
			{
				this.entityAliasField = value;
				this.RaisePropertyChanged("EntityAlias");
			}
		}
		[XmlElement(Order = 3)]
		public int ImageType
		{
			get
			{
				return this.imageTypeField;
			}
			set
			{
				this.imageTypeField = value;
				this.RaisePropertyChanged("ImageType");
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
