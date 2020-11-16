using System;
using System.Collections.Generic;
using System.Xml;

namespace XmlParser
{
    class SaxStrategy : ISearchStrategy
    {
        public List<Bike> Search(string path, BikeFilter filter)
        {
            List<Bike> foundBikes = new List<Bike>();
            using (XmlReader xmlReader = XmlReader.Create(path))
            {
                while (xmlReader.Read())
                {
                    if (xmlReader.NodeType == XmlNodeType.Element && xmlReader.Name == "bike")
                    {
                        Bike foundBike = new Bike();
                        while (xmlReader.MoveToNextAttribute())
                        {
                            if (xmlReader.Name.Equals("brand"))
                            {
                                foundBike.Brand = xmlReader.Value;
                            }
                            if (xmlReader.Name.Equals("size"))
                            {
                                foundBike.Size = xmlReader.Value;
                            }
                            if (xmlReader.Name.Equals("material"))
                            {
                                foundBike.Material = xmlReader.Value;
                            }
                            if (xmlReader.Name.Equals("colour"))
                            {
                                foundBike.Colour = xmlReader.Value;
                            }
                            if (xmlReader.Name.Equals("travel"))
                            {
                                foundBike.Travel = Int32.Parse(xmlReader.Value);
                            }
                            if (xmlReader.Name.Equals("wheelsize"))
                            {
                                foundBike.WheelSize = double.Parse(xmlReader.Value);
                            }
                        }

                        if (filter.satisfyFilter(foundBike))
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
