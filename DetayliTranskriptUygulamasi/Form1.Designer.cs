namespace DetayliTranskriptUygulamasi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnOgrenciEkle = new Button();
            btnDersEkle = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(42, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(233, 45);
            label1.TabIndex = 0;
            label1.Text = "İşlem Birimi Seçiniz";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnOgrenciEkle
            // 
            btnOgrenciEkle.Location = new Point(42, 69);
            btnOgrenciEkle.Name = "btnOgrenciEkle";
            btnOgrenciEkle.Size = new Size(233, 41);
            btnOgrenciEkle.TabIndex = 1;
            btnOgrenciEkle.Text = "Ogrenci Ekleme Kısmı";
            btnOgrenciEkle.UseVisualStyleBackColor = true;
            btnOgrenciEkle.Click += btnOgrenciEkle_Click;
            // 
            // btnDersEkle
            // 
            btnDersEkle.Location = new Point(42, 134);
            btnDersEkle.Name = "btnDersEkle";
            btnDersEkle.Size = new Size(233, 41);
            btnDersEkle.TabIndex = 2;
            btnDersEkle.Text = "Öğrenci Transkript Görme";
            btnDersEkle.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(348, 219);
            Controls.Add(btnDersEkle);
            Controls.Add(btnOgrenciEkle);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnOgrenciEkle;
        private Button btnDersEkle;
    }
}