using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Xsl;
using System.Xml.XPath;

namespace ClubCloud.Common.Mail
{
    /// <summary>
    /// Generates content from a XSL Transformation template.
    /// </summary>
    public static class EmailTemplate
    {
        /// <summary>
        /// Generates the E-mail body content using a XSL Transformation and a EmailTemplateParameters object 
        /// to set the input data required by the XSL Template.
        /// </summary>
        /// <param name="templatePath">XSL Tranformation template</param>
        /// <param name="templateProperties">Properties required by the XSL Transformation template</param>
        /// <returns>Generated body content</returns>
        public static string GenerateEmailBody(string templatePath, EmailTemplateParameters templateProperties)
        {
            // Convert properties to XML 
            XElement element = new XElement(
                                "Properties",
                                from keyValue in templateProperties
                                select new XElement(keyValue.Key, keyValue.Value));

            XDocument document = new XDocument();
            document.Add(element);

            return GenerateEmailBody(templatePath, document);
        }

        /// <summary>
        /// Generates the E-mail body content using a XSL Transformation and a XNode object 
        /// with the input data required by the XSL Template.
        /// </summary>
        /// <param name="templatePath">XSL Tranformation template</param>
        /// <param name="templatePropertiesDocument">XML input data required by the XSL Transformation template</param>
        /// <returns>Generated body content</returns>
        public static string GenerateEmailBody(string templatePath, XNode xmlInputData)
        {
            string strHtml = string.Empty;
            MemoryStream memoryStream = new MemoryStream();
            StreamWriter writer = new StreamWriter(memoryStream, Encoding.UTF8);
            XmlTextWriter htmlWriter = new XmlTextWriter(writer);
            StreamReader streamReader = new StreamReader(memoryStream);

            try
            {
                DebugLog("Starting Transformation for template: {0}...", templatePath);
                DebugLog("Transformation Input Data:\n{0}", xmlInputData.ToString());

                // Load the style sheet.
                XsltSettings setting = new XsltSettings { EnableScript = true, EnableDocumentFunction = true };
                XslCompiledTransform xslCompiledTransform = new XslCompiledTransform();
                xslCompiledTransform.Load(templatePath, setting, null);

                xslCompiledTransform.Transform(
                    xmlInputData.CreateNavigator(),
                    null,
                    htmlWriter);

                memoryStream.Position = 0;
                strHtml = streamReader.ReadToEnd();
            }
            catch (XsltException xsltException)
            {
                strHtml = string.Format(CultureInfo.InvariantCulture, "Error: {0}\n\tFileName: {1}\n\tLine Number: {2} - Position: {3}", new object[] { xsltException.Message, xsltException.SourceUri, xsltException.LineNumber, xsltException.LinePosition });
            }
            catch (Exception ex)
            {
                strHtml = string.Format(CultureInfo.InvariantCulture, "Error: {0}", ex.Message);
            }
            finally
            {
                streamReader.Close();
                memoryStream.Close();
            }

            DebugLog("Transformation Result:\n{0}", strHtml);

            return strHtml;
        }

        /// <summary>
        /// Saves logging information.
        /// </summary>
        /// <param name="msg">Message to be logged</param>
        /// <param name="args">Argument values used in the message</param>
        private static void DebugLog(string msg, params object[] args)
        {
            StringBuilder builder = new StringBuilder();

            if ((args != null) && (args.Length != 0))
            {
                builder.AppendFormat(CultureInfo.InvariantCulture, msg, args);
            }
            else
            {
                builder.Append(msg);
            }

            try
            {
                //Trace.WriteLine(string.Format(CultureInfo.InvariantCulture, "[{0}] {1}", DateTime.Now, builder.ToString()));
            }
            catch (Exception exception)
            {
                if (IsFatal(exception))
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// Returns true if an exception is fatal. This is used for logging purposes only.
        /// </summary>
        /// <param name="exception">Exception object</param>
        /// <returns>True if exception is fatal</returns>
        private static bool IsFatal(Exception exception)
        {
            for (Exception exception2 = exception; exception2 != null; exception2 = exception2.InnerException)
            {
                if (((exception2 is OutOfMemoryException) && !(exception2 is InsufficientMemoryException)) || (((exception2 is ThreadAbortException) || (exception2 is AccessViolationException)) || (exception2 is SEHException)))
                {
                    return true;
                }

                if (!(exception2 is TypeInitializationException) && !(exception2 is TargetInvocationException))
                {
                    break;
                }
            }

            return false;
        }
    }
}
