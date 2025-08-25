namespace OCP_Flux_Tonnage_Manager
{
    partial class frmProduction
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.grpNewProduction = new System.Windows.Forms.GroupBox();
            this.btnSaveProduction = new System.Windows.Forms.Button();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpProductionDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.numQuantityProduced = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvProductionLog = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.modernButton1 = new ModernUIButton.ModernButton();
            this.grpNewProduction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantityProduced)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductionLog)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpNewProduction
            // 
            this.grpNewProduction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.grpNewProduction.Controls.Add(this.modernButton1);
            this.grpNewProduction.Controls.Add(this.txtNotes);
            this.grpNewProduction.Controls.Add(this.label4);
            this.grpNewProduction.Controls.Add(this.dtpProductionDate);
            this.grpNewProduction.Controls.Add(this.label3);
            this.grpNewProduction.Controls.Add(this.numQuantityProduced);
            this.grpNewProduction.Controls.Add(this.label2);
            this.grpNewProduction.Controls.Add(this.cmbProduct);
            this.grpNewProduction.Controls.Add(this.label1);
            this.grpNewProduction.Font = new System.Drawing.Font("Sansita One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNewProduction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(225)))), ((int)(((byte)(188)))));
            this.grpNewProduction.Location = new System.Drawing.Point(4, 6);
            this.grpNewProduction.Name = "grpNewProduction";
            this.grpNewProduction.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grpNewProduction.Size = new System.Drawing.Size(902, 200);
            this.grpNewProduction.TabIndex = 0;
            this.grpNewProduction.TabStop = false;
            this.grpNewProduction.Text = "Nouveau enregistrement de production";
            // 
            // btnSaveProduction
            // 
            this.btnSaveProduction.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnSaveProduction.Location = new System.Drawing.Point(12, 604);
            this.btnSaveProduction.Name = "btnSaveProduction";
            this.btnSaveProduction.Size = new System.Drawing.Size(235, 40);
            this.btnSaveProduction.TabIndex = 8;
            this.btnSaveProduction.Text = "Sauvegarder la production";
            this.btnSaveProduction.UseVisualStyleBackColor = true;
            this.btnSaveProduction.Click += new System.EventHandler(this.btnSaveProduction_Click);
            // 
            // txtNotes
            // 
            this.txtNotes.BackColor = System.Drawing.Color.Gray;
            this.txtNotes.Font = new System.Drawing.Font("Arial Narrow", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.Location = new System.Drawing.Point(167, 86);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(501, 30);
            this.txtNotes.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(6, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "commentaires:";
            // 
            // dtpProductionDate
            // 
            this.dtpProductionDate.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.dtpProductionDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpProductionDate.Location = new System.Drawing.Point(169, 38);
            this.dtpProductionDate.Name = "dtpProductionDate";
            this.dtpProductionDate.Size = new System.Drawing.Size(150, 26);
            this.dtpProductionDate.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(6, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date de production :";
            // 
            // numQuantityProduced
            // 
            this.numQuantityProduced.DecimalPlaces = 2;
            this.numQuantityProduced.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.numQuantityProduced.Location = new System.Drawing.Point(469, 38);
            this.numQuantityProduced.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numQuantityProduced.Name = "numQuantityProduced";
            this.numQuantityProduced.Size = new System.Drawing.Size(140, 26);
            this.numQuantityProduced.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(318, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantité produite :";
            // 
            // cmbProduct
            // 
            this.cmbProduct.BackColor = System.Drawing.Color.White;
            this.cmbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduct.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(732, 36);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(153, 28);
            this.cmbProduct.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(614, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produit final :";
            // 
            // dgvProductionLog
            // 
            this.dgvProductionLog.AllowUserToAddRows = false;
            this.dgvProductionLog.AllowUserToDeleteRows = false;
            this.dgvProductionLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductionLog.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.dgvProductionLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductionLog.Location = new System.Drawing.Point(10, 28);
            this.dgvProductionLog.Name = "dgvProductionLog";
            this.dgvProductionLog.ReadOnly = true;
            this.dgvProductionLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductionLog.Size = new System.Drawing.Size(879, 177);
            this.dgvProductionLog.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvProductionLog);
            this.groupBox1.Font = new System.Drawing.Font("Sansita One", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(225)))), ((int)(((byte)(188)))));
            this.groupBox1.Location = new System.Drawing.Point(4, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(902, 217);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Record de production";
            // 
            // modernButton1
            // 
            this.modernButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(225)))), ((int)(((byte)(188)))));
            this.modernButton1.FlatAppearance.BorderSize = 0;
            this.modernButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modernButton1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.modernButton1.ForeColor = System.Drawing.Color.Black;
            this.modernButton1.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(89)))), ((int)(((byte)(84)))));
            this.modernButton1.Location = new System.Drawing.Point(618, 150);
            this.modernButton1.Name = "modernButton1";
            this.modernButton1.NormalBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(225)))), ((int)(((byte)(188)))));
            this.modernButton1.Size = new System.Drawing.Size(267, 40);
            this.modernButton1.TabIndex = 9;
            this.modernButton1.Text = "Sauvegarder la production";
            this.modernButton1.TextColor = System.Drawing.Color.Black;
            this.modernButton1.UseVisualStyleBackColor = false;
            // 
            // frmProduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(918, 437);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSaveProduction);
            this.Controls.Add(this.grpNewProduction);
            this.Name = "frmProduction";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Suivi de la production";
            this.Load += new System.EventHandler(this.frmProduction_Load);
            this.grpNewProduction.ResumeLayout(false);
            this.grpNewProduction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantityProduced)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductionLog)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpNewProduction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.NumericUpDown numQuantityProduced;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpProductionDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btnSaveProduction;
        private System.Windows.Forms.DataGridView dgvProductionLog;
        private System.Windows.Forms.GroupBox groupBox1;
        private ModernUIButton.ModernButton modernButton1;
    }
}