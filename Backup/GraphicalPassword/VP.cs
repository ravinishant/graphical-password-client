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
    public partial class VP : Form
    {
        string imagelist = "";
        string pass = "";
        string connectionstring = @"Provider=microsoft.jet.oledb.4.0; Data Source=" + Application.StartupPath + "/GP.mdb";
        OleDbConnection connection;
        OleDbDataAdapter ad;
        //OleDbCommand com;
        DataSet ds;
        public VP()
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
                imagelist = imagelist + fn.Name + "$";
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
                imagelist = imagelist + fn.Name + "$";
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
        }

        private void pb2_MouseClick(object sender, MouseEventArgs e)
        {
            int xvalue = e.X;
            int yvalue = e.Y;
            pass = pass + e.X + "#" + e.Y + "$";
        }

        private void pb3_MouseClick(object sender, MouseEventArgs e)
        {
            int xvalue = e.X;
            int yvalue = e.Y;
            pass = pass + e.X + "#" + e.Y + "$";
        }

        private void pb4_MouseClick(object sender, MouseEventArgs e)
        {
            int xvalue = e.X;
            int yvalue = e.Y;
            pass = pass + e.X + "#" + e.Y + "$";
        }

        private void pb5_MouseClick(object sender, MouseEventArgs e)
        {
            int xvalue = e.X;
            int yvalue = e.Y;
            pass = pass + e.X + "#" + e.Y + "$";
        }



        private void pb6_MouseClick(object sender, MouseEventArgs e)
        {
            int xvalue = e.X;
            int yvalue = e.Y;
            pass = pass + e.X + "#" + e.Y + "$";
        }

        private void pb7_MouseClick(object sender, MouseEventArgs e)
        {
            int xvalue = e.X;
            int yvalue = e.Y;
            pass = pass + e.X + "#" + e.Y + "$";
        }

        private void pb8_MouseClick(object sender, MouseEventArgs e)
        {
            int xvalue = e.X;
            int yvalue = e.Y;
            pass = pass + e.X + "#" + e.Y;
        }
        int range = 5;
        private void btnvp_Click(object sender, EventArgs e)
        {
            bool validpassflag = false;
            if (txtuserid.Text != "")
            {
                connection = new OleDbConnection(connectionstring);
                connection.Open();
                string verifyinfo = "select imagelist, pass from Gpass where userid=" + txtuserid.Text;
                ad = new OleDbDataAdapter(verifyinfo, connection);
                ds = new DataSet();
                ad.Fill(ds, "Gpass");
                if (imagelist == ds.Tables["Gpass"].Rows[0][0].ToString())
                {
                    string[] oldpass = ds.Tables["Gpass"].Rows[0][1].ToString().Split('$');
                    string[] newpass = pass.Split('$');

                    for (int index = 0; index < oldpass.Length; index++)
                    {
                        string[] oldxyvalues = oldpass[index].Split('#');
                        string[] newxyvalues = newpass[index].Split('#');
                        if ((Convert.ToInt32(oldxyvalues[0]) - range) <= Convert.ToInt32(newxyvalues[0]) && Convert.ToInt32(newxyvalues[0]) <= (Convert.ToInt32(oldxyvalues[0]) + range))
                        {
                            if ((Convert.ToInt32(oldxyvalues[1]) - range) <= Convert.ToInt32(newxyvalues[1]) && Convert.ToInt32(newxyvalues[1]) <= (Convert.ToInt32(oldxyvalues[1]) + range))
                            {
                                validpassflag = true;
                            }
                            else
                            {
                                validpassflag = false;
                                break;
                            }
                        }
                        else
                        {
                            validpassflag = false;
                            break;
                        }

                    }
                    if (validpassflag)
                    {
                        MessageBox.Show("Valid Password", "Graphical Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        panel1.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Invalid Password", "Graphical Password", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    pass = "";


                }
                else
                {
                    MessageBox.Show("Your Image list is wrong", "Graphical Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please Enter User ID", "Graphical Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtuserid.Focus();
            }
        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            //openFileDialog2.InitialDirectory = Application.StartupPath;
            openFileDialog2.Filter = "Text File(*.txt)|*.txt";
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                //Bitmap bp = new Bitmap(openFileDialog1.FileName);
                //pb8.Image = (Image)bp;
                FileInfo fn = new FileInfo(openFileDialog2.FileName);
                txtfilename.Text = fn.Name;
                StreamReader sr = new StreamReader(openFileDialog2.FileName);
                txtinfo.Text =  sr.ReadToEnd();
                panel1.Visible = false;
            }
        }


        
    }
}