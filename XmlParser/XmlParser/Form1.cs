using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace XmlParser
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        public XmlDocument readFile(string path)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(path);
            return doc;

        }
        private void HtmBbutton_Click(object sender, EventArgs e)
        {

        }

        private void SaxRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DomRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LinqRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void OpenFileMenuItem_Click(object sender, EventArgs e)
        {
            string filter = @"XML Files (*.xml)| *.xml";
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = filter;
            dialog.ShowDialog();
            dialog.DefaultExt = ".xml";
            string path = dialog.FileName;
            Debug.WriteLine(path);
            var doc = XDocument.Load(path);
            var bikes = from obj in doc.Descendants("bike")
                        select new
                        {
                            brand = obj.Attribute("brand").Value,
                            size = obj.Attribute("size").Value,
                            material = obj.Attribute("material").Value,
                            colour = obj.Attribute("colour").Value,
                            travel = obj.Attribute("travel").Value,
                            wheelsize = obj.Attribute("wheelsize").Value,
                            weight = obj.Attribute("weight").Value,
                            price = obj.Attribute("price").Value
                        };
            foreach (var bike in bikes)
            {
                if (!BrandComboBox.Items.Contains(bike.brand))
                    BrandComboBox.Items.Add(bike.brand);
                if (!SizeComboBox.Items.Contains(bike.size))
                    SizeComboBox.Items.Add(bike.size);
                if (!ColourComboBox.Items.Contains(bike.colour))
                    ColourComboBox.Items.Add(bike.colour);
                if (!MaterialComboBox.Items.Contains(bike.material))
                    MaterialComboBox.Items.Add(bike.material);
                if (!PriceComboBox.Items.Contains(bike.brand))
                    BrandComboBox.Items.Add(bike.brand);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            Bike filter = new Bike();
            filter.Brand =
            filter.Colour =
        }
    }
}
