using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ohm_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double volt;
        double ampere;
        double ohm;
        double watt;
        
        private void button1_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox1.Text, out double volt);
            double.TryParse(textBox2.Text, out double ampere);
            double.TryParse(textBox3.Text, out double ohm);
            double.TryParse(textBox4.Text, out double watt);

            if (volt == 0)
            {
                volt = Math.Sqrt(ampere * ohm);
                volt = (watt % ampere);
                volt = (ampere * ohm);
            }

            if (ampere == 0)
            {
                ampere = (volt / ohm);
                ampere = (watt / volt);
                ampere = Math.Sqrt(watt / ohm);
            }

            if (ohm == 0)
            {
                ohm = (volt / ampere);
                ohm = (Math.Pow(volt, 2) / watt);
                ohm = (watt / Math.Pow(ampere, 2));
            }

            if (watt == 0)
            {
                watt = (Math.Pow(volt, 2) / ohm);
                watt = (Math.Pow(ampere, 2) * ohm);
                watt = (volt * ampere);
            }

            if (checkBox1.Checked == true)
            {
                textBox1.Text = Math.Round(volt, 2, MidpointRounding.AwayFromZero).ToString();
                textBox2.Text = Math.Round(ampere, 2, MidpointRounding.AwayFromZero).ToString();
                textBox3.Text = Math.Round(ohm, 2, MidpointRounding.AwayFromZero).ToString();
                textBox4.Text = Math.Round(watt, 2, MidpointRounding.AwayFromZero).ToString();
            }
            else
            {
                textBox1.Text = volt.ToString();
                textBox2.Text = ampere.ToString();
                textBox3.Text = ohm.ToString();
                textBox4.Text = watt.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }
    }
}
