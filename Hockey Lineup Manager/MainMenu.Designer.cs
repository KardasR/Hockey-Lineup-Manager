
namespace Hockey_Lineup_Manager
{
    partial class MainMenu
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
            this.SelTeambtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.NewTeambtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SelTeambtn
            // 
            this.SelTeambtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelTeambtn.Location = new System.Drawing.Point(76, 97);
            this.SelTeambtn.Name = "SelTeambtn";
            this.SelTeambtn.Size = new System.Drawing.Size(191, 101);
            this.SelTeambtn.TabIndex = 0;
            this.SelTeambtn.Text = "Select Team";
            this.SelTeambtn.UseVisualStyleBackColor = true;
            this.SelTeambtn.Click += new System.EventHandler(this.SelTeambtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hockey Lineup Manager";
            // 
            // NewTeambtn
            // 
            this.NewTeambtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewTeambtn.Location = new System.Drawing.Point(324, 97);
            this.NewTeambtn.Name = "NewTeambtn";
            this.NewTeambtn.Size = new System.Drawing.Size(191, 101);
            this.NewTeambtn.TabIndex = 2;
            this.NewTeambtn.Text = "New Team";
            this.NewTeambtn.UseVisualStyleBackColor = true;
            this.NewTeambtn.Click += new System.EventHandler(this.NewTeambtn_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 223);
            this.Controls.Add(this.NewTeambtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelTeambtn);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SelTeambtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NewTeambtn;
    }
}