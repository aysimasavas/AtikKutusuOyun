namespace NDPprojeTasarim
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSaniye = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPuan = new System.Windows.Forms.Label();
            this.cikisButton = new System.Windows.Forms.Button();
            this.yeniOyunButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.progressBarOrganik = new System.Windows.Forms.ProgressBar();
            this.bosaltOrganikAtikButton = new System.Windows.Forms.Button();
            this.listBoxOrganik = new System.Windows.Forms.ListBox();
            this.organikAtikButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.listBoxCam = new System.Windows.Forms.ListBox();
            this.progressBarCam = new System.Windows.Forms.ProgressBar();
            this.bosaltCamButton = new System.Windows.Forms.Button();
            this.camButton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.listBoxKagit = new System.Windows.Forms.ListBox();
            this.progressBarKagit = new System.Windows.Forms.ProgressBar();
            this.bosaltKagitButton = new System.Windows.Forms.Button();
            this.kagitButton = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.listBoxMetal = new System.Windows.Forms.ListBox();
            this.progressBarMetal = new System.Windows.Forms.ProgressBar();
            this.bosaltMetalButton = new System.Windows.Forms.Button();
            this.metalButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 160);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(15, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lblSaniye);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lblPuan);
            this.panel2.Controls.Add(this.cikisButton);
            this.panel2.Controls.Add(this.yeniOyunButton);
            this.panel2.Location = new System.Drawing.Point(13, 178);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(196, 341);
            this.panel2.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(15, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 26);
            this.label5.TabIndex = 6;
            this.label5.Text = "PUAN";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSaniye
            // 
            this.lblSaniye.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lblSaniye.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaniye.ForeColor = System.Drawing.Color.Lavender;
            this.lblSaniye.Location = new System.Drawing.Point(15, 100);
            this.lblSaniye.Name = "lblSaniye";
            this.lblSaniye.Size = new System.Drawing.Size(169, 60);
            this.lblSaniye.TabIndex = 5;
            this.lblSaniye.Text = "0";
            this.lblSaniye.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(15, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "SÜRE";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPuan
            // 
            this.lblPuan.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lblPuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPuan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPuan.Location = new System.Drawing.Point(15, 195);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(169, 66);
            this.lblPuan.TabIndex = 3;
            this.lblPuan.Text = "0";
            this.lblPuan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cikisButton
            // 
            this.cikisButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.cikisButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikisButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cikisButton.Location = new System.Drawing.Point(15, 266);
            this.cikisButton.Name = "cikisButton";
            this.cikisButton.Size = new System.Drawing.Size(169, 41);
            this.cikisButton.TabIndex = 1;
            this.cikisButton.Text = "ÇIKIŞ";
            this.cikisButton.UseVisualStyleBackColor = false;
            // 
            // yeniOyunButton
            // 
            this.yeniOyunButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.yeniOyunButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yeniOyunButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.yeniOyunButton.Location = new System.Drawing.Point(15, 8);
            this.yeniOyunButton.Name = "yeniOyunButton";
            this.yeniOyunButton.Size = new System.Drawing.Size(169, 57);
            this.yeniOyunButton.TabIndex = 0;
            this.yeniOyunButton.Text = "YENİ OYUN";
            this.yeniOyunButton.UseVisualStyleBackColor = false;
            this.yeniOyunButton.Click += new System.EventHandler(this.yeniOyunButton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel3.Controls.Add(this.progressBarOrganik);
            this.panel3.Controls.Add(this.bosaltOrganikAtikButton);
            this.panel3.Controls.Add(this.listBoxOrganik);
            this.panel3.Controls.Add(this.organikAtikButton);
            this.panel3.Location = new System.Drawing.Point(223, 39);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(153, 237);
            this.panel3.TabIndex = 1;
            // 
            // progressBarOrganik
            // 
            this.progressBarOrganik.Location = new System.Drawing.Point(6, 181);
            this.progressBarOrganik.Name = "progressBarOrganik";
            this.progressBarOrganik.Size = new System.Drawing.Size(141, 23);
            this.progressBarOrganik.TabIndex = 6;
            // 
            // bosaltOrganikAtikButton
            // 
            this.bosaltOrganikAtikButton.BackColor = System.Drawing.Color.LavenderBlush;
            this.bosaltOrganikAtikButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bosaltOrganikAtikButton.Location = new System.Drawing.Point(3, 208);
            this.bosaltOrganikAtikButton.Name = "bosaltOrganikAtikButton";
            this.bosaltOrganikAtikButton.Size = new System.Drawing.Size(144, 26);
            this.bosaltOrganikAtikButton.TabIndex = 5;
            this.bosaltOrganikAtikButton.Text = "BOŞALT";
            this.bosaltOrganikAtikButton.UseVisualStyleBackColor = false;
            // 
            // listBoxOrganik
            // 
            this.listBoxOrganik.BackColor = System.Drawing.SystemColors.Info;
            this.listBoxOrganik.FormattingEnabled = true;
            this.listBoxOrganik.Location = new System.Drawing.Point(5, 41);
            this.listBoxOrganik.Name = "listBoxOrganik";
            this.listBoxOrganik.Size = new System.Drawing.Size(141, 134);
            this.listBoxOrganik.TabIndex = 2;
            // 
            // organikAtikButton
            // 
            this.organikAtikButton.BackColor = System.Drawing.Color.LavenderBlush;
            this.organikAtikButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.organikAtikButton.Location = new System.Drawing.Point(3, 3);
            this.organikAtikButton.Name = "organikAtikButton";
            this.organikAtikButton.Size = new System.Drawing.Size(144, 32);
            this.organikAtikButton.TabIndex = 0;
            this.organikAtikButton.Text = "ORGANİK ATIK";
            this.organikAtikButton.UseVisualStyleBackColor = false;
            this.organikAtikButton.Click += new System.EventHandler(this.organikAtikButton_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel4.Controls.Add(this.listBoxCam);
            this.panel4.Controls.Add(this.progressBarCam);
            this.panel4.Controls.Add(this.bosaltCamButton);
            this.panel4.Controls.Add(this.camButton);
            this.panel4.Location = new System.Drawing.Point(223, 282);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(153, 237);
            this.panel4.TabIndex = 2;
            // 
            // listBoxCam
            // 
            this.listBoxCam.BackColor = System.Drawing.SystemColors.Info;
            this.listBoxCam.FormattingEnabled = true;
            this.listBoxCam.Location = new System.Drawing.Point(5, 40);
            this.listBoxCam.Name = "listBoxCam";
            this.listBoxCam.Size = new System.Drawing.Size(141, 134);
            this.listBoxCam.TabIndex = 5;
            // 
            // progressBarCam
            // 
            this.progressBarCam.Location = new System.Drawing.Point(6, 180);
            this.progressBarCam.Name = "progressBarCam";
            this.progressBarCam.Size = new System.Drawing.Size(140, 23);
            this.progressBarCam.TabIndex = 5;
            // 
            // bosaltCamButton
            // 
            this.bosaltCamButton.BackColor = System.Drawing.Color.LavenderBlush;
            this.bosaltCamButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bosaltCamButton.Location = new System.Drawing.Point(3, 209);
            this.bosaltCamButton.Name = "bosaltCamButton";
            this.bosaltCamButton.Size = new System.Drawing.Size(144, 25);
            this.bosaltCamButton.TabIndex = 3;
            this.bosaltCamButton.Text = "BOŞALT";
            this.bosaltCamButton.UseVisualStyleBackColor = false;
            // 
            // camButton
            // 
            this.camButton.BackColor = System.Drawing.Color.LavenderBlush;
            this.camButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.camButton.Location = new System.Drawing.Point(4, 3);
            this.camButton.Name = "camButton";
            this.camButton.Size = new System.Drawing.Size(144, 32);
            this.camButton.TabIndex = 2;
            this.camButton.Text = "CAM";
            this.camButton.UseVisualStyleBackColor = false;
            this.camButton.Click += new System.EventHandler(this.camButton_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel5.Controls.Add(this.listBoxKagit);
            this.panel5.Controls.Add(this.progressBarKagit);
            this.panel5.Controls.Add(this.bosaltKagitButton);
            this.panel5.Controls.Add(this.kagitButton);
            this.panel5.Location = new System.Drawing.Point(382, 39);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(153, 237);
            this.panel5.TabIndex = 3;
            // 
            // listBoxKagit
            // 
            this.listBoxKagit.BackColor = System.Drawing.SystemColors.Info;
            this.listBoxKagit.FormattingEnabled = true;
            this.listBoxKagit.Location = new System.Drawing.Point(7, 41);
            this.listBoxKagit.Name = "listBoxKagit";
            this.listBoxKagit.Size = new System.Drawing.Size(141, 134);
            this.listBoxKagit.TabIndex = 4;
            // 
            // progressBarKagit
            // 
            this.progressBarKagit.Location = new System.Drawing.Point(7, 181);
            this.progressBarKagit.Name = "progressBarKagit";
            this.progressBarKagit.Size = new System.Drawing.Size(140, 23);
            this.progressBarKagit.TabIndex = 4;
            // 
            // bosaltKagitButton
            // 
            this.bosaltKagitButton.BackColor = System.Drawing.Color.LavenderBlush;
            this.bosaltKagitButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bosaltKagitButton.Location = new System.Drawing.Point(6, 208);
            this.bosaltKagitButton.Name = "bosaltKagitButton";
            this.bosaltKagitButton.Size = new System.Drawing.Size(144, 26);
            this.bosaltKagitButton.TabIndex = 2;
            this.bosaltKagitButton.Text = "BOŞALT";
            this.bosaltKagitButton.UseVisualStyleBackColor = false;
            // 
            // kagitButton
            // 
            this.kagitButton.BackColor = System.Drawing.Color.LavenderBlush;
            this.kagitButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kagitButton.Location = new System.Drawing.Point(6, 3);
            this.kagitButton.Name = "kagitButton";
            this.kagitButton.Size = new System.Drawing.Size(144, 32);
            this.kagitButton.TabIndex = 1;
            this.kagitButton.Text = "KAĞIT";
            this.kagitButton.UseVisualStyleBackColor = false;
            this.kagitButton.Click += new System.EventHandler(this.kagitButton_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel6.Controls.Add(this.listBoxMetal);
            this.panel6.Controls.Add(this.progressBarMetal);
            this.panel6.Controls.Add(this.bosaltMetalButton);
            this.panel6.Controls.Add(this.metalButton);
            this.panel6.Location = new System.Drawing.Point(382, 282);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(153, 237);
            this.panel6.TabIndex = 3;
            // 
            // listBoxMetal
            // 
            this.listBoxMetal.BackColor = System.Drawing.SystemColors.Info;
            this.listBoxMetal.FormattingEnabled = true;
            this.listBoxMetal.Location = new System.Drawing.Point(6, 41);
            this.listBoxMetal.Name = "listBoxMetal";
            this.listBoxMetal.Size = new System.Drawing.Size(141, 134);
            this.listBoxMetal.TabIndex = 6;
            // 
            // progressBarMetal
            // 
            this.progressBarMetal.Location = new System.Drawing.Point(6, 180);
            this.progressBarMetal.Name = "progressBarMetal";
            this.progressBarMetal.Size = new System.Drawing.Size(140, 23);
            this.progressBarMetal.TabIndex = 6;
            // 
            // bosaltMetalButton
            // 
            this.bosaltMetalButton.BackColor = System.Drawing.Color.LavenderBlush;
            this.bosaltMetalButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bosaltMetalButton.Location = new System.Drawing.Point(3, 209);
            this.bosaltMetalButton.Name = "bosaltMetalButton";
            this.bosaltMetalButton.Size = new System.Drawing.Size(144, 25);
            this.bosaltMetalButton.TabIndex = 4;
            this.bosaltMetalButton.Text = "BOŞALT";
            this.bosaltMetalButton.UseVisualStyleBackColor = false;
            // 
            // metalButton
            // 
            this.metalButton.BackColor = System.Drawing.Color.LavenderBlush;
            this.metalButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.metalButton.Location = new System.Drawing.Point(3, 3);
            this.metalButton.Name = "metalButton";
            this.metalButton.Size = new System.Drawing.Size(144, 32);
            this.metalButton.TabIndex = 3;
            this.metalButton.Text = "METAL";
            this.metalButton.UseVisualStyleBackColor = false;
            this.metalButton.Click += new System.EventHandler(this.metalButton_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(223, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "ATIK KUTULARI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(548, 521);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ATIK UYGULAMASI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button organikAtikButton;
        private System.Windows.Forms.Button camButton;
        private System.Windows.Forms.Button kagitButton;
        private System.Windows.Forms.Button metalButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxOrganik;
        private System.Windows.Forms.ListBox listBoxCam;
        private System.Windows.Forms.ProgressBar progressBarCam;
        private System.Windows.Forms.Button bosaltCamButton;
        private System.Windows.Forms.ListBox listBoxKagit;
        private System.Windows.Forms.ProgressBar progressBarKagit;
        private System.Windows.Forms.Button bosaltKagitButton;
        private System.Windows.Forms.ListBox listBoxMetal;
        private System.Windows.Forms.ProgressBar progressBarMetal;
        private System.Windows.Forms.Button bosaltMetalButton;
        private System.Windows.Forms.Button cikisButton;
        private System.Windows.Forms.Button yeniOyunButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPuan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSaniye;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bosaltOrganikAtikButton;
        private System.Windows.Forms.ProgressBar progressBarOrganik;
        private System.Windows.Forms.Timer timer1;
    }
}

