using System;
using System.Drawing;
using System.Windows.Forms;

namespace Colloring
{
    public partial class Colloring : Form
    {

        public Colloring()
        {
            InitializeComponent();
            Random random = new Random();
            int red, green, blue;
            red = random.Next(0, 255);
            green = random.Next(0, 255);
            blue = random.Next(0, 255);
            colorPanel.BackColor = Color.FromArgb(red, green, blue);
        }


        private void changeButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int red, green, blue;
            red = random.Next(0, 255);
            green = random.Next(0, 255);
            blue = random.Next(0, 255);
            colorPanel.BackColor = Color.FromArgb(red, green, blue);
        }
    }
}
