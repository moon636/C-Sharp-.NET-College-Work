using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoomCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float roomLength = float.Parse(txtRoomLength.Text);
            float roomWidth = float.Parse(txtRoomWidth.Text);
            float roomArea = roomLength * roomWidth;

            txtRoomArea.Text = roomArea.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculateVolume_Click (object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculateVolume_Click_1(object sender, EventArgs e)
        {
            float roomLength = float.Parse(txtRoomLength.Text);
            float roomWidth = float.Parse(txtRoomWidth.Text);
            float roomHeight = float.Parse(txtRoomHeight.Text);
            float roomVolume = roomLength * roomWidth * roomHeight;
            txtRoomVolume.Text = roomVolume.ToString();
        }

        private void txtRoomArea_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRoomWidth_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
