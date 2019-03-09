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
    public partial class DrawGRAPH : Form
    {
        public DrawGRAPH()
        {
            InitializeComponent();
        }

        private void DrawGRAPH_Load(object sender, EventArgs e)
        {

        }

        private void DrawGRAPH_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        
            int visVal;

            Random r1 = new Random();

            int a = r1.Next(0, 255), b = r1.Next(0, 255), c = r1.Next(0, 255);
            Color[] colr = new Color[InputNodes.nodes.Length];
            for (int i = 0; i < colr.Length ; i++)
            {
                colr[i] = Color.FromArgb((int)a, (int)b, (int)c);

                a = r1.Next(0, 255);
                b = r1.Next(0, 255);
                c = r1.Next(0, 255);
            }

            int x =180, y = 198;  //213, 140
            TextBox[] txtbx = new TextBox[InputNodes.nodes.Length];
            bool[] vt = new bool[InputNodes.nodes.Length];
            bool isEveryNodeVisi = false;
           for (int j=0;j<InputNodes.nodes.Length;j++)
            {
                txtbx[j] = new TextBox();
                txtbx[j].Text = InputNodes.nodes[j];
                txtbx[j].Width = 100;
                txtbx[j].Height = 80;
                txtbx[j].BackColor = colr[0];
                if (j == 0)
                {
                    txtbx[j].Location = new Point(190, 70);
                    //x += 165; //y+=20 ;
                }
                if (j == 1)
                {
                    txtbx[j].Location = new Point(100,180);
                    //x -= 83; y -= 90;
                }
                if (j == 2)
                {
                    txtbx[j].Location = new Point(500,220 );
                    //y += 160;
                }
                if (j == 3)
                {
                    txtbx[j].Location = new Point(198, 350);
                 //   y -= 80;
                }
                panel1.Controls.Add(txtbx[j]);
            }
                //int k = 0;
            for (int i=0;i<InputNodes.EdgesArr.Length;i++)
            {
                Point pnt = new Point();int n=0;
                // if root node is found on the first index of txtbx
                if (txtbx[n].Text == InputNodes.nodes[i])
                {
                    pnt = txtbx[n].Location; 
                }
                //if not then will search for the index where txtbx contsin the root node
                else
                {
                    while (txtbx[n].Text != InputNodes.nodes[i])
                    {
                        n++;
                        if (txtbx[n].Text == InputNodes.nodes[i])
                        {
                            pnt = txtbx[n].Location; break;
                        }
                    }
                }
                Node temp = InputNodes.EdgesArr[i].start.next;
                if (temp.next == null)
                {
                    for (int k = 0; k < InputNodes.nodes.Length; k++)
                    {
                        if (txtbx[k].Text == temp.data)
                        {
                            //Point pnt = txtbx[k - 1].Location;

                            Point p4 = txtbx[k].Location;
                            Pen pen = new Pen(Color.Black, 3);
                            pen.StartCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                            int o = 0;
                            while (txtbx[k].BackColor == txtbx[i].BackColor)
                            {
                                if (o < colr.Length)
                                {
                                    txtbx[k].BackColor = colr[o];
                                    o++;
                                }
                            }
                            e.Graphics.DrawLine(pen, p4, pnt);

                        }
                    }
                }
                while (temp.next != null)
                {
                    for (int k = 0; k < InputNodes.nodes.Length; k++)
                    { if (txtbx[k].Text == temp.data)
                        {
                            //Point pnt = txtbx[k - 1].Location;

                            Point p4 = txtbx[k].Location;
                            Pen pen = new Pen(Color.Black, 3);
                            pen.StartCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                            int o = 0;
                            while (txtbx[k].BackColor == txtbx[i].BackColor)
                            {
                                if (o < colr.Length)
                                {
                                    txtbx[k].BackColor = colr[o];
                                    o++;
                                }
                            }
                            e.Graphics.DrawLine(pen, p4, pnt);

                        }
                   
                    else
                        { continue; }
                    } 
                    //else

                    
                        temp = temp.next; 
                    if (temp.next==null)
                    {
                        for (int k = 0; k < InputNodes.nodes.Length; k++)
                        {
                            if (txtbx[k].Text == temp.data)
                            {
                                //Point pnt = txtbx[k - 1].Location;

                                Point p4 = txtbx[k].Location;
                                Pen pen = new Pen(Color.Black, 3);
                                pen.StartCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                                int o = 0;
                                while (txtbx[k].BackColor == txtbx[i].BackColor)
                                {
                                    if (o < colr.Length)
                                    {
                                        txtbx[k].BackColor = colr[o];
                                        o++;
                                    }
                                }
                                e.Graphics.DrawLine(pen, p4, pnt);

                            }

                            else
                            { continue; }
                        }

                    }

                }
            }
            //for (int i = 0; i < Form1.EdgesArr.Length; i++)
            //{
            //    while (isEveryNodeVisi==false)
            //    {
            //        if (Form1.EdgesArr[i].start.next.data=="")
            //        {
            //            if (vt[i] != true)
            //            {
            //                //txtbx[k] = new TextBox();
            //                //txtbx[k].Text = Form1.nodes[i];
            //                //txtbx[k].Width = 100;
            //                //txtbx[k].Height = 80;
            //                //txtbx[k].BackColor = colr[0];
            //                //if (k == 0)
            //                //{
            //                //    txtbx[k].Location = new Point(x, y);
            //                //    x += 165; //y+=20 ;
            //                //}
            //                //if (k == 1)
            //                //{
            //                //    txtbx[k].Location = new Point(x, y);
            //                //    x -= 83; y -= 90;
            //                //}
            //                //if (k == 2)
            //                //{
            //                //    txtbx[k].Location = new Point(x, y);
            //                //    y -= 160;
            //                //}
            //                //if (k == 3)
            //                //{
            //                //    txtbx[k].Location = new Point(x, y);
            //                //    y -= 80;
            //                //}
            //                //panel1.Controls.Add(txtbx[k]);

            //                //visVal = Array.IndexOf(Form1.nodes, Form1.nodes[i]);
            //                //vt[visVal] = true;

            //            }
            //        }
            //        else
            //        {
            //            Node temp = Form1.EdgesArr[i].start.next;
            //            while (temp.next != null)
            //            {
            //                txtbx[k] = new TextBox();
            //                txtbx[k].Text = temp.data;
            //                txtbx[k].Width = 100;
            //                txtbx[k].Height = 80;
            //                txtbx[k].BackColor = colr[0];
            //                if (k == 0)
            //                {
            //                    txtbx[k].Location = new Point(x, y);
            //                    x += 165; //y+=20 ;
            //                }
            //                if (k == 1)
            //                { txtbx[k].Location = new Point(x, y);
            //                    x -= 83; y -= 90;
            //                }
            //                if (k == 2)
            //                {
            //                    txtbx[k].Location = new Point(x, y);
            //                    y += 160;
            //                }
            //                if (k == 3)
            //                {
            //                    txtbx[k].Location = new Point(x, y);
            //                    y -= 80;
            //                }
            //                panel1.Controls.Add(txtbx[k]);

            //                visVal = Array.IndexOf(Form1.nodes, temp.data);
            //                vt[visVal] = true;

            //                temp = temp.next;
            //                k++;

            //                if (temp.next == null)
            //                {
            //                    txtbx[k] = new TextBox();
            //                    txtbx[k].Text = temp.data;
            //                    txtbx[k].Width = 70;
            //                    txtbx[k].Height = 30;
            //                    txtbx[k].BackColor = colr[0];
            //                    txtbx[k].ReadOnly = true;
            //                    txtbx[k].Location = new Point(x, y);
            //                    x -= 90; y -= 90;
            //                    panel1.Controls.Add(txtbx[k]);

            //                    visVal = Array.IndexOf(Form1.nodes, temp.data);
            //                    vt[visVal] = true;
            //                    k++;
            //                }
            //            }
                      
            //            txtbx[k] = new TextBox();
            //            txtbx[k].Text = Form1.nodes[i];
            //            txtbx[k].Width = 100;
            //            txtbx[k].Height = 80;
            //            txtbx[k].BackColor = colr[0];
            //            txtbx[k].ReadOnly = true;

            //            if (k == 0)
            //            {
            //                txtbx[k].Location = new Point(x, y);
            //                x += 160;
            //            }
            //            if (k == 1)
            //            {
            //                txtbx[k].Location = new Point(x, y);
            //                x -= 80; y -= 80;
            //            }
            //            if (k == 2)
            //            {
            //                txtbx[k].Location = new Point(x, y);
            //                y += 160;
            //            }
            //            if (k == 3)
            //            {
            //                txtbx[k].Location = new Point(x, y);
            //                y -= 80;
            //            }
            //            panel1.Controls.Add(txtbx[k]);
            //            k++;

            //            visVal = Array.IndexOf(Form1.nodes, Form1.nodes[i]);
            //            vt[visVal] = true;

            //            Point pnt = txtbx[k - 1].Location;
            //            for (int j = 0; j < k - 1; j++)
            //            {
            //                Point p4 = txtbx[j].Location;
            //                Pen pen = new Pen(Color.Black, 6);
            //                pen.StartCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            //                int o = 0;
            //                while (txtbx[j].BackColor== txtbx[k - 1].BackColor)
            //                {
            //                    if (o < colr.Length)
            //                    {
            //                        txtbx[j].BackColor = colr[o];
            //                        o++;
            //                    }
            //                }
            //                e.Graphics.DrawLine(pen, p4, pnt);
            //            }

            //            for (int d = 0; d < vt.Length; d++)
            //            {
            //                if (vt[d] == true)
            //                {
            //                    isEveryNodeVisi = true;
            //                }
            //                else
            //                {
            //                    isEveryNodeVisi = false;
            //                    break;
            //                }
            //            }
            //        }
            //    }

            //}
                #region
                //for (int n = 0; n < Form1.nodes.Length; n++)
                //{
                //    txtbx[n] = new TextBox();
                //    txtbx[n].Text = Form1.nodes[n];

                //    txtbx[n].Width = 70;
                //    txtbx[n].Height = 30;

                //    txtbx[n].BackColor = Color.Cyan;

                //    txtbx[n].ReadOnly = true;

                //    txtbx[n].Location = new Point(x, y);

                //    #region
                //    if (n >= n / 4 && n < n / 2)
                //    { x -= 40; y += 40; }

                //    else if (n >= n / 2 && n < n / 8)
                //    { x += 40; y -= 40; }


                //    else
                //    { x += 40; y += 40; }
                //    #endregion

                //    panel1.Controls.Add(txtbx[n]);
                //}

                //    for (int i = 0; i < Form1.nodes.Length; i++)
                //    {
                //        Node temp = Form1.EdgesArr[i].start.next;
                //        for (int j = 0; j < Form1.nodes.Length; j++)
                //        {
                //            int k = j;
                //            if (txtbx[k].Text == temp.next.data)

                //            {
                //                //while (txtbx[k].Text != temp.data)
                //                //{
                //                //    if (txtbx[k].Text == temp.data) break;
                //                //    else k++;
                //                //}
                //                Point P1 = txtbx[i].Location;
                //                Point p2 = txtbx[k].Location;
                //                Pen p = new Pen(Color.Black, 4);
                //                p.StartCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                //                e.Graphics.DrawLine(p, p2, P1);
                //                temp = temp.next;
                //            }
                //        else {
                //           continue; }
                //        }
                #endregion
          





        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
