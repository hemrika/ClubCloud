using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Service.Model
{
    public class SignalRInitializer : System.Data.Entity.CreateDatabaseIfNotExists<SignalRContainer>
    {
        public SignalRInitializer()
        {
        }
        public override void InitializeDatabase(SignalRContainer context)
        {
            base.InitializeDatabase(context);
        }

        protected override void Seed(SignalRContainer context)
        {
            base.Seed(context);
        }
    }
}
