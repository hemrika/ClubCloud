using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace ClubCloud.Model
{
    internal sealed class BeheerConfiguration : DbMigrationsConfiguration<Model.BeheerContainer>
    {
        public BeheerConfiguration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(Model.BeheerContainer context)
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

            
                //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            //context.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction, "DROP FULLTEXT INDEX ON dbo.ClubCloud_Vereniging");
            //context.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction, "DROP FULLTEXT CATALOG ClubCloud_Vereniging_catalog]");
        }
    }
}
