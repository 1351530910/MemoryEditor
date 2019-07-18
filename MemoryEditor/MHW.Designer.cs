namespace MemoryEditor
{
    partial class MHW
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
            this.gold_lb = new System.Windows.Forms.Label();
            this.gold_tb = new System.Windows.Forms.TextBox();
            this.SP_tb = new System.Windows.Forms.TextBox();
            this.level_tb = new System.Windows.Forms.TextBox();
            this.exp_tb = new System.Windows.Forms.TextBox();
            this.sp_lb = new System.Windows.Forms.Label();
            this.level_lb = new System.Windows.Forms.Label();
            this.exp_lb = new System.Windows.Forms.Label();
            this.Scan = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gold_lb
            // 
            this.gold_lb.AutoSize = true;
            this.gold_lb.Location = new System.Drawing.Point(13, 16);
            this.gold_lb.Name = "gold_lb";
            this.gold_lb.Size = new System.Drawing.Size(29, 12);
            this.gold_lb.TabIndex = 0;
            this.gold_lb.Text = "Gold";
            // 
            // gold_tb
            // 
            this.gold_tb.Location = new System.Drawing.Point(60, 10);
            this.gold_tb.Name = "gold_tb";
            this.gold_tb.Size = new System.Drawing.Size(100, 21);
            this.gold_tb.TabIndex = 1;
            // 
            // SP_tb
            // 
            this.SP_tb.Location = new System.Drawing.Point(220, 10);
            this.SP_tb.Name = "SP_tb";
            this.SP_tb.Size = new System.Drawing.Size(100, 21);
            this.SP_tb.TabIndex = 2;
            // 
            // level_tb
            // 
            this.level_tb.Location = new System.Drawing.Point(386, 10);
            this.level_tb.Name = "level_tb";
            this.level_tb.Size = new System.Drawing.Size(100, 21);
            this.level_tb.TabIndex = 3;
            // 
            // exp_tb
            // 
            this.exp_tb.Location = new System.Drawing.Point(539, 10);
            this.exp_tb.Name = "exp_tb";
            this.exp_tb.Size = new System.Drawing.Size(100, 21);
            this.exp_tb.TabIndex = 4;
            // 
            // sp_lb
            // 
            this.sp_lb.AutoSize = true;
            this.sp_lb.Location = new System.Drawing.Point(177, 16);
            this.sp_lb.Name = "sp_lb";
            this.sp_lb.Size = new System.Drawing.Size(17, 12);
            this.sp_lb.TabIndex = 5;
            this.sp_lb.Text = "SP";
            // 
            // level_lb
            // 
            this.level_lb.AutoSize = true;
            this.level_lb.Location = new System.Drawing.Point(339, 16);
            this.level_lb.Name = "level_lb";
            this.level_lb.Size = new System.Drawing.Size(35, 12);
            this.level_lb.TabIndex = 6;
            this.level_lb.Text = "Level";
            // 
            // exp_lb
            // 
            this.exp_lb.AutoSize = true;
            this.exp_lb.Location = new System.Drawing.Point(494, 16);
            this.exp_lb.Name = "exp_lb";
            this.exp_lb.Size = new System.Drawing.Size(23, 12);
            this.exp_lb.TabIndex = 7;
            this.exp_lb.Text = "Exp";
            // 
            // Scan
            // 
            this.Scan.Location = new System.Drawing.Point(658, 8);
            this.Scan.Name = "Scan";
            this.Scan.Size = new System.Drawing.Size(75, 23);
            this.Scan.TabIndex = 8;
            this.Scan.Text = "Scan";
            this.Scan.UseVisualStyleBackColor = true;
            this.Scan.Click += new System.EventHandler(this.Scan_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(740, 8);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 9;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.Save_Click);
            // 
            // MHW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 53);
            this.Controls.Add(this.save);
            this.Controls.Add(this.Scan);
            this.Controls.Add(this.exp_lb);
            this.Controls.Add(this.level_lb);
            this.Controls.Add(this.sp_lb);
            this.Controls.Add(this.exp_tb);
            this.Controls.Add(this.level_tb);
            this.Controls.Add(this.SP_tb);
            this.Controls.Add(this.gold_tb);
            this.Controls.Add(this.gold_lb);
            this.Name = "MHW";
            this.Text = "MHW";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gold_lb;
        private System.Windows.Forms.TextBox gold_tb;
        private System.Windows.Forms.TextBox SP_tb;
        private System.Windows.Forms.TextBox level_tb;
        private System.Windows.Forms.TextBox exp_tb;
        private System.Windows.Forms.Label sp_lb;
        private System.Windows.Forms.Label level_lb;
        private System.Windows.Forms.Label exp_lb;
        private System.Windows.Forms.Button Scan;
        private System.Windows.Forms.Button save;
    }
}