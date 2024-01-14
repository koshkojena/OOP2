using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace лабораторная_2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text.Replace(".", ","), out double x) && double.TryParse(textBox2.Text.Replace(".", ","), out double y) && double.TryParse(textBox3.Text.Replace(".", ","), out double z))
            {
                double t = ((2 * Math.Cos(x - (Math.PI / 6))) / (0.5 + Math.Pow(Math.Sin(y), 2))) * (1 + ((Math.Pow(z, 2)) / (3 - (Math.Pow(z, 2) / 5))));
                textBox4.Text += Environment.NewLine + "Результат T = " + t.ToString();
            }
            else
            {
                MessageBox.Show("Некорректный ввод чисел.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Введите Х";
            label2.Text = "Введите Y";
            label3.Text = "Введите Z";
            textBox1.Text = "14.26";
            textBox2.Text = "-1.22";
            textBox3.Text = "0.035";
            label4.Text = "Результат выполнения программы";
            button1.Text = "Выполнить";
            button1.Click += button1_Click;
        }
    }
}

