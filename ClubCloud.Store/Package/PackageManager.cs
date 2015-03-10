//using ClubCloud.Model;
//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Reflection;
//using System.Text;
//using System.Threading.Tasks;

//namespace ClubCloud.Store.Package
//{
//    public class PackageManager : PackageBase
//    {
//        public static ApplicationVersion UploadPackage(Stream stream, int appid, int versionid, string name, long length, out string url)
//        {
//            url = string.Empty;


//            /*
//            CloudBlob blob = _blobContainer.GetBlobReference(name);
//            blob.UploadFromStream(stream);

//            blob.FetchAttributes();
//            bool success = blob.Properties.Length == length;

//            url = blob.Uri.ToString();
//            */
//            bool success = true;

//            if (success && !name.EndsWith(".cer"))
//            {
//                var result = PackageAnalyzer.GetPackageInfo(stream);
//                var package = result.VersionInfo;

//                PropertyInfo[] properties = package.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);

//                foreach (PropertyInfo pi in properties)
//                {
//                    if (pi.Name.StartsWith("LogoUrl_"))
//                    {
//                        var logopath = pi.GetValue(package, null).ToString();

//                        if (!string.IsNullOrEmpty(logopath))
//                        {

//                            //CloudBlob imageBlob = _blobContainer.GetBlobReference(appid.ToString() + "_" + versionid.ToString() + "_" + logopath.Split('\\').Last());

//                            var p = result.GetType().GetProperty(pi.Name + "_Stream");
//                            var logoStream = p.GetValue(result) as Stream;

//                            logoStream.Position = 0;
//                            //imageBlob.UploadFromStream(logoStream);

//                            //pi.SetValue(package, imageBlob.Uri.ToString());
//                        }

//                    }
//                }

//                return package;

//                //if (imageStream != null)
//                //{
//                //    CloudBlob imageBlob =
//                //        _blobContainer.GetBlobReference(appid.ToString() + "_" + versionid.ToString() + "_" + package.LogoUrl_Store.Split('\\').Last());
//                //    imageStream.Position = 0;
//                //    imageBlob.UploadFromStream(imageStream);

//                //    package.LogoUrl_Store = imageBlob.Uri.ToString();
//                //}
//                //return package;
//            }

//            return null;
//        }

//        /*
//        public static string UploadImage(Stream stream, string name, long length)
//        {
//            var url = string.Empty;

//            CloudBlob blob = _blobContainer.GetBlobReference(name);
//            blob.UploadFromStream(stream);

//            blob.FetchAttributes();
//            bool success = blob.Properties.Length == length;

//            if (success)
//            {
//                url = blob.Uri.ToString();
//            }

//            return url;
//        }
//        */
//    }
//}
