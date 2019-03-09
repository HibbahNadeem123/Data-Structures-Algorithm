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
    public partial class InputNodes : Form
    {
        public InputNodes()
        {
            InitializeComponent();
            
            //textBox2.Hide();
           // label2.Hide();
           
          //  button3.Hide();
            
        }

        static public string[] nodes;
        static public LinkedList[] EdgesArr;
       // static bool[] vt;
        static int i = 0;
        private void button1_Click(object sender, EventArgs e)
        {       
           
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
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
            
             nodes = textBox1.Text.Split(',');
            if (nodes.Length>4)
            {
                MessageBox.Show("Please enter nodes less than or equal to 4");
            }
            if (nodes.Length==0 || textBox1.Text=="")
            {
                MessageBox.Show("This field cannot be left empty");
            }
            if (nodes.Length<=4 && textBox1.Text!="")
            {
                EdgesArr = new LinkedList[nodes.Length];
                #region
                ////if (textBox2.Text == null||textBox2 .Text =="")
                ////{
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
                #endregion
                for (int i = 0; i < nodes.Length; i++)
                {
                    EdgesArr[i] = new LinkedList();
                }
                InputConnections iv = new InputConnections();
                iv.Show();
                this.Hide();
            }
}

        private void button3_Click(object sender, EventArgs e)
        {
           
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
        }
    }
    }

