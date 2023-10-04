using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxiFare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculateFare_Click(object sender, EventArgs e)
        {
            float distance;
            bool isNumeric = float.TryParse(txtDistance.Text, out distance);
            if (isNumeric)
            {
                float distanceInMeteres = distance * 1000;
                float baseFee = 4;
                float extraFee = (distanceInMeteres / 140) * 0.25f;

                lblFare.Text = "Fare = " + (baseFee + extraFee).ToString("C2");

            }
            else
            {
                MessageBox.Show("Enter numbers only");
            }
        }
    }
}
