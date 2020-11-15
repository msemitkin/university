using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Xsl;

namespace XmlParser
{
    public partial class mainForm : Form
    {
        public readonly string FILE_FILTER = @"XML Files (*.xml)| *.xml";
        public readonly string DEFAULT_EXTENTION = ".xml";
        public string path = "";
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
            XslCompiledTransform xct = new XslCompiledTransform();
            string dirPath = Path.GetDirectoryName(path);
            string xslPath = $@"{dirPath}\example.xsl";
            string htmlPath = $@"{dirPath}\example.html";
            xct.Load(xslPath);
            xct.Transform(path, htmlPath);
        }

        private void requestPath()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = FILE_FILTER;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                dialog.DefaultExt = DEFAULT_EXTENTION;
                path = dialog.FileName;
            }
        }

        private void LoadFilters(string path)
        {
            var doc = XDocument.Load(path);
            var bikes = from obj in doc.Element("bikes").Elements("bike")
                        select new Bike
                        {
                            Brand = obj.Attribute("brand").Value,
                            Size = obj.Attribute("size").Value,
                            Material = obj.Attribute("material").Value,
                            Colour = obj.Attribute("colour").Value,
                            Travel = Int32.Parse(obj.Attribute("travel").Value),
                            WheelSize = double.Parse(obj.Attribute("wheelsize").Value),
                        };
            foreach (var bike in bikes)
            {
                if (!BrandComboBox.Items.Contains(bike.Brand))
                    BrandComboBox.Items.Add(bike.Brand);
                if (!SizeComboBox.Items.Contains(bike.Size))
                    SizeComboBox.Items.Add(bike.Size);
                if (!ColourComboBox.Items.Contains(bike.Colour))
                    ColourComboBox.Items.Add(bike.Colour);
                if (!MaterialComboBox.Items.Contains(bike.Material))
                    MaterialComboBox.Items.Add(bike.Material);
                if (!TravelComboBox.Items.Contains(bike.Travel))
                    TravelComboBox.Items.Add(bike.Travel);
                if (!WheelSizeComboBox.Items.Contains(bike.WheelSize))
                    WheelSizeComboBox.Items.Add(bike.WheelSize);
            }
        }

        private void OpenFileMenuItem_Click(object sender, EventArgs e)
        {
            requestPath();
            if (!path.Equals(""))
            {
                LoadFilters(path);
            }
        }
        private string GetResult(BikeFilter filter, SearchStrategy searchStrategy)
        {
            List<Bike> foundBikes = searchStrategy.Search(path, filter);

            if (foundBikes.Count < 1)
            {
                return "No bikes found that satisfy filters";
            }
            string result = "";
            foreach (Bike bike in foundBikes)
                result += bike.ToString();
            return result;
        }
        private void InitializeFilter(BikeFilter filter)
        {
            filter.Brand = BrandComboBox.GetItemText(BrandComboBox.SelectedItem);
            filter.Colour = ColourComboBox.GetItemText(ColourComboBox.SelectedItem);
            filter.Material = MaterialComboBox.GetItemText(MaterialComboBox.SelectedItem);
            filter.Size = SizeComboBox.GetItemText(SizeComboBox.SelectedItem);
            try
            {
                filter.Travel = Int32.Parse(TravelComboBox.GetItemText(TravelComboBox.SelectedItem));
            }
            catch (FormatException)
            {
                filter.Travel = 0;
            }
            try
            {
                filter.WheelSize = double.Parse(WheelSizeComboBox.GetItemText(WheelSizeComboBox.SelectedItem));
            }
            catch (FormatException)
            {
                filter.WheelSize = 0;
            }

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            BikeFilter filter = new BikeFilter();

            InitializeFilter(filter);

            if (LinqRadioButton.Checked == true)
            {
                SearchStrategy strategy = new LinqStrategy();
                richTextBox.Text = GetResult(filter, strategy);
            }
            else if (DomRadioButton.Checked == true)
            {
                SearchStrategy strategy = new DomStrategy();
                richTextBox.Text = GetResult(filter, strategy);
            }
            else if (SaxRadioButton.Checked == true)
            {
                SearchStrategy strategy = new SaxStrategy();
                richTextBox.Text = GetResult(filter, strategy);
            }
            else
            {
                MessageBox.Show("Please choose parser",
                    "No parser chosen", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            BrandComboBox.SelectedItem = null;
            ColourComboBox.SelectedItem = null;
            SizeComboBox.SelectedItem = null;
            MaterialComboBox.SelectedItem = null;
            TravelComboBox.SelectedItem = null;
            WheelSizeComboBox.SelectedItem = null;
            LinqRadioButton.Checked = false;
            SaxRadioButton.Checked = false;
            DomRadioButton.Checked = false;
        }
    }
}
