using P03_SalesDatabase.Data.Models;
using P03_SalesDatabase.Data.Seeding.Contracts;
using P03_SalesDatabase.IOManagement.Contracts;

namespace P03_SalesDatabase.Data.Seeding
{
    public class StoreSeeder : ISeeder
    {
        private readonly SalesContext dbContext;
        private readonly IWriter writer; 

        public StoreSeeder(SalesContext context, IWriter writer)
        {
            this.dbContext = context;
            this.writer = writer;
        }
        public void Seed()
        {
            Store[] stores = new Store[]
            {
                new Store{Name = "PCTech Sofia"},
                new Store{Name = "PCTech Varna"},
                new Store{Name = "PCTech Plovdiv"},
                new Store{Name = "InovativeTech Sofia"},
                new Store{Name = "InovativeTech Plovdiv"},
                new Store{Name = "InovativeTech Varna"}
            };

            this.dbContext.Stores.AddRange(stores);
            
            this.dbContext.SaveChanges();
            
            this.writer.WriteLine($"{stores.Length} stores were added to the database!");
        }
    }
}
