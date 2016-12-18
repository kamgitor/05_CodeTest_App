using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CodeTest_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Akcja 1
        private void button1_Click(object sender, EventArgs e)
        {
            // Dzialanie na samych stringach

            OutputBox1.Text = InputBox1.Text;
            OutputBox2.Text = InputBox2.Text;
            OutputBox3.Text = InputBox3.Text;
            OutputBox4.Text = InputBox4.Text;
        }

        // Akcja 2
        private void button2_Click(object sender, EventArgs e)
        {
            // Dzialanie na intach

            // string str1, str2, str3, str4;
            int val1, val2, val3, val4;
/*
            str1 = InputBox1.Text;
            str2 = InputBox2.Text;
            str3 = InputBox3.Text;
            str4 = InputBox4.Text;

            // uzywajac posredniego stringa
            val1 = Convert.ToInt32(str1);
            val2 = Convert.ToInt32(str2);
            val3 = Convert.ToInt32(str3);
            val4 = Convert.ToInt32(str4);
*/

            // bez uzycia posredniego stringa
            val1 = Convert.ToInt32(InputBox1.Text);
            val2 = Convert.ToInt32(InputBox2.Text);
            val3 = Convert.ToInt32(InputBox3.Text);
            val4 = Convert.ToInt32(InputBox4.Text);

            // operacje na wartosciach
            val1 += 10;         // val1 = val1 + 10;
            val2 += 20;
            val3 += 30;
            val4 += 40;

            OutputBox1.Text = Convert.ToString(val1);
            OutputBox2.Text = Convert.ToString(val2);
            OutputBox3.Text = Convert.ToString(val3);
            OutputBox4.Text = Convert.ToString(val4);

        }

        // Akcja 3
        private void button3_Click(object sender, EventArgs e)
        {
            // Dzialanie na zmiennoprzecinkowych

            double val1, val2, val3, val4;

            // bez uzycia posredniego stringa
            val1 = Convert.ToDouble(InputBox1.Text);
            val2 = Convert.ToDouble(InputBox2.Text);
            val3 = Convert.ToDouble(InputBox3.Text);
            val4 = Convert.ToDouble(InputBox4.Text);

            // operacje na wartosciach
            val1 += 10;
            val2 += 20;
            val3 += 30;
            val4 += 40;

            OutputBox1.Text = Convert.ToString(val1);
            OutputBox2.Text = Convert.ToString(val2);
            OutputBox3.Text = Convert.ToString(val3);
            OutputBox4.Text = Convert.ToString(val4);

        }

        // Akcja 4
        private void button4_Click(object sender, EventArgs e)
        {

        }



        // Akcja 2
    }
}
