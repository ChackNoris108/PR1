using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Math;

namespace Пр1
{
    public partial class Form2 : Form
    {
       
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsValidInput())
            {


                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                double c = Convert.ToDouble(textBox3.Text);

                double ot = b * b - 4 * a * c;

                label7.Text = "Дискриминант равен: " + ot;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            label9.Text = "";
            label8.Text = "";
            label7.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (IsValidInput())
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                double c = Convert.ToDouble(textBox3.Text);
                double ot = b * b - 4 * a * c;

                if (ot > 0)
                {
                    double x1 = (-b + Sqrt(ot)) / 2 * a;
                    double x2 = (-b - Sqrt(ot)) / 2 * a;
                    label8.Text = "x1= " + x1;
                    label9.Text = "x2=" + x2;
                    label10.Text = "2";
                }
                else if (ot == 0)
                {
                    double x1 = -(b / (2 * a));
                    label8.Text = "x1= " + x1;
                    label10.Text = "1";
                }
                else if (ot < 0)
                {
                    label8.Text = "Нет корней";
                    label10.Text = "0";
                }
            }
            
        }
        private bool IsValidInput()
        {
            if (!double.TryParse(textBox1.Text, out double a) ||
                !double.TryParse(textBox2.Text, out double b) ||
                !double.TryParse(textBox3.Text, out double c))
            {
                MessageBox.Show("Пожалуйста, введите Числа во все три поля.");
                return false;
            }
            return true;
        }
    }
}
