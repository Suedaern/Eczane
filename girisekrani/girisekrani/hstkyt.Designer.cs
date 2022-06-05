namespace girisekrani
{
    partial class hstkyt
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.adsoyadtxt = new System.Windows.Forms.TextBox();
            this.tctxt = new System.Windows.Forms.TextBox();
            this.sosyalgüvencetxt = new System.Windows.Forms.ComboBox();
            this.cinsiyettxt = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.teltxt = new System.Windows.Forms.MaskedTextBox();
            this.doğumtarihitxt = new System.Windows.Forms.MaskedTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button1.Location = new System.Drawing.Point(25, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "<--";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(65, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad :";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(35, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "T.C Kimlik No :";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(50, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Telefon No  :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "DoğumTarihi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Sosyal Güvencesi :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "Cinsiyeti :";
            // 
            // adsoyadtxt
            // 
            this.adsoyadtxt.Location = new System.Drawing.Point(167, 131);
            this.adsoyadtxt.Name = "adsoyadtxt";
            this.adsoyadtxt.Size = new System.Drawing.Size(200, 24);
            this.adsoyadtxt.TabIndex = 4;
            // 
            // tctxt
            // 
            this.tctxt.Location = new System.Drawing.Point(167, 177);
            this.tctxt.Name = "tctxt";
            this.tctxt.Size = new System.Drawing.Size(200, 24);
            this.tctxt.TabIndex = 5;
            // 
            // sosyalgüvencetxt
            // 
            this.sosyalgüvencetxt.FormattingEnabled = true;
            this.sosyalgüvencetxt.Items.AddRange(new object[] {
            "SGK",
            "Emekli Sandığı ",
            "Bağkur"});
            this.sosyalgüvencetxt.Location = new System.Drawing.Point(167, 312);
            this.sosyalgüvencetxt.Name = "sosyalgüvencetxt";
            this.sosyalgüvencetxt.Size = new System.Drawing.Size(200, 26);
            this.sosyalgüvencetxt.TabIndex = 8;
            this.sosyalgüvencetxt.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // cinsiyettxt
            // 
            this.cinsiyettxt.FormattingEnabled = true;
            this.cinsiyettxt.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.cinsiyettxt.Location = new System.Drawing.Point(167, 359);
            this.cinsiyettxt.Name = "cinsiyettxt";
            this.cinsiyettxt.Size = new System.Drawing.Size(200, 26);
            this.cinsiyettxt.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(185, 475);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 35);
            this.button2.TabIndex = 10;
            this.button2.Text = "Kaydet";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // teltxt
            // 
            this.teltxt.Location = new System.Drawing.Point(167, 222);
            this.teltxt.Mask = "(999) 000-0000";
            this.teltxt.Name = "teltxt";
            this.teltxt.Size = new System.Drawing.Size(200, 24);
            this.teltxt.TabIndex = 11;
            // 
            // doğumtarihitxt
            // 
            this.doğumtarihitxt.Location = new System.Drawing.Point(167, 269);
            this.doğumtarihitxt.Mask = "00/00/0000";
            this.doğumtarihitxt.Name = "doğumtarihitxt";
            this.doğumtarihitxt.Size = new System.Drawing.Size(200, 24);
            this.doğumtarihitxt.TabIndex = 12;
            this.doğumtarihitxt.ValidatingType = typeof(System.DateTime);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(126, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(231, 28);
            this.textBox1.TabIndex = 17;
            // 
            // hstkyt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(452, 593);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.doğumtarihitxt);
            this.Controls.Add(this.teltxt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cinsiyettxt);
            this.Controls.Add(this.sosyalgüvencetxt);
            this.Controls.Add(this.tctxt);
            this.Controls.Add(this.adsoyadtxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "hstkyt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta Kayıt";
            this.Load += new System.EventHandler(this.hstkyt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox adsoyadtxt;
        public System.Windows.Forms.TextBox tctxt;
        public System.Windows.Forms.ComboBox sosyalgüvencetxt;
        public System.Windows.Forms.ComboBox cinsiyettxt;
        public System.Windows.Forms.MaskedTextBox teltxt;
        public System.Windows.Forms.MaskedTextBox doğumtarihitxt;
    }
}