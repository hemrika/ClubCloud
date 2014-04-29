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
    public partial class Ledenpas : object, System.ComponentModel.INotifyPropertyChanged
    {

        private int jaarField;

        private double verenigingsTextTopField;

        private double verenigingsTextLeftField;

        private double verenigingsTextFontSizeField;

        private double verenigingsNummerTextTopField;

        private double verenigingsNummerTextLeftField;

        private double verenigingsNummerTextFontSizeField;

        private double verenigingsPlaatsTextTopField;

        private double verenigingsPlaatsTextLeftField;

        private double verenigingsPlaatsTextFontSizeField;

        private double spelersNaamTextTopField;

        private double spelersNaamTextLeftField;

        private double spelersNaamTextFontSizeField;

        private double spelersGeboortedatumTextTopField;

        private double spelersGeboortedatumTextLeftField;

        private double spelersGeboortedatumTextFontSizeField;

        private double spelersGeslachtTextTopField;

        private double spelersGeslachtTextLeftField;

        private double spelersGeslachtTextFontSizeField;

        private double spelersEnkelCatTextTopField;

        private double spelersEnkelCatTextLeftField;

        private double spelersEnkelCatTextFontSizeField;

        private double spelersDubbelCatTextTopField;

        private double spelersDubbelCatTextLeftField;

        private double spelersDubbelCatTextFontSizeField;

        private double spelersBondsnummerTextTopField;

        private double spelersBondsnummerTextLeftField;

        private double spelersBondsnummerTextFontSizeField;

        private double spelersJuniorSeniorTextTopField;

        private double spelersJuniorSeniorTextLeftField;

        private double spelersJuniorSeniorTextFontSizeField;

        private double spelersFotoLeftField;

        private double spelersFotoTopField;

        private double spelersFotoWidthField;

        private double spelersFotoHeightField;

        private byte[] backGroundField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public int Jaar
        {
            get
            {
                return this.jaarField;
            }
            set
            {
                this.jaarField = value;
                this.RaisePropertyChanged("Jaar");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public double VerenigingsTextTop
        {
            get
            {
                return this.verenigingsTextTopField;
            }
            set
            {
                this.verenigingsTextTopField = value;
                this.RaisePropertyChanged("VerenigingsTextTop");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public double VerenigingsTextLeft
        {
            get
            {
                return this.verenigingsTextLeftField;
            }
            set
            {
                this.verenigingsTextLeftField = value;
                this.RaisePropertyChanged("VerenigingsTextLeft");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public double VerenigingsTextFontSize
        {
            get
            {
                return this.verenigingsTextFontSizeField;
            }
            set
            {
                this.verenigingsTextFontSizeField = value;
                this.RaisePropertyChanged("VerenigingsTextFontSize");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public double VerenigingsNummerTextTop
        {
            get
            {
                return this.verenigingsNummerTextTopField;
            }
            set
            {
                this.verenigingsNummerTextTopField = value;
                this.RaisePropertyChanged("VerenigingsNummerTextTop");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public double VerenigingsNummerTextLeft
        {
            get
            {
                return this.verenigingsNummerTextLeftField;
            }
            set
            {
                this.verenigingsNummerTextLeftField = value;
                this.RaisePropertyChanged("VerenigingsNummerTextLeft");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public double VerenigingsNummerTextFontSize
        {
            get
            {
                return this.verenigingsNummerTextFontSizeField;
            }
            set
            {
                this.verenigingsNummerTextFontSizeField = value;
                this.RaisePropertyChanged("VerenigingsNummerTextFontSize");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public double VerenigingsPlaatsTextTop
        {
            get
            {
                return this.verenigingsPlaatsTextTopField;
            }
            set
            {
                this.verenigingsPlaatsTextTopField = value;
                this.RaisePropertyChanged("VerenigingsPlaatsTextTop");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public double VerenigingsPlaatsTextLeft
        {
            get
            {
                return this.verenigingsPlaatsTextLeftField;
            }
            set
            {
                this.verenigingsPlaatsTextLeftField = value;
                this.RaisePropertyChanged("VerenigingsPlaatsTextLeft");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public double VerenigingsPlaatsTextFontSize
        {
            get
            {
                return this.verenigingsPlaatsTextFontSizeField;
            }
            set
            {
                this.verenigingsPlaatsTextFontSizeField = value;
                this.RaisePropertyChanged("VerenigingsPlaatsTextFontSize");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public double SpelersNaamTextTop
        {
            get
            {
                return this.spelersNaamTextTopField;
            }
            set
            {
                this.spelersNaamTextTopField = value;
                this.RaisePropertyChanged("SpelersNaamTextTop");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public double SpelersNaamTextLeft
        {
            get
            {
                return this.spelersNaamTextLeftField;
            }
            set
            {
                this.spelersNaamTextLeftField = value;
                this.RaisePropertyChanged("SpelersNaamTextLeft");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public double SpelersNaamTextFontSize
        {
            get
            {
                return this.spelersNaamTextFontSizeField;
            }
            set
            {
                this.spelersNaamTextFontSizeField = value;
                this.RaisePropertyChanged("SpelersNaamTextFontSize");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
        public double SpelersGeboortedatumTextTop
        {
            get
            {
                return this.spelersGeboortedatumTextTopField;
            }
            set
            {
                this.spelersGeboortedatumTextTopField = value;
                this.RaisePropertyChanged("SpelersGeboortedatumTextTop");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 14)]
        public double SpelersGeboortedatumTextLeft
        {
            get
            {
                return this.spelersGeboortedatumTextLeftField;
            }
            set
            {
                this.spelersGeboortedatumTextLeftField = value;
                this.RaisePropertyChanged("SpelersGeboortedatumTextLeft");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 15)]
        public double SpelersGeboortedatumTextFontSize
        {
            get
            {
                return this.spelersGeboortedatumTextFontSizeField;
            }
            set
            {
                this.spelersGeboortedatumTextFontSizeField = value;
                this.RaisePropertyChanged("SpelersGeboortedatumTextFontSize");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 16)]
        public double SpelersGeslachtTextTop
        {
            get
            {
                return this.spelersGeslachtTextTopField;
            }
            set
            {
                this.spelersGeslachtTextTopField = value;
                this.RaisePropertyChanged("SpelersGeslachtTextTop");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 17)]
        public double SpelersGeslachtTextLeft
        {
            get
            {
                return this.spelersGeslachtTextLeftField;
            }
            set
            {
                this.spelersGeslachtTextLeftField = value;
                this.RaisePropertyChanged("SpelersGeslachtTextLeft");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 18)]
        public double SpelersGeslachtTextFontSize
        {
            get
            {
                return this.spelersGeslachtTextFontSizeField;
            }
            set
            {
                this.spelersGeslachtTextFontSizeField = value;
                this.RaisePropertyChanged("SpelersGeslachtTextFontSize");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 19)]
        public double SpelersEnkelCatTextTop
        {
            get
            {
                return this.spelersEnkelCatTextTopField;
            }
            set
            {
                this.spelersEnkelCatTextTopField = value;
                this.RaisePropertyChanged("SpelersEnkelCatTextTop");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 20)]
        public double SpelersEnkelCatTextLeft
        {
            get
            {
                return this.spelersEnkelCatTextLeftField;
            }
            set
            {
                this.spelersEnkelCatTextLeftField = value;
                this.RaisePropertyChanged("SpelersEnkelCatTextLeft");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 21)]
        public double SpelersEnkelCatTextFontSize
        {
            get
            {
                return this.spelersEnkelCatTextFontSizeField;
            }
            set
            {
                this.spelersEnkelCatTextFontSizeField = value;
                this.RaisePropertyChanged("SpelersEnkelCatTextFontSize");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 22)]
        public double SpelersDubbelCatTextTop
        {
            get
            {
                return this.spelersDubbelCatTextTopField;
            }
            set
            {
                this.spelersDubbelCatTextTopField = value;
                this.RaisePropertyChanged("SpelersDubbelCatTextTop");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 23)]
        public double SpelersDubbelCatTextLeft
        {
            get
            {
                return this.spelersDubbelCatTextLeftField;
            }
            set
            {
                this.spelersDubbelCatTextLeftField = value;
                this.RaisePropertyChanged("SpelersDubbelCatTextLeft");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 24)]
        public double SpelersDubbelCatTextFontSize
        {
            get
            {
                return this.spelersDubbelCatTextFontSizeField;
            }
            set
            {
                this.spelersDubbelCatTextFontSizeField = value;
                this.RaisePropertyChanged("SpelersDubbelCatTextFontSize");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 25)]
        public double SpelersBondsnummerTextTop
        {
            get
            {
                return this.spelersBondsnummerTextTopField;
            }
            set
            {
                this.spelersBondsnummerTextTopField = value;
                this.RaisePropertyChanged("SpelersBondsnummerTextTop");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 26)]
        public double SpelersBondsnummerTextLeft
        {
            get
            {
                return this.spelersBondsnummerTextLeftField;
            }
            set
            {
                this.spelersBondsnummerTextLeftField = value;
                this.RaisePropertyChanged("SpelersBondsnummerTextLeft");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 27)]
        public double SpelersBondsnummerTextFontSize
        {
            get
            {
                return this.spelersBondsnummerTextFontSizeField;
            }
            set
            {
                this.spelersBondsnummerTextFontSizeField = value;
                this.RaisePropertyChanged("SpelersBondsnummerTextFontSize");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 28)]
        public double SpelersJuniorSeniorTextTop
        {
            get
            {
                return this.spelersJuniorSeniorTextTopField;
            }
            set
            {
                this.spelersJuniorSeniorTextTopField = value;
                this.RaisePropertyChanged("SpelersJuniorSeniorTextTop");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 29)]
        public double SpelersJuniorSeniorTextLeft
        {
            get
            {
                return this.spelersJuniorSeniorTextLeftField;
            }
            set
            {
                this.spelersJuniorSeniorTextLeftField = value;
                this.RaisePropertyChanged("SpelersJuniorSeniorTextLeft");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 30)]
        public double SpelersJuniorSeniorTextFontSize
        {
            get
            {
                return this.spelersJuniorSeniorTextFontSizeField;
            }
            set
            {
                this.spelersJuniorSeniorTextFontSizeField = value;
                this.RaisePropertyChanged("SpelersJuniorSeniorTextFontSize");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 31)]
        public double SpelersFotoLeft
        {
            get
            {
                return this.spelersFotoLeftField;
            }
            set
            {
                this.spelersFotoLeftField = value;
                this.RaisePropertyChanged("SpelersFotoLeft");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 32)]
        public double SpelersFotoTop
        {
            get
            {
                return this.spelersFotoTopField;
            }
            set
            {
                this.spelersFotoTopField = value;
                this.RaisePropertyChanged("SpelersFotoTop");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 33)]
        public double SpelersFotoWidth
        {
            get
            {
                return this.spelersFotoWidthField;
            }
            set
            {
                this.spelersFotoWidthField = value;
                this.RaisePropertyChanged("SpelersFotoWidth");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 34)]
        public double SpelersFotoHeight
        {
            get
            {
                return this.spelersFotoHeightField;
            }
            set
            {
                this.spelersFotoHeightField = value;
                this.RaisePropertyChanged("SpelersFotoHeight");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary", Order = 35)]
        public byte[] BackGround
        {
            get
            {
                return this.backGroundField;
            }
            set
            {
                this.backGroundField = value;
                this.RaisePropertyChanged("BackGround");
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
