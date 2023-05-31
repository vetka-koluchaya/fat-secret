using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fat_secret
{
    public partial class main_window : Form
    {
        public main_window()
        {
            InitializeComponent();
        }

        private void calculate_RSK_Click(object sender, EventArgs e)
        {
            double total_res;
            double res;
            if (cb_gender.SelectedValue.ToString() == "Ж")
            {
                total_res = 9.99 * Convert.ToInt32(tb_weight.Text.ToString()) + 6.26 * Convert.ToInt32(tb_height.Text.ToString()) - 4.92 * Convert.ToInt32(tb_age.Text.ToString()) - 161;
            }
            else
            {
                total_res = 9.99 * Convert.ToInt32(tb_weight.Text.ToString()) + 6.25 * Convert.ToInt32(tb_height.Text.ToString()) - 4.92 * Convert.ToInt32(tb_age.Text.ToString()) + 5;
            }
            if(cb_dinweight.SelectedValue.ToString() == "снизить")
            {
                res = total_res * Convert.ToInt32(tb_KA.Text.ToString()) - total_res * 0.75;
            }
            if (cb_dinweight.SelectedValue.ToString() == "увеличить")
            {
                res = total_res * Convert.ToInt32(tb_KA.Text.ToString()) + total_res * 0.75;
            }
            else
            {
                res = total_res * Convert.ToInt32(tb_KA.Text.ToString());
            }

            // вывод
            tb_RSK.Text = String.Format(Convert.ToString(res));





            // сслыка на построение гистограммы 
            // https://ru.stackoverflow.com/questions/717121/c-winforms-%D0%B8%D1%81%D0%BF%D0%BE%D0%BB%D1%8C%D0%B7%D0%BE%D0%B2%D0%B0%D0%BD%D0%B8%D0%B5-chart-%D0%B4%D0%BB%D1%8F-%D1%80%D0%B8%D1%81%D0%BE%D0%B2%D0%B0%D0%BD%D0%B8%D1%8F-%D0%B3%D0%B8%D1%81%D1%82%D0%BE%D0%B3%D1%80%D0%B0%D0%BC%D0%BC

        }

    }
}
