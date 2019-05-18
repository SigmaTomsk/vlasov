using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MATEMATIC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Простой метод")
            {


                int a = 0;
                int b = 0;
                try
                {
                    a = Convert.ToInt32(textBox1.Text);
                    b = Convert.ToInt32(textBox2.Text);
                }
                catch
                {
                    MessageBox.Show("Введи не очень большие числа или заполни поля.");
                }
                int y = 0;
                for (int i = 0; i < b; i++)
                {
                    y += a;
                }
                textBox3.Text = Convert.ToString(y);
            }
            else if (comboBox1.Text == "Сложный метод")
            {
                int a, b;
                int q = Convert.ToInt32(textBox1.Text);
                a = q / 10;
                b = q % 10;
                int a1, b1, perviy, vtoroy, tretiy, chetvetiy, ved, ped, konec, kopec, kopec2;
                int q1 = Convert.ToInt32(textBox2.Text);
                a1 = q1 / 10;
                b1 = q1 % 10;
                perviy = a * a1;
                vtoroy = b * b1;
                tretiy = a + b;
                chetvetiy = a1 + b1;
                ved = tretiy * chetvetiy;
                ped = ved - vtoroy - perviy;
                kopec = ped * 10;
                kopec2 = perviy * 100;
                konec = kopec + kopec2 + vtoroy;
                textBox3.Text = Convert.ToString(konec);

            }
        }
    }
}
