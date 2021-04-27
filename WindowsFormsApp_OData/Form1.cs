using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace WindowsFormsApp_OData
{
    public partial class CharProcuctPrice : Form
    {
        JArray wholeDataAsArray;
        Dictionary<string, float> productPrice;
        string orderOption = "asc";
        bool downloadedData = false;

        public CharProcuctPrice()
        {
            InitializeComponent();
        }

        private void PriceProduct_char(object sender, EventArgs e)
        {

        }

        private void LoadData_button(object sender, EventArgs e)
        {
            chartPriceforProduct.Series["Price"].Points.Clear();

            HttpRequest http = new HttpRequest();
            try
            {
                wholeDataAsArray = http.loadData();
                ProcessingData processData = new ProcessingData();
                productPrice = processData.takeNamePrice(wholeDataAsArray);

                string dataForLabel = "Data: ";
                for (int i = 0; i < productPrice.Count; i++)
                {
                    dataForLabel += " \n " + (i + 1) + ". " + productPrice.ElementAt(i).Key.ToString() + "  " + productPrice.ElementAt(i).Value.ToString();
                    chartPriceforProduct.Series["Price"].Points.AddXY(productPrice.ElementAt(i).Key, productPrice.ElementAt(i).Value);
                }

                label1.Text = dataForLabel;
                downloadedData = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong downloading data", "Error");
            }            
        }

        private void DataShort_label(object sender, EventArgs e)
        {

        }

        private void ShowJson_button(object sender, EventArgs e)
        {
            if (wholeDataAsArray != null) MessageBox.Show(wholeDataAsArray[0].ToString(), "Example data");
            else MessageBox.Show("First download data", "Error");
        }

        private void SortData_button(object sender, EventArgs e)
        {
            orderOption = orderOption == "asc" ? "desc" : "asc";
            try
            {
                var sortedByPrice = (from entry in productPrice orderby entry.Value ascending select entry);
                if (orderOption == "desc")
                {
                    sortedByPrice = (from entry in productPrice orderby entry.Value descending select entry);
                }

                chartPriceforProduct.Series["Price"].Points.Clear();
                foreach (var item in sortedByPrice)
                {
                    chartPriceforProduct.Series["Price"].Points.AddXY(item.Key, item.Value);
                }
            } catch (Exception)
            {
                MessageBox.Show("First download data.", "Error");
            }
        }

        private void FiltrPrice_button(object sender, EventArgs e)
        {
            var priceTextBox = textBox1.Text;
            float priceValue = 0;
            bool parseDone = true;

            try
            {
                priceValue = float.Parse(priceTextBox);
            }
            catch (Exception)
            {
                MessageBox.Show("Incorrect data.", "Error");
                parseDone = false;
            }

            if (parseDone && downloadedData)
            {
                chartPriceforProduct.Series["Price"].Points.Clear();
                var priceBelow50 = (
                from entry in productPrice
                where entry.Value < priceValue
                orderby entry.Value ascending
                select entry
                );

                foreach (var item in priceBelow50)
                {
                    chartPriceforProduct.Series["Price"].Points.AddXY(item.Key, item.Value);
                }
            } else if (!downloadedData)
            {
                MessageBox.Show("First download data.", "Error");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
