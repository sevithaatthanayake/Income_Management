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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Settings.Default["shortnote1"] = richTextBox1.Text;
            Settings.Default["shortnote2"] = richTextBox2.Text;

            Settings.Default.Save();
           
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = Settings.Default["shortnote1"].ToString();
            richTextBox2.Text = Settings.Default["shortnote2"].ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtmonth.Text = (Convert.ToDecimal(txtcost.Text) * Convert.ToDecimal(txtdays.Text)).ToString();

            txtyear.Text = (Convert.ToDecimal(txtmonth.Text) * 12).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtmonth.Text = "";
            txtyear.Text = "";
            txtdays.Text = "";
            txtcost.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            richTextBox2.Text = "";
        }
    }
}
