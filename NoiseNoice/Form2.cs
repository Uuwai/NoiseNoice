using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoiseNoice
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Image createdimage;
        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                button1.BackColor = colorDialog1.Color;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap((int)numericUpDown1.Value, (int)numericUpDown2.Value);
            using (Graphics graphics = Graphics.FromImage(image))
            {
                graphics.Clear(colorDialog1.Color);
            }
            createdimage = image;
        }
    }
}
