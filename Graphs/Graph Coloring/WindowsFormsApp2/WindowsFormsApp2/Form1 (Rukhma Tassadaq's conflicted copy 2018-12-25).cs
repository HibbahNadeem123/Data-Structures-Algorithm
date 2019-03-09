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
            button3.Hide();

        }

        static string[] nodes;
        static LinkedList[] EdgesArr;
        // static bool[] vt;
        static int i = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Show();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            int x = 50, y = 10;  //213, 140
            TextBox[] txtbx = new TextBox[nodes.Length];
            if (nodes != null)
            {
                for (int n = 0; n < nodes.Length; n++)
                {
                    txtbx[n] = new TextBox();
                    txtbx[n].Text = nodes[n];

                    txtbx[n].Width = 70;
                    txtbx[n].Height = 30;

                    txtbx[n].BackColor = Color.Cyan;

                    txtbx[n].ReadOnly = true;

                    txtbx[n].Location = new Point(x, y);

                    #region
                    if (n >= n / 4 && n < n / 2)
                    { x -= 40; y += 40; }

                    else if (n >= n / 2 && n < n / 8)
                    { x += 40; y -= 40; }


                    else
                    { x += 40; y += 40; }
                    #endregion

                    panel1.Controls.Add(txtbx[n]);





                }

                //Point P1 = new Point(15, y);
                //Point p2 = new Point(32, 35);
                //Pen p = new Pen(Color.Black , 4);
                //e.Graphics.DrawLine(p, P1, p2);
                //p.Dispose();
            }

            for (int i = 0; i < nodes.Length; i++)
            {
                Node temp = EdgesArr[i].start.next;
                for (int j = 0; j < nodes.Length; j++)
                {
                    int k = j;
                    if (txtbx[k].Text == temp.next.data)

                    {
                        while (txtbx[k].Text != temp.data)
                        {
                            if (txtbx[k].Text == temp.data) break;
                            else k++;
                        }
                        Point P1 = txtbx[j].Location;
                        Point p2 = txtbx[k].Location;
                        Pen p = new Pen(Color.Black, 4);
                        p.StartCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                        e.Graphics.DrawLine(p, p2, P1);
                        temp = temp.next;
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {

            //if (textBox2.Text == null||textBox2 .Text =="")
            ////{
            //    nodes = textBox1.Text.Split(',');
            //    EdgesArr = new LinkedList[nodes.Length];
            //    for (int i = 0; i < nodes.Length; i++)
            //    {
            //        EdgesArr[i] = new LinkedList();
            //    }
            //    label1.Text = "Enter cities connected to " + nodes[i];
            //    textBox1.Hide();
            //    label2.Text = "Enter cities here";
            //    label2.Show();
            //    textBox2.Show(); i++;
            ////}
            ////else
            ////{
            //    //nodes = textBox1.Text.Split(',');
            //    //EdgesArr = new LinkedList[nodes.Length];
            //    //for (int i = 0; i < nodes.Length; i++)
            //    //{
            //    //    EdgesArr[i] = new LinkedList();
            //    //}
            //    //label1.Text = "Enter cities connected to " + nodes[i];
            //    //textBox1.Hide();
            //    //label2.Text = "Enter cities here";
            //    //label2.Show();
            //    //textBox2.Show();
            //    //  textBox2.Text = "b,c";



            //        button3.Show();
            //        button2.Hide();


            //    //}
            //    textBox2.Text = null;
            //}

            //private void button3_Click(object sender, EventArgs e)
            //{

                //    if (i < nodes.Length - 1)
                //    {
                //        string[] edges = textBox2.Text.Split(',');

                //        for (int j = 0; j < edges.Length; j++)
                //        {
                //            EdgesArr[i].InsertAtBeg(edges[j].ToString());
                //        }
                //        label1.Text = "Enter cities connected to " + nodes[i];
                //        i++;
                //    }
                //    else
                //    {
                //        button1.Show();
                //        button3.Hide();
                //    }

                //    textBox2.Text = null;
                //}
            }
        } } 

