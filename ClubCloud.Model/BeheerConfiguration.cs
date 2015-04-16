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
            //context.ClubCloud_Verenigingen.AddOrUpdate
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
