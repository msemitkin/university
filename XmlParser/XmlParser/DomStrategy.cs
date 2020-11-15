using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Xml;

namespace XmlParser
{
    class DomStrategy : SearchStrategy
    {
        public override List<Bike> Search(string path, BikeFilter filter)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            List<Bike> foundBikes = new List<Bike>();
            XmlNode rootNode = doc.DocumentElement;
            foreach (XmlNode node in rootNode.ChildNodes)
            {
                Bike bike = new Bike();
                foreach (XmlAttribute attribute in node.Attributes)
                {
                    if (attribute.Name.Equals("brand"))
                    {
                        bike.Brand = attribute.Value;
                    }
                    if (attribute.Name.Equals("size"))
                    {
                        bike.Size = attribute.Value;
                    }
                    if (attribute.Name.Equals("material"))
                    {
                        bike.Material = attribute.Value;
                    }
                    if (attribute.Name.Equals("colour"))
                    {
                        bike.Colour = attribute.Value;
                    }
                    if (attribute.Name.Equals("travel"))
                    {
                        bike.Travel = Int32.Parse(attribute.Value);
                    }
                    if (attribute.Name.Equals("wheelsize"))
                    {
                        bike.WheelSize = double.Parse(attribute.Value);
                    }
                }
                if (filter.satisfyFilter(bike))
                {
                    foundBikes.Add(bike);
                }
            }
            return foundBikes;
        }
    }
}
