using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analytica_Lada
{
 
    public partial class Form3 : Form
    {
        
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label8.Text = ((Form1)Tag).b + " * " + "X" + " - " + ((Form1)Tag).a;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(textBox1.Text);
                double y = Convert.ToDouble(textBox2.Text);
                ((Form1)this.Tag).changecoof(x, y);
                label8.Text = x + " * " + "X" + " - " + y;
                return;
            }
            catch (FormatException)
            {
                MessageBox.Show("Поле с данными пустое или использованы некорректные символы!", "Предупреждение");
            }

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
