using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Analytica_Lada
{
    public partial class Form1 : Form              
    {
        public Form3 form3;
        public  Form2 form2;
        public  Form1 Main;
        public Double b = 0.7485, a = 3.4491;
        public Double NumberSales = 0;
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
             
        }

        public void changecoof(double first, double second)
        {
            b = first;
            a = second;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                NumberSales = Convert.ToDouble(textBox1.Text);
                if (comboBox1.Text == "") MessageBox.Show("Вы забыли указать год!", "Предупреждение");
                else if (comboBox2.Text == "") MessageBox.Show("Вы забыли указать месяц!", "Предупреждение");
                else
                {
                    label2.Text = "При объёме продажа Lada = " + NumberSales + " Тыс. шт. за " + comboBox2.Text + " месяц " + comboBox1.Text + " Года";
                    Double NewNumberSales = (b * NumberSales) - a;
                    if (NewNumberSales < 0) NewNumberSales = 0;
                    NewNumberSales = Math.Round(NewNumberSales, 3);
                    label5.Text = "Теоретическое значение объема продаж Huyndai = " + NewNumberSales + " Тыс. шт. за " + comboBox2.Text + " месяц " + (Convert.ToInt32(comboBox1.Text) + 1) + " Года";
                }
                return;
            }
            catch (FormatException)
            {
                MessageBox.Show("Вводить в поле с данными можно только числа, если дробное, то необходимо использовать запятые!", "Предупреждение");
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Вы уверены, что хотите выйти?";
            string caption = "Выход";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;


            result = MessageBox.Show(this, message, caption, buttons);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа «Прогнозирование объёма продаж Huyndai» предназначена для расчета объёма продаж машин марки «Huyndai» основываясь на объёме продаж машин марки «Lada». Программа, разработана в среде разработки Visual Studio при помощи языка c#");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form2 = new Form2();
            form2.Tag = this;
            form2.Show();
        }

        private void общийВидФормулыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Формула имеет общий вид:                                                                 Первый коэффициент * Кол-во продаж Лады - Второй коэффициент ", "Информация");
        }


        public void ShowMyDialogBox()
        {
            Form3 form3 = new Form3();

            
            if (form3.ShowDialog(this) == DialogResult.OK)
            {
                this.b = 1f;
            }
            else
            {
                
            }
            form3.Dispose();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            form3 = new Form3();
            form3.Tag = this;
            form3.Show();
        }



        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void изменитьДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
