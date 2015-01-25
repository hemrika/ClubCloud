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
    public partial class Pasfoto : object, System.ComponentModel.INotifyPropertyChanged
    {

        private int pasfotoIdField;

        private string fotonummerField;

        private byte[] fotoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public int PasfotoId
        {
            get
            {
                return this.pasfotoIdField;
            }
            set
            {
                this.pasfotoIdField = value;
                this.RaisePropertyChanged("PasfotoId");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string Fotonummer
        {
            get
            {
                return this.fotonummerField;
            }
            set
            {
                this.fotonummerField = value;
                this.RaisePropertyChanged("Fotonummer");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary", Order = 2)]
        public byte[] Foto
        {
            get
            {
                return this.fotoField;
            }
            set
            {
                this.fotoField = value;
                this.RaisePropertyChanged("Foto");
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
