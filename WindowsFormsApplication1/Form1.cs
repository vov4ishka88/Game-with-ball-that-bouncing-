﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Ball ball1;
        public Form1()
        {            
            InitializeComponent();            
            ball1 = new Ball(panel1);
            timer1.Start();
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ball1.draw(e.Graphics);
        }
    }
}
