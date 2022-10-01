using E4.Polymorphism_Example.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E4.Polymorphism_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Human human = new Human();
        Rammus rammus = new Rammus();
        Warwick Warwick = new Warwick();
        private void btnStart_Click(object sender, EventArgs e)
        {
            tmrGame.Enabled = true;
            tmrGame.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHuman.Left += human.GetSpeed();
            lblRammus.Left += rammus.GetSpeed();
            lblWarwick.Left += Warwick.GetSpeed();

            if(lblHuman.Right >= lblFinish.Left)
            {
                tmrGame.Stop();
                tmrGame.Enabled = false;
                MessageBox.Show("İnsan Kazandı.");
                
            }
            else if (lblRammus.Right >= lblFinish.Right)
            {
                tmrGame.Stop();
                tmrGame.Enabled = false;
                MessageBox.Show("Rammus Kazandı.");
                
            }
            else if (lblWarwick.Right >= lblFinish.Left)
            {
                tmrGame.Stop();
                tmrGame.Enabled = false;
                MessageBox.Show("Warick Kazandı.");
              
            }

            if(tmrGame.Enabled == false)
            {
                Application.Restart();
            }
        }
    }
}
