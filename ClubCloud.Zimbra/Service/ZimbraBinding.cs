using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Web.Configuration;
using System.Web.Administration;
using System.Dynamic;
using System.Collections.Specialized;
using System.Reflection;
namespace ClubCloud.Zimbra.Service
{
    internal class ZimbraBinding : BasicHttpsBinding
    {
        internal ZimbraConfigurationSection configuration = null;

        internal ZimbraBinding()
            : base(BasicHttpsSecurityMode.Transport)
        {
            

            try
            {
                configuration = (ZimbraConfigurationSection)ConfigurationManager.GetSection("Zimbra/Configuration");
            }
            catch { };

            if (configuration != null)
            {
                Type tbindingElement = configuration.Binding.GetType();
                Type tbinding = this.GetType();

                foreach (PropertyInfo propertyInfo in tbinding.GetProperties())
                {
                    PropertyInfo elementPropertyInfo = tbindingElement.GetProperty(propertyInfo.Name);
                    if(elementPropertyInfo != null)
                    {
                        object value = elementPropertyInfo.GetValue(configuration.Binding);
                        if(value != null)
                        {
                            propertyInfo.SetValue(this, Convert.ChangeType(value, propertyInfo.PropertyType), null);
                        }
                    }

                }
            }
            else
            {
                MaxReceivedMessageSize = (base.MaxReceivedMessageSize * 4);
            }

            //string name
            //AllowCookies = true;
            //base.MaxBufferPoolSize
            //base.MaxBufferSize
            //base.MaxReceivedMessageSize
            //base.MessageEncoding
            //base.Name
            //base.Namespace
            //base.OpenTimeout
            //base.ReaderQuotas
            //base.ReceiveTimeout
            //base.Scheme
            //base.SendTimeout
            //base.TextEncoding = Encoding.UTF8;
            //base.TransferMode
        }

        public override string Scheme
        {
            get
            {
                return "https";
            }
        }
    }
}
