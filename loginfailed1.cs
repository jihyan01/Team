﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teamproject1
{
    public partial class loginfailed1 : Form
    {
        public loginfailed1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginform2 loginform3 = new loginform2();
            loginform3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainform1 mainform2 = new mainform1();  
            mainform2.Show(); 
        }
    }
}
