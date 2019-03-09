using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.Hide();
            textBox2.Hide();
            label2.Hide();
            button1.Hide();
        }

        static string[] nodes;char[] edges ;
        static LinkedList[] EdgesArr;
        private void button1_Click(object sender, EventArgs e)
        {

            //for (int j=0;j<nodes.Length; j++)
            //{
            //    for (int k = j+1; k < nodes.Length+1; k+=2)
            //    {
            //        nodes[j] = edges [k].ToString ();
            //        EdgesArr[j].InsertAtBeg(edges[k + 2]);
            //    }
            //}

            panel1.Show();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            int x = 50, y = 10;  //213, 140
            TextBox[] txtbx = new TextBox[nodes.Length ];
            if (nodes != null)
            {
                for (int n = 0; n < nodes.Length; n++)
                {
                    txtbx[n] = new TextBox();
                    txtbx[n].Text = nodes[n];

                    txtbx[n].Width = 30;
                    txtbx[n].Height = 30;

                    txtbx[n].BackColor = Color.Beige ;

                    txtbx[n].ReadOnly = true;

                    txtbx[n].Location = new Point(x, y);

                    if (n >= n / 4 && n < n / 2)
                    { x -= 40; y += 40; }

                    else if (n >= n / 2 && n < n / 8)
                    { x += 40; y -= 40; }

                    else
                    { x += 40; y += 40; }

                    panel1.Controls.Add(txtbx[n]);
                }
                //Point P1 = new Point(10, 50);
                //Point p2 = new Point(50, 50);
                //Pen p = new Pen(Color.Red, 4);
                //e.Graphics.DrawLine(p, P1, p2);
                //p.Dispose();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string s = textBox1.Text;
            nodes = s.Split(',');
            edges = textBox2.Text.ToCharArray();
            EdgesArr = new LinkedList[nodes.Length];
            for (int i = 0; i < nodes.Length; i++)
            {
                EdgesArr[i] = new LinkedList();
            }
            for (int i=0; i<nodes .Length; i++)
            {
                ////  MessageBox.Show("Enter cities to " + nodes[i]);
                //  //  if (Messagebox.Show(MessageBoxButtons.OkCancel) == Form1.DialogResult.OK)
                //  DialogResult d = MessageBox.Show("Enter cities conected to " + nodes[i]," ", MessageBoxButtons.OK );
                //  if (d == DialogResult.OK )
                //  {
                textBox2.Show ();
                label2.Show ();
                button1.Show();
                label1.Text = "root city";
                    textBox1.Text = nodes[i];
                    string c = textBox2.Text;
                    string[] con = c.Split(',');
                    for (int j = 0; j < con.Length; j++)
                    {
                        EdgesArr[i].InsertAtBeg(con[j]);
                    }
                button2.Hide();
                //}
                //else
                //    continue;
            }
        }
    }
}
