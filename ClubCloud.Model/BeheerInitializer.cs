using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Model
{
    public class BeheerInitializer : System.Data.Entity.CreateDatabaseIfNotExists<BeheerContainer>
    {
        public BeheerInitializer()
        {
        }
        public override void InitializeDatabase(BeheerContainer context)
        {
            base.InitializeDatabase(context);
        }

        protected override void Seed(BeheerContainer context)
        {
            base.Seed(context);
            try
            {
                context.ClubCloud_Settings.AddOrUpdate(
                    new ClubCloud_Setting { Access = true, Agree = true, GebruikerId = new Guid("6F0DF085-8B6C-414C-9A2E-27DC351B0C39"), Id = 12073385, Password = "yByDYj2MctGhkpH0ZEGrww==", VerenigingId = new Guid("02ADA6C7-80F9-4671-91F9-898EA5DA3CCD"), Gewijzigd = DateTime.Now }
                    );
                context.SaveChanges();
            }
            catch { };
        }
    }
}
