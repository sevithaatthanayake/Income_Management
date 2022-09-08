namespace Income_Management
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.txtamount = new System.Windows.Forms.TextBox();
            this.txtrate = new System.Windows.Forms.TextBox();
            this.txtduration = new System.Windows.Forms.TextBox();
            this.txtinterest = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txttotinterest = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtamount
            // 
            this.txtamount.BackColor = System.Drawing.Color.White;
            this.txtamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtamount.Location = new System.Drawing.Point(15, 122);
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(194, 53);
            this.txtamount.TabIndex = 0;
            // 
            // txtrate
            // 
            this.txtrate.BackColor = System.Drawing.Color.White;
            this.txtrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtrate.Location = new System.Drawing.Point(248, 122);
            this.txtrate.Name = "txtrate";
            this.txtrate.Size = new System.Drawing.Size(130, 53);
            this.txtrate.TabIndex = 0;
            // 
            // txtduration
            // 
            this.txtduration.BackColor = System.Drawing.Color.White;
            this.txtduration.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtduration.Location = new System.Drawing.Point(513, 122);
            this.txtduration.Name = "txtduration";
            this.txtduration.Size = new System.Drawing.Size(107, 53);
            this.txtduration.TabIndex = 0;
            // 
            // txtinterest
            // 
            this.txtinterest.BackColor = System.Drawing.Color.IndianRed;
            this.txtinterest.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtinterest.Location = new System.Drawing.Point(714, 122);
            this.txtinterest.Name = "txtinterest";
            this.txtinterest.ReadOnly = true;
            this.txtinterest.Size = new System.Drawing.Size(184, 53);
            this.txtinterest.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(199, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 90);
            this.label2.TabIndex = 1;
            this.label2.Text = "Interest Rate\r\n Per Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label4.Location = new System.Drawing.Point(470, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 92);
            this.label4.TabIndex = 1;
            this.label4.Text = "Duration\r\n(months)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(691, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 88);
            this.label3.TabIndex = 1;
            this.label3.Text = "Interest\r\n(Per Month)";
            // 
            // txttotal
            // 
            this.txttotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txttotal.Location = new System.Drawing.Point(943, 122);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(184, 53);
            this.txttotal.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(948, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 92);
            this.label5.TabIndex = 1;
            this.label5.Text = " Total\r\nAmount";
            // 
            // btncalculate
            // 
            this.btncalculate.BackColor = System.Drawing.Color.DimGray;
            this.btncalculate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncalculate.BackgroundImage")));
            this.btncalculate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btncalculate.ForeColor = System.Drawing.Color.White;
            this.btncalculate.Location = new System.Drawing.Point(31, 234);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(370, 95);
            this.btncalculate.TabIndex = 2;
            this.btncalculate.UseVisualStyleBackColor = false;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Yellow;
            this.btnclear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnclear.BackgroundImage")));
            this.btnclear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnclear.ForeColor = System.Drawing.Color.White;
            this.btnclear.Location = new System.Drawing.Point(456, 234);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(99, 77);
            this.btnclear.TabIndex = 3;
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnclear);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btncalculate);
            this.panel1.Controls.Add(this.txtamount);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtduration);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txttotinterest);
            this.panel1.Controls.Add(this.txtinterest);
            this.panel1.Controls.Add(this.txtrate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txttotal);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(11, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1240, 332);
            this.panel1.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkGreen;
            this.label7.Location = new System.Drawing.Point(663, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(281, 46);
            this.label7.TabIndex = 1;
            this.label7.Text = "Total Interest";
            // 
            // txttotinterest
            // 
            this.txttotinterest.BackColor = System.Drawing.Color.IndianRed;
            this.txttotinterest.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txttotinterest.Location = new System.Drawing.Point(712, 258);
            this.txttotinterest.Name = "txttotinterest";
            this.txttotinterest.ReadOnly = true;
            this.txttotinterest.Size = new System.Drawing.Size(184, 53);
            this.txttotinterest.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(706, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 67);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.richTextBox1.Location = new System.Drawing.Point(16, 444);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(550, 112);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "ABc";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.richTextBox2.Location = new System.Drawing.Point(16, 569);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(550, 82);
            this.richTextBox2.TabIndex = 6;
            this.richTextBox2.Text = "ABc";
            // 
            // richTextBox3
            // 
            this.richTextBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.richTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.richTextBox3.Location = new System.Drawing.Point(583, 444);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(372, 112);
            this.richTextBox3.TabIndex = 6;
            this.richTextBox3.Text = "ABc";
            // 
            // richTextBox4
            // 
            this.richTextBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.richTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.richTextBox4.Location = new System.Drawing.Point(583, 569);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(372, 82);
            this.richTextBox4.TabIndex = 6;
            this.richTextBox4.Text = "ABc";
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(836, 366);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 67);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(497, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 50);
            this.label6.TabIndex = 1;
            this.label6.Text = "Notes";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(943, 452);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.Location = new System.Drawing.Point(17, 661);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(310, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "AllRightsReserved@SevithaAtthanayake";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1180, 691);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.richTextBox4);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1198, 738);
            this.Name = "Form4";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtamount;
        private System.Windows.Forms.TextBox txtrate;
        private System.Windows.Forms.TextBox txtduration;
        private System.Windows.Forms.TextBox txtinterest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txttotinterest;
        private System.Windows.Forms.Label label8;
    }
}