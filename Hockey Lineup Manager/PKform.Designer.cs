
namespace Hockey_Lineup_Manager
{
    partial class PKform
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
            this.label21 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PKLW1tb = new System.Windows.Forms.TextBox();
            this.PKC1tb = new System.Windows.Forms.TextBox();
            this.PKLD1tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PKRD1tb = new System.Windows.Forms.TextBox();
            this.PKLW2tb = new System.Windows.Forms.TextBox();
            this.PKC2tb = new System.Windows.Forms.TextBox();
            this.PKLD2tb = new System.Windows.Forms.TextBox();
            this.PKRD2tb = new System.Windows.Forms.TextBox();
            this.LoadLinesbtn = new System.Windows.Forms.Button();
            this.SaveLinesbtn = new System.Windows.Forms.Button();
            this.TPRD2tb = new System.Windows.Forms.TextBox();
            this.TPLD2tb = new System.Windows.Forms.TextBox();
            this.TPC2tb = new System.Windows.Forms.TextBox();
            this.TPRD1tb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TPLD1tb = new System.Windows.Forms.TextBox();
            this.TPC1tb = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(83, 23);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(185, 37);
            this.label21.TabIndex = 51;
            this.label21.Text = "Penalty Kill";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(212, 166);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(23, 13);
            this.label16.TabIndex = 69;
            this.label16.Text = "RD";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 166);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 13);
            this.label13.TabIndex = 68;
            this.label13.Text = "LD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 66;
            this.label2.Text = "C";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 65;
            this.label1.Text = "LW";
            // 
            // PKLW1tb
            // 
            this.PKLW1tb.AllowDrop = true;
            this.PKLW1tb.Location = new System.Drawing.Point(241, 95);
            this.PKLW1tb.Name = "PKLW1tb";
            this.PKLW1tb.Size = new System.Drawing.Size(100, 20);
            this.PKLW1tb.TabIndex = 2;
            this.PKLW1tb.DragDrop += new System.Windows.Forms.DragEventHandler(this.PKLW1tb_DragDrop);
            this.PKLW1tb.DragEnter += new System.Windows.Forms.DragEventHandler(this.CheckDataFormat);
            this.PKLW1tb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PKLW1tb_MouseDown);
            // 
            // PKC1tb
            // 
            this.PKC1tb.AllowDrop = true;
            this.PKC1tb.Location = new System.Drawing.Point(40, 95);
            this.PKC1tb.Name = "PKC1tb";
            this.PKC1tb.Size = new System.Drawing.Size(100, 20);
            this.PKC1tb.TabIndex = 1;
            this.PKC1tb.DragDrop += new System.Windows.Forms.DragEventHandler(this.PKC1tb_DragDrop);
            this.PKC1tb.DragEnter += new System.Windows.Forms.DragEventHandler(this.CheckDataFormat);
            this.PKC1tb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PKC1tb_MouseDown);
            // 
            // PKLD1tb
            // 
            this.PKLD1tb.AllowDrop = true;
            this.PKLD1tb.Location = new System.Drawing.Point(40, 163);
            this.PKLD1tb.Name = "PKLD1tb";
            this.PKLD1tb.Size = new System.Drawing.Size(100, 20);
            this.PKLD1tb.TabIndex = 3;
            this.PKLD1tb.DragDrop += new System.Windows.Forms.DragEventHandler(this.PKLD1tb_DragDrop);
            this.PKLD1tb.DragEnter += new System.Windows.Forms.DragEventHandler(this.CheckDataFormat);
            this.PKLD1tb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PKLD1tb_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 81;
            this.label3.Text = "RD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 80;
            this.label4.Text = "LD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 79;
            this.label5.Text = "C";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(211, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 78;
            this.label6.Text = "LW";
            // 
            // PKRD1tb
            // 
            this.PKRD1tb.AllowDrop = true;
            this.PKRD1tb.Location = new System.Drawing.Point(241, 163);
            this.PKRD1tb.Name = "PKRD1tb";
            this.PKRD1tb.Size = new System.Drawing.Size(100, 20);
            this.PKRD1tb.TabIndex = 4;
            this.PKRD1tb.DragDrop += new System.Windows.Forms.DragEventHandler(this.PKRD1tb_DragDrop);
            this.PKRD1tb.DragEnter += new System.Windows.Forms.DragEventHandler(this.CheckDataFormat);
            this.PKRD1tb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PKRD1tb_MouseDown);
            // 
            // PKLW2tb
            // 
            this.PKLW2tb.AllowDrop = true;
            this.PKLW2tb.Location = new System.Drawing.Point(241, 252);
            this.PKLW2tb.Name = "PKLW2tb";
            this.PKLW2tb.Size = new System.Drawing.Size(100, 20);
            this.PKLW2tb.TabIndex = 6;
            this.PKLW2tb.DragDrop += new System.Windows.Forms.DragEventHandler(this.PKLW2tb_DragDrop);
            this.PKLW2tb.DragEnter += new System.Windows.Forms.DragEventHandler(this.CheckDataFormat);
            this.PKLW2tb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PKLW2tb_MouseDown);
            // 
            // PKC2tb
            // 
            this.PKC2tb.AllowDrop = true;
            this.PKC2tb.Location = new System.Drawing.Point(40, 252);
            this.PKC2tb.Name = "PKC2tb";
            this.PKC2tb.Size = new System.Drawing.Size(100, 20);
            this.PKC2tb.TabIndex = 5;
            this.PKC2tb.DragDrop += new System.Windows.Forms.DragEventHandler(this.PKC2tb_DragDrop);
            this.PKC2tb.DragEnter += new System.Windows.Forms.DragEventHandler(this.CheckDataFormat);
            this.PKC2tb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PKC2tb_MouseDown);
            // 
            // PKLD2tb
            // 
            this.PKLD2tb.AllowDrop = true;
            this.PKLD2tb.Location = new System.Drawing.Point(40, 320);
            this.PKLD2tb.Name = "PKLD2tb";
            this.PKLD2tb.Size = new System.Drawing.Size(100, 20);
            this.PKLD2tb.TabIndex = 7;
            this.PKLD2tb.DragDrop += new System.Windows.Forms.DragEventHandler(this.PKLD2tb_DragDrop);
            this.PKLD2tb.DragEnter += new System.Windows.Forms.DragEventHandler(this.CheckDataFormat);
            this.PKLD2tb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PKLD2tb_MouseDown);
            // 
            // PKRD2tb
            // 
            this.PKRD2tb.AllowDrop = true;
            this.PKRD2tb.Location = new System.Drawing.Point(241, 320);
            this.PKRD2tb.Name = "PKRD2tb";
            this.PKRD2tb.Size = new System.Drawing.Size(100, 20);
            this.PKRD2tb.TabIndex = 8;
            this.PKRD2tb.DragDrop += new System.Windows.Forms.DragEventHandler(this.PKRD2tb_DragDrop);
            this.PKRD2tb.DragEnter += new System.Windows.Forms.DragEventHandler(this.CheckDataFormat);
            this.PKRD2tb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PKRD2tb_MouseDown);
            // 
            // LoadLinesbtn
            // 
            this.LoadLinesbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadLinesbtn.Location = new System.Drawing.Point(35, 392);
            this.LoadLinesbtn.Name = "LoadLinesbtn";
            this.LoadLinesbtn.Size = new System.Drawing.Size(121, 44);
            this.LoadLinesbtn.TabIndex = 15;
            this.LoadLinesbtn.Text = "Load Lines";
            this.LoadLinesbtn.UseVisualStyleBackColor = true;
            this.LoadLinesbtn.Click += new System.EventHandler(this.LoadLinesbtn_Click);
            // 
            // SaveLinesbtn
            // 
            this.SaveLinesbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveLinesbtn.Location = new System.Drawing.Point(215, 392);
            this.SaveLinesbtn.Name = "SaveLinesbtn";
            this.SaveLinesbtn.Size = new System.Drawing.Size(121, 44);
            this.SaveLinesbtn.TabIndex = 16;
            this.SaveLinesbtn.Text = "Save Lines";
            this.SaveLinesbtn.UseVisualStyleBackColor = true;
            this.SaveLinesbtn.Click += new System.EventHandler(this.SaveLinesbtn_Click);
            // 
            // TPRD2tb
            // 
            this.TPRD2tb.AllowDrop = true;
            this.TPRD2tb.Location = new System.Drawing.Point(241, 705);
            this.TPRD2tb.Name = "TPRD2tb";
            this.TPRD2tb.Size = new System.Drawing.Size(100, 20);
            this.TPRD2tb.TabIndex = 14;
            this.TPRD2tb.DragDrop += new System.Windows.Forms.DragEventHandler(this.TPRD2tb_DragDrop);
            this.TPRD2tb.DragEnter += new System.Windows.Forms.DragEventHandler(this.CheckDataFormat);
            this.TPRD2tb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TPRD2tb_MouseDown);
            // 
            // TPLD2tb
            // 
            this.TPLD2tb.AllowDrop = true;
            this.TPLD2tb.Location = new System.Drawing.Point(40, 705);
            this.TPLD2tb.Name = "TPLD2tb";
            this.TPLD2tb.Size = new System.Drawing.Size(100, 20);
            this.TPLD2tb.TabIndex = 13;
            this.TPLD2tb.DragDrop += new System.Windows.Forms.DragEventHandler(this.TPLD2tb_DragDrop);
            this.TPLD2tb.DragEnter += new System.Windows.Forms.DragEventHandler(this.CheckDataFormat);
            this.TPLD2tb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TPLD2tb_MouseDown);
            // 
            // TPC2tb
            // 
            this.TPC2tb.AllowDrop = true;
            this.TPC2tb.Location = new System.Drawing.Point(135, 637);
            this.TPC2tb.Name = "TPC2tb";
            this.TPC2tb.Size = new System.Drawing.Size(100, 20);
            this.TPC2tb.TabIndex = 12;
            this.TPC2tb.DragDrop += new System.Windows.Forms.DragEventHandler(this.TPC2tb_DragDrop);
            this.TPC2tb.DragEnter += new System.Windows.Forms.DragEventHandler(this.CheckDataFormat);
            this.TPC2tb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TPC2tb_MouseDown);
            // 
            // TPRD1tb
            // 
            this.TPRD1tb.AllowDrop = true;
            this.TPRD1tb.Location = new System.Drawing.Point(241, 558);
            this.TPRD1tb.Name = "TPRD1tb";
            this.TPRD1tb.Size = new System.Drawing.Size(100, 20);
            this.TPRD1tb.TabIndex = 11;
            this.TPRD1tb.DragDrop += new System.Windows.Forms.DragEventHandler(this.TPRD1tb_DragDrop);
            this.TPRD1tb.DragEnter += new System.Windows.Forms.DragEventHandler(this.CheckDataFormat);
            this.TPRD1tb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TPRD1tb_MouseDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(212, 708);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 99;
            this.label7.Text = "RD";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 708);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 98;
            this.label8.Text = "LD";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(115, 640);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 97;
            this.label9.Text = "C";
            // 
            // TPLD1tb
            // 
            this.TPLD1tb.AllowDrop = true;
            this.TPLD1tb.Location = new System.Drawing.Point(40, 558);
            this.TPLD1tb.Name = "TPLD1tb";
            this.TPLD1tb.Size = new System.Drawing.Size(100, 20);
            this.TPLD1tb.TabIndex = 10;
            this.TPLD1tb.DragDrop += new System.Windows.Forms.DragEventHandler(this.TPLD1tb_DragDrop);
            this.TPLD1tb.DragEnter += new System.Windows.Forms.DragEventHandler(this.CheckDataFormat);
            this.TPLD1tb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TPLD1tb_MouseDown);
            // 
            // TPC1tb
            // 
            this.TPC1tb.AllowDrop = true;
            this.TPC1tb.Location = new System.Drawing.Point(135, 492);
            this.TPC1tb.Name = "TPC1tb";
            this.TPC1tb.Size = new System.Drawing.Size(100, 20);
            this.TPC1tb.TabIndex = 9;
            this.TPC1tb.DragDrop += new System.Windows.Forms.DragEventHandler(this.TPC1tb_DragDrop);
            this.TPC1tb.DragEnter += new System.Windows.Forms.DragEventHandler(this.CheckDataFormat);
            this.TPC1tb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TPC1tb_MouseDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(212, 561);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 13);
            this.label11.TabIndex = 92;
            this.label11.Text = "RD";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 561);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 13);
            this.label12.TabIndex = 91;
            this.label12.Text = "LD";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(115, 495);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(14, 13);
            this.label14.TabIndex = 90;
            this.label14.Text = "C";
            // 
            // PKform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 746);
            this.Controls.Add(this.TPRD2tb);
            this.Controls.Add(this.TPLD2tb);
            this.Controls.Add(this.TPC2tb);
            this.Controls.Add(this.TPRD1tb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TPLD1tb);
            this.Controls.Add(this.TPC1tb);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.SaveLinesbtn);
            this.Controls.Add(this.LoadLinesbtn);
            this.Controls.Add(this.PKRD2tb);
            this.Controls.Add(this.PKLD2tb);
            this.Controls.Add(this.PKC2tb);
            this.Controls.Add(this.PKLW2tb);
            this.Controls.Add(this.PKRD1tb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PKLD1tb);
            this.Controls.Add(this.PKC1tb);
            this.Controls.Add(this.PKLW1tb);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label21);
            this.MaximumSize = new System.Drawing.Size(380, 790);
            this.MinimumSize = new System.Drawing.Size(375, 780);
            this.Name = "PKform";
            this.Text = "PKform";
            this.Load += new System.EventHandler(this.PKform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PKLW1tb;
        private System.Windows.Forms.TextBox PKC1tb;
        private System.Windows.Forms.TextBox PKLD1tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PKRD1tb;
        private System.Windows.Forms.TextBox PKLW2tb;
        private System.Windows.Forms.TextBox PKC2tb;
        private System.Windows.Forms.TextBox PKLD2tb;
        private System.Windows.Forms.TextBox PKRD2tb;
        private System.Windows.Forms.Button LoadLinesbtn;
        private System.Windows.Forms.Button SaveLinesbtn;
        private System.Windows.Forms.TextBox TPRD2tb;
        private System.Windows.Forms.TextBox TPLD2tb;
        private System.Windows.Forms.TextBox TPC2tb;
        private System.Windows.Forms.TextBox TPRD1tb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TPLD1tb;
        private System.Windows.Forms.TextBox TPC1tb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
    }
}