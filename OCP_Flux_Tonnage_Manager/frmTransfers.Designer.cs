namespace OCP_Flux_Tonnage_Manager
{
    partial class frmTransfers
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
            this.grpNewTransfer = new System.Windows.Forms.GroupBox();
            this.btnSaveTransfer = new System.Windows.Forms.Button();
            this.dtpTransferDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbItemName = new System.Windows.Forms.ComboBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.cmbItemType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTransfersLog = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.modernButton1 = new ModernUIButton.ModernButton();
            this.grpNewTransfer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransfersLog)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpNewTransfer
            // 
            this.grpNewTransfer.Controls.Add(this.modernButton1);
            this.grpNewTransfer.Controls.Add(this.dtpTransferDate);
            this.grpNewTransfer.Controls.Add(this.label5);
            this.grpNewTransfer.Controls.Add(this.txtDestination);
            this.grpNewTransfer.Controls.Add(this.label4);
            this.grpNewTransfer.Controls.Add(this.txtSource);
            this.grpNewTransfer.Controls.Add(this.label3);
            this.grpNewTransfer.Controls.Add(this.numQuantity);
            this.grpNewTransfer.Controls.Add(this.label2);
            this.grpNewTransfer.Controls.Add(this.cmbItemName);
            this.grpNewTransfer.Controls.Add(this.lblItemName);
            this.grpNewTransfer.Controls.Add(this.cmbItemType);
            this.grpNewTransfer.Controls.Add(this.label1);
            this.grpNewTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpNewTransfer.Font = new System.Drawing.Font("Sansita One", 14.25F, System.Drawing.FontStyle.Bold);
            this.grpNewTransfer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(225)))), ((int)(((byte)(188)))));
            this.grpNewTransfer.Location = new System.Drawing.Point(12, 12);
            this.grpNewTransfer.Name = "grpNewTransfer";
            this.grpNewTransfer.Size = new System.Drawing.Size(827, 200);
            this.grpNewTransfer.TabIndex = 0;
            this.grpNewTransfer.TabStop = false;
            this.grpNewTransfer.Text = "Enregistrer un nouveau mouvement";
            this.grpNewTransfer.Enter += new System.EventHandler(this.grpNewTransfer_Enter);
            // 
            // btnSaveTransfer
            // 
            this.btnSaveTransfer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnSaveTransfer.Location = new System.Drawing.Point(598, 728);
            this.btnSaveTransfer.Name = "btnSaveTransfer";
            this.btnSaveTransfer.Size = new System.Drawing.Size(220, 40);
            this.btnSaveTransfer.TabIndex = 12;
            this.btnSaveTransfer.Text = "Sauvegarder mouvement";
            this.btnSaveTransfer.UseVisualStyleBackColor = true;
            this.btnSaveTransfer.Click += new System.EventHandler(this.btnSaveTransfer_Click_1);
            // 
            // dtpTransferDate
            // 
            this.dtpTransferDate.CustomFormat = "yyyy/MM/dd HH:mm";
            this.dtpTransferDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.dtpTransferDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTransferDate.Location = new System.Drawing.Point(403, 158);
            this.dtpTransferDate.Name = "dtpTransferDate";
            this.dtpTransferDate.Size = new System.Drawing.Size(179, 26);
            this.dtpTransferDate.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(209, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Histoire du mouvement :";
            // 
            // txtDestination
            // 
            this.txtDestination.AllowDrop = true;
            this.txtDestination.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtDestination.Font = new System.Drawing.Font("Arial Narrow", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestination.Location = new System.Drawing.Point(568, 97);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(248, 25);
            this.txtDestination.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(398, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Section Destination :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtSource
            // 
            this.txtSource.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSource.Font = new System.Drawing.Font("Arial Narrow", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSource.Location = new System.Drawing.Point(139, 97);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(250, 25);
            this.txtSource.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(6, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Section source :";
            // 
            // numQuantity
            // 
            this.numQuantity.BackColor = System.Drawing.Color.Gray;
            this.numQuantity.DecimalPlaces = 2;
            this.numQuantity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.numQuantity.ForeColor = System.Drawing.SystemColors.InfoText;
            this.numQuantity.Location = new System.Drawing.Point(86, 156);
            this.numQuantity.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(120, 26);
            this.numQuantity.TabIndex = 5;
            this.numQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(6, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quantité :";
            // 
            // cmbItemName
            // 
            this.cmbItemName.BackColor = System.Drawing.Color.White;
            this.cmbItemName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbItemName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItemName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.cmbItemName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmbItemName.FormattingEnabled = true;
            this.cmbItemName.Location = new System.Drawing.Point(566, 43);
            this.cmbItemName.Name = "cmbItemName";
            this.cmbItemName.Size = new System.Drawing.Size(250, 28);
            this.cmbItemName.TabIndex = 3;
            this.cmbItemName.SelectedIndexChanged += new System.EventHandler(this.cmbItemName_SelectedIndexChanged);
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblItemName.Location = new System.Drawing.Point(398, 43);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(139, 19);
            this.lblItemName.TabIndex = 2;
            this.lblItemName.Text = "Nom du matière :";
            // 
            // cmbItemType
            // 
            this.cmbItemType.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cmbItemType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbItemType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItemType.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.cmbItemType.FormattingEnabled = true;
            this.cmbItemType.Items.AddRange(new object[] {
            "Matière première",
            "Produit final"});
            this.cmbItemType.Location = new System.Drawing.Point(138, 43);
            this.cmbItemType.Name = "cmbItemType";
            this.cmbItemType.Size = new System.Drawing.Size(251, 28);
            this.cmbItemType.TabIndex = 1;
            this.cmbItemType.SelectedIndexChanged += new System.EventHandler(this.cmbItemType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type d\'article :";
            // 
            // dgvTransfersLog
            // 
            this.dgvTransfersLog.AllowUserToAddRows = false;
            this.dgvTransfersLog.AllowUserToDeleteRows = false;
            this.dgvTransfersLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTransfersLog.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.dgvTransfersLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransfersLog.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvTransfersLog.Location = new System.Drawing.Point(6, 28);
            this.dgvTransfersLog.Name = "dgvTransfersLog";
            this.dgvTransfersLog.ReadOnly = true;
            this.dgvTransfersLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransfersLog.Size = new System.Drawing.Size(810, 192);
            this.dgvTransfersLog.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvTransfersLog);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(225)))), ((int)(((byte)(188)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 218);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(827, 234);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Record des mouvements";
            // 
            // modernButton1
            // 
            this.modernButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(225)))), ((int)(((byte)(188)))));
            this.modernButton1.FlatAppearance.BorderSize = 0;
            this.modernButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modernButton1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.modernButton1.ForeColor = System.Drawing.Color.Black;
            this.modernButton1.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(89)))), ((int)(((byte)(84)))));
            this.modernButton1.Location = new System.Drawing.Point(591, 151);
            this.modernButton1.Name = "modernButton1";
            this.modernButton1.NormalBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(225)))), ((int)(((byte)(188)))));
            this.modernButton1.Size = new System.Drawing.Size(220, 40);
            this.modernButton1.TabIndex = 2;
            this.modernButton1.Text = "Sauvegarder Mouvement";
            this.modernButton1.TextColor = System.Drawing.Color.Black;
            this.modernButton1.UseVisualStyleBackColor = false;
            // 
            // frmTransfers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(849, 463);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSaveTransfer);
            this.Controls.Add(this.grpNewTransfer);
            this.Name = "frmTransfers";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestion des mouvements logistiques";
            this.Load += new System.EventHandler(this.frmTransfers_Load);
            this.grpNewTransfer.ResumeLayout(false);
            this.grpNewTransfer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransfersLog)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpNewTransfer;
        private System.Windows.Forms.ComboBox cmbItemType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbItemName;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpTransferDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSaveTransfer;
        private System.Windows.Forms.DataGridView dgvTransfersLog;
        private System.Windows.Forms.GroupBox groupBox1;
        private ModernUIButton.ModernButton modernButton1;
    }
}