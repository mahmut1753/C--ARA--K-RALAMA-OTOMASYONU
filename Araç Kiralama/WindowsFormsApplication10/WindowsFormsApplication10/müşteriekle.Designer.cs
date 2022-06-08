namespace WindowsFormsApplication10
{
    partial class müşteriekle
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(müşteriekle));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txttc = new System.Windows.Forms.TextBox();
            this.txtadsoy = new System.Windows.Forms.TextBox();
            this.txttel = new System.Windows.Forms.TextBox();
            this.txtadres = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboil = new System.Windows.Forms.ComboBox();
            this.comboilce = new System.Windows.Forms.ComboBox();
            this.txtehliyetyer = new System.Windows.Forms.TextBox();
            this.txtehliyetno = new System.Windows.Forms.TextBox();
            this.txtehliyettarih = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btnekle = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "müşeri2.jpg");
            this.ımageList1.Images.SetKeyName(1, "logout.png");
            this.ımageList1.Images.SetKeyName(2, "pink_line_png_1030365.png");
            // 
            // txttc
            // 
            this.txttc.Location = new System.Drawing.Point(217, 98);
            this.txttc.Name = "txttc";
            this.txttc.Size = new System.Drawing.Size(185, 20);
            this.txttc.TabIndex = 0;
            this.txttc.TextChanged += new System.EventHandler(this.txttc_TextChanged);
            this.txttc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttc_KeyPress);
            // 
            // txtadsoy
            // 
            this.txtadsoy.Location = new System.Drawing.Point(217, 142);
            this.txtadsoy.Name = "txtadsoy";
            this.txtadsoy.Size = new System.Drawing.Size(185, 20);
            this.txtadsoy.TabIndex = 1;
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(217, 186);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(185, 20);
            this.txttel.TabIndex = 2;
            // 
            // txtadres
            // 
            this.txtadres.Location = new System.Drawing.Point(217, 320);
            this.txtadres.Name = "txtadres";
            this.txtadres.Size = new System.Drawing.Size(185, 20);
            this.txtadres.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(143, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "TC NO:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(118, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ad Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(135, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Telefon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(148, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Adres:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(181, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "İl:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(166, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "İlçe:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(108, 451);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Ehliyet Yer:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(96, 407);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Ehliyet Tarih:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(114, 363);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "Ehliyet No:";
            // 
            // comboil
            // 
            this.comboil.FormattingEnabled = true;
            this.comboil.Location = new System.Drawing.Point(217, 230);
            this.comboil.Name = "comboil";
            this.comboil.Size = new System.Drawing.Size(185, 21);
            this.comboil.TabIndex = 17;
            this.comboil.SelectedIndexChanged += new System.EventHandler(this.comboil_SelectedIndexChanged);
            // 
            // comboilce
            // 
            this.comboilce.FormattingEnabled = true;
            this.comboilce.Location = new System.Drawing.Point(217, 275);
            this.comboilce.Name = "comboilce";
            this.comboilce.Size = new System.Drawing.Size(185, 21);
            this.comboilce.TabIndex = 18;
            // 
            // txtehliyetyer
            // 
            this.txtehliyetyer.Location = new System.Drawing.Point(217, 452);
            this.txtehliyetyer.Name = "txtehliyetyer";
            this.txtehliyetyer.Size = new System.Drawing.Size(185, 20);
            this.txtehliyetyer.TabIndex = 19;
            // 
            // txtehliyetno
            // 
            this.txtehliyetno.Location = new System.Drawing.Point(217, 364);
            this.txtehliyetno.Name = "txtehliyetno";
            this.txtehliyetno.Size = new System.Drawing.Size(185, 20);
            this.txtehliyetno.TabIndex = 21;
            // 
            // txtehliyettarih
            // 
            this.txtehliyettarih.Location = new System.Drawing.Point(217, 407);
            this.txtehliyettarih.Name = "txtehliyettarih";
            this.txtehliyettarih.Size = new System.Drawing.Size(185, 20);
            this.txtehliyettarih.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(0)))), ((int)(((byte)(127)))));
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(561, 20);
            this.panel1.TabIndex = 23;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ImageKey = "pink_line_png_1030365.png";
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(439, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 42);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button9
            // 
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.Location = new System.Drawing.Point(497, 28);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(52, 42);
            this.button9.TabIndex = 24;
            this.button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(0)))), ((int)(((byte)(127)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 566);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(561, 10);
            this.panel2.TabIndex = 0;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // btnekle
            // 
            this.btnekle.ActiveBorderThickness = 1;
            this.btnekle.ActiveCornerRadius = 20;
            this.btnekle.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(11)))), ((int)(((byte)(83)))));
            this.btnekle.ActiveForecolor = System.Drawing.Color.White;
            this.btnekle.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(11)))), ((int)(((byte)(83)))));
            this.btnekle.BackColor = System.Drawing.Color.White;
            this.btnekle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnekle.BackgroundImage")));
            this.btnekle.ButtonText = "Ekle";
            this.btnekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnekle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnekle.ForeColor = System.Drawing.Color.White;
            this.btnekle.IdleBorderThickness = 1;
            this.btnekle.IdleCornerRadius = 20;
            this.btnekle.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.btnekle.IdleForecolor = System.Drawing.Color.White;
            this.btnekle.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnekle.Location = new System.Drawing.Point(217, 489);
            this.btnekle.Margin = new System.Windows.Forms.Padding(5);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(185, 41);
            this.btnekle.TabIndex = 25;
            this.btnekle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(0)))), ((int)(((byte)(127)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 546);
            this.panel3.TabIndex = 26;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(0)))), ((int)(((byte)(127)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(559, 20);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2, 546);
            this.panel4.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(0)))), ((int)(((byte)(127)))));
            this.label5.Location = new System.Drawing.Point(12, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 25);
            this.label5.TabIndex = 28;
            this.label5.Text = "Müşteri Ekle...";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // müşteriekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(561, 576);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtehliyettarih);
            this.Controls.Add(this.txtehliyetno);
            this.Controls.Add(this.txtehliyetyer);
            this.Controls.Add(this.comboilce);
            this.Controls.Add(this.comboil);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtadres);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.txtadsoy);
            this.Controls.Add(this.txttc);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "müşteriekle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Müşteri Ekle";
            this.Load += new System.EventHandler(this.müşteriekle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.TextBox txttc;
        private System.Windows.Forms.TextBox txtadsoy;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.TextBox txtadres;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboil;
        private System.Windows.Forms.ComboBox comboilce;
        private System.Windows.Forms.TextBox txtehliyetyer;
        private System.Windows.Forms.TextBox txtehliyetno;
        private System.Windows.Forms.DateTimePicker txtehliyettarih;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnekle;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
    }
}