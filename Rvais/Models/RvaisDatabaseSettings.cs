using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Rvais.Models;

namespace Rvais.Models
{
    public class RvaisDatabaseSettings : IRvaisDatabaseSettings
    {
        public string CollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IRvaisDatabaseSettings
    {
        string CollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
