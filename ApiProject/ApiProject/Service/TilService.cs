using ApiProject.model;
using System.Text;

namespace ApiProject.Service
{
    public class TilService
    {
        public TilService()
        {

        }
        public IEnumerable<Til> GetData()
        {
            return DB.data;
        }
        public IEnumerable<Til> GetData(string city)
        {
            return DB.data.Where(t => t.Locations.City.Equals(city)).ToList();
        }
        public IEnumerable<string> GetLocations()
        {
            return DB.data.Select(t => t.Locations.City).ToList();

        }
        public bool Add(Til til)
        {
            DB.data.Add(til);
            return true;
        }
    }
}
