using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Store.Package
{
    public class PackageBase
    {
        protected static string _constr;
        //protected static CloudStorageAccount _storageAccount;
        //protected static CloudBlobContainer _blobContainer;
        static PackageBase()
        {
            //_constr = ConfigurationManager.ConnectionStrings["StorageAccount"].ToString();
            //_storageAccount = CloudStorageAccount.Parse(_constr);
            //_blobContainer = _storageAccount.CreateCloudBlobClient().GetContainerReference("bootybaystore");
        }
    }
}
