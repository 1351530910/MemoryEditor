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
            this.components = new System.ComponentModel.Container();
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
            this.refresh_btn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lockedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.set_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
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
            this.level_tb.Location = new System.Drawing.Point(60, 37);
            this.level_tb.Name = "level_tb";
            this.level_tb.Size = new System.Drawing.Size(100, 21);
            this.level_tb.TabIndex = 3;
            // 
            // exp_tb
            // 
            this.exp_tb.Location = new System.Drawing.Point(220, 37);
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
            this.level_lb.Location = new System.Drawing.Point(13, 43);
            this.level_lb.Name = "level_lb";
            this.level_lb.Size = new System.Drawing.Size(35, 12);
            this.level_lb.TabIndex = 6;
            this.level_lb.Text = "Level";
            // 
            // exp_lb
            // 
            this.exp_lb.AutoSize = true;
            this.exp_lb.Location = new System.Drawing.Point(175, 43);
            this.exp_lb.Name = "exp_lb";
            this.exp_lb.Size = new System.Drawing.Size(23, 12);
            this.exp_lb.TabIndex = 7;
            this.exp_lb.Text = "Exp";
            // 
            // Scan
            // 
            this.Scan.Location = new System.Drawing.Point(345, 10);
            this.Scan.Name = "Scan";
            this.Scan.Size = new System.Drawing.Size(75, 23);
            this.Scan.TabIndex = 8;
            this.Scan.Text = "Scan";
            this.Scan.UseVisualStyleBackColor = true;
            this.Scan.Click += new System.EventHandler(this.Scan_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(345, 35);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 9;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.Save_Click);
            // 
            // refresh_btn
            // 
            this.refresh_btn.Location = new System.Drawing.Point(426, 8);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(75, 23);
            this.refresh_btn.TabIndex = 11;
            this.refresh_btn.Text = "refresh";
            this.refresh_btn.UseVisualStyleBackColor = true;
            this.refresh_btn.Click += new System.EventHandler(this.Refresh_btn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(15, 64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(307, 20);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.lockedDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.itemBindingSource;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(15, 91);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(548, 333);
            this.dataGridView1.TabIndex = 14;

            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "count";
            this.countDataGridViewTextBoxColumn.HeaderText = "count";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // lockedDataGridViewCheckBoxColumn
            // 
            this.lockedDataGridViewCheckBoxColumn.DataPropertyName = "locked";
            this.lockedDataGridViewCheckBoxColumn.HeaderText = "locked";
            this.lockedDataGridViewCheckBoxColumn.Name = "lockedDataGridViewCheckBoxColumn";
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataSource = typeof(MemoryEditor.Item);
            // 
            // set_btn
            // 
            this.set_btn.Location = new System.Drawing.Point(426, 37);
            this.set_btn.Name = "set_btn";
            this.set_btn.Size = new System.Drawing.Size(75, 23);
            this.set_btn.TabIndex = 15;
            this.set_btn.Text = "set";
            this.set_btn.UseVisualStyleBackColor = true;
            this.set_btn.Click += new System.EventHandler(this.Set_btn_Click);
            // 
            // MHW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 460);
            this.Controls.Add(this.set_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.refresh_btn);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
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
        private System.Windows.Forms.Button refresh_btn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn lockedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private System.Windows.Forms.Button set_btn;
    }
}