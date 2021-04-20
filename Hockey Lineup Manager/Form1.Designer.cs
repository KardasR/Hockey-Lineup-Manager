
namespace Hockey_Lineup_Manager
{
    partial class Form1
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
            this.LW1tb = new System.Windows.Forms.TextBox();
            this.C1TB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LW1tb
            // 
            this.LW1tb.Location = new System.Drawing.Point(70, 103);
            this.LW1tb.Name = "LW1tb";
            this.LW1tb.Size = new System.Drawing.Size(100, 20);
            this.LW1tb.TabIndex = 0;
            // 
            // C1TB
            // 
            this.C1TB.Location = new System.Drawing.Point(252, 103);
            this.C1TB.Name = "C1TB";
            this.C1TB.Size = new System.Drawing.Size(100, 20);
            this.C1TB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "LW";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "C";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.C1TB);
            this.Controls.Add(this.LW1tb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LW1tb;
        private System.Windows.Forms.TextBox C1TB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

