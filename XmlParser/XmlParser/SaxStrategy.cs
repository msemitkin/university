using System;
using System.Collections.Generic;
using System.Xml;

namespace XmlParser
{
    class SaxStrategy : SearchStrategy
    {
        public override List<Bike> Search(string path, Bike filter)
        {
            List<Bike> foundBikes = new List<Bike>();
            using (XmlReader xmlReader = XmlReader.Create(path))
            {
                while (xmlReader.Read())
                {
                    if (xmlReader.NodeType == XmlNodeType.Element)
                    {
                        string brand = xmlReader.GetAttribute("brand");
                        string size = xmlReader.GetAttribute("size");
                        string material = xmlReader.GetAttribute("material");
                        string colour = xmlReader.GetAttribute("colour");
                        int travel = Int32.Parse(xmlReader.GetAttribute("travel"));
                        int wheelSize = Int32.Parse(xmlReader.GetAttribute("wheelsize"));
                        double weight = double.Parse(xmlReader.GetAttribute("weight"));
                        double price = double.Parse(xmlReader.GetAttribute("price"));
                        Bike foundBike = new Bike(brand, size, material,
                            colour, travel, wheelSize, weight, price);
                        if (foundBike.SatisfyFilter(filter))
                        {
                            foundBikes.Add(foundBike);
                        }
                    }

                }
            }
            return foundBikes;
        }
    }
}
