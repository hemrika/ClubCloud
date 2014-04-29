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
    public partial class SpelersprofielTotaal : object, System.ComponentModel.INotifyPropertyChanged
    {

        private Spelersprofiel spelersprofielField;

        private PartijResult[] uitslagenCompetitieField;

        private PartijResult[] uitslagenToernooienField;

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
        [System.Xml.Serialization.XmlArrayAttribute(Order = 1)]
        public PartijResult[] UitslagenCompetitie
        {
            get
            {
                return this.uitslagenCompetitieField;
            }
            set
            {
                this.uitslagenCompetitieField = value;
                this.RaisePropertyChanged("UitslagenCompetitie");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 2)]
        public PartijResult[] UitslagenToernooien
        {
            get
            {
                return this.uitslagenToernooienField;
            }
            set
            {
                this.uitslagenToernooienField = value;
                this.RaisePropertyChanged("UitslagenToernooien");
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
