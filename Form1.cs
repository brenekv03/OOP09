using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stroj stroj = new Stroj("15", DateTime.Parse("06-02-2022"));
            stroj.ProvedServis();
            MessageBox.Show( stroj.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Automat automat = new Automat("A15", DateTime.Parse("06-02-2022"), false);
            automat.ProvedServis();
            MessageBox.Show( automat.ToString());
        }
    }
}
