using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Provider.Controls
{
    public class ClaimsConverter : StringConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            if (sourceType == typeof(string) || sourceType == typeof(List<string>))
            {
                return true;
            }
            return base.CanConvertFrom(context, sourceType);
        }

        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            if (destinationType == typeof(string) || destinationType == typeof(List<string>))
            {
                return true;
            }
            return base.CanConvertTo(context, destinationType);
        }

        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            if (value is string)
            {
                string[] arr = ((string)value).Split(new char[] { ',' });
                List<string> v = new List<string>();
                for (int i = 0; i < arr.Length; i++)
                {
                    v.Add(arr[i]);
                }
                return v;
            }
            else if (value is List<string>)
            {
                List<string> myList = (List<string>)value;
                string s = "";
                for (int i = 0; i < myList.Count; i++)
                {
                    s += myList[i] + ",";
                }
                return s;
            }
            return base.ConvertFrom(context, culture, value);
        }

        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if (destinationType == typeof(string))
            {
                List<string> myList = (List<string>)value;
                string s = "";
                for (int i = 0; i < myList.Count; i++)
                {
                    s += myList[i] + ",";
                }
                return s;
            }
            else if (destinationType == typeof(List<string>))
            {
                string[] arr = ((string)value).Split(new char[] { ',' });
                List<string> v = new List<string>();
                for (int i = 0; i < arr.Length; i++)
                {
                    v.Add(arr[i]);
                }
                return v;
            }
            return base.ConvertTo(context, culture, value, destinationType);
        }
    }
}
