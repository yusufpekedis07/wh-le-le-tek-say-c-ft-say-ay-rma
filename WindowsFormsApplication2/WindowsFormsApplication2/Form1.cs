﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i=0;
            while (i <= 100)
            {
                listBox1.Items.Add(i);
                i++; 
            }
            if (i % 2 == 0)
            {


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int y = 0;
            while (y <= 100)
            {
                listBox2.Items.Add(y);
                y--;
            }
            if (y % 2 == 1)
            {
 
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
