using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GraphicalPassword
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btngenerate_Click(object sender, EventArgs e)
        {
            GP gp = new GP();
            gp.Show();
        }

        private void btnverify_Click(object sender, EventArgs e)
        {
            VP vp = new VP();
            vp.Show();
        }
    }
}