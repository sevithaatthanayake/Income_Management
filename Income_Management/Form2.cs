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
    public partial class Form2 : Form
    {
        public static string passingText;

        public Form2()
        {
            InitializeComponent();
        }

        private void btntot1_Click(object sender, EventArgs e)
        {
            txttotone.Text = (Convert.ToDecimal(txtmed.Text) + Convert.ToDecimal(txtlight.Text) +
                Convert.ToDecimal(txtwater.Text) + Convert.ToDecimal(txtedu.Text) + Convert.ToDecimal(txttrans.Text) +
                Convert.ToDecimal(txttel.Text) + Convert.ToDecimal(txttv.Text) + Convert.ToDecimal(txtint.Text) +
                Convert.ToDecimal(txtrent.Text)+Convert.ToDecimal(txthealth.Text)).ToString();

            
        }

        private void txtmed_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtincome_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btnhouseholdtot_Click(object sender, EventArgs e)
        {
            txthouseholdtot.Text = (Convert.ToDecimal(txtfood.Text) + Convert.ToDecimal(txtshopping.Text) + Convert.ToDecimal(txtpets.Text) +
                Convert.ToDecimal(txthousehold.Text) + Convert.ToDecimal(txtclothes.Text) + Convert.ToDecimal(txtvehinsu.Text)).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtmaintot.Text = (Convert.ToDecimal(txtpropmain.Text) + Convert.ToDecimal(txtrep.Text) + Convert.ToDecimal(txtconstr.Text) +
                Convert.ToDecimal(txtvehmain.Text)).ToString();

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtotot.Text = (Convert.ToDecimal(txtotherone.Text) + Convert.ToDecimal(txtothertwo.Text) +
                Convert.ToDecimal(txtotherthree.Text)).ToString();

           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtdebtstot.Text = (Convert.ToDecimal(txtdbtone.Text) + Convert.ToDecimal(txtdbttwo.Text) + 
                Convert.ToDecimal(txtdbtthree.Text)).ToString();

            
        }

        private void btnnettot_Click(object sender, EventArgs e)
        {
            txtnettot.Text = (Convert.ToDecimal(txtdebtstot.Text) + Convert.ToDecimal(txthouseholdtot.Text) + Convert.ToDecimal(txtmaintot.Text) +
                Convert.ToDecimal(txtotot.Text) + Convert.ToDecimal(txttotone.Text)).ToString();



            txtbalance.Text = (Convert.ToDecimal(txtincome.Text) - Convert.ToDecimal(txtnettot.Text)).ToString();

            passingText = txtnettot.Text;


        }

        private void button4_Click(object sender, EventArgs e)
        {
          Settings.Default["one"] =txtmed.Text;
          Settings.Default["two"] = txtlight.Text;
          Settings.Default["three"] =txtwater.Text;
          Settings.Default["four"] = txtedu.Text;
            Settings.Default["five"] = txtnettot.Text;
            Settings.Default["six"] = txtbalance.Text;
         Settings.Default["house"] = txttrans.Text;
            Settings.Default["info1"] = txtotherone.Text;
            Settings.Default["info2"] = txtothertwo.Text;
            Settings.Default["info3"] = txtotherthree.Text;

            Settings.Default["other1"] = richTextBox1.Text;
            Settings.Default["other2"] = richTextBox2.Text;
            Settings.Default["other3"] = richTextBox6.Text;

            Settings.Default["dinfo1"] = richTextBox3.Text;
            Settings.Default["dinfo2"] = richTextBox4.Text;
            Settings.Default["dinfo3"] = richTextBox5.Text;

            Settings.Default["debt1"] = txtdbtone.Text;
            Settings.Default["debt2"] = txtdbttwo.Text;
            Settings.Default["debt3"] = txtdbtthree.Text;

            Settings.Default["tel"] = txttel.Text;
            Settings.Default["tele"] = txttv.Text;
            Settings.Default["health"] = txthealth.Text;
            Settings.Default["house"] = txtrent.Text;
            Settings.Default["internet"] = txtint.Text;

           

            Settings.Default.Save();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           txtmed.Text = Settings.Default["one"].ToString();
           txtlight.Text = Settings.Default["two"].ToString();
           txtwater.Text = Settings.Default["three"].ToString();
          txtedu.Text = Settings.Default["four"].ToString();
            txtnettot.Text = Settings.Default["five"].ToString();
            txtbalance.Text = Settings.Default["six"].ToString();
          txttrans.Text = Settings.Default["transport"].ToString();


            txthealth.Text = Settings.Default["health"].ToString();
            txttv.Text = Settings.Default["tele"].ToString();
            txttel.Text = Settings.Default["tel"].ToString();
            txtrent.Text = Settings.Default["house"].ToString();
            txtint.Text = Settings.Default["internet"].ToString();

            txtotherone.Text = Settings.Default["info1"].ToString();
            txtothertwo.Text = Settings.Default["info2"].ToString();
            txtotherthree.Text = Settings.Default["info3"].ToString();

            richTextBox1.Text = Settings.Default["other1"].ToString();
            richTextBox2.Text = Settings.Default["other2"].ToString();
            richTextBox6.Text = Settings.Default["other3"].ToString();

            richTextBox3.Text = Settings.Default["dinfo1"].ToString();
            richTextBox4.Text = Settings.Default["dinfo2"].ToString();
            richTextBox5.Text = Settings.Default["dinfo3"].ToString();

            txtdbtone.Text = Settings.Default["debt1"].ToString();
            txtdbttwo.Text = Settings.Default["debt2"].ToString();
            txtdbtthree.Text = Settings.Default["debt3"].ToString();

           

        }

        private void button5_Click(object sender, EventArgs e)
        {
          
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
         
           
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Settings.Default["one"] = txtmed.Text;
            Settings.Default["two"] = txtlight.Text;
            Settings.Default["three"] = txtwater.Text;
            Settings.Default["four"] = txtedu.Text;
            Settings.Default["house"] = txttrans.Text;
            Settings.Default["tel"] = txttel.Text;
            Settings.Default["tele"] = txttv.Text;
            Settings.Default["health"] = txthealth.Text;
            Settings.Default["house"] = txtrent.Text;
            Settings.Default["internet"] = txtint.Text;

            Settings.Default.Save();


        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Settings.Default["info1"] = txtotherone.Text;
            Settings.Default["info2"] = txtothertwo.Text;
            Settings.Default["info3"] = txtotherthree.Text;

            Settings.Default["other1"] = richTextBox1.Text;
            Settings.Default["other2"] = richTextBox2.Text;
            Settings.Default["other3"] = richTextBox6.Text;

            Settings.Default["dinfo1"] = richTextBox3.Text;
            Settings.Default["dinfo2"] = richTextBox4.Text;
            Settings.Default["dinfo3"] = richTextBox5.Text;

            Settings.Default["debt1"] = txtdbtone.Text;
            Settings.Default["debt2"] = txtdbttwo.Text;
            Settings.Default["debt3"] = txtdbtthree.Text;

            Settings.Default.Save();
        }
    }
        }
    

