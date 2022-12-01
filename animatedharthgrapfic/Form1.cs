using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using graphiccontrol;
using System.Threading;

namespace animatedharthgrapfic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int j = 1;
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i+=10)
            {
                this.userControl11.g.DrawEllipse(this.userControl11.pen0,i+j, 10, 220, 210);
                this.userControl11.Left-=9;
                Thread.Sleep(10);
                
            }j+=100;
        }
    }
}
