using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taschenrechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double Zahl1;
        double Zahl2;
        String operation = "";

        #region Zahleneingaben
        private void Zahl_0_Button_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }
        private void Zahl_1_Button_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }
        private void Zahl_2_Button_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }
        private void Zahl_3_Button_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }
        private void Zahl_4_Button_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }
        private void Zahl_5_Button_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }
        private void Zahl_6_Button_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }
        private void Zahl_7_Button_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }
        private void Zahl_8_Button_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }
        private void Zahl_9_Button_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        #endregion

        #region Operationen
        private void AdditionButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            { }
            else
            {
                operation = "+";
                Zahl1 = Convert.ToDouble(textBox1.Text);
                textBox1.Clear();
                Zahl1Label.Text = Convert.ToString(Zahl1) + " +";
            }
        }

        private void SubtraktionButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            { }

            else
            {
                operation = "-";
                Zahl1 = Convert.ToDouble(textBox1.Text);
                textBox1.Clear();
                Zahl1Label.Text = Convert.ToString(Zahl1) + " -";
            }
        }

        private void MultiplikationButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            { }
            else
            {
                operation = "*";
                Zahl1 = Convert.ToDouble(textBox1.Text);
                textBox1.Clear();
                Zahl1Label.Text = Convert.ToString(Zahl1) + " *";
            }
        }

        private void DivisionButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            { }
            else
            {
                operation = "/";
                Zahl1 = Convert.ToDouble(textBox1.Text);
                textBox1.Clear();
                Zahl1Label.Text = Convert.ToString(Zahl1) + " /";
            }
        }

        #endregion

        private void GleichheitszeichechenButton_Click(object sender, EventArgs e)
        {
            switch(operation)
            {
                case "+":
                    Zahl2 = Convert.ToDouble(textBox1.Text);
                    textBox1.Text = (Zahl1 + Zahl2).ToString();
                    Zahl1Label.Text = "";
                    break;
                case "-":
                    Zahl2 = Convert.ToDouble(textBox1.Text);
                    textBox1.Text = (Zahl1 - Zahl2).ToString();
                    Zahl1Label.Text = "";
                    break;
                case "*":
                    Zahl2 = Convert.ToDouble(textBox1.Text);
                    textBox1.Text = (Zahl1 * Zahl2).ToString();
                    Zahl1Label.Text = "";
                    break;
                case "/":
                    Zahl2 = Convert.ToDouble(textBox1.Text);
                    textBox1.Text = (Zahl1 / Zahl2).ToString();
                    Zahl1Label.Text = "";
                    break;
            }
        }

        private void KommaButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
            }
            else
            {
                if (textBox1.Text != "")
                {

                    if (textBox1.Text.Contains(","))
                        textBox1.Text = textBox1.Text;
                    else
                    {
                        textBox1.Text = textBox1.Text + ",";
                    }

                }
                
            }

        }

        private void CEButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            { }
            else
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }
        private void CButton_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            { }
            else
            {
                textBox1.Text = "";
                Zahl1 = Convert.ToDouble("");
            }
        }
    }
}
