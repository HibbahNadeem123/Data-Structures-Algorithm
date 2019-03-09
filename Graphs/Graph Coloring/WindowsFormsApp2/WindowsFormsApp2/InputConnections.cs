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
    public partial class InputConnections : Form
    {
        int i = 0;
        public InputConnections()
        {
            InitializeComponent();
            button1.Hide();
            label1.Text = "Enter cities connected to " + InputNodes.nodes[i];
            
        }
        
        //this.label1.Text = "Enter cities connected to " + nodes[i];
        private void button3_Click(object sender, EventArgs e)
        {
            
          //label1.Text = "Enter cities connected to " + Form1.nodes[i];
               
                string[] edges = textBox2.Text.Split(',');
            for (int j = 0; j < edges.Length; j++)
            {
                InputNodes.EdgesArr[i].InsertAtBeg(edges[j].ToString());
            }
            if (i < InputNodes.nodes.Length )
            {                   
                    i++;
            }
            if (i < InputNodes.nodes.Length)
            {
                label1.Text = "Enter cities connected to " + InputNodes.nodes[i];
            }
            else
            {
                DrawGRAPH dg = new DrawGRAPH();
                dg.Show();
                this.Close();
            }
            textBox2.Text = null;
            

            #region
            //}
            //if(i==0)
            ////{
            //    Form1.EdgesArr = new LinkedList[Form1.nodes.Length];
            //    for (int i = 0; i < Form1.nodes.Length; i++)
            //    {
            //        Form1.EdgesArr[i] = new LinkedList();
            //    }

            //    string[] edg = textBox2.Text.Split(',');
            //    if (i < Form1.nodes.Length - 1)
            //    {
            //        for (int j = 0; j < edg.Length; j++)
            //        {
            //            Form1.EdgesArr[i].InsertAtBeg(edg[j].ToString());
            //        }
            //        i++;
            //    }
            //    else
            //    {
            //        button3.Hide();
            //        button1.Show();
            //    }

            //textBox2.Text = null;
            #endregion
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void InputValAndDraw_Load(object sender, EventArgs e)
        {
            //button1.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DrawGRAPH dg = new DrawGRAPH();
            dg.Show();
            this.Close();
        }
        //}
    }
}
