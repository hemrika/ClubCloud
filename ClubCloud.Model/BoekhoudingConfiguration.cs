using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace ClubCloud.Model
{
    internal sealed class BoekhoudingConfiguration : DbMigrationsConfiguration<BoekhoudingContainer>
    {
        public BoekhoudingConfiguration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(BoekhoudingContainer context)
        {
        }
    }
}
