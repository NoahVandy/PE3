using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE3
{
    public partial class poundsConverter : Form
    {
        public poundsConverter()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
        }

        private void convertButton_Click_1(object sender, EventArgs e)
        {
            //get pounds from poundsBox
            string strPounds = txtBox_pounds.Text;
            double pounds = double.Parse(strPounds);
            //convert pounds to kilos
            double kilos = pounds / 2.205;
            //display kilos from pounds
            txtBox_kilos.Text = kilos.ToString();
        }
    }
}
