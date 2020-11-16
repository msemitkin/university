using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace XmlParser
{
    public class LinqStrategy : ISearchStrategy
    {
        public List<Bike> Search(string path, BikeFilter filter)
        {
            var doc = XDocument.Load(path);
            var foundBikes = from obj in doc.Element("bikes").Elements("bike")
                             where filter.satistyFilter(obj)
                             select new Bike
                             {
                                 Brand = obj.Attribute("brand").Value,
                                 Size = obj.Attribute("size").Value,
                                 Material = obj.Attribute("material").Value,
                                 Colour = obj.Attribute("colour").Value,
                                 Travel = Int32.Parse(obj.Attribute("travel").Value),
                                 WheelSize = double.Parse(obj.Attribute("wheelsize").Value),
                             };
            return foundBikes.ToList();
        }
    }
}
