using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Service.Model
{
    public class MijnInitializer : System.Data.Entity.CreateDatabaseIfNotExists<MijnContainer>
    {
        public override void InitializeDatabase(MijnContainer context)
        {
            base.InitializeDatabase(context);
        }

        protected override void Seed(MijnContainer context)
        {
            base.Seed(context);
        }
    }
}
