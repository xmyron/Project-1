using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        int k;
        Calc C;

        public Form1()
        {
            InitializeComponent();
            C = new Calc();
            label1.Text = "0";
        }

        private void CorrectNumber()
        {
            if (label1.Text.IndexOf("∞") != -1)
                label1.Text = label1.Text.Substring(0, label1.Text.Length - 1);

            if (label1.Text[0] == '0' && (label1.Text.IndexOf(",") != 1))
                label1.Text = label1.Text.Remove(0, 1);

            if (label1.Text[0] == '-')
                if (label1.Text[1] == '0' && (label1.Text.IndexOf(",") != 2))
                    label1.Text = label1.Text.Remove(1, 1);
        }

        private bool CanPress()
        {
            if (!button14.Enabled)
                return false;

            if (!button10.Enabled)
                return false;

            if (!button18.Enabled)
                return false;

            if (!button27.Enabled)
                return false;

            if (!button22.Enabled)
                return false;

            if (!button23.Enabled)
                return false;

            return true;
        }

        private void FreeButtons()
        {
            button14.Enabled = true;
            button10.Enabled = true;
            button18.Enabled = true;
            button27.Enabled = true;
            button22.Enabled = true;
            button23.Enabled = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            C.Clear_A();
            FreeButtons();
            k = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int lenght = label1.Text.Length - 1;
            string text = label1.Text;
            label1.Text = "";
            for (int i = 0; i < lenght; i++)
            {
                label1.Text = label1.Text + text[i];
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if ((label1.Text.IndexOf(",") == -1) && (label1.Text.IndexOf("∞") == -1))
                label1.Text += ",";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(label1.Text));
                button14.Enabled = false;
                label1.Text = "0";
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(label1.Text));
                label1.Text = C.Sqrt().ToString();
                C.Clear_A();
                FreeButtons();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text += "7";
            CorrectNumber();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text += "8";
            CorrectNumber();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text += "9";
            CorrectNumber();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(label1.Text));
                button10.Enabled = false;
                label1.Text = "0";
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(label1.Text));
                button22.Enabled = false;
                label1.Text = "0";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label1.Text += "4";
            CorrectNumber();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label1.Text += "5";
            CorrectNumber();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label1.Text += "6";
            CorrectNumber();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(label1.Text));
                button18.Enabled = false;
                label1.Text = "0";
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(label1.Text));
                button23.Enabled = false;
                label1.Text = "0";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            label1.Text += "1";
            CorrectNumber();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            label1.Text += "2";
            CorrectNumber();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            label1.Text += "3";
            CorrectNumber();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(label1.Text));
                button27.Enabled = false;
                label1.Text = "0";
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                C.Put_A(Convert.ToDouble(label1.Text));
                label1.Text = C.Square().ToString();
                C.Clear_A();
                FreeButtons();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if ((label1.Text.IndexOf(",") == -1) && (label1.Text.IndexOf("∞") == -1))
                label1.Text += ",";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            label1.Text += "0";
            CorrectNumber();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (!button14.Enabled)
                label1.Text = C.Multiplication(Convert.ToDouble(label1.Text)).ToString();

            if (!button10.Enabled)
                label1.Text = C.Division(Convert.ToDouble(label1.Text)).ToString();

            if (!button18.Enabled)
                label1.Text = C.Sum(Convert.ToDouble(label1.Text)).ToString();

            if (!button27.Enabled)
                label1.Text = C.Subtraction(Convert.ToDouble(label1.Text)).ToString();

            if (!button22.Enabled)
                label1.Text = C.SqrtX(Convert.ToDouble(label1.Text)).ToString();

            if (!button23.Enabled)
                label1.Text = C.DegreeY(Convert.ToDouble(label1.Text)).ToString();

            C.Clear_A();
            FreeButtons();

            k = 0;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (CanPress())
            {
                if ((Convert.ToDouble(label1.Text) == (int)(Convert.ToDouble(label1.Text))) &&
                    ((Convert.ToDouble(label1.Text) >= 0.0)))
                {
                    C.Put_A(Convert.ToDouble(label1.Text));
                    label1.Text = C.Factorial().ToString();
                    C.Clear_A();
                    FreeButtons();
                }
                else
                    MessageBox.Show("Number should be >= 0 and integer!");
            }
        }
    }

    public class Calc
    {
        private double a = 0;
        private double memory = 0;

        public void Put_A(double a)
        {
            this.a = a;
        }

        public void Clear_A()
        {
            a = 0;
        }

        public double Multiplication(double b)
        {
            return a * b;
        }

        public double Division(double b)
        {
            return a / b;
        }

        public double Sum(double b)
        {
            return a + b;
        }

        public double Subtraction(double b)
        {
            return a - b;
        }

        public double SqrtX(double b)
        {
            return Math.Pow(a, 1 / b);
        }

        public double DegreeY(double b)
        {
            return Math.Pow(a, b);
        }

        public double Sqrt()
        {
            return Math.Sqrt(a);
        }

        public double Square()
        {
            return Math.Pow(a, 2.0);
        }

        public double Factorial()
        {
            double f = 1;

            for (var i = 1; i <= a; i++)
                f *= (double) i;

            return f;
        }

        public double MemoryShow()
        {
            return memory;
        }

        public void Memory_Clear()
        {
            memory = 0.0;
        }

        public void M_Multiplication(double b)
        {
            memory *= b;
        }

        public void M_Division(double b)
        {
            memory /= b;
        }

        public void M_Sum(double b)
        {
            memory += b;
        }

        public void M_Subtraction(double b)
        {
            memory -= b;
        }
    }

}
