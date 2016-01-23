using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace GraphicalPassword
{
    public partial class GP : Form
    {
        string imagelist = "";
        string pass = "";
        int imageclickcounter = 0;
        string connectionstring = @"Provider=microsoft.jet.oledb.4.0; Data Source=" + Application.StartupPath + "/GP.mdb";
        OleDbConnection connection;
        //OleDbDataAdapter ad;
        OleDbCommand com;
        //DataSet ds;
        public GP()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnli1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath;
            openFileDialog1.Filter = "Bitmap File(*.bmp)|*.bmp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap bp = new Bitmap(openFileDialog1.FileName);
                pb1.Image = (Image)bp;
                FileInfo fn = new FileInfo(openFileDialog1.FileName);
                imagelist = imagelist+ fn.Name + "$";

            }
        }

        private void btnli2_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath;
            openFileDialog1.Filter = "Bitmap File(*.bmp)|*.bmp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap bp = new Bitmap(openFileDialog1.FileName);
                pb2.Image = (Image)bp;
                FileInfo fn = new FileInfo(openFileDialog1.FileName);
                imagelist = imagelist+ fn.Name + "$";
            }
        }

        private void btnli3_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath;
            openFileDialog1.Filter = "Bitmap File(*.bmp)|*.bmp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap bp = new Bitmap(openFileDialog1.FileName);
                pb3.Image = (Image)bp;
                FileInfo fn = new FileInfo(openFileDialog1.FileName);
                imagelist = imagelist + fn.Name + "$";
            }
        }

        private void btnli4_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath;
            openFileDialog1.Filter = "Bitmap File(*.bmp)|*.bmp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap bp = new Bitmap(openFileDialog1.FileName);
                pb4.Image = (Image)bp;
                FileInfo fn = new FileInfo(openFileDialog1.FileName);
                imagelist = imagelist + fn.Name + "$";
            }
        }

        private void btnli5_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath;
            openFileDialog1.Filter = "Bitmap File(*.bmp)|*.bmp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap bp = new Bitmap(openFileDialog1.FileName);
                pb5.Image = (Image)bp;
                FileInfo fn = new FileInfo(openFileDialog1.FileName);
                imagelist = imagelist + fn.Name + "$";
            }
        }

        private void btnli6_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath;
            openFileDialog1.Filter = "Bitmap File(*.bmp)|*.bmp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap bp = new Bitmap(openFileDialog1.FileName);
                pb6.Image = (Image)bp;
                FileInfo fn = new FileInfo(openFileDialog1.FileName);
                imagelist = imagelist + fn.Name + "$";
            }
        }

        private void btnli7_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath;
            openFileDialog1.Filter = "Bitmap File(*.bmp)|*.bmp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap bp = new Bitmap(openFileDialog1.FileName);
                pb7.Image = (Image)bp;
                FileInfo fn = new FileInfo(openFileDialog1.FileName);
                imagelist = imagelist + fn.Name + "$";
            }
        }

        private void btnli8_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath;
            openFileDialog1.Filter = "Bitmap File(*.bmp)|*.bmp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap bp = new Bitmap(openFileDialog1.FileName);
                pb8.Image = (Image)bp;
                FileInfo fn = new FileInfo(openFileDialog1.FileName);
                imagelist = imagelist + fn.Name;
            }
        }

        private void pb1_MouseClick(object sender, MouseEventArgs e)
        {
            int xvalue = e.X;
            int yvalue = e.Y;
            pass = pass + e.X + "#" + e.Y + "$";
            imageclickcounter++;
           
        }

        private void pb2_MouseClick(object sender, MouseEventArgs e)
        {
            int xvalue = e.X;
            int yvalue = e.Y;
            pass = pass+ e.X + "#" + e.Y + "$";
            imageclickcounter++;
        }

        private void pb3_MouseClick(object sender, MouseEventArgs e)
        {
            int xvalue = e.X;
            int yvalue = e.Y;
            pass = pass + e.X + "#" + e.Y + "$";
            imageclickcounter++;
        }

        private void pb4_MouseClick(object sender, MouseEventArgs e)
        {
            int xvalue = e.X;
            int yvalue = e.Y;
            pass = pass + e.X + "#" + e.Y + "$";
            imageclickcounter++;
        }

        private void pb5_MouseClick(object sender, MouseEventArgs e)
        {
            int xvalue = e.X;
            int yvalue = e.Y;
            pass = pass + e.X + "#" + e.Y + "$";
            imageclickcounter++;
        }



        private void pb6_MouseClick(object sender, MouseEventArgs e)
        {
            int xvalue = e.X;
            int yvalue = e.Y;
            pass = pass + e.X + "#" + e.Y + "$";
            imageclickcounter++;
        }

        private void pb7_MouseClick(object sender, MouseEventArgs e)
        {
            int xvalue = e.X;
            int yvalue = e.Y;
            pass = pass + e.X + "#" + e.Y + "$";
            imageclickcounter++;
        }

        private void pb8_MouseClick(object sender, MouseEventArgs e)
        {
            int xvalue = e.X;
            int yvalue = e.Y;
            pass = pass + e.X + "#" + e.Y;
            imageclickcounter++;
        }

        private void btngp_Click(object sender, EventArgs e)
        {
            if (imageclickcounter == 8)
            {
                if (txtuserid.Text != "")
                {
                    connection = new OleDbConnection(connectionstring);
                    connection.Open();
                    string passinfo = "insert into Gpass values(" + txtuserid.Text + ",'" + imagelist + "','" + pass + "')";
                    com = new OleDbCommand(passinfo, connection);
                    com.ExecuteNonQuery();
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("Please Enter User ID", "Graphical Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtuserid.Focus();
                }
            }
            else
            {
                MessageBox.Show("AllPixels Are Not Selected", "Graphical Password", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        
    }
}