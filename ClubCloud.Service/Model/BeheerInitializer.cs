﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Service.Model
{
    public class BeheerInitializer : System.Data.Entity.CreateDatabaseIfNotExists<BeheerContainer>
    {
        public override void InitializeDatabase(BeheerContainer context)
        {
            base.InitializeDatabase(context);
        }

        protected override void Seed(BeheerContainer context)
        {
            base.Seed(context);
        }
    }
}