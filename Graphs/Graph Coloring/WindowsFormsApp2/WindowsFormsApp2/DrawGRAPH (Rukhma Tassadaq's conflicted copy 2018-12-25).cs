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
            int x = 50, y = 10;  //213, 140
            TextBox[] txtbx = new TextBox[Form1.nodes.Length];
            if (Form1.nodes != null)
            {
                for (int n = 0; n < Form1.nodes.Length; n++)
                {
                    txtbx[n] = new TextBox();
                    txtbx[n].Text = Form1.nodes[n];

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
                for (int i = 0; i < Form1.nodes.Length; i++)
                {
                    Node temp = Form1.EdgesArr[i].start.next;
                    for (int j = 0; j < Form1.nodes.Length; j++)
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
                            //p.StartCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                            e.Graphics.DrawLine(p, p2, P1);
                            temp = temp.next;
                        }
                    }
                }






            }
        }
    }
}
