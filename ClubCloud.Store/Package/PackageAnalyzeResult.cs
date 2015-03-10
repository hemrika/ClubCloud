using ClubCloud.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Store.Package
{
    public class PackageAnalyzeResult
    {
        public ApplicationVersion ApplicationVersion { get; set; }
        public ApplicationProcessorArchitecture ApplicationProcessorArchitecture { get; set; }

        /*
        public Stream LogoUrl_Store_Stream { get; set; }
        public Stream LogoUrl_150x150_Stream { get; set; }
        public Stream LogoUrl_30x30_Stream { get; set; }
        public Stream LogoUrl_310x150_Stream { get; set; }
        public Stream LogoUrl_310x310_Stream { get; set; }
        public Stream LogoUrl_70x70_Stream { get; set; }
        */
    }

}
