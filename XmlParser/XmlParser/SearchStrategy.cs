using System.Collections.Generic;

namespace XmlParser
{
    public abstract class SearchStrategy
    {
        public abstract List<Bike> Search(string path, BikeFilter filter);
    }
}
