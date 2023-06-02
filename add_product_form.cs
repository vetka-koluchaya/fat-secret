using Newtonsoft.Json;
using System;
using System.Windows.Forms;
using System.IO;

namespace fat_secret
{
    public partial class add_product_form : Form
    {

        private main_window main;
        private dynamic products;

        public add_product_form(main_window window)
        {
            InitializeComponent();
            this.main = window;
            get_products_from_file();
        }

        private void get_products_from_file()
        {
            string json = File.ReadAllText("product_data.json");
            this.products = JsonConvert.DeserializeObject(json);
            foreach (dynamic product in products)
            {
                string product_name = Convert.ToString(product["Name"]);
                this.product_selector.Items.Add(product_name);
            }
            this.product_selector.SelectedIndex = 0;
        }

        private void calculate()
        {
            string input = product_weight.Text;
            if (double.TryParse(input, out double weight) && weight >= 0)
            {
                string product_name = product_selector.Text;
                foreach (dynamic product in products)
                {
                    if (product["Name"] == product_name)
                    {
                        double proteins = Convert.ToDouble(product["Protein"]) / 100 * weight;
                        double fats = Convert.ToDouble(product["Fat"]) / 100 * weight;
                        double carbonhydrates = Convert.ToDouble(product["Carbohydrates"]) / 100 * weight;
                        double calories = Convert.ToDouble(product["Сalories"]) / 100 * weight;
                        this.proteins_weight.Text = Convert.ToString(proteins);
                        this.fats_weight.Text = Convert.ToString(fats);
                        this.carbonhydrates_weight.Text = Convert.ToString(carbonhydrates);
                        this.calories_weight.Text = Convert.ToString(calories);
                    }
                }
            }

            else
            {
                return;
            }
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            string input = product_weight.Text;
            if (double.TryParse(input, out double weight) && weight >= 0)
            {
                Product data;
                data.Time = period_selector.Text;
                data.Name = product_selector.Text;
                data.Weight = product_weight.Text;
                data.Proteins = proteins_weight.Text;
                data.Fats = fats_weight.Text;
                data.Carbonhydrates = carbonhydrates_weight.Text;
                data.Calories = calories_weight.Text;
                data.Date = Convert.ToString(DateTime.Today);
                main.receive_data(data);
            }
            else
            {
                return;
            }
            this.Close();
        }

        private void product_selector_SelectedIndexChanged(object sender, EventArgs e)
        {
            calculate();
        }

        private void product_weight_TextChanged(object sender, EventArgs e)
        {
            calculate();
        }

    }
}
