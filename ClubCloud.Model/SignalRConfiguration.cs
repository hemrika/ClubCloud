using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace ClubCloud.Model
{
    internal sealed class SignalRConfiguration : DbMigrationsConfiguration<SignalRContainer>
    {
        public SignalRConfiguration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(SignalRContainer context)
        {
        }
    }
}
