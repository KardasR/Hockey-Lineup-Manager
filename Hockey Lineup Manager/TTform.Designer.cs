
namespace Hockey_Lineup_Manager
{
    partial class TTform
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
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TTC1tb = new System.Windows.Forms.TextBox();
            this.TTW1tb = new System.Windows.Forms.TextBox();
            this.TTD1tb = new System.Windows.Forms.TextBox();
            this.TTC2tb = new System.Windows.Forms.TextBox();
            this.TTW2tb = new System.Windows.Forms.TextBox();
            this.TTD2tb = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.LoadLinesbtn = new System.Windows.Forms.Button();
            this.SaveLinesbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TTD3tb = new System.Windows.Forms.TextBox();
            this.TTW3tb = new System.Windows.Forms.TextBox();
            this.TTC3tb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ClearLinesbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(96, 184);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(15, 13);
            this.label16.TabIndex = 88;
            this.label16.Text = "D";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(197, 107);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 13);
            this.label13.TabIndex = 87;
            this.label13.Text = "W";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 86;
            this.label2.Text = "C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 89;
            this.label4.Text = "C";
            // 
            // TTC1tb
            // 
            this.TTC1tb.AllowDrop = true;
            this.TTC1tb.Location = new System.Drawing.Point(35, 104);
            this.TTC1tb.Name = "TTC1tb";
            this.TTC1tb.Size = new System.Drawing.Size(100, 20);
            this.TTC1tb.TabIndex = 2;
            this.TTC1tb.DragDrop += new System.Windows.Forms.DragEventHandler(this.TTC1tb_DragDrop);
            this.TTC1tb.DragEnter += new System.Windows.Forms.DragEventHandler(this.CheckDataFormat);
            this.TTC1tb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TTC1tb_MouseDown);
            // 
            // TTW1tb
            // 
            this.TTW1tb.AllowDrop = true;
            this.TTW1tb.Location = new System.Drawing.Point(221, 104);
            this.TTW1tb.Name = "TTW1tb";
            this.TTW1tb.Size = new System.Drawing.Size(100, 20);
            this.TTW1tb.TabIndex = 1;
            this.TTW1tb.DragDrop += new System.Windows.Forms.DragEventHandler(this.TTLD1tb_DragDrop);
            this.TTW1tb.DragEnter += new System.Windows.Forms.DragEventHandler(this.CheckDataFormat);
            this.TTW1tb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TTLD1tb_MouseDown);
            // 
            // TTD1tb
            // 
            this.TTD1tb.AllowDrop = true;
            this.TTD1tb.Location = new System.Drawing.Point(117, 181);
            this.TTD1tb.Name = "TTD1tb";
            this.TTD1tb.Size = new System.Drawing.Size(100, 20);
            this.TTD1tb.TabIndex = 3;
            this.TTD1tb.DragDrop += new System.Windows.Forms.DragEventHandler(this.TTRD1tb_DragDrop);
            this.TTD1tb.DragEnter += new System.Windows.Forms.DragEventHandler(this.CheckDataFormat);
            this.TTD1tb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TTRD1tb_MouseDown);
            // 
            // TTC2tb
            // 
            this.TTC2tb.AllowDrop = true;
            this.TTC2tb.Location = new System.Drawing.Point(35, 325);
            this.TTC2tb.Name = "TTC2tb";
            this.TTC2tb.Size = new System.Drawing.Size(100, 20);
            this.TTC2tb.TabIndex = 5;
            this.TTC2tb.DragDrop += new System.Windows.Forms.DragEventHandler(this.TTC2tb_DragDrop);
            this.TTC2tb.DragEnter += new System.Windows.Forms.DragEventHandler(this.CheckDataFormat);
            this.TTC2tb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TTC2tb_MouseDown);
            // 
            // TTW2tb
            // 
            this.TTW2tb.AllowDrop = true;
            this.TTW2tb.Location = new System.Drawing.Point(221, 325);
            this.TTW2tb.Name = "TTW2tb";
            this.TTW2tb.Size = new System.Drawing.Size(100, 20);
            this.TTW2tb.TabIndex = 4;
            this.TTW2tb.DragDrop += new System.Windows.Forms.DragEventHandler(this.TTLD2tb_DragDrop);
            this.TTW2tb.DragEnter += new System.Windows.Forms.DragEventHandler(this.CheckDataFormat);
            this.TTW2tb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TTLD2tb_MouseDown);
            // 
            // TTD2tb
            // 
            this.TTD2tb.AllowDrop = true;
            this.TTD2tb.Location = new System.Drawing.Point(117, 402);
            this.TTD2tb.Name = "TTD2tb";
            this.TTD2tb.Size = new System.Drawing.Size(100, 20);
            this.TTD2tb.TabIndex = 6;
            this.TTD2tb.DragDrop += new System.Windows.Forms.DragEventHandler(this.TTRD2tb_DragDrop);
            this.TTD2tb.DragEnter += new System.Windows.Forms.DragEventHandler(this.CheckDataFormat);
            this.TTD2tb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TTRD2tb_MouseDown);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(119, 32);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(113, 37);
            this.label21.TabIndex = 98;
            this.label21.Text = "3 on 3";
            // 
            // LoadLinesbtn
            // 
            this.LoadLinesbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadLinesbtn.Location = new System.Drawing.Point(35, 243);
            this.LoadLinesbtn.Name = "LoadLinesbtn";
            this.LoadLinesbtn.Size = new System.Drawing.Size(123, 41);
            this.LoadLinesbtn.TabIndex = 10;
            this.LoadLinesbtn.Text = "Load Lines";
            this.LoadLinesbtn.UseVisualStyleBackColor = true;
            this.LoadLinesbtn.Click += new System.EventHandler(this.LoadLinesbtn_Click);
            // 
            // SaveLinesbtn
            // 
            this.SaveLinesbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveLinesbtn.Location = new System.Drawing.Point(100, 466);
            this.SaveLinesbtn.Name = "SaveLinesbtn";
            this.SaveLinesbtn.Size = new System.Drawing.Size(123, 41);
            this.SaveLinesbtn.TabIndex = 11;
            this.SaveLinesbtn.Text = "Save Lines";
            this.SaveLinesbtn.UseVisualStyleBackColor = true;
            this.SaveLinesbtn.Click += new System.EventHandler(this.SaveLinesbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 101;
            this.label1.Text = "D";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 102;
            this.label3.Text = "W";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(197, 552);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 108;
            this.label5.Text = "W";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(96, 629);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 107;
            this.label6.Text = "D";
            // 
            // TTD3tb
            // 
            this.TTD3tb.AllowDrop = true;
            this.TTD3tb.Location = new System.Drawing.Point(117, 626);
            this.TTD3tb.Name = "TTD3tb";
            this.TTD3tb.Size = new System.Drawing.Size(100, 20);
            this.TTD3tb.TabIndex = 9;
            this.TTD3tb.DragDrop += new System.Windows.Forms.DragEventHandler(this.TTRD3tb_DragDrop);
            this.TTD3tb.DragEnter += new System.Windows.Forms.DragEventHandler(this.CheckDataFormat);
            this.TTD3tb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TTRD3tb_MouseDown);
            // 
            // TTW3tb
            // 
            this.TTW3tb.AllowDrop = true;
            this.TTW3tb.Location = new System.Drawing.Point(221, 549);
            this.TTW3tb.Name = "TTW3tb";
            this.TTW3tb.Size = new System.Drawing.Size(100, 20);
            this.TTW3tb.TabIndex = 7;
            this.TTW3tb.DragDrop += new System.Windows.Forms.DragEventHandler(this.TTLD3tb_DragDrop);
            this.TTW3tb.DragEnter += new System.Windows.Forms.DragEventHandler(this.CheckDataFormat);
            this.TTW3tb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TTLD3tb_MouseDown);
            // 
            // TTC3tb
            // 
            this.TTC3tb.AllowDrop = true;
            this.TTC3tb.Location = new System.Drawing.Point(35, 549);
            this.TTC3tb.Name = "TTC3tb";
            this.TTC3tb.Size = new System.Drawing.Size(100, 20);
            this.TTC3tb.TabIndex = 8;
            this.TTC3tb.DragDrop += new System.Windows.Forms.DragEventHandler(this.TTC3tb_DragDrop);
            this.TTC3tb.DragEnter += new System.Windows.Forms.DragEventHandler(this.CheckDataFormat);
            this.TTC3tb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TTC3tb_MouseDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 552);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 103;
            this.label7.Text = "C";
            // 
            // ClearLinesbtn
            // 
            this.ClearLinesbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearLinesbtn.Location = new System.Drawing.Point(198, 244);
            this.ClearLinesbtn.Name = "ClearLinesbtn";
            this.ClearLinesbtn.Size = new System.Drawing.Size(123, 41);
            this.ClearLinesbtn.TabIndex = 109;
            this.ClearLinesbtn.Text = "Clear Lines";
            this.ClearLinesbtn.UseVisualStyleBackColor = true;
            this.ClearLinesbtn.Click += new System.EventHandler(this.ClearLinesbtn_Click);
            // 
            // TTform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(339, 660);
            this.Controls.Add(this.ClearLinesbtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TTD3tb);
            this.Controls.Add(this.TTW3tb);
            this.Controls.Add(this.TTC3tb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveLinesbtn);
            this.Controls.Add(this.LoadLinesbtn);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.TTD2tb);
            this.Controls.Add(this.TTW2tb);
            this.Controls.Add(this.TTC2tb);
            this.Controls.Add(this.TTD1tb);
            this.Controls.Add(this.TTW1tb);
            this.Controls.Add(this.TTC1tb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label2);
            this.MaximumSize = new System.Drawing.Size(360, 700);
            this.MinimumSize = new System.Drawing.Size(350, 695);
            this.Name = "TTform";
            this.Text = "TTform";
            this.Load += new System.EventHandler(this.TTform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TTC1tb;
        private System.Windows.Forms.TextBox TTW1tb;
        private System.Windows.Forms.TextBox TTD1tb;
        private System.Windows.Forms.TextBox TTC2tb;
        private System.Windows.Forms.TextBox TTW2tb;
        private System.Windows.Forms.TextBox TTD2tb;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button LoadLinesbtn;
        private System.Windows.Forms.Button SaveLinesbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TTD3tb;
        private System.Windows.Forms.TextBox TTW3tb;
        private System.Windows.Forms.TextBox TTC3tb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ClearLinesbtn;
    }
}