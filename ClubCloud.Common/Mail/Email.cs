﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClubCloud.Common.Mail
{
    public static class Email
    {
        /// <summary>
        /// Creates and sends a simple E-mail.
        /// </summary>
        /// <param name="recipient">E-mail address of 'To' field</param>
        /// <param name="subject">E-mail subject</param>
        /// <param name="body">E-mail body content</param>
        public static void Send(string recipient, string subject, string body)
        {
            MailMessage mailMessage = CreateMailMessage(body);
            mailMessage.Subject = subject;
            mailMessage.To.Add(new MailAddress(recipient));
            Send(mailMessage);
        }

        /// <summary>
        /// Generates and sends an E-mail using a XSL Transformation template to generate the body content.
        /// </summary>
        /// <param name="recipient">E-mail address of 'To' field</param>
        /// <param name="subject">E-mail subject</param>
        /// <param name="templatePath">XSL Tranformation template</param>
        /// <param name="templateProperties">Properties required by the XSL Transformation template</param>
        public static void Send(string recipient, string subject, string templatePath, EmailTemplateParameters templateProperties)
        {
            MailMessage mailMessage = CreateMailMessage(recipient, subject, templatePath, templateProperties);
            Send(mailMessage);
        }

        /// <summary>
        /// Generates and sends an E-mail using a XSL Transformation template to generate the body content.
        /// </summary>
        /// <param name="recipient">E-mail address of 'To' field</param>
        /// <param name="subject">E-mail subject</param>
        /// <param name="templatePath">XSL Tranformation template</param>
        /// <param name="xmlInputData">XML input data required by the XSL Transformation template</param>
        public static void Send(string recipient, string subject, string templatePath, XNode xmlInputData)
        {
            MailMessage mailMessage = CreateMailMessage(recipient, subject, templatePath, xmlInputData);
            Send(mailMessage);
        }

        private static Queue<MailMessage> _messages = new Queue<MailMessage>();
        private static SmtpClient Client = null;
        private static bool sending = false;

        public static Task SendAsync(MailMessage message, SmtpClient client)
        {
            if (client == null)
                client = new SmtpClient();

            if (client.DeliveryMethod == SmtpDeliveryMethod.PickupDirectoryFromIis)
                client.DeliveryMethod = SmtpDeliveryMethod.Network; client.EnableSsl = true;

            if (client.DeliveryMethod == SmtpDeliveryMethod.SpecifiedPickupDirectory)
                client.DeliveryMethod = SmtpDeliveryMethod.Network; client.EnableSsl = true;

            if (client.DeliveryMethod == SmtpDeliveryMethod.Network)
                client.EnableSsl = true;

            bool valid = true;
            if (string.IsNullOrWhiteSpace(client.Host))
                valid = false;

            int output;
            if (!int.TryParse(client.Port.ToString(), out output))
                valid = false;

            if (client.Credentials == null)
                valid = false;

            try
            {
                if (valid)
                {
                    if (Client == null)
                    {
                        Client = client;
                        Client.SendCompleted += client_SendCompleted;
                    }

                    while (sending) { Thread.Sleep(100); }

                    sending = true;
                    Client.SendAsync(message, message);
                    //client.Send(message);
                }
            }
            catch (Exception ex)
            {
                Logger.WriteLog(Logger.Category.Unexpected, ex.Source, ex.Message);
            }

            return Task.FromResult<object>(null);
        }

        /// <summary>
        /// Sends the E-mail using the configured delivery method.
        /// </summary>
        /// <param name="mailMessage">MailMessage instance to be sent</param>
        public static void Send(MailMessage message, SmtpClient client = null)
        {
            if (client == null)
                client = new SmtpClient();

            if (client.DeliveryMethod == null)
                client.DeliveryMethod = SmtpDeliveryMethod.PickupDirectoryFromIis; client.EnableSsl = false;

            if (client.DeliveryMethod == SmtpDeliveryMethod.Network)
                client.EnableSsl = true;

            if (string.IsNullOrWhiteSpace(client.Host))
                return;

            int output;
            if (!int.TryParse(client.Port.ToString(), out output))
                return;

            if (client.Credentials == null)
                return;

            try
            {
                //client.SendCompleted += client_SendCompleted;
                client.Send(message);
            }
            catch (Exception ex)
            {
                Logger.WriteLog(Logger.Category.Unexpected, ex.Source, ex.Message);
            }
        }

        static void client_SendCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            try
            {
                MailMessage message = (MailMessage)e.UserState;

                if (e.Cancelled)
                {
                    Logger.WriteLog(Logger.Category.Unexpected, "ClubCLoud.Common.Mail", message.Subject);
                }
                if (e.Error != null)
                {
                    Logger.WriteLog(Logger.Category.Unexpected, e.Error.Source, e.Error.Message);
                }

                message.Dispose();
            }
            catch (Exception ex)
            {
                Logger.WriteLog(Logger.Category.Unexpected, ex.Source, ex.Message);
            }
            finally
            {
                sending = false;
            }
        }

        /// <summary>
        /// Creates a simple MailMessage object.
        /// </summary>
        /// <param name="recipient">E-mail address of 'To' field</param>
        /// <param name="subject">E-mail subject</param>
        /// <param name="body">E-mail body content</param>
        /// <returns>MailMessage instance to be sent</returns>
        public static MailMessage CreateMailMessage(string body)
        {
            MailMessage mailMessage = new MailMessage();

            List<Attachment> attachmentList = new List<Attachment>();
            List<LinkedResource> resourceList = new List<LinkedResource>();

            // Convert to embedded images
            Regex regexImg = new Regex(@"<img\s[^>]*/>", RegexOptions.IgnoreCase);
            Regex regexSrc = new Regex(@"src=(?:(['""])(?<src>(?:(?!\1).)*)\1|(?<src>[^\s>]+))", RegexOptions.IgnoreCase | RegexOptions.Singleline);
            Regex regexBackground = new Regex(@"background=(?:(['""])(?<src>(?:(?!\1).)*)\1|(?<src>[^\s>]+))", RegexOptions.IgnoreCase | RegexOptions.Singleline);

            MatchCollection imgCollection = regexImg.Matches(body);
            MatchCollection backgroundCollection = regexBackground.Matches(body);
            /*
            foreach (Match background in backgroundCollection)
            {
                foreach (Group group in background.Groups)
                {
                    string val = group.Value;
                }
                string bgvalue = background.Groups["src"].Value;

                string attachmentContentId = string.Empty;
                Attachment attachment = null;
                LinkedResource resource = null;

                if (!bgvalue.StartsWith("http", System.StringComparison.OrdinalIgnoreCase))
                {
                    attachmentContentId = Path.GetFileName(bgvalue).Replace(".", string.Empty);
                    attachment = CreateInlineAttachmentDisk(bgvalue, attachmentContentId);

                    if (!string.IsNullOrEmpty(attachmentContentId) && attachment != null)
                    {
                        body = body.Replace(background.Groups["src"].Value, "cid:" + attachmentContentId);
                        attachmentList.Add(attachment);
                    }
                }
                else
                {
                    attachmentContentId = Path.GetFileName(bgvalue);
                    resource = CreateInlineAttachmentOnline(bgvalue, attachmentContentId);

                    if (!string.IsNullOrEmpty(attachmentContentId) && resource != null)
                    {
                        body = body.Replace(background.Groups["src"].Value, "cid:" + attachmentContentId);
                        resourceList.Add(resource);
                    }

                }
            }

            foreach (Match matchImg in imgCollection)
            {
                if (regexSrc.IsMatch(matchImg.Groups[0].Value))
                {
                    Match matchSrc = regexSrc.Match(matchImg.Groups[0].Value);
                    string srcValue = matchSrc.Groups["src"].Value;

                    string attachmentContentId = string.Empty;
                    Attachment attachment = null;
                    LinkedResource resource = null;

                    if (!srcValue.StartsWith("http", System.StringComparison.OrdinalIgnoreCase))
                    {
                        attachmentContentId = Path.GetFileName(srcValue).Replace(".", string.Empty);
                        attachment = CreateInlineAttachmentDisk(srcValue, attachmentContentId);

                        if (!string.IsNullOrEmpty(attachmentContentId) && attachment != null)
                        {
                            body = body.Replace(matchSrc.Groups["src"].Value, "cid:" + attachmentContentId);
                            attachmentList.Add(attachment);
                        }
                    }
                    else
                    {
                        attachmentContentId = Path.GetFileName(srcValue);
                        resource = CreateInlineAttachmentOnline(srcValue, attachmentContentId);

                        if (!string.IsNullOrEmpty(attachmentContentId) && resource != null)
                        {
                            body = body.Replace(matchSrc.Groups["src"].Value, "cid:" + attachmentContentId);
                            resourceList.Add(resource);
                        }

                    }

                }
            }
            */

            AlternateView plain = AlternateView.CreateAlternateViewFromString("You must use an email client that supports HTML messages", null, MediaTypeNames.Text.Plain);
            mailMessage.AlternateViews.Add(plain);

            AlternateView view = AlternateView.CreateAlternateViewFromString(body, null, MediaTypeNames.Text.Html);

            if (resourceList.Count > 0)
            {
                //AlternateView htmlview = default(AlternateView);
                //AlternateView view = AlternateView.CreateAlternateViewFromString(body, new System.Net.Mime.ContentType("text/html"), "text/html");


                foreach (LinkedResource attachment in resourceList)
                {
                    view.LinkedResources.Add(attachment);
                }



            }

            mailMessage.AlternateViews.Add(view);

            foreach (Attachment attachment in attachmentList)
            {
                mailMessage.Attachments.Add(attachment);
            }
            /*
            AlternateView view = AlternateView.CreateAlternateViewFromString(body, null, MediaTypeNames.Text.Html);
            mailMessage.AlternateViews.Add(view);
            */
            //mailMessage.To.Add(recipient);
            //mailMessage.Subject = subject;
            mailMessage.IsBodyHtml = true;
            mailMessage.Body = body;

            return mailMessage;
        }

        /// <summary>
        /// Creates a MailMessage object with a dynamically generated body and the specified parameters.
        /// </summary>
        /// <param name="recipient">E-mail address of 'To' field</param>
        /// <param name="subject">E-mail subject</param>
        /// <param name="templatePath">XSL Tranformation template</param>
        /// <param name="templateProperties">Properties required by the XSL Transformation template</param>
        /// <returns>MailMessage instance to be sent</returns>
        public static MailMessage CreateMailMessage(string recipient, string subject, string templatePath, EmailTemplateParameters templateProperties)
        {
            string body = EmailTemplate.GenerateEmailBody(templatePath, templateProperties);

            MailMessage mailMessage = CreateMailMessage(body);
            mailMessage.Subject = subject;
            mailMessage.To.Add(new MailAddress(recipient));

            return mailMessage;
        }

        /// <summary>
        /// Creates a MailMessage object with a dynamically generated body and the specified XML input data.
        /// </summary>
        /// <param name="recipient">E-mail address of 'To' field</param>
        /// <param name="subject">E-mail subject</param>
        /// <param name="templatePath">XSL Tranformation template</param>
        /// <param name="xmlInputData">XML input data required by the XSL Transformation template</param>
        /// <returns>MailMessage instance to be sent</returns>
        public static MailMessage CreateMailMessage(string recipient, string subject, string templatePath, XNode xmlInputData)
        {
            string body = EmailTemplate.GenerateEmailBody(templatePath, xmlInputData);

            MailMessage mailMessage = CreateMailMessage(body);
            mailMessage.Subject = subject;
            mailMessage.To.Add(new MailAddress(recipient));

            return mailMessage;
        }

        /// <summary>
        /// Creates an Attachment object for a specified file.
        /// </summary>
        /// <param name="attachmentPath">Path to the file to be attached</param>
        /// <param name="contentId">ID to be used in the E-mail body for the attachment</param>
        /// <returns>Attachment object instance</returns>
        private static Attachment CreateInlineAttachmentDisk(string attachmentPath, string contentId)
        {
            string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, attachmentPath);
            Attachment inline = new Attachment(fullPath);

            inline.ContentDisposition.Inline = true;
            inline.ContentDisposition.DispositionType = DispositionTypeNames.Inline;
            inline.ContentId = contentId;
            inline.ContentType.MediaType = "image/png";
            inline.ContentType.Name = Path.GetFileName(fullPath);

            return inline;
        }

        /// <summary>
        /// Creates an Attachment object for a specified file.
        /// </summary>
        /// <param name="attachmentPath">Path to the file to be attached</param>
        /// <param name="contentId">ID to be used in the E-mail body for the attachment</param>
        /// <returns>Attachment object instance</returns>
        private static LinkedResource CreateInlineAttachmentOnline(string attachmentPath, string contentId)
        {
            WebClient client = new WebClient();
            byte[] data = client.DownloadData(attachmentPath);
            MemoryStream ms = new MemoryStream(data);

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(attachmentPath);

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            /*
            Stream receiveStream = response.GetResponseStream();
            Image image = Image.FromStream(receiveStream);

            MemoryStream ms = new MemoryStream();
            image.Save(ms,ImageFormat.Png);
            response.Close();
            */
            /*
            StreamReader reader = new StreamReader(response.GetResponseStream());

            BinaryReader binaryReader = new BinaryReader(receiveStream);
            MemoryStream memoryStream = new MemoryStream();
              try
              {
                  while (true)
                  {
                      byte b = binaryReader.ReadByte(); // Not so efficient but it works...
                      memoryStream.WriteByte(b);
                  }
              }
              catch (EndOfStreamException)
              {
                  memoryStream.Position = 0;
              }
            string image = reader.ReadToEnd();
            MemoryStream ms = new MemoryStream(Encoding.ASCII.GetBytes(image));
            */

            //Attachment inline = new Attachment(ms, contentId, response.ContentType);
            LinkedResource resource = new LinkedResource(ms, new ContentType(response.ContentType));
            resource.ContentId = contentId;
            resource.ContentType.Name = contentId;
            resource.TransferEncoding = TransferEncoding.Base64;
            resource.ContentLink = new Uri("cid:" + contentId);
            //inline.ContentDisposition.Inline = true;
            //inline.ContentDisposition.DispositionType = DispositionTypeNames.Inline;
            //inline.ContentId = contentId;
            //inline.TransferEncoding = System.Net.Mime.TransferEncoding.Base64;
            //inline.ContentType.MediaType = response.ContentType;
            //inline.ContentType.Name = Name;

            //return inline;
            return resource;
        }

    }
}
