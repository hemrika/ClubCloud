using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace ClubCloud.Service.Model
{
    internal sealed class SignalRConfiguration : DbMigrationsConfiguration<Model.SignalRContainer>
    {
        public SignalRConfiguration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(Model.SignalRContainer context)
        {
        }
    }
}
