using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using weptoon_introduction.Frist_Form;
using weptoon_introduction.ID;


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
            this.Visible = false;
            stat.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

            Joinmembership join = new Joinmembership();
            this.Visible = false;
            join.Show();
     
        }

        private void label7_Click(object sender, EventArgs e)
        {
            reserch reserch = new reserch();
            this.Visible = false;
            reserch.Show();
           
        }

        private void label8_Click(object sender, EventArgs e)
        {
            membership_withdrawal clear = new membership_withdrawal();
            this.Visible = false;
            clear.ShowDialog();
            clear.Show();
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (ID_txt.Text == "korea7794" && PW_txt.Text == "tkfkdgo12!")
            {
                this.Visible = false;
                MainForm mainForm1 = new MainForm();
                mainForm1.ShowDialog();
            }
        }
    }
}   
