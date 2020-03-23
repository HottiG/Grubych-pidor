using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Binary[] mas = new Binary[10];
        private void button1_Click(object sender, EventArgs e)
        {

            Binary number = new Binary(textBox1.Text);
            if (number.Bin == null || textBox1.Text == "")
            {
                MessageBox.Show("Введите двоичное число");
            }
            else
            {
                try
                {
                    dataGridView1.Rows.Add(number.Bin);
                    textBox1.Text = "";
                    mas[dataGridView1.RowCount - 1] = number;
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show("Количество элементов не может превышать 10");
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                switch (textBox2.Text[1])
                {
                    case '+':
                        int x = Convert.ToInt32(char.GetNumericValue(textBox2.Text[0]));
                        int y = Convert.ToInt32(char.GetNumericValue(textBox2.Text[textBox2.Text.Length - 1]));
                        label2.Text = (mas[x - 1] + mas[y - 1]).Bin;
                        break;
                    case '-':
                        x = Convert.ToInt32(char.GetNumericValue(textBox2.Text[0]));
                        y = Convert.ToInt32(char.GetNumericValue(textBox2.Text[textBox2.Text.Length - 1]));
                        label2.Text = (mas[x - 1] - mas[y - 1]).Bin;
                        break;
                    case '*':
                        x = Convert.ToInt32(char.GetNumericValue(textBox2.Text[0]));
                        y = Convert.ToInt32(char.GetNumericValue(textBox2.Text[textBox2.Text.Length - 1]));
                        label2.Text = (mas[x - 1] * mas[y - 1]).Bin;
                        break;
                    case '/':
                        x = Convert.ToInt32(char.GetNumericValue(textBox2.Text[0]));
                        y = Convert.ToInt32(char.GetNumericValue(textBox2.Text[textBox2.Text.Length - 1]));
                        label2.Text = (mas[x - 1] / mas[y - 1]).Bin;
                        break;
                    default:
                        label2.Text = "Неверный ввод";
                        break;
                }
            }
            catch (IndexOutOfRangeException)
            {
                label2.Text = "Неверный ввод";
            }
        }
    }
}
