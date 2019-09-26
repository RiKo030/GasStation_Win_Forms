using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POEHALI
{
    public partial class Form1 : Form
    {
        double FoodPrice;
        double Profit;
        double box3, box4, box5, box6;
        public Form1()
        {
            InitializeComponent();
            string n= Environment.CurrentDirectory.ToString();
            n += "\\img\\1.jpg";
            pictureBox1.ImageLocation = n;
            FoodPrice = 0;
            Profit = 0;
            box3 = 0;box4 = 0;box5 = 0;box6 = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void l2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            try
            {
                if(l3.Text!="" && textBox1.Text !="") { 
                double a = Convert.ToDouble(l3.Text);
                double b = Convert.ToDouble(textBox1.Text);
                FuelPrice.Text = (a * b).ToString();
                }
            }
            catch
            {
                MessageBox.Show("Введите правильные данные");
            }
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox3.Text != "" && label4.Text != "") { 
                double a = Convert.ToDouble(textBox3.Text);
                double b = Convert.ToDouble(label4.Text);
                FoodPrice = (Convert.ToDouble(FoodPrice) - (b * box3));
                FoodPrice = ((a * b) + FoodPrice);
                label10.Text = FoodPrice.ToString();
                box3 = Convert.ToDouble(textBox3.Text);
                }
            }
            catch
            {
                MessageBox.Show("Введите правильные данные");
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                textBox6.Enabled = true;
            }
            else
            {
                if (textBox6.Text != "") {
                double c = Convert.ToDouble(textBox6.Text);
                textBox6.Text = "";
                double sum = FoodPrice - (Convert.ToDouble(label7.Text) * c);
                FoodPrice = sum;
                label10.Text = FoodPrice.ToString();
                }
                textBox6.Enabled = false;
                box6 = 0;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex==0)
            {
                l3.Text = "22,50";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                l3.Text = "25,25";
            }
            else if(comboBox1.SelectedIndex == 2)
            {
                l3.Text = "29,00";
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                l3.Text = "30,30";
            }
            else if(comboBox1.SelectedIndex == 4)
            {
                l3.Text = "20,50";
            }
            else if (comboBox1.SelectedIndex == 5)
            {
                l3.Text = "26,10";
            }
        }

        private void l3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                textBox1.Enabled = true;
            }
            else
            {
                textBox1.Enabled = false;
                textBox1.Text = "";
                FuelPrice.Text = "";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                textBox2.Enabled = true;
            }
            else
            {
                textBox2.Enabled = false;
                textBox2.Text = "";
                FuelPrice.Text = "";
            }
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text != "") { 
                FuelPrice.Text = textBox2.Text;
                }
            }
            catch
            {
                MessageBox.Show("Введите правильные данные");
            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox3.Enabled = true;
            }
            else
            {
                if (textBox3.Text != "") {
                double c = Convert.ToDouble(textBox3.Text);
                textBox3.Text = "";
                double sum =FoodPrice - (Convert.ToDouble(label4.Text) * c);
                FoodPrice = sum;
                label10.Text = FoodPrice.ToString();
                }
                textBox3.Enabled = false;
                box3 = 0;
            }
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox4.Enabled = true;
            }
            else
            {
                if (textBox4.Text != "") {
                double c = Convert.ToDouble(textBox4.Text);
                textBox4.Text = "";
                double sum = FoodPrice - (Convert.ToDouble(label5.Text) * c);
                FoodPrice = sum;
                label10.Text = FoodPrice.ToString();
                }
                textBox4.Enabled = false;
                box4 = 0;
            }
        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                textBox5.Enabled = true;
            }
            else
            {
                if (textBox5.Text != "") {
                double c = Convert.ToDouble(textBox5.Text);
                textBox5.Text = "";
                double sum = FoodPrice - (Convert.ToDouble(label6.Text) * c);
                FoodPrice = sum;
                label10.Text = FoodPrice.ToString();
                }
                textBox5.Enabled = false;
                box5 = 0;
            }
        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox4.Text != "" && label5.Text != "")
                {
                    double a = Convert.ToDouble(textBox4.Text);
                    double b = Convert.ToDouble(label5.Text);
                    FoodPrice = (Convert.ToDouble(FoodPrice) - (b * box4));
                    FoodPrice = ((a * b) + FoodPrice);
                    label10.Text = FoodPrice.ToString();
                    box4 = Convert.ToDouble(textBox4.Text);
                }
            }
            catch
            {
                MessageBox.Show("Введите правильные данные");
            }
        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox5.Text != "" && label6.Text != "")
                {
                    double a = Convert.ToDouble(textBox5.Text);
                    double b = Convert.ToDouble(label6.Text);
                    FoodPrice = (Convert.ToDouble(FoodPrice) - (b * box5));
                    FoodPrice = ((a * b) + FoodPrice);
                    label10.Text = FoodPrice.ToString();
                    box5 = Convert.ToDouble(textBox5.Text);
                }
                }
            catch
            {
                MessageBox.Show("Введите правильные данные");
            }
        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox6.Text != "" && label7.Text != "")
                {
                    double a = Convert.ToDouble(textBox6.Text);
                    double b = Convert.ToDouble(label7.Text);
                    FoodPrice = (Convert.ToDouble(FoodPrice) - (b * box6));
                    FoodPrice = ((a * b) + FoodPrice);
                    label10.Text = FoodPrice.ToString();
                    box6 = Convert.ToDouble(textBox6.Text);
                }
            }
            catch
            {
                MessageBox.Show("Введите правильные данные");
            }
}

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (FuelPrice.Text != "" && label10.Text != "") { 
                double a = Convert.ToDouble(FuelPrice.Text);
                double b = Convert.ToDouble(label10.Text);
                label12.Text = (a + b).ToString();
                button2.Visible = true;
                Profit += Convert.ToDouble(label12.Text);
                }
                else if(FuelPrice.Text != "")
                {
                    label12.Text = FuelPrice.Text;
                    button2.Visible = true;
                    Profit += Convert.ToDouble(label12.Text);
                }
                else if(label10.Text != "")
                {
                    label12.Text = label10.Text;
                    button2.Visible = true;
                    Profit += Convert.ToDouble(label12.Text);
                }
            }
            catch
            {
                MessageBox.Show("Введите правильные данные");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            comboBox1.ResetText();
            l3.ResetText();
            textBox1.Text = "";
            textBox2.ResetText();
            FuelPrice.ResetText();
            textBox3.ResetText();
            textBox4.ResetText();
            textBox5.ResetText();
            textBox6.ResetText();
            label12.ResetText();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            label10.ResetText();
            FoodPrice = 0;
            button2.Visible = false;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show(string.Format($"За сегодня вы заработали {Profit} гривен"), "Message!!", 0);
        }

        private void FuelPrice_Click(object sender, EventArgs e)
        {

        }
    }
}
