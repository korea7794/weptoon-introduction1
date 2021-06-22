using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace weptoon_introduction
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private int imageNuMber = 1;
        
        private void LoadNextImage()
        {
            if (imageNuMber == 10) 
            {
                imageNuMber = 1;
            }
            sidePic.ImageLocation = string.Format(@"Images/{0}.jpg", imageNuMber);
            imageNuMber++;
        }


        private void rscroll_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }
    }
}
