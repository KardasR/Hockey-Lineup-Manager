
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TTC1tb = new System.Windows.Forms.TextBox();
            this.TTLD1tb = new System.Windows.Forms.TextBox();
            this.TTRD1tb = new System.Windows.Forms.TextBox();
            this.TTC2tb = new System.Windows.Forms.TextBox();
            this.TTLD2tb = new System.Windows.Forms.TextBox();
            this.TTRD2tb = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(240, 177);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(23, 13);
            this.label16.TabIndex = 88;
            this.label16.Text = "RD";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(41, 177);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 13);
            this.label13.TabIndex = 87;
            this.label13.Text = "LD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 86;
            this.label2.Text = "C";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 91;
            this.label1.Text = "RD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 90;
            this.label3.Text = "LD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 89;
            this.label4.Text = "C";
            // 
            // TTC1tb
            // 
            this.TTC1tb.AllowDrop = true;
            this.TTC1tb.Location = new System.Drawing.Point(150, 103);
            this.TTC1tb.Name = "TTC1tb";
            this.TTC1tb.Size = new System.Drawing.Size(100, 20);
            this.TTC1tb.TabIndex = 92;
            this.TTC1tb.DragDrop += new System.Windows.Forms.DragEventHandler(this.TTC1tb_DragDrop);
            this.TTC1tb.DragEnter += new System.Windows.Forms.DragEventHandler(this.CheckDataFormat);
            this.TTC1tb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TTC1tb_MouseDown);
            // 
            // TTLD1tb
            // 
            this.TTLD1tb.AllowDrop = true;
            this.TTLD1tb.Location = new System.Drawing.Point(68, 174);
            this.TTLD1tb.Name = "TTLD1tb";
            this.TTLD1tb.Size = new System.Drawing.Size(100, 20);
            this.TTLD1tb.TabIndex = 93;
            this.TTLD1tb.DragDrop += new System.Windows.Forms.DragEventHandler(this.TTLD1tb_DragDrop);
            this.TTLD1tb.DragEnter += new System.Windows.Forms.DragEventHandler(this.CheckDataFormat);
            this.TTLD1tb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TTLD1tb_MouseDown);
            // 
            // TTRD1tb
            // 
            this.TTRD1tb.AllowDrop = true;
            this.TTRD1tb.Location = new System.Drawing.Point(269, 174);
            this.TTRD1tb.Name = "TTRD1tb";
            this.TTRD1tb.Size = new System.Drawing.Size(100, 20);
            this.TTRD1tb.TabIndex = 94;
            this.TTRD1tb.DragDrop += new System.Windows.Forms.DragEventHandler(this.TTRD1tb_DragDrop);
            this.TTRD1tb.DragEnter += new System.Windows.Forms.DragEventHandler(this.CheckDataFormat);
            this.TTRD1tb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TTRD1tb_MouseDown);
            // 
            // TTC2tb
            // 
            this.TTC2tb.AllowDrop = true;
            this.TTC2tb.Location = new System.Drawing.Point(150, 266);
            this.TTC2tb.Name = "TTC2tb";
            this.TTC2tb.Size = new System.Drawing.Size(100, 20);
            this.TTC2tb.TabIndex = 95;
            this.TTC2tb.DragDrop += new System.Windows.Forms.DragEventHandler(this.TTC2tb_DragDrop);
            this.TTC2tb.DragEnter += new System.Windows.Forms.DragEventHandler(this.CheckDataFormat);
            this.TTC2tb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TTC2tb_MouseDown);
            // 
            // TTLD2tb
            // 
            this.TTLD2tb.AllowDrop = true;
            this.TTLD2tb.Location = new System.Drawing.Point(68, 331);
            this.TTLD2tb.Name = "TTLD2tb";
            this.TTLD2tb.Size = new System.Drawing.Size(100, 20);
            this.TTLD2tb.TabIndex = 96;
            this.TTLD2tb.DragDrop += new System.Windows.Forms.DragEventHandler(this.TTLD2tb_DragDrop);
            this.TTLD2tb.DragEnter += new System.Windows.Forms.DragEventHandler(this.CheckDataFormat);
            this.TTLD2tb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TTLD2tb_MouseDown);
            // 
            // TTRD2tb
            // 
            this.TTRD2tb.AllowDrop = true;
            this.TTRD2tb.Location = new System.Drawing.Point(269, 331);
            this.TTRD2tb.Name = "TTRD2tb";
            this.TTRD2tb.Size = new System.Drawing.Size(100, 20);
            this.TTRD2tb.TabIndex = 97;
            this.TTRD2tb.DragDrop += new System.Windows.Forms.DragEventHandler(this.TTRD2tb_DragDrop);
            this.TTRD2tb.DragEnter += new System.Windows.Forms.DragEventHandler(this.CheckDataFormat);
            this.TTRD2tb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TTRD2tb_MouseDown);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(137, 22);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(113, 37);
            this.label21.TabIndex = 98;
            this.label21.Text = "3 on 3";
            // 
            // TTform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 378);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.TTRD2tb);
            this.Controls.Add(this.TTLD2tb);
            this.Controls.Add(this.TTC2tb);
            this.Controls.Add(this.TTRD1tb);
            this.Controls.Add(this.TTLD1tb);
            this.Controls.Add(this.TTC1tb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label2);
            this.Name = "TTform";
            this.Text = "TTform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TTC1tb;
        private System.Windows.Forms.TextBox TTLD1tb;
        private System.Windows.Forms.TextBox TTRD1tb;
        private System.Windows.Forms.TextBox TTC2tb;
        private System.Windows.Forms.TextBox TTLD2tb;
        private System.Windows.Forms.TextBox TTRD2tb;
        private System.Windows.Forms.Label label21;
    }
}