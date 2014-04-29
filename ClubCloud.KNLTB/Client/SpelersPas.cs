using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.KNLTB.Client
{
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class SpelersPas : object, System.ComponentModel.INotifyPropertyChanged
    {

        private Spelersprofiel spelersprofielField;

        private Ledenpas ledenpasField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public Spelersprofiel Spelersprofiel
        {
            get
            {
                return this.spelersprofielField;
            }
            set
            {
                this.spelersprofielField = value;
                this.RaisePropertyChanged("Spelersprofiel");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public Ledenpas Ledenpas
        {
            get
            {
                return this.ledenpasField;
            }
            set
            {
                this.ledenpasField = value;
                this.RaisePropertyChanged("Ledenpas");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
