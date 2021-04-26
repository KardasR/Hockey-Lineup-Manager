
namespace Hockey_Lineup_Manager
{
    partial class SOEAform
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EA1tb = new System.Windows.Forms.TextBox();
            this.EA2tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SO1tb = new System.Windows.Forms.TextBox();
            this.SO2tb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SO3tb = new System.Windows.Forms.TextBox();
            this.SO4tb = new System.Windows.Forms.TextBox();
            this.SO5tb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(185, 32);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(249, 37);
            this.label21.TabIndex = 99;
            this.label21.Text = "Extra Attackers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 37);
            this.label1.TabIndex = 100;
            this.label1.Text = "Shootout";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 101;
            this.label2.Text = "EA 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(393, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 102;
            this.label3.Text = "EA 2";
            // 
            // EA1tb
            // 
            this.EA1tb.AllowDrop = true;
            this.EA1tb.Location = new System.Drawing.Point(92, 103);
            this.EA1tb.Name = "EA1tb";
            this.EA1tb.Size = new System.Drawing.Size(100, 20);
            this.EA1tb.TabIndex = 103;
            this.EA1tb.DragDrop += new System.Windows.Forms.DragEventHandler(this.EA1tb_DragDrop);
            this.EA1tb.DragEnter += new System.Windows.Forms.DragEventHandler(this.CheckDataFormat);
            this.EA1tb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EA1tb_MouseDown);
            // 
            // EA2tb
            // 
            this.EA2tb.AllowDrop = true;
            this.EA2tb.Location = new System.Drawing.Point(429, 103);
            this.EA2tb.Name = "EA2tb";
            this.EA2tb.Size = new System.Drawing.Size(100, 20);
            this.EA2tb.TabIndex = 104;
            this.EA2tb.DragDrop += new System.Windows.Forms.DragEventHandler(this.EA2tb_DragDrop);
            this.EA2tb.DragEnter += new System.Windows.Forms.DragEventHandler(this.CheckDataFormat);
            this.EA2tb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EA2tb_MouseDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 105;
            this.label4.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(257, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 106;
            this.label5.Text = "2";
            // 
            // SO1tb
            // 
            this.SO1tb.AllowDrop = true;
            this.SO1tb.Location = new System.Drawing.Point(46, 223);
            this.SO1tb.Name = "SO1tb";
            this.SO1tb.Size = new System.Drawing.Size(100, 20);
            this.SO1tb.TabIndex = 107;
            this.SO1tb.DragDrop += new System.Windows.Forms.DragEventHandler(this.SO1tb_DragDrop);
            this.SO1tb.DragEnter += new System.Windows.Forms.DragEventHandler(this.CheckDataFormat);
            this.SO1tb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SO1tb_MouseDown);
            // 
            // SO2tb
            // 
            this.SO2tb.AllowDrop = true;
            this.SO2tb.Location = new System.Drawing.Point(276, 223);
            this.SO2tb.Name = "SO2tb";
            this.SO2tb.Size = new System.Drawing.Size(100, 20);
            this.SO2tb.TabIndex = 108;
            this.SO2tb.DragDrop += new System.Windows.Forms.DragEventHandler(this.SO2tb_DragDrop);
            this.SO2tb.DragEnter += new System.Windows.Forms.DragEventHandler(this.CheckDataFormat);
            this.SO2tb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SO2tb_MouseDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(487, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 109;
            this.label6.Text = "3";
            // 
            // SO3tb
            // 
            this.SO3tb.AllowDrop = true;
            this.SO3tb.Location = new System.Drawing.Point(506, 223);
            this.SO3tb.Name = "SO3tb";
            this.SO3tb.Size = new System.Drawing.Size(100, 20);
            this.SO3tb.TabIndex = 110;
            this.SO3tb.DragDrop += new System.Windows.Forms.DragEventHandler(this.SO3tb_DragDrop);
            this.SO3tb.DragEnter += new System.Windows.Forms.DragEventHandler(this.CheckDataFormat);
            this.SO3tb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SO3tb_MouseDown);
            // 
            // SO4tb
            // 
            this.SO4tb.AllowDrop = true;
            this.SO4tb.Location = new System.Drawing.Point(170, 288);
            this.SO4tb.Name = "SO4tb";
            this.SO4tb.Size = new System.Drawing.Size(100, 20);
            this.SO4tb.TabIndex = 111;
            this.SO4tb.DragDrop += new System.Windows.Forms.DragEventHandler(this.SO4tb_DragDrop);
            this.SO4tb.DragEnter += new System.Windows.Forms.DragEventHandler(this.CheckDataFormat);
            this.SO4tb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SO4tb_MouseDown);
            // 
            // SO5tb
            // 
            this.SO5tb.AllowDrop = true;
            this.SO5tb.Location = new System.Drawing.Point(400, 288);
            this.SO5tb.Name = "SO5tb";
            this.SO5tb.Size = new System.Drawing.Size(100, 20);
            this.SO5tb.TabIndex = 112;
            this.SO5tb.DragDrop += new System.Windows.Forms.DragEventHandler(this.SO5tb_DragDrop);
            this.SO5tb.DragEnter += new System.Windows.Forms.DragEventHandler(this.CheckDataFormat);
            this.SO5tb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SO5tb_MouseDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(151, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 113;
            this.label7.Text = "4";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(381, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 114;
            this.label8.Text = "5";
            // 
            // SOEAform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 343);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SO5tb);
            this.Controls.Add(this.SO4tb);
            this.Controls.Add(this.SO3tb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SO2tb);
            this.Controls.Add(this.SO1tb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EA2tb);
            this.Controls.Add(this.EA1tb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label21);
            this.Name = "SOEAform";
            this.Text = "SOEAform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EA1tb;
        private System.Windows.Forms.TextBox EA2tb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SO1tb;
        private System.Windows.Forms.TextBox SO2tb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SO3tb;
        private System.Windows.Forms.TextBox SO4tb;
        private System.Windows.Forms.TextBox SO5tb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}