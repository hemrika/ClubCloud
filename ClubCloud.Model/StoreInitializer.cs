using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Model
{

    public class StoreInitializer : System.Data.Entity.CreateDatabaseIfNotExists<StoreContainer>
    {
        public StoreInitializer()
        {
        }
        public override void InitializeDatabase(StoreContainer context)
        {
            base.InitializeDatabase(context);
        }

        protected override void Seed(StoreContainer context)
        {
            base.Seed(context);
        }
    }
}
