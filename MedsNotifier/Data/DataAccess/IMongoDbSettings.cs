using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedsNotifier.Data.DataAccess
{
    public interface IMongoDbSettings
    {
        string DatabaseName { get; set; }
        string ConnectionString { get; set; }
    }
}
