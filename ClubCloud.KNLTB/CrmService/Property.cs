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
    [XmlInclude(typeof(CrmBooleanProperty))]
	[XmlInclude(typeof(CrmDateTimeProperty))]
	[XmlInclude(typeof(CrmDecimalProperty))]
	[XmlInclude(typeof(CrmFloatProperty))]
	[XmlInclude(typeof(CrmMoneyProperty))]
	[XmlInclude(typeof(CrmNumberProperty))]
	[XmlInclude(typeof(CustomerProperty))]
	[XmlInclude(typeof(DynamicEntityArrayProperty))]
	[XmlInclude(typeof(EntityNameReferenceProperty))]
	[XmlInclude(typeof(KeyProperty))]
	[XmlInclude(typeof(LookupProperty))]
	[XmlInclude(typeof(OwnerProperty))]
	[XmlInclude(typeof(PicklistProperty))]
	[XmlInclude(typeof(StateProperty))]
	[XmlInclude(typeof(StatusProperty))]
	[XmlInclude(typeof(StringProperty))]
	[XmlInclude(typeof(UniqueIdentifierProperty))]
    */
    [XmlSerializerAssembly(AssemblyName = "ClubCloud.KNLTB.XmlSerializers")]
	[XmlType(Namespace="http://schemas.microsoft.com/crm/2006/WebServices")]
	public abstract class Property : INotifyPropertyChanged
	{
		private string nameField;

		[XmlAttribute]
		public string Name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
				this.RaisePropertyChanged("Name");
			}
		}

		protected Property()
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