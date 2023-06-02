using System;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using System.Data;
using System.Windows.Forms.DataVisualization.Charting;

namespace fat_secret
{

    public struct Product
    {
        public string Time;
        public string Name;
        public string Weight;
        public string Proteins;
        public string Fats;
        public string Carbonhydrates;
        public string Calories;
        public string Date;
    }

    public partial class main_window : Form
    {

        private double RSK = 0;
        private string RSK_filepath = "RSK.txt";
        private string consumed_products_path = "consumed_products.txt";
        private double current_calories = 0;

        public main_window()
        {
            InitializeComponent();
            get_RSK_from_file();
            get_consumed_products();
        }

        private void get_RSK_from_file()
        {
            string content = File.ReadAllText(RSK_filepath);
            RSK = Convert.ToDouble(content);
            tb_RSK.Text = String.Format(Convert.ToString(RSK));
            pb_total_kkal.Maximum = (int)(RSK * 2);
        }

        private void get_consumed_products()
        {
            string[] input = File.ReadAllLines(consumed_products_path);
            string today_date = Convert.ToString(DateTime.Today);
            today_date = today_date.Substring(0, today_date.Length - 8);
            foreach (string line in input)
            {
                string[] words = line.Split(' ');
                if (words[6] == "Завтрак" && words[7] == today_date)
                {
                    dg_breakfast.Rows.Add(words[0], words[1], words[2], words[3], words[4], words[5]);
                    current_calories += Convert.ToDouble(words[5]);
                }
                else if (words[6] == "Обед" && words[7] == today_date)
                {
                    dg_lunch.Rows.Add(words[0], words[1], words[2], words[3], words[4], words[5]);
                    current_calories += Convert.ToDouble(words[5]);
                }
                else if (words[6] == "Ужин" && words[7] == today_date)
                {
                    dg_dinner.Rows.Add(words[0], words[1], words[2], words[3], words[4], words[5]);
                    current_calories += Convert.ToDouble(words[5]);
                }
                current_kkal.Text = Convert.ToString(current_calories);
                pb_total_kkal.Value = (int)(current_calories);
            }
        }

        private void delete_line(DataGridViewRow row, string time)
        {
            string name = Convert.ToString(row.Cells[0].Value);
            string weight = Convert.ToString(row.Cells[1].Value);
            string proteins = Convert.ToString(row.Cells[2].Value);
            string fats = Convert.ToString(row.Cells[3].Value);
            string carbons = Convert.ToString(row.Cells[4].Value);
            string calories = Convert.ToString(row.Cells[5].Value);
            string date = Convert.ToString(DateTime.Today);
            date = date.Substring(0, date.Length - 8);
            string deleting_line = name + " " + weight + " " + proteins + " " + fats + " " + carbons + " " + calories + " " + time + " " + date;

            string[] input = File.ReadAllLines(consumed_products_path);
            for (int i=0; i<input.Length; i++)
            {
                if (input[i] == deleting_line)
                {
                    var tmp = new string[input.Length-1];
                    Array.Copy(input, 0, tmp, 0, i);
                    Array.Copy(input, i+1, tmp, i, input.Length-i-1);
                    input = tmp;
                    break;
                }
            }
            File.WriteAllLines(consumed_products_path, input);
        }

        public void receive_data(Product data)
        {
            if (data.Time == "Завтрак")
            {
                dg_breakfast.Rows.Add(data.Name, data.Weight, data.Proteins, data.Fats, data.Carbonhydrates, data.Calories);
            }
            else if (data.Time == "Обед")
            {
                dg_lunch.Rows.Add(data.Name, data.Weight, data.Proteins, data.Fats, data.Carbonhydrates, data.Calories);
            }
            else if (data.Time == "Ужин")
            {
                dg_dinner.Rows.Add(data.Name, data.Weight, data.Proteins, data.Fats, data.Carbonhydrates, data.Calories);
            }
            current_calories += Convert.ToDouble(data.Calories);
            current_kkal.Text = Convert.ToString(current_calories);
            pb_total_kkal.Value = (int)(current_calories);

            string[] output = { data.Name + " " + data.Weight + " " + data.Proteins + " " + data.Fats + " " + data.Carbonhydrates + " " + data.Calories + " " + data.Time + " " + data.Date.Substring(0, data.Date.Length - 8)};
            File.AppendAllLines(consumed_products_path, output);
        }
       
