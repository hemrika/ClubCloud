using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace ClubCloud.Service.Model
{
    internal sealed class BoekhoudingConfiguration : DbMigrationsConfiguration<Model.BoekhoudingContainer>
    {
        public BoekhoudingConfiguration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(Model.BoekhoudingContainer context)
        {
        }
    }
}
