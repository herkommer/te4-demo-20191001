using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            button1.Text = "Red pill";
            button2.Text = "Blue pill";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Red pill
            Red MyRedForm = new Red();
            MyRedForm.Text = "This is my Red form";

            MyRedForm.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Blue MyBlueForm = new Blue() { Text = "My Blue form" };
            MyBlueForm.ShowDialog();
        }
    }
}
