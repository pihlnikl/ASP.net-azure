using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webbtjänsterProjekt2_pihlnikl
{
    public class CabinDatabaseSetting : ICabinDatabaseSetting
    {
        public string CabinCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
    public interface ICabinDatabaseSetting
    {
        public string CabinCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
