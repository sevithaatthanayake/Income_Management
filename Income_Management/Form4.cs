using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Income_Management.Properties;

namespace Income_Management
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            txtinterest.Text = (Convert.ToDecimal(txtamount.Text) * Convert.ToDecimal(txtrate.Text)/100 / Convert.ToDecimal(txtduration.Text)).ToString();

            txttotal.Text = (Convert.ToDecimal(txtinterest.Text)*Convert.ToDecimal(txtduration.Text) + Convert.ToDecimal(txtamount.Text)).ToString();

            txttotinterest.Text = (Convert.ToDecimal(txtamount.Text) * Convert.ToDecimal(txtrate.Text) / 100).ToString();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtamount.Text = "";
            txtduration.Text = "";
            txtinterest.Text = "";
            txtrate.Text = "";
            txttotal.Text = "";
            txttotinterest.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Settings.Default["note1"] = richTextBox1.Text;
            Settings.Default["note2"] = richTextBox2.Text;
            Settings.Default["note3"] = richTextBox3.Text;
            Settings.Default["note4"] = richTextBox4.Text;
            Settings.Default.Save();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = Settings.Default["note1"].ToString();
            richTextBox2.Text = Settings.Default["note2"].ToString();
            richTextBox3.Text = Settings.Default["note3"].ToString();
            richTextBox4.Text = Settings.Default["note4"].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            richTextBox1.Text = "";
            richTextBox2.Text = "";
            richTextBox3.Text = "";
            richTextBox4.Text = "";

            Settings.Default["note1"] = richTextBox1.Text;
            Settings.Default["note2"] = richTextBox2.Text;
            Settings.Default["note3"] = richTextBox3.Text;
            Settings.Default["note4"] = richTextBox4.Text;
            Settings.Default.Save();
        }
    }
}
