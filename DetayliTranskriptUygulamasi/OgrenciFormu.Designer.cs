namespace DetayliTranskriptUygulamasi
{
    partial class OgrenciFormu
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
            groupBox1 = new GroupBox();
            cmbDers = new ComboBox();
            label5 = new Label();
            cmbDonem = new ComboBox();
            label4 = new Label();
            txtNot = new TextBox();
            label3 = new Label();
            txtSoyad = new TextBox();
            label2 = new Label();
            txtAd = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label10 = new Label();
            txtDersAd = new TextBox();
            cmbDersDonem = new ComboBox();
            label9 = new Label();
            label7 = new Label();
            txtDersKredi = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbDers);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cmbDonem);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtNot);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtSoyad);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtAd);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(23, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(273, 309);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Öğrenci Ekleme";
            // 
            // cmbDers
            // 
            cmbDers.FormattingEnabled = true;
            cmbDers.Location = new Point(127, 239);
            cmbDers.Name = "cmbDers";
            cmbDers.Size = new Size(100, 29);
            cmbDers.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 247);
            label5.Name = "label5";
            label5.Size = new Size(82, 21);
            label5.TabIndex = 8;
            label5.Text = "Ders Seç :";
            // 
            // cmbDonem
            // 
            cmbDonem.FormattingEnabled = true;
            cmbDonem.Location = new Point(127, 185);
            cmbDonem.Name = "cmbDonem";
            cmbDonem.Size = new Size(100, 29);
            cmbDonem.TabIndex = 7;
            cmbDonem.SelectedIndexChanged += cmbDonem_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 188);
            label4.Name = "label4";
            label4.Size = new Size(79, 21);
            label4.TabIndex = 6;
            label4.Text = "Dönemi :";
            // 
            // txtNot
            // 
            txtNot.Location = new Point(127, 126);
            txtNot.Name = "txtNot";
            txtNot.Size = new Size(100, 29);
            txtNot.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 134);
            label3.Name = "label3";
            label3.Size = new Size(57, 21);
            label3.TabIndex = 4;
            label3.Text = "Notu :";
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(127, 77);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(100, 29);
            txtSoyad.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 85);
            label2.Name = "label2";
            label2.Size = new Size(70, 21);
            label2.TabIndex = 2;
            label2.Text = "Soyadı :";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(127, 32);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(100, 29);
            txtAd.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 40);
            label1.Name = "label1";
            label1.Size = new Size(39, 21);
            label1.TabIndex = 0;
            label1.Text = "Ad :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(txtDersAd);
            groupBox2.Controls.Add(cmbDersDonem);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtDersKredi);
            groupBox2.Location = new Point(350, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(273, 309);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Yeni Ders Oluşturma";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(37, 40);
            label10.Name = "label10";
            label10.Size = new Size(39, 21);
            label10.TabIndex = 10;
            label10.Text = "Ad :";
            // 
            // txtDersAd
            // 
            txtDersAd.Location = new Point(147, 32);
            txtDersAd.Name = "txtDersAd";
            txtDersAd.Size = new Size(100, 29);
            txtDersAd.TabIndex = 11;
            // 
            // cmbDersDonem
            // 
            cmbDersDonem.FormattingEnabled = true;
            cmbDersDonem.Location = new Point(147, 113);
            cmbDersDonem.Name = "cmbDersDonem";
            cmbDersDonem.Size = new Size(100, 29);
            cmbDersDonem.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(37, 80);
            label9.Name = "label9";
            label9.Size = new Size(70, 21);
            label9.TabIndex = 12;
            label9.Text = "Kredisi :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(37, 121);
            label7.Name = "label7";
            label7.Size = new Size(79, 21);
            label7.TabIndex = 16;
            label7.Text = "Dönemi :";
            // 
            // txtDersKredi
            // 
            txtDersKredi.Location = new Point(147, 72);
            txtDersKredi.Name = "txtDersKredi";
            txtDersKredi.Size = new Size(100, 29);
            txtDersKredi.TabIndex = 13;
            // 
            // button1
            // 
            button1.Location = new Point(23, 337);
            button1.Name = "button1";
            button1.Size = new Size(87, 29);
            button1.TabIndex = 2;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(116, 337);
            button2.Name = "button2";
            button2.Size = new Size(87, 29);
            button2.TabIndex = 3;
            button2.Text = "Sil";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(209, 337);
            button3.Name = "button3";
            button3.Size = new Size(87, 29);
            button3.TabIndex = 4;
            button3.Text = "Güncelle";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(536, 337);
            button4.Name = "button4";
            button4.Size = new Size(87, 29);
            button4.TabIndex = 7;
            button4.Text = "Güncelle";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(443, 337);
            button5.Name = "button5";
            button5.Size = new Size(87, 29);
            button5.TabIndex = 6;
            button5.Text = "Sil";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(350, 337);
            button6.Name = "button6";
            button6.Size = new Size(87, 29);
            button6.TabIndex = 5;
            button6.Text = "Ekle";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // OgrenciFormu
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(653, 394);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "OgrenciFormu";
            Text = "OgrenciFormu";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtNot;
        private Label label3;
        private TextBox txtSoyad;
        private Label label2;
        private TextBox txtAd;
        private Label label1;
        private ComboBox cmbDonem;
        private Label label4;
        private ComboBox cmbDers;
        private Label label5;
        private Label label10;
        private TextBox txtDersAd;
        private ComboBox cmbDersDonem;
        private Label label9;
        private Label label7;
        private TextBox txtDersKredi;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}