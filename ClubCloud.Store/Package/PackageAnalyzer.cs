using ClubCloud.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Xml.Linq;
using System.Xml.XPath;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ClubCloud.Store.Package
{
    public class PackageAnalyzer : PackageBase
    {
        public static PackageAnalyzeResult GetPackageInfo(Stream packageStream)
        {
            PackageAnalyzeResult result = new PackageAnalyzeResult();
            result.ApplicationVersion = new ApplicationVersion();
            result.ApplicationProcessorArchitecture = new ApplicationProcessorArchitecture();

            using (ZipArchive archive = new ZipArchive(packageStream, ZipArchiveMode.Read))
            {
                foreach (ZipArchiveEntry entry in archive.Entries)
                {
                    if (entry.FullName == "AppxManifest.xml")
                    {
                        var stream = entry.Open();
                        XElement root = XElement.Load(stream);

                        var ns = "http://schemas.microsoft.com/appx/2010/manifest";

                        // for windows store 8.0 and 8.1
                        var ns80 = "http://schemas.microsoft.com/developer/appx/2012/build";
                        var ns81 = "http://schemas.microsoft.com/appx/2013/manifest";

                        bool is80package = root.Attributes().Where(a => a.Value == ns80).Count() > 0;
                        bool is81package = root.Attributes().Where(a => a.Value == ns81).Count() > 0;

                        //app manifest error, can't find manifest schema
                        if (root.Attributes().Where(a => a.Value == ns).Count() <= 0)
                        {
                            return null;
                        }

                        System.Xml.XmlNamespaceManager nsmgr = new System.Xml.XmlNamespaceManager(new System.Xml.NameTable());
                        nsmgr.AddNamespace("ns", ns);

                        XElement identity = root.XPathSelectElement(@"//ns:Identity", nsmgr);

                        string name = identity.Attribute("Name").Value;
                        string version = identity.Attribute("Version").Value;
                        string publisher = identity.Attribute("Publisher").Value;
                        

                        string displayName = root.XPathSelectElement(@"//ns:DisplayName", nsmgr).Value;
                        string publisherDisplayName = root.XPathSelectElement(@"//ns:PublisherDisplayName", nsmgr).Value;
                        string description = root.XPathSelectElement(@"//ns:Description", nsmgr).Value;
                        
                        var protocolElement = root.XPathSelectElement(@"//ns:Extension[@Category='windows.protocol']/ns:Protocol", nsmgr);
                        string protocol = protocolElement == null ? null : (protocolElement == null ? null : protocolElement.Attribute("Name").Value);

                        result.ApplicationVersion = new ApplicationVersion()
                        {
                            IdentityName = name,
                            Version = version,
                            Publisher = publisher,
                            DisplayName = displayName,
                            Description = description,
                            PublisherDisplayName = publisherDisplayName,
                            ProtocolUrl = protocol,
                            OperationDate = DateTime.Now
                        };

                        string _processorArchitecture = identity.Attribute("ProcessorArchitecture").Value;

                        ClubCloud.Model.ProcessorArchitecture architecture = ClubCloud.Model.ProcessorArchitecture.Unknown;

                        switch (_processorArchitecture)
                        {
                            case "arm":
                                architecture = ClubCloud.Model.ProcessorArchitecture.ARM;
                                break;
                            case "x86":
                                architecture = ClubCloud.Model.ProcessorArchitecture.x86;
                                break;
                            case "x64":
                                architecture = ClubCloud.Model.ProcessorArchitecture.x64;
                                break;
                            case "neutral":
                                architecture = ClubCloud.Model.ProcessorArchitecture.Neutual;
                                break;
                        }

                        result.ApplicationProcessorArchitecture = new ApplicationProcessorArchitecture() { ProcessorArchitecture = architecture, UploadDate = DateTime.Now, Version = version };

                        /*
                        applicationVersion.ApplicationProcessorArchitectures.Add(new ApplicationProcessorArchitecture()
                        {
                            ProcessorArchitecture = architecture
                        });
                        */
                        /*
                        string logoUrl_Store = string.Empty;
                        string logoUrl_150x150 = string.Empty;
                        string logoUrl_30x30 = string.Empty;
                        string logoUrl_310x150 = string.Empty;
                        string logoUrl_310x310 = string.Empty;
                        string logoUrl_70x70 = string.Empty;

                        if (is81package)
                        {
                            nsmgr.AddNamespace("ns2", ns81);
                            logoUrl_Store = root.XPathSelectElement(@"//ns:Logo", nsmgr).Value;

                            XElement visualElements = root.XPathSelectElement(@"//ns2:VisualElements", nsmgr);
                            if (visualElements != null)
                            {
                                logoUrl_150x150 = visualElements.Attribute("Square150x150Logo") == null ?
                                                       string.Empty : visualElements.Attribute("Square150x150Logo").Value;
                                logoUrl_30x30 = visualElements.Attribute("Square30x30Logo") == null ?
                                                       string.Empty : visualElements.Attribute("Square30x30Logo").Value;
                            }

                            XElement defaultTile = root.XPathSelectElement(@"//ns2:DefaultTile", nsmgr);
                            if (defaultTile != null)
                            {
                                logoUrl_310x150 = defaultTile.Attribute("Wide310x150Logo") == null ?
                                                       string.Empty : defaultTile.Attribute("Wide310x150Logo").Value;
                                logoUrl_310x310 = defaultTile.Attribute("Square310x310Logo") == null ?
                                                       string.Empty : defaultTile.Attribute("Square310x310Logo").Value;
                                logoUrl_70x70 = defaultTile.Attribute("Square70x70Logo") == null ?
                                                       string.Empty : defaultTile.Attribute("Square70x70Logo").Value;
                            }


                        }
                        else if (is80package)
                        {
                            logoUrl_Store = root.XPathSelectElement(@"//ns:Logo", nsmgr).Value;

                            XElement visualElements = root.XPathSelectElement(@"//ns:VisualElements", nsmgr);
                            if (visualElements != null)
                            {
                                logoUrl_150x150 = visualElements.Attribute("Logo") == null ?
                                                      string.Empty : visualElements.Attribute("Logo").Value;
                                logoUrl_30x30 = visualElements.Attribute("SmallLogo") == null ?
                                                       string.Empty : visualElements.Attribute("SmallLogo").Value;
                            }

                            XElement defaultTile = root.XPathSelectElement(@"//ns:DefaultTile", nsmgr);
                            if (defaultTile != null)
                            {
                                logoUrl_310x150 = defaultTile.Attribute("WideLogo") == null ?
                                                       string.Empty : defaultTile.Attribute("WideLogo").Value;
                            }
                        }

                        applicationVersion.LogoUrl_Store = logoUrl_Store;
                        applicationVersion.LogoUrl_30x30 = logoUrl_30x30;
                        applicationVersion.LogoUrl_150x150 = logoUrl_150x150;
                        applicationVersion.LogoUrl_310x150 = logoUrl_310x150;
                        applicationVersion.LogoUrl_310x310 = logoUrl_310x310;
                        applicationVersion.LogoUrl_70x70 = logoUrl_70x70;
                        */
                    }
                }
                /*
                PropertyInfo[] properties = applicationVersion.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);

                foreach (PropertyInfo pi in properties)
                {
                    if (pi.Name.StartsWith("LogoUrl_"))
                    {
                        var path = pi.GetValue(applicationVersion).ToString().Replace(@"\", @"/");
                        var logoEntry = archive.GetEntry(path);

                        if (logoEntry == null)
                        {
                            pi.SetValue(applicationVersion, string.Empty);
                        }
                        else
                        {
                            var logoStream = new MemoryStream();
                            var zipedStream = logoEntry.Open();
                            zipedStream.CopyTo(logoStream);

                            PropertyInfo p = typeof(PackageAnalyzeResult).GetProperty(pi.Name + "_Stream");
                            p.SetValue(result, logoStream);
                        }
                    }
                }
                */
            }


            //result.ApplicationVersion = applicationVersion;
            //result.ApplicationProcessorArchitecture = applicationProcessorArchitecture;

            return result;
        }

        public static Stream GetFileFromZip(Stream zip, string fileName)
        {
            using (ZipArchive archive = new ZipArchive(zip, ZipArchiveMode.Read))
            {
                var entry = archive.GetEntry(fileName);
                var stream = entry.Open();
                return stream;
            }
        }
    }
}