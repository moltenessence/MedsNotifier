using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace MedsNotifier.Data.DataAccess
{
    public class MongoDbSettings : IMongoDbSettings
    {
        public string DatabaseName { get; set; } 
        public string ConnectionString { get; set; }
    }
}
