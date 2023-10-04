using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcHypotenuse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblLengthC_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            float lengthA;
            float lengthB;
            float hypotenuse;
            bool aIsNumeric = float.TryParse(txtLengthA.Text, out lengthA);
            bool bIsNumeric = float.TryParse(txtLengthB.Text, out lengthB);

            if (aIsNumeric && bIsNumeric) { 
                hypotenuse = (lengthA * lengthA) + (lengthB * lengthB);
                hypotenuse = (float)Math.Sqrt(hypotenuse);

                lblLengthC.Text = "Length C = " + hypotenuse.ToString();

            } else
            {
                MessageBox.Show("Please enter numbers only");
            }

        }

        private void txtLengthA_TextChanged(object sender, EventArgs e)
        {
            lblLengthC.Text = "";
        }

        private void txtLengthB_TextChanged(object sender, EventArgs e)
        {
            lblLengthC.Text = "";
        }
    }
}
