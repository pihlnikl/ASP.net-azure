using MongoDB.Driver;
using webbtjänsterProjekt2_pihlnikl.Models;
using System.Collections.Generic;
using System.Linq;

namespace webbtjänsterProjekt2_pihlnikl.Services
{
    public class CabinServices
    {
        private readonly IMongoCollection<Cabin> _cabins;
        public CabinServices(ICabinDatabaseSetting settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _cabins = database.GetCollection<Cabin>(settings.CabinCollectionName);

        }

        public List<Cabin> Get()
        {
            List<Cabin> cabins;
            cabins = _cabins.Find(cab => true).ToList();
            return cabins;
        }

        public List<Cabin> Get(string owner)
        {
            List<Cabin> cabins;
            cabins = _cabins.Find(cab => cab.owner == owner).ToList();
            return cabins;
        }
            
    }
}
