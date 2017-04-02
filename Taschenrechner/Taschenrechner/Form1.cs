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
            Zahl1 = Convert.ToDouble(textBox1.Text);

        }

        private void SubtraktionButton_Click(object sender, EventArgs e)
        {
            Zahl1 = Convert.ToDouble(textBox1.Text);
        }

        private void MultiplikationButton_Click(object sender, EventArgs e)
        {
            Zahl1 = Convert.ToDouble(textBox1.Text);
        }

        private void DivisionButton_Click(object sender, EventArgs e)
        {
            Zahl1 = Convert.ToDouble(textBox1.Text);
        }
        #endregion
    }
}
