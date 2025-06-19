using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulačka
{
    public partial class Form1 : Form
    {
        double enter_first_value;double enter_second_value;
        string oper;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 270;
            txt_result.Width = 240;
        }

        private void enter_num(object sender, EventArgs e)
        {
            Button num = (Button)sender;

            if(txt_result.Text == "0")
                txt_result.Text = "";
            if (num.Text == ",") 
            {
                if(!txt_result.Text.Contains(",")) 
                {
                    txt_result.Text = txt_result.Text + num.Text;
                }
            }
            else
            {
                txt_result.Text = txt_result.Text + num.Text;
            }
        }

        private void num_oper(object sender, EventArgs e)
        {
            Button num = (Button)sender;

            enter_first_value = Convert.ToDouble(txt_result.Text);
            oper = num.Text;
            txt_result.Text = "";

        }

        private void btn_result_Click(object sender, EventArgs e)
        {
            enter_second_value = Convert.ToDouble(txt_result.Text);
            double result;

            switch (oper)
            {
                case "+":
                    result = enter_first_value + enter_second_value;
                    break;
                case "-":
                    result = enter_first_value - enter_second_value;
                    break;
                case "*":
                    result = enter_first_value * enter_second_value;
                    break;
                case "/":
                    if (enter_second_value == 0)
                    {
                        MessageBox.Show("Cannot divide by zero.");
                        return;
                    }
                    result = enter_first_value / enter_second_value;
                    break;
                case "exp":
                    result = Math.Pow(enter_first_value,enter_second_value);
                    break;
                case "mod":
                    result = enter_first_value % enter_second_value;
                    break;
                default:
                    MessageBox.Show("Invalid operation.");
                    return;
            }
            txt_result.Text = result.ToString();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_result.Text = "0";
        }

        private void btn_clear_empty_Click(object sender, EventArgs e)
        {
            txt_result.Text = "0";
            enter_first_value = 0;
            enter_second_value = 0;
        }

        private void btn_plus_minus_Click(object sender, EventArgs e)
        {
            double q = Convert.ToDouble(txt_result.Text);
            txt_result.Text = Convert.ToString(-q);
        }

        private void btn_backspace_Click(object sender, EventArgs e)
        {
            if (txt_result.Text.Length>0)
            {
                txt_result.Text = txt_result.Text.Remove(txt_result.Text.Length - 1, 1);
            }
            if (txt_result.Text == "")
            {
                txt_result.Text = "0";
            }
        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Width = 270;
            txt_result.Width = 240;
        }

        private void sciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 540;
            txt_result.Width = 500;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult exitCal = MessageBox.Show("Confirm if you want to exit", "Calculator", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (exitCal == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_pi_Click(object sender, EventArgs e)
        {
            txt_result.Text = Math.PI.ToString();
        }

        private void btn_log_Click(object sender, EventArgs e)
        {
            double log = Convert.ToDouble(txt_result.Text);
            log = Math.Log10(log);
            txt_result.Text = Convert.ToString(log);
        }

        private void btn_sqrt_Click(object sender, EventArgs e)
        {
            double sq = Convert.ToDouble(txt_result.Text);
            sq = Math.Sqrt(sq);
            txt_result.Text = Convert.ToString(sq);
        }

        private void btn_x_x_Click(object sender, EventArgs e)
        {
            double x;

            x = Convert.ToDouble(txt_result.Text) * Convert.ToDouble(txt_result.Text);
            txt_result.Text = Convert.ToString(x);
        }

        private void btn_xxx_Click(object sender, EventArgs e)
        {
            double x;

            x = Convert.ToDouble(txt_result.Text) * Convert.ToDouble(txt_result.Text) * Convert.ToDouble(txt_result.Text);
            txt_result.Text = Convert.ToString(x);
        }

        private void btn_sinh_Click(object sender, EventArgs e)
        {
            double sinh = Convert.ToDouble(txt_result.Text);
            sinh = Math.Sinh(sinh);
            txt_result.Text = Convert.ToString(sinh);
        }

        private void btn_sin_Click(object sender, EventArgs e)
        {
            double sin = Convert.ToDouble(txt_result.Text);
            sin = Math.Sin(sin);
            txt_result.Text = Convert.ToString(sin);
        }

        private void btn_cosh_Click(object sender, EventArgs e)
        {
            double cosh = Convert.ToDouble(txt_result.Text);
            cosh = Math.Cosh(cosh);
            txt_result.Text = Convert.ToString(cosh);
        }

        private void btn_cos_Click(object sender, EventArgs e)
        {
            double cos = Convert.ToDouble(txt_result.Text);
            cos = Math.Cos(cos);
            txt_result.Text = Convert.ToString(cos);
        }

        private void btn_tanh_Click(object sender, EventArgs e)
        {
            double tanh = Convert.ToDouble(txt_result.Text);
            tanh = Math.Tanh(tanh);
            txt_result.Text = Convert.ToString(tanh);
        }

        private void btn_tan_Click(object sender, EventArgs e)
        {
            double tan = Convert.ToDouble(txt_result.Text);
            tan = Math.Tan(tan);
            txt_result.Text = Convert.ToString(tan);
        }

        private void btn_1overx_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(txt_result.Text);
            if (x == 0)
            {
                MessageBox.Show("Cannot divide by zero.");
                return;
            }
            txt_result.Text = (1.0 / x).ToString();
        }

        private void btn_lnx_Click(object sender, EventArgs e)
        {
            double lnx = Convert.ToDouble(txt_result.Text);
            lnx = Math.Log(lnx);
            txt_result.Text = Convert.ToString(lnx);
        }

        private void btn_perc_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(txt_result.Text) / Convert.ToDouble(100);

            txt_result.Text = Convert.ToString(a);
        }

        private void btn_dec_Click(object sender, EventArgs e)
        {
            double dec = Convert.ToDouble(txt_result.Text);
            MessageBox.Show(dec + " in dec is: " + Convert.ToString((int)dec));
        }

        private void btn_bin_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToDouble(txt_result.Text) + " in dec is: " + Convert.ToInt32(Convert.ToDouble(txt_result.Text)) + " in bin is: " + Convert.ToString(Convert.ToInt32(Convert.ToDouble(txt_result.Text)), 2));            
        }

        private void btn_hex_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToDouble(txt_result.Text) + " in dec is: " + Convert.ToInt32(Convert.ToDouble(txt_result.Text)) + " in hex is: " + Convert.ToString(Convert.ToInt32(Convert.ToDouble(txt_result.Text)), 16).ToUpper());
        }

        private void btn_oct_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToDouble(txt_result.Text) + " in dec is: " + Convert.ToInt32(Convert.ToDouble(txt_result.Text)) + " in oct is: " + Convert.ToString(Convert.ToInt32(Convert.ToDouble(txt_result.Text)), 8));
        }
    }
}
