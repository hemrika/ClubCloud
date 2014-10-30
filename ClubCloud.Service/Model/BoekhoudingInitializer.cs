using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Service.Model
{
    public class BoekhoudingInitializer : System.Data.Entity.CreateDatabaseIfNotExists<BoekhoudingContainer>
    {
        public BoekhoudingInitializer()
        {
        }
        public override void InitializeDatabase(BoekhoudingContainer context)
        {
            base.InitializeDatabase(context);
        }

        protected override void Seed(BoekhoudingContainer context)
        {
            FinancialYear financialYear = context.FinancialYears.Add(new FinancialYear { Closed = false, Current = true, DateEnd = new DateTime(DateTime.Now.Year, 12, 31), DateStart = new DateTime(DateTime.Now.Year, 01, 01), Name = DateTime.Now.Year.ToString(), Description = "" });
            JournalYear journalYear = context.JournalYears.Add(new JournalYear { Description = "", FinancialYearId = financialYear.Id, Name = financialYear.Name });

            CostCenter[] costCenters = new CostCenter[6] {
                new CostCenter{ Name = "Algemeen", Description = ""},
                new CostCenter{ Name = "Organisatie", Description = ""},
                new CostCenter{ Name = "Activiteit", Description = ""},
                new CostCenter{ Name = "Competitie", Description = ""},
                new CostCenter{ Name = "Toernooi", Description = ""},
                new CostCenter{ Name = "Diensten", Description = ""},
            };
            context.CostCenters.AddOrUpdate(costCenters);

            Tax[] taxes = new Tax[5]{
                new Tax { Name = "BTW Vrij", Rate = 0.00M, Description = "Btw die u voor deze goederen of diensten betaalt, kunt u niet aftrekken als voorbelasting." },
                new Tax { Name = "BTW Nul", Rate = 0.00M , Description = "Het 0%-tarief kan gelden als u zakendoet met het buitenland." },
                new Tax { Name = "BTW Laag", Rate = 6.99M , Description = "Verlaagde btw-tarief. Het geldt onder meer voor etenswaren en sommige diensten" },
                new Tax { Name = "BTW Hoog", Rate = 21.00M , Description = "Het algemene btw-tarief" },
                new Tax { Name = "BTW Forfait", Rate = 11.50M , Description = "U hebt een sportkantine en u kiest ervoor om 11,5% btw te betalen over uw totale kantineontvangsten inclusief btw." },
            };
            context.Taxes.AddOrUpdate(taxes);

            JournalType[] journalTypes = new JournalType[5] {
                new JournalType{ Name = "Kasboek", Description = ""},
                new JournalType{ Name = "Bankboek", Description = ""},
                new JournalType{ Name = "Verkoopboek", Description = ""},
                new JournalType{ Name = "Inkoopboek", Description = ""},
                new JournalType{ Name = "Memoriaal", Description = ""},
            };
            context.JournalTypes.AddOrUpdate(journalTypes);

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

            base.Seed(context);
        }
    }
}
