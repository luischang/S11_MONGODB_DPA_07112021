using MongoDB.Driver;
using S11_MONGODB_DPA.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace S11_MONGODB_DPA.API.Repositories
{
    public class CustomerRepository
    {
        private readonly IMongoCollection<Customer> _context;

        public CustomerRepository(ICustomerDatabaseSetting setting)
        {
            var client = new MongoClient(setting.ConnectionString);
            var database = client.GetDatabase(setting.DatabaseName);

            _context = database.GetCollection<Customer>(setting.CustomerCollectionName);
        }


        public async Task<IEnumerable<Customer>> GetCustomers()
        {
            return await _context.Find(x => true).ToListAsync();
        }

        public async Task<Customer> GetCustomerById(string id)
        {
            return await _context.Find<Customer>(x => x.id == id).FirstOrDefaultAsync();
        }

    }
}
