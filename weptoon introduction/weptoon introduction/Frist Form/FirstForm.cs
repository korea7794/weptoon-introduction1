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
    public partial class FirstForm : Form
    {

        private Point point = new Point();


        public FirstForm()
        {

            InitializeComponent();
        }


        private void FirstForm_Load(object sender, EventArgs e)
        {
        }

        private void FistForm_Down(object sender, MouseEventArgs e)
        {
            point = new Point(e.X, e.Y);
        }

        private void FistForm_Move(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                this.Location = new Point(this.Left - (point.X - e.X), this.Top - (point.Y - e.Y));
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          
      
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm stat= new MainForm();
            stat.Tag = this;
            stat.Show();
            this.Hide();
        }
    }
}