        private void btn_RSK_Click(object sender, EventArgs e)
        {
            if (cb_gender.SelectedItem.ToString() == "Ж")
            {
                RSK = 9.99 * Convert.ToInt32(tb_weight.Text.ToString()) + 6.26 * Convert.ToInt32(tb_height.Text.ToString()) - 4.92 * Convert.ToInt32(tb_age.Text.ToString()) - 161;
            }
            else
            {
                RSK = 9.99 * Convert.ToInt32(tb_weight.Text.ToString()) + 6.25 * Convert.ToInt32(tb_height.Text.ToString()) - 4.92 * Convert.ToInt32(tb_age.Text.ToString()) + 5;
            }
            if (cb_dinweight.SelectedItem.ToString() == "снизить")
            {
                RSK *= Convert.ToDouble(tb_KA.Text.ToString()) - 0.75;
            }
            if (cb_dinweight.SelectedItem.ToString() == "увеличить")
            {
                RSK *= Convert.ToDouble(tb_KA.Text.ToString()) + 0.75;
            }
            else
            {
                RSK *= Convert.ToDouble(tb_KA.Text.ToString());
            }

            File.WriteAllText(RSK_filepath, Convert.ToString(RSK));
            tb_RSK.Text = String.Format(Convert.ToString(RSK));
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            add_product_form f = new add_product_form(this);
            f.ShowDialog();
        }

        private void dg_breakfast_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    current_calories -= Convert.ToDouble(dg_breakfast.Rows[e.RowIndex].Cells[5].Value);
                    current_kkal.Text = Convert.ToString(current_calories);

                    delete_line(dg_breakfast.Rows[e.RowIndex], "Завтрак");

                    pb_total_kkal.Value = (int)(current_calories);
                    dg_breakfast.Rows.RemoveAt(e.RowIndex);
                }
                catch
                {

                }
            }
        }

        private void dg_lunch_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    current_calories -= Convert.ToDouble(dg_lunch.Rows[e.RowIndex].Cells[5].Value);
                    current_kkal.Text = Convert.ToString(current_calories);

                    delete_line(dg_lunch.Rows[e.RowIndex], "Обед");

                    pb_total_kkal.Value = (int)(current_calories);
                    dg_lunch.Rows.RemoveAt(e.RowIndex);
                }
                catch
                {

                }
            }
        }

        private void dg_dinner_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    current_calories -= Convert.ToDouble(dg_dinner.Rows[e.RowIndex].Cells[5].Value);
                    current_kkal.Text = Convert.ToString(current_calories);

                    delete_line(dg_dinner.Rows[e.RowIndex], "Ужин");

                    pb_total_kkal.Value = (int)(current_calories);
                    dg_dinner.Rows.RemoveAt(e.RowIndex);
                }
                catch
                {

                }
            }
        }

        private void make_report_Click(object sender, EventArgs e)
        {
            double last_six_days_calories = 0;
            double last_five_days_calories = 0;
            double last_four_days_calories = 0;
            double last_three_days_calories = 0;
            double last_two_days_calories = 0;
            double yesterday_calories = 0;
            double nowadays_calories = current_calories;

            string last_six_days_date = Convert.ToString(DateTime.Now.AddDays(-6)).Substring(0, 10);
            string last_five_days_date = Convert.ToString(DateTime.Now.AddDays(-5)).Substring(0, 10);
            string last_four_days_date = Convert.ToString(DateTime.Now.AddDays(-4)).Substring(0, 10);
            string last_three_days_date = Convert.ToString(DateTime.Now.AddDays(-3)).Substring(0, 10);
            string last_two_days_date = Convert.ToString(DateTime.Now.AddDays(-2)).Substring(0, 10);
            string yesterday_date = Convert.ToString(DateTime.Now.AddDays(-1)).Substring(0, 10);
            string today_date = Convert.ToString(DateTime.Now).Substring(0, 10);

            string[] input = File.ReadAllLines(consumed_products_path);
            foreach(string line in input)
            {
                string[] words = line.Split(' ');
                double calories = Convert.ToDouble(words[5]);
                if (words[7] == yesterday_date)
                    yesterday_calories += calories;
                else if (words[7] == last_two_days_date)
                    last_two_days_calories += calories;
                else if (words[7] == last_three_days_date)
                    last_three_days_calories += calories;
                else if (words[7] == last_four_days_date)
                    last_four_days_calories += calories;
                else if (words[7] == last_five_days_date)
                    last_five_days_calories += calories;
                else if (words[7] == last_six_days_date)
                    last_six_days_calories += calories;
            }

            gist_week.ChartAreas[0].AxisY.Maximum = RSK * 2;
            gist_week.Series.Clear();
            gist_week.Series.Add("Test");
            gist_week.Series[0].Points.AddXY(last_six_days_date, last_six_days_calories);
            gist_week.Series[0].Points.AddXY(last_five_days_date, last_five_days_calories);
            gist_week.Series[0].Points.AddXY(last_four_days_date, last_four_days_calories);
            gist_week.Series[0].Points.AddXY(last_three_days_date, last_three_days_calories);
            gist_week.Series[0].Points.AddXY(last_two_days_date, last_two_days_calories);
            gist_week.Series[0].Points.AddXY(yesterday_date, yesterday_calories);
            gist_week.Series[0].Points.AddXY(today_date, nowadays_calories);
        }

    }
}
