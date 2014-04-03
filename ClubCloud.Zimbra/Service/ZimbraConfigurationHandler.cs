using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ClubCloud.Zimbra.Service
{
    public class ZimbraConfigurationHandler : IConfigurationSectionHandler
    {
        public object Create(object parent, object configContext, System.Xml.XmlNode section)
        {

            ZimbraConfigurationSection config = new ZimbraConfigurationSection();

            if(section.HasChildNodes)
            {
                XmlNode binding = section.SelectSingleNode("//Binding");
                XmlNode server = section.SelectSingleNode("//Server");

                if (binding != null)
                {
                    XmlAttributeCollection bindingAttributes = binding.Attributes;

                    if (bindingAttributes != null && bindingAttributes.Count > 0)
                    {
                        Type tbinding = config.Binding.GetType();

                        foreach (XmlAttribute attribute in bindingAttributes)
                        {
                            PropertyInfo propertyInfo = tbinding.GetProperty(attribute.Name);

                            if (propertyInfo != null)
                            {
                                propertyInfo.SetValue(config.Binding, Convert.ChangeType(attribute.Value, propertyInfo.PropertyType), null);
                            }

                            //string name = attribute.Name;
                            //string value = attribute.Value;
                        }
                    }
                }

                if (server != null)
                {
                    XmlAttributeCollection serverAttributes = server.Attributes;

                    if (serverAttributes != null && serverAttributes.Count > 0)
                    {
                        Type tserver = config.Server.GetType();
                        foreach (XmlAttribute attribute in serverAttributes)
                        {
                            PropertyInfo propertyInfo = tserver.GetProperty(attribute.Name);

                            if (propertyInfo != null)
                            {
                                propertyInfo.SetValue(config.Server, Convert.ChangeType(attribute.Value, propertyInfo.PropertyType), null);
                            }

                            //string name = attribute.Name;
                            //string value = attribute.Value;
                        }
                    }

                }
            }
            
            if(config != null)
            {
                return config;
            }
            else
            {
                return null;
            }
        }
    }
}
