using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Пр1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private string GetTriangleType(int a, int b, int c)
        {
            if (a == b && b == c)
            {
                return "Равносторонний";
            }
            else if (a == b || a == c || b == c)
            {
                return "Равнобедренный";
            }
            else
            {
                int[] sides = { a, b, c };
                Array.Sort(sides);
                if (sides[2] * sides[2] == sides[0] * sides[0] + sides[1] * sides[1])
                {
                    return "Прямоугольный";
                }
                else if (sides[2] * sides[2] > sides[0] * sides[0] + sides[1] * sides[1])
                {
                    return "Тупоугольный";
                }
                else
                {
                    return "Остроугольный";
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                int sideA = int.Parse(textBox1.Text);
                int sideB = int.Parse(textBox2.Text);
                int sideC = int.Parse(textBox3.Text);

                if (sideA <= 0 || sideB <= 0 || sideC <= 0)
                {
                    throw new ArgumentException("Стороны треугольника должны быть положительными числами.");
                }

                if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
                {
                    throw new ArgumentException("Такой треугольник не существует.");
                }

                string triangleType = GetTriangleType(sideA, sideB, sideC);
                double perimeter = sideA + sideB + sideC;
                double halfPerimeter = perimeter / 2;
                double area = Math.Sqrt(halfPerimeter * (halfPerimeter - sideA) * (halfPerimeter - sideB) * (halfPerimeter - sideC));

                MessageBox.Show($"Тип треугольника: {triangleType}\n" +
                                   $"Периметр треугольника: {perimeter}\n" +
                                   $"Площадь треугольника: {area}");
            }
            catch (FormatException)
            {
                MessageBox.Show("Пожалуйста, введите целочисленные значения для сторон треугольника.");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2();
            Hide();
            a.Show();
        }
    }
}
