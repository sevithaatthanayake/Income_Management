using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Income_Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 

           // DateTime dt1 = DateTime.Now;
            //DateTime dt2 = DateTime.Parse("12/01/2020");
            //if (dt1.Date > dt2.Date)
           // {
              //  MessageBox.Show("Application Expired. Contact The Developer For Lisence");

//            }
  //          else
            {

                Form2 next = new Form2();
                next.Show();
                MessageBox.Show("Warning:- Save Important Info and Enter Value 0 in every Empty TextBox");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //DateTime dt1 = DateTime.Now;
            //DateTime dt2 = DateTime.Parse("12/01/2020");
            //if (dt1.Date > dt2.Date)
            //{
              //  MessageBox.Show("Application Expired. Contact The Developer For Lisence");

            //}
            //else
            {
                Form3 nm = new Form3();
                nm.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //DateTime dt1 = DateTime.Now;
           // DateTime dt2 = DateTime.Parse("12/01/2020");

           // if (dt1.Date > dt2.Date)
           // {
           //     MessageBox.Show("Application Expired. Contact The Developer For Lisence");

           // }
           // else
            {
                Form4 mm = new Form4();
                mm.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 mm = new Form5();
            mm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 bn = new Form6();
            bn.Show();
        }
    }
}
