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
	[XmlType(Namespace="http://schemas.microsoft.com/crm/2006/Query")]
	public class ConditionExpression : INotifyPropertyChanged
	{
		private string attributeNameField;

		private ConditionOperator operatorField;

        private string uinameField;

        private string uitypeField;

		private object[] valuesField;

		[XmlElement] //[XmlElement(Order=0)]
		public string AttributeName
		{
			get
			{
				return this.attributeNameField;
			}
			set
			{
				this.attributeNameField = value;
				this.RaisePropertyChanged("AttributeName");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
		public ConditionOperator Operator
		{
			get
			{
				return this.operatorField;
			}
			set
			{
				this.operatorField = value;
				this.RaisePropertyChanged("Operator");
			}
		}


        [XmlElement] //[XmlElement(Order=0)]
        public string uiname
        {
            get
            {
                return this.uinameField;
            }
            set
            {
                this.uinameField = value;
                this.RaisePropertyChanged("uiname");
            }
        }

        [XmlElement] //[XmlElement(Order=0)]
        public string uitype
        {
            get
            {
                return this.uitypeField;
            }
            set
            {
                this.uitypeField = value;
                this.RaisePropertyChanged("uitype");
            }
        }

		[XmlArray] //[XmlArray(Order=2)]
		[XmlArrayItem("Value")]
		public object[] Values
		{
			get
			{
				return this.valuesField;
			}
			set
			{
				this.valuesField = value;
				this.RaisePropertyChanged("Values");
			}
		}


         //uiname
		public ConditionExpression()
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