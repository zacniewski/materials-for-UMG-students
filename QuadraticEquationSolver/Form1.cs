using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuadraticEquationSolver
{
    public partial class Form1 : Form
    {
        // współczynniki równania kwadratowego
        int a = 0;
        int b = 0;
        int c = 0;
        double x, x1, x2, img;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number;
            bool success = int.TryParse(textBox1.Text, out number);
            if (success == true)
            {
                a = number;
                label6.ForeColor = Color.Blue;
                label6.Text = "Podano poprawne wartości :)";
            }
            else
            {
                a = 1;
                textBox1.Text = 1.ToString();
                label6.Text = "Nie wpisałeś liczby całkowitej, a ustawiono na 1 !!! ";
            }

            if (a == 0)
            {
                a = 1;
                textBox1.Text = 1.ToString();
                label6.Text = "Nie wpisałeś liczby całkowitej, a ustawiono na 1 !!! ";
            }

            //a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            c = int.Parse(textBox3.Text);

            // obliczamy deltę
            double delta = b * b - 4 * a * c;
            label4.Text = "Delta wynosi: " + delta.ToString();

            // obliczanie pierwiastków równania
            if (delta >= 0)
            {
                x1 = (-b + System.Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - System.Math.Sqrt(delta)) / (2 * a);
                label5.Text = "Pierwiastki równania: x1 = " + x1.ToString() + " , x2 = " + x2.ToString();
            }
            else
            {
                delta = -delta;
                x = -b / (2 * a);
                img = System.Math.Sqrt(delta) / (2 * a);
                label5.Text = "Urojone pierwiastki równania: x1_img = " + x.ToString() + " + i" + img.ToString() 
                    + ", x2_img = " + x.ToString() + " - i" + img.ToString();
            }

        }
    }
}
