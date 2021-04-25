
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
            this.SuspendLayout();
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(108, 33);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(185, 37);
            this.label21.TabIndex = 51;
            this.label21.Text = "Penalty Kill";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(237, 190);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(23, 13);
            this.label16.TabIndex = 69;
            this.label16.Text = "RD";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(38, 190);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 13);
            this.label13.TabIndex = 68;
            this.label13.Text = "LD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 66;
            this.label2.Text = "C";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 65;
            this.label1.Text = "LW";
            // 
            // PKLW1tb
            // 
            this.PKLW1tb.AllowDrop = true;
            this.PKLW1tb.Location = new System.Drawing.Point(65, 119);
            this.PKLW1tb.Name = "PKLW1tb";
            this.PKLW1tb.Size = new System.Drawing.Size(100, 20);
            this.PKLW1tb.TabIndex = 75;
            this.PKLW1tb.DragDrop += new System.Windows.Forms.DragEventHandler(this.PKLW1tb_DragDrop);
            this.PKLW1tb.DragEnter += new System.Windows.Forms.DragEventHandler(this.CheckDataFormat);
            this.PKLW1tb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PKLW1tb_MouseDown);
            // 
            // PKC1tb
            // 
            this.PKC1tb.AllowDrop = true;
            this.PKC1tb.Location = new System.Drawing.Point(266, 119);
            this.PKC1tb.Name = "PKC1tb";
            this.PKC1tb.Size = new System.Drawing.Size(100, 20);
            this.PKC1tb.TabIndex = 76;
            this.PKC1tb.DragDrop += new System.Windows.Forms.DragEventHandler(this.PKC1tb_DragDrop);
            this.PKC1tb.DragEnter += new System.Windows.Forms.DragEventHandler(this.CheckDataFormat);
            this.PKC1tb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PKC1tb_MouseDown);
            // 
            // PKLD1tb
            // 
            this.PKLD1tb.AllowDrop = true;
            this.PKLD1tb.Location = new System.Drawing.Point(65, 187);
            this.PKLD1tb.Name = "PKLD1tb";
            this.PKLD1tb.Size = new System.Drawing.Size(100, 20);
            this.PKLD1tb.TabIndex = 77;
            this.PKLD1tb.DragDrop += new System.Windows.Forms.DragEventHandler(this.PKLD1tb_DragDrop);
            this.PKLD1tb.DragEnter += new System.Windows.Forms.DragEventHandler(this.CheckDataFormat);
            this.PKLD1tb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PKLD1tb_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 81;
            this.label3.Text = "RD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 80;
            this.label4.Text = "LD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(246, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 79;
            this.label5.Text = "C";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 78;
            this.label6.Text = "LW";
            // 
            // PKRD1tb
            // 
            this.PKRD1tb.AllowDrop = true;
            this.PKRD1tb.Location = new System.Drawing.Point(266, 187);
            this.PKRD1tb.Name = "PKRD1tb";
            this.PKRD1tb.Size = new System.Drawing.Size(100, 20);
            this.PKRD1tb.TabIndex = 82;
            this.PKRD1tb.DragDrop += new System.Windows.Forms.DragEventHandler(this.PKRD1tb_DragDrop);
            this.PKRD1tb.DragEnter += new System.Windows.Forms.DragEventHandler(this.CheckDataFormat);
            this.PKRD1tb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PKRD1tb_MouseDown);
            // 
            // PKLW2tb
            // 
            this.PKLW2tb.AllowDrop = true;
            this.PKLW2tb.Location = new System.Drawing.Point(65, 262);
            this.PKLW2tb.Name = "PKLW2tb";
            this.PKLW2tb.Size = new System.Drawing.Size(100, 20);
            this.PKLW2tb.TabIndex = 83;
            this.PKLW2tb.DragDrop += new System.Windows.Forms.DragEventHandler(this.PKLW2tb_DragDrop);
            this.PKLW2tb.DragEnter += new System.Windows.Forms.DragEventHandler(this.CheckDataFormat);
            this.PKLW2tb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PKLW2tb_MouseDown);
            // 
            // PKC2tb
            // 
            this.PKC2tb.AllowDrop = true;
            this.PKC2tb.Location = new System.Drawing.Point(266, 259);
            this.PKC2tb.Name = "PKC2tb";
            this.PKC2tb.Size = new System.Drawing.Size(100, 20);
            this.PKC2tb.TabIndex = 84;
            this.PKC2tb.DragDrop += new System.Windows.Forms.DragEventHandler(this.PKC2tb_DragDrop);
            this.PKC2tb.DragEnter += new System.Windows.Forms.DragEventHandler(this.CheckDataFormat);
            this.PKC2tb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PKC2tb_MouseDown);
            // 
            // PKLD2tb
            // 
            this.PKLD2tb.AllowDrop = true;
            this.PKLD2tb.Location = new System.Drawing.Point(65, 327);
            this.PKLD2tb.Name = "PKLD2tb";
            this.PKLD2tb.Size = new System.Drawing.Size(100, 20);
            this.PKLD2tb.TabIndex = 85;
            this.PKLD2tb.DragDrop += new System.Windows.Forms.DragEventHandler(this.PKLD2tb_DragDrop);
            this.PKLD2tb.DragEnter += new System.Windows.Forms.DragEventHandler(this.CheckDataFormat);
            this.PKLD2tb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PKLD2tb_MouseDown);
            // 
            // PKRD2tb
            // 
            this.PKRD2tb.AllowDrop = true;
            this.PKRD2tb.Location = new System.Drawing.Point(266, 327);
            this.PKRD2tb.Name = "PKRD2tb";
            this.PKRD2tb.Size = new System.Drawing.Size(100, 20);
            this.PKRD2tb.TabIndex = 86;
            this.PKRD2tb.DragDrop += new System.Windows.Forms.DragEventHandler(this.PKRD2tb_DragDrop);
            this.PKRD2tb.DragEnter += new System.Windows.Forms.DragEventHandler(this.CheckDataFormat);
            this.PKRD2tb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PKRD2tb_MouseDown);
            // 
            // PKform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 370);
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
            this.Name = "PKform";
            this.Text = "PKform";
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
    }
}