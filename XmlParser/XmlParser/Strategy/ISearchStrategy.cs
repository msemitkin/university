using System.Collections.Generic;

namespace XmlParser
{
    public interface ISearchStrategy
    {
        public List<Bike> Search(string path, BikeFilter filter);
    }
}
