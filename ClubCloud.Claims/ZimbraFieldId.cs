using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Provider
{
    public sealed class ZimbraFieldId
    {
        static ZimbraFieldId()
        {
            ZimbraFieldId.Title = new Guid("{fa564e0f-0c70-4ab9-b863-0177e6ddd247}");
            ZimbraFieldId.MobilePhone = new Guid("{bf03d3ca-aa6e-4845-809a-b4378b37ce08}");
            ZimbraFieldId.Name = new Guid("{bfc6f32c-668c-43c4-a903-847cca2f9b3c}");
            ZimbraFieldId.EMail = new Guid("{fce16b4c-fe53-4793-aaab-b4892e736d15}");
            ZimbraFieldId.SipAddress = new Guid("{829c275d-8744-4d9b-a42f-53f53eb60559}");
            ZimbraFieldId.Picture = new Guid("{d9339777-b964-489a-bf09-2ac3c3fe5f0d}");
            ZimbraFieldId.Department = new Guid("{05fdf852-4b64-4096-9b2b-d2a62a86bc59}");
            ZimbraFieldId.JobTitle = new Guid("{c4e0f350-52cc-4ede-904c-dd71a3d11f7d}");
            ZimbraFieldId.WorkPhone = new Guid("{fd630629-c165-4513-b43c-fdb16b86a14d}");
            ZimbraFieldId.HomePhone = new Guid("{2ab923eb-9880-4b47-9965-ebf93ae15487}");
            ZimbraFieldId.CellPhone = new Guid("{2a464df1-44c1-4851-949d-fcd270f0ccf2}");
            ZimbraFieldId.Company = new Guid("{038d1503-4629-40f6-adaf-b47d1ab2d4fe}");
            ZimbraFieldId.MiddleName = new Guid("{418c8d29-6f2e-44c3-8955-2cd7ec3e2151}");
            ZimbraFieldId.HomeAddressStreet = new Guid("{8c66e340-0985-4d68-af03-3050ece4862b}");
            ZimbraFieldId.HomeAddressCity = new Guid("{5aeabc56-57c6-4861-bc12-bd72c30fc6bd}");
            ZimbraFieldId.HomeAddressStateOrProvince = new Guid("{f5b36006-69b0-418c-bd4a-f25ca7e096bb}");
            ZimbraFieldId.HomeAddressPostalCode = new Guid("{c0e4b4c6-6245-4846-8561-b8c6c01fefc1}");
            ZimbraFieldId.HomeAddressCountry = new Guid("{897ecfd7-4293-4782-b463-bd68440a5fed}");
            ZimbraFieldId.UserName = new Guid("{211a8cfc-93b7-4173-9254-0bfe2d1643da}");
            ZimbraFieldId.FirstName = new Guid("{4a722dd4-d406-4356-93f9-2550b8f50dd0}");
            ZimbraFieldId.FullName = new Guid("{475c2610-c157-4b91-9e2d-6855031b3538}");

        }

        public static Guid MobilePhone;

        public static Guid Name;

        public static Guid EMail;

        public static Guid SipAddress;

        public static Guid Picture;

        public static Guid Department;

        public static Guid JobTitle;

        public static Guid WorkPhone;

        public static Guid HomePhone;

        public static Guid CellPhone;

        public static Guid Company;

        public static Guid MiddleName;

        public static Guid HomeAddressStreet;

        public static Guid HomeAddressCity;

        public static Guid HomeAddressStateOrProvince;

        public static Guid HomeAddressPostalCode;

        public static Guid HomeAddressCountry;

        public static Guid UserName;

        public static Guid FirstName;

        public static Guid FullName;

        public static Guid Title;
    }
}
