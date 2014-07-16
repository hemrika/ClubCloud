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
	[XmlType(Namespace="http://schemas.microsoft.com/crm/2007/WebServices")]
	public class SdkMessageProcessingStepImageRegistration : INotifyPropertyChanged
	{
		private string messagePropertyNameField;

		private string[] attributesField;

		private string entityAliasField;

		private int imageTypeField;

		[XmlArray] //[XmlArray(Order=1)]
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

		[XmlElement] //[XmlElement(Order=2)]
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

		[XmlElement] //[XmlElement(Order=3)]
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

		[XmlElement] //[XmlElement(Order=0)]
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

		public SdkMessageProcessingStepImageRegistration()
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