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
    public partial class joinform : Form
    {
        public joinform()
        {
            InitializeComponent();
        }

        private void joinform_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainform mainform1 = new mainform();
            mainform1.Show(); 

        }
    }
}
