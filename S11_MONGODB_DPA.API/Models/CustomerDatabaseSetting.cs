using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace S11_MONGODB_DPA.API.Models
{
    public class CustomerDatabaseSetting : ICustomerDatabaseSetting
    {
        public string CustomerCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
