namespace girisekrani
{
    partial class ilcblg
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
            this.label7 = new System.Windows.Forms.Label();
            this.ürüngrubutxt = new System.Windows.Forms.ComboBox();
            this.ATCkodutxt = new System.Windows.Forms.ComboBox();
            this.etkenmaddetxt = new System.Windows.Forms.TextBox();
            this.üreticiFirmatxt = new System.Windows.Forms.TextBox();
            this.reçetetipitxt = new System.Windows.Forms.ComboBox();
            this.miktarıtxt = new System.Windows.Forms.TextBox();
            this.fiyatıtxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.alınanadettxt = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ilaç_adı = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
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
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(54, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün Grubu : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(46, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Üretici Firma :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(39, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Etken Madde  :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(65, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "ATC Kodu : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(56, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Reçete Tipi :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(84, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Miktarı : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(93, 400);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Fiyatı :";
            // 
            // ürüngrubutxt
            // 
            this.ürüngrubutxt.FormattingEnabled = true;
            this.ürüngrubutxt.Items.AddRange(new object[] {
            "Anabolik Sterodiler",
            "Analjezikler",
            "Anestezikler",
            "Antianjinal ilaçlar",
            "Antidemans ajanlar",
            "Antidiyabetikler",
            "Antiemektikler",
            "Antienfeksiyon ajanlar",
            "Antienflamatuar ajanlar",
            "Antihipertansif ilaçlar",
            "Antikonvülzanlar",
            "Antipiretikler",
            "Antiseptikler",
            "Antitrombotik ilaçlar",
            "Antitussif ve Ekspektoranlar",
            "Antrakinon ilaçlar",
            "Atipik antipsikotikler",
            "Barbitüratlar",
            "Dekonjestanlar",
            "Hemostatik ajanlar",
            "Hipolipidemik ilaçlar",
            "Hormonal ajanlar",
            "Kas gevşeticiler",
            "Kemoterapik ajanlar",
            "Kortikosteroid ilaçlar",
            "Mide asiditesini azaltan ilaçlar",
            "Psikoaktif ilaçlar",
            "Psikoanaleptikler",
            "Seksüel disfonksiyon ilaçları",
            "Sempatomimetik aminler"});
            this.ürüngrubutxt.Location = new System.Drawing.Point(217, 126);
            this.ürüngrubutxt.Name = "ürüngrubutxt";
            this.ürüngrubutxt.Size = new System.Drawing.Size(194, 24);
            this.ürüngrubutxt.TabIndex = 8;
            // 
            // ATCkodutxt
            // 
            this.ATCkodutxt.FormattingEnabled = true;
            this.ATCkodutxt.Items.AddRange(new object[] {
            "A SİNDİRİM SİSTEMİ VE METABOLİZMA ",
            "",
            " A01 Ağız Sağlığı İlaçları",
            " A02 Mide İlaçları",
            " A03 Gastrointestinal Fonksiyonel Hastalıklar",
            " A04 Bulantı ve Kusmada Kullanılan İlaçlar",
            " A05 Safra Kesesi ve Karaciğer",
            " A06 Kabızlık İlaçları",
            " A07 İshal İlaçları, Bağırsak Antienflamatuar ve Antienfektifleri",
            " A08 Obezite Tedavisi",
            " A09 Sindirimi Kolaylaştıran İlaçlar",
            " A10 Diyabet(Şeker Hastalığı) İlaçları",
            " A11 Vitamin İlaçları",
            " A12 Mineraller",
            " A14 Anabolik İlaçlar ",
            " A16 Diğer Sindirim Sistemi ve Metabolizma İlaçları",
            "B KAN VE KAN YAPICI ORGANLAR ",
            "",
            " B01 Antirombotikler",
            " B02 Kanama Durdurucu İlaçlar",
            " B03 Anemi(Kansızlık) İlaçları",
            " B05 Kan ve Perfüzyon Solüsyonları",
            " B06 Hematolojik Ajanlar",
            "C KALP DAMAR SİSTEMİ ",
            "",
            " C01 Kalp İlaçları",
            " C02 Antihipertansif İlaçlar (Yüksek Tansiyon İlaçları)",
            " C03 Diüretik İlaçlar - İdrar Arttırıcı İlaçlar",
            " C04 Periferik Vazodilatörler",
            " C05 Vazoprotektifler",
            " C07 Beta Bloke Edici Ajanlar",
            " C08 Kalsiyum Kanal Blokerleri",
            " C09 Kan Basıncını Düzenleyen İlaçlar",
            " C10 Lipid Metabolizması İlaçları ",
            "D DERMATOLOJİK İLAÇLAR ",
            "",
            " D01 Dermatolojik Mantar Tedavisi ",
            " D02 Yumuşatıcı ve Koruyucu İlaçlar",
            " D03 Yara Ülser Tedavisi  ",
            " D04 Antiprüritik İlaçlar",
            " D05 Antipsoriatik İlaçlar ",
            " D06 Dermatolojik Antibiyotik ve Kemoterapötik İlaçlar ",
            " D07 Dermatolojik Kortikosteroidler",
            " D08 Antiseptik ve Dezenfektan İlaçar",
            " D09 İlaçlı Pansumanlar ",
            " D10 Akne İlaçları ",
            " D11 Diğer Dermatolojik İlaçlar",
            "G ÜROGENİTAL SİSTEM VE CİNSİYET HORMONLARI",
            "",
            " G01 Jinekolojik Antiinektif ve Antiseptikler ",
            " G02 Diğer Jinekolojik İlaçla ",
            " G03 Cinsiyet Hormonları ve Genital Sistem ",
            " G04 Ürolojik İlaçlar ",
            "H ENDOKRİN SİSTEM ",
            "",
            " H01 Hipofiz ve Hipotalamus Hormonları ve Analogları",
            " H02 Sistemik Kortikosteroidler ",
            " H03 Tiroid İlaçları ",
            " H04 Pankreas ",
            " H05 Kalsiyum Metabolizması ",
            "J ENFEKSİYONA KARŞI KULLANILAN (ANRİENFEKTİF) İLAÇLAR ",
            "",
            " J01 Antibakteriyel(Antibiyotik) İlaçlar ",
            " J02 Antimikotik İlaçlar ",
            " J04 Antimikobakteriyel İlaçlar ",
            " J05 Sistemik Antiviral İlaçlar ",
            " J06 İmmün Serum ve İmmünoglobülinler ",
            " J07 Aşılar",
            "L ANTİNEOPLASTİK VE İMMÜNOMODÜLATÖR AJANLAR ",
            "",
            " L01 Antineoplastik İlaçlar (Kanser İlaçları)",
            " L02 Hormonal Tedavi İlaçları ",
            " L03 İmmünostimülanlar ",
            " L04 İmmünsupresif Ajanlar ",
            "M KAS İSKELET SİSTEMİ ",
            "",
            " M01 Antienflamatuar ve Antiromatikler ",
            " M02 Vücut Yüzeyine Uygulanan Kas-Eklem Ağrısı İlaçları",
            " M03 Kas Gevşeticiler ",
            " M04 Gut Hastalığı İlaçları ",
            " M05 Kemik ",
            " M09 Diğer Kas İskelet Sistemi İlaçları ",
            "N SİNİR SİSTEMİ ",
            "",
            " N01 Anestezi İlaçları ",
            " N02 Ağrı Kesici / Ateş Düşürücü (Aneljezik)",
            " N03 Antiepileptik İlaçlar",
            " N04 Parkinson İlaçları ",
            " N05 Psikoleptikler (Psikolojik İlaçlar) ",
            " N06 Psikoanaleptikler",
            " N07 Diğer Sinir Sistemi İlaçları",
            "P PARAZİT VE BÖCEK İLAÇLARI ",
            "",
            " P01 Antiprotozoal İlaçlar ",
            " P02 Antihelmintik İlaçlar ",
            " P03 Ektoparazit İlaçları",
            "R SOLUNUM SİSTEMİ ",
            "",
            " R01 Burunla İlgili İlaçlar ",
            " R02 Boğaz ",
            " R03 Solunum Sisteminde Tıkanma - Astım İlaçları",
            " R05 Soğuk Algınlığı ve Öksürük İlaçları ",
            " R06 Sistemik Antihistaminikler ",
            " R07 Diğer Solunum Sistemi İlaçları ",
            "S DUYU ORGANLARI ",
            "",
            " S01 Göze Uygulanan İlaçlar ",
            " S02 Kulak Hastalıkları ",
            " S03 Göz ve Kulak İlaçları",
            "V ÇEŞİTLİ İLAÇLAR ",
            "",
            " V01 Allerjenler ",
            " V03 Diğer Tüm Terapötik İlaçlar",
            " V04 Tanı Ajanları ",
            " V06 Genel Besin İlaçları ",
            " V07 Tedavi Edici Olmayan Diğer Tüm Ürünler ",
            " V08 Konsrast Medya ",
            " V09 Radyofarmasötik İlaçlar  "});
            this.ATCkodutxt.Location = new System.Drawing.Point(217, 261);
            this.ATCkodutxt.Name = "ATCkodutxt";
            this.ATCkodutxt.Size = new System.Drawing.Size(194, 24);
            this.ATCkodutxt.TabIndex = 9;
            // 
            // etkenmaddetxt
            // 
            this.etkenmaddetxt.Location = new System.Drawing.Point(217, 218);
            this.etkenmaddetxt.Name = "etkenmaddetxt";
            this.etkenmaddetxt.Size = new System.Drawing.Size(194, 22);
            this.etkenmaddetxt.TabIndex = 10;
            // 
            // üreticiFirmatxt
            // 
            this.üreticiFirmatxt.Location = new System.Drawing.Point(217, 173);
            this.üreticiFirmatxt.Name = "üreticiFirmatxt";
            this.üreticiFirmatxt.Size = new System.Drawing.Size(194, 22);
            this.üreticiFirmatxt.TabIndex = 11;
            // 
            // reçetetipitxt
            // 
            this.reçetetipitxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.reçetetipitxt.ForeColor = System.Drawing.Color.Black;
            this.reçetetipitxt.FormattingEnabled = true;
            this.reçetetipitxt.Items.AddRange(new object[] {
            "Beyaz Reçete",
            "Kımızı Reçete",
            "Yeşil Reçete",
            "Turuncu Reçete",
            "Mor Reçete"});
            this.reçetetipitxt.Location = new System.Drawing.Point(217, 306);
            this.reçetetipitxt.Name = "reçetetipitxt";
            this.reçetetipitxt.Size = new System.Drawing.Size(194, 24);
            this.reçetetipitxt.TabIndex = 12;
            this.reçetetipitxt.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // miktarıtxt
            // 
            this.miktarıtxt.Location = new System.Drawing.Point(217, 353);
            this.miktarıtxt.Name = "miktarıtxt";
            this.miktarıtxt.Size = new System.Drawing.Size(194, 22);
            this.miktarıtxt.TabIndex = 13;
            // 
            // fiyatıtxt
            // 
            this.fiyatıtxt.Location = new System.Drawing.Point(217, 398);
            this.fiyatıtxt.Name = "fiyatıtxt";
            this.fiyatıtxt.Size = new System.Drawing.Size(194, 22);
            this.fiyatıtxt.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(46, 448);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Alınan Adet :";
            // 
            // alınanadettxt
            // 
            this.alınanadettxt.Location = new System.Drawing.Point(217, 446);
            this.alınanadettxt.Name = "alınanadettxt";
            this.alınanadettxt.Size = new System.Drawing.Size(194, 22);
            this.alınanadettxt.TabIndex = 18;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(217, 526);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 35);
            this.button3.TabIndex = 19;
            this.button3.Text = "Kaydet";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(217, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 28);
            this.textBox1.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(84, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "İlaç Adı :";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // ilaç_adı
            // 
            this.ilaç_adı.Location = new System.Drawing.Point(217, 89);
            this.ilaç_adı.Name = "ilaç_adı";
            this.ilaç_adı.Size = new System.Drawing.Size(194, 22);
            this.ilaç_adı.TabIndex = 22;
            // 
            // ilcblg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(507, 653);
            this.Controls.Add(this.ilaç_adı);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.alınanadettxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.fiyatıtxt);
            this.Controls.Add(this.miktarıtxt);
            this.Controls.Add(this.reçetetipitxt);
            this.Controls.Add(this.üreticiFirmatxt);
            this.Controls.Add(this.etkenmaddetxt);
            this.Controls.Add(this.ATCkodutxt);
            this.Controls.Add(this.ürüngrubutxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "ilcblg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İlaç Bilgi";
            this.Load += new System.EventHandler(this.ilcblg_Load);
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.ComboBox ürüngrubutxt;
        public System.Windows.Forms.ComboBox ATCkodutxt;
        public System.Windows.Forms.TextBox etkenmaddetxt;
        public System.Windows.Forms.TextBox üreticiFirmatxt;
        public System.Windows.Forms.ComboBox reçetetipitxt;
        public System.Windows.Forms.TextBox miktarıtxt;
        public System.Windows.Forms.TextBox fiyatıtxt;
        public System.Windows.Forms.TextBox alınanadettxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ilaç_adı;
    }
}