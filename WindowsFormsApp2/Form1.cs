using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void clear_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (this.textBox1.Text.Trim().Length > 0 && this.textBox1.Text.Trim() == "67" || this.textBox1.Text.Trim() == "six seven" || this.textBox1.Text.Trim() == "шість сім")
            {
                MessageBox.Show("МОЛОДЕЦЬ", "SIXSEVEN!!!!!!!!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else if (this.textBox1.Text.Trim().Length > 0)
            {
                MessageBox.Show(this.textBox1.Text.Trim(), "67", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("ВИ ВВЕЛИ НЕВАЛІДНИЙ ТЕКСТ", "ПОМИЛКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        int points = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            points += 1;
            this.label2.Text = points.ToString();
            if (points == 67)
            {
                MessageBox.Show("ВИ ВИГРАЛИ", "ПОЗДРАВЛЯЮ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MessageBox.Show("ДАЛІ МОЖЕШ КЛІКАТИ СКІЛЬКИ ХОЧЕШ", "Я ЗАДОВОЛЕНИЙ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (this.textBox2.Text.Trim().Length > 0 || this.textBox3.Text.Trim().Length > 0)
            {
                double a = Convert.ToDouble(this.textBox2.Text);
                double b = Convert.ToDouble(this.textBox3.Text);
                double result = a * b;
                this.label5.Text = "Результат: " + result.ToString();
                if (result == 67)
                {
                    MessageBox.Show("SIX SEVEN!!!!", "67", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Ви не ввели 1 або 2 число", "ПОМИЛКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (this.textBox2.Text.Trim().Length > 0 || this.textBox3.Text.Trim().Length > 0)
            {
                double a = Convert.ToDouble(this.textBox2.Text);
                double b = Convert.ToDouble(this.textBox3.Text);
                double result = a + b;
                this.label5.Text = "Результат: " + result.ToString();
                if (result == 67)
                {
                    MessageBox.Show("SIX SEVEN!!!!", "67", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Ви не ввели 1 або 2 число", "ПОМИЛКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (this.textBox2.Text.Trim().Length > 0 || this.textBox3.Text.Trim().Length > 0)
            {
                double a = Convert.ToDouble(this.textBox2.Text);
                double b = Convert.ToDouble(this.textBox3.Text);
                double result = a - b;
                this.label5.Text = "Результат: " + result.ToString();
                if (result == 67)
                {
                    MessageBox.Show("SIX SEVEN!!!!", "67", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Ви не ввели 1 або 2 число", "ПОМИЛКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (this.textBox2.Text.Trim().Length > 0 || this.textBox3.Text.Trim().Length > 0)
            {
                double a = Convert.ToDouble(this.textBox2.Text);
                double b = Convert.ToDouble(this.textBox3.Text);
                if (a == 0 || b == 0)
                {
                    MessageBox.Show("Ділення на нуль неможливе", "ПОМИЛКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    double result = a / b;
                    this.label5.Text = "Результат: " + result.ToString();
                    if (result == 67)
                    {
                        MessageBox.Show("SIX SEVEN!!!!", "67", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else
            {
                MessageBox.Show("Ви не ввели 1 або 2 число", "ПОМИЛКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}