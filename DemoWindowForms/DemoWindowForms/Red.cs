﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoWindowForms
{
    public partial class Red : Form
    {
        public Red()
        {
            InitializeComponent();

            button1.Text = "Close me";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
