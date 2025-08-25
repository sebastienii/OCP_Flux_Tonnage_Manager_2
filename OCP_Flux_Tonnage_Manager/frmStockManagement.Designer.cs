namespace OCP_Flux_Tonnage_Manager
{
    partial class frmStockManagement
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
            this.tabControlStock = new System.Windows.Forms.TabControl();
            this.tabRawMaterials = new System.Windows.Forms.TabPage();
            this.grpRawMaterialDetails = new System.Windows.Forms.GroupBox();
            this.btnDeleteRaw = new System.Windows.Forms.Button();
            this.btnSaveRaw = new System.Windows.Forms.Button();
            this.btnNewRaw = new System.Windows.Forms.Button();
            this.txtRawUnit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numRawQuantity = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRawName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvRawMaterials = new System.Windows.Forms.DataGridView();
            this.tabFinishedProducts = new System.Windows.Forms.TabPage();
            this.grpFinishedProductDetails = new System.Windows.Forms.GroupBox();
            this.btnDeleteFinished = new System.Windows.Forms.Button();
            this.btnSaveFinished = new System.Windows.Forms.Button();
            this.btnNewFinished = new System.Windows.Forms.Button();
            this.txtFinishedUnit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numFinishedQuantity = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFinishedName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvFinishedProducts = new System.Windows.Forms.DataGridView();
            this.tabControlStock.SuspendLayout();
            this.tabRawMaterials.SuspendLayout();
            this.grpRawMaterialDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRawQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRawMaterials)).BeginInit();
            this.tabFinishedProducts.SuspendLayout();
            this.grpFinishedProductDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFinishedQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinishedProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlStock
            // 
            this.tabControlStock.Controls.Add(this.tabRawMaterials);
            this.tabControlStock.Controls.Add(this.tabFinishedProducts);
            this.tabControlStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlStock.Font = new System.Drawing.Font("Sansita One", 12.25F, System.Drawing.FontStyle.Bold);
            this.tabControlStock.Location = new System.Drawing.Point(0, 0);
            this.tabControlStock.Name = "tabControlStock";
            this.tabControlStock.RightToLeftLayout = true;
            this.tabControlStock.SelectedIndex = 0;
            this.tabControlStock.Size = new System.Drawing.Size(816, 431);
            this.tabControlStock.TabIndex = 0;
            // 
            // tabRawMaterials
            // 
            this.tabRawMaterials.Controls.Add(this.grpRawMaterialDetails);
            this.tabRawMaterials.Controls.Add(this.dgvRawMaterials);
            this.tabRawMaterials.Location = new System.Drawing.Point(4, 28);
            this.tabRawMaterials.Name = "tabRawMaterials";
            this.tabRawMaterials.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabRawMaterials.Size = new System.Drawing.Size(808, 399);
            this.tabRawMaterials.TabIndex = 0;
            this.tabRawMaterials.Text = "matières premières";
            this.tabRawMaterials.UseVisualStyleBackColor = true;
            // 
            // grpRawMaterialDetails
            // 
            this.grpRawMaterialDetails.Controls.Add(this.btnDeleteRaw);
            this.grpRawMaterialDetails.Controls.Add(this.btnSaveRaw);
            this.grpRawMaterialDetails.Controls.Add(this.btnNewRaw);
            this.grpRawMaterialDetails.Controls.Add(this.txtRawUnit);
            this.grpRawMaterialDetails.Controls.Add(this.label3);
            this.grpRawMaterialDetails.Controls.Add(this.numRawQuantity);
            this.grpRawMaterialDetails.Controls.Add(this.label2);
            this.grpRawMaterialDetails.Controls.Add(this.txtRawName);
            this.grpRawMaterialDetails.Controls.Add(this.label1);
            this.grpRawMaterialDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpRawMaterialDetails.Location = new System.Drawing.Point(3, 200);
            this.grpRawMaterialDetails.Name = "grpRawMaterialDetails";
            this.grpRawMaterialDetails.Size = new System.Drawing.Size(802, 196);
            this.grpRawMaterialDetails.TabIndex = 1;
            this.grpRawMaterialDetails.TabStop = false;
            this.grpRawMaterialDetails.Text = "Données de matière";
            // 
            // btnDeleteRaw
            // 
            this.btnDeleteRaw.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnDeleteRaw.Location = new System.Drawing.Point(676, 140);
            this.btnDeleteRaw.Name = "btnDeleteRaw";
            this.btnDeleteRaw.Size = new System.Drawing.Size(120, 40);
            this.btnDeleteRaw.TabIndex = 8;
            this.btnDeleteRaw.Text = "supprimer";
            this.btnDeleteRaw.UseVisualStyleBackColor = true;
            // 
            // btnSaveRaw
            // 
            this.btnSaveRaw.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnSaveRaw.Location = new System.Drawing.Point(550, 140);
            this.btnSaveRaw.Name = "btnSaveRaw";
            this.btnSaveRaw.Size = new System.Drawing.Size(120, 40);
            this.btnSaveRaw.TabIndex = 7;
            this.btnSaveRaw.Text = "sauvegarder";
            this.btnSaveRaw.UseVisualStyleBackColor = true;
            // 
            // btnNewRaw
            // 
            this.btnNewRaw.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnNewRaw.Location = new System.Drawing.Point(424, 140);
            this.btnNewRaw.Name = "btnNewRaw";
            this.btnNewRaw.Size = new System.Drawing.Size(120, 40);
            this.btnNewRaw.TabIndex = 6;
            this.btnNewRaw.Text = "Ajouter";
            this.btnNewRaw.UseVisualStyleBackColor = true;
            // 
            // txtRawUnit
            // 
            this.txtRawUnit.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Bold);
            this.txtRawUnit.Location = new System.Drawing.Point(444, 88);
            this.txtRawUnit.Name = "txtRawUnit";
            this.txtRawUnit.Size = new System.Drawing.Size(131, 27);
            this.txtRawUnit.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(303, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Unité de mesure :";
            // 
            // numRawQuantity
            // 
            this.numRawQuantity.DecimalPlaces = 2;
            this.numRawQuantity.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Bold);
            this.numRawQuantity.Location = new System.Drawing.Point(161, 88);
            this.numRawQuantity.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numRawQuantity.Name = "numRawQuantity";
            this.numRawQuantity.Size = new System.Drawing.Size(120, 27);
            this.numRawQuantity.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(25, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantité:";
            // 
            // txtRawName
            // 
            this.txtRawName.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Bold);
            this.txtRawName.Location = new System.Drawing.Point(161, 35);
            this.txtRawName.Name = "txtRawName";
            this.txtRawName.Size = new System.Drawing.Size(555, 27);
            this.txtRawName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(25, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom du sujet :";
            // 
            // dgvRawMaterials
            // 
            this.dgvRawMaterials.AllowUserToAddRows = false;
            this.dgvRawMaterials.AllowUserToDeleteRows = false;
            this.dgvRawMaterials.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRawMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRawMaterials.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvRawMaterials.Location = new System.Drawing.Point(3, 3);
            this.dgvRawMaterials.Name = "dgvRawMaterials";
            this.dgvRawMaterials.ReadOnly = true;
            this.dgvRawMaterials.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRawMaterials.Size = new System.Drawing.Size(802, 188);
            this.dgvRawMaterials.TabIndex = 0;
            // 
            // tabFinishedProducts
            // 
            this.tabFinishedProducts.Controls.Add(this.grpFinishedProductDetails);
            this.tabFinishedProducts.Controls.Add(this.dgvFinishedProducts);
            this.tabFinishedProducts.Location = new System.Drawing.Point(4, 28);
            this.tabFinishedProducts.Name = "tabFinishedProducts";
            this.tabFinishedProducts.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabFinishedProducts.Size = new System.Drawing.Size(808, 399);
            this.tabFinishedProducts.TabIndex = 1;
            this.tabFinishedProducts.Text = "Produits finis";
            this.tabFinishedProducts.UseVisualStyleBackColor = true;
            // 
            // grpFinishedProductDetails
            // 
            this.grpFinishedProductDetails.Controls.Add(this.btnDeleteFinished);
            this.grpFinishedProductDetails.Controls.Add(this.btnSaveFinished);
            this.grpFinishedProductDetails.Controls.Add(this.btnNewFinished);
            this.grpFinishedProductDetails.Controls.Add(this.txtFinishedUnit);
            this.grpFinishedProductDetails.Controls.Add(this.label4);
            this.grpFinishedProductDetails.Controls.Add(this.numFinishedQuantity);
            this.grpFinishedProductDetails.Controls.Add(this.label5);
            this.grpFinishedProductDetails.Controls.Add(this.txtFinishedName);
            this.grpFinishedProductDetails.Controls.Add(this.label6);
            this.grpFinishedProductDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpFinishedProductDetails.Location = new System.Drawing.Point(3, 204);
            this.grpFinishedProductDetails.Name = "grpFinishedProductDetails";
            this.grpFinishedProductDetails.Size = new System.Drawing.Size(802, 192);
            this.grpFinishedProductDetails.TabIndex = 3;
            this.grpFinishedProductDetails.TabStop = false;
            this.grpFinishedProductDetails.Text = "Données de produit";
            // 
            // btnDeleteFinished
            // 
            this.btnDeleteFinished.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnDeleteFinished.Location = new System.Drawing.Point(676, 136);
            this.btnDeleteFinished.Name = "btnDeleteFinished";
            this.btnDeleteFinished.Size = new System.Drawing.Size(120, 40);
            this.btnDeleteFinished.TabIndex = 8;
            this.btnDeleteFinished.Text = "Supprimer";
            this.btnDeleteFinished.UseVisualStyleBackColor = true;
            // 
            // btnSaveFinished
            // 
            this.btnSaveFinished.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnSaveFinished.Location = new System.Drawing.Point(550, 136);
            this.btnSaveFinished.Name = "btnSaveFinished";
            this.btnSaveFinished.Size = new System.Drawing.Size(120, 40);
            this.btnSaveFinished.TabIndex = 7;
            this.btnSaveFinished.Text = "Sauvegarder";
            this.btnSaveFinished.UseVisualStyleBackColor = true;
            // 
            // btnNewFinished
            // 
            this.btnNewFinished.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnNewFinished.Location = new System.Drawing.Point(424, 136);
            this.btnNewFinished.Name = "btnNewFinished";
            this.btnNewFinished.Size = new System.Drawing.Size(120, 40);
            this.btnNewFinished.TabIndex = 6;
            this.btnNewFinished.Text = "Ajouter";
            this.btnNewFinished.UseVisualStyleBackColor = true;
            // 
            // txtFinishedUnit
            // 
            this.txtFinishedUnit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtFinishedUnit.Location = new System.Drawing.Point(444, 88);
            this.txtFinishedUnit.Name = "txtFinishedUnit";
            this.txtFinishedUnit.Size = new System.Drawing.Size(183, 26);
            this.txtFinishedUnit.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(303, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Unité de mesure";
            // 
            // numFinishedQuantity
            // 
            this.numFinishedQuantity.DecimalPlaces = 2;
            this.numFinishedQuantity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.numFinishedQuantity.Location = new System.Drawing.Point(161, 88);
            this.numFinishedQuantity.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numFinishedQuantity.Name = "numFinishedQuantity";
            this.numFinishedQuantity.Size = new System.Drawing.Size(120, 26);
            this.numFinishedQuantity.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(25, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Quantité :";
            // 
            // txtFinishedName
            // 
            this.txtFinishedName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtFinishedName.Location = new System.Drawing.Point(161, 35);
            this.txtFinishedName.Name = "txtFinishedName";
            this.txtFinishedName.Size = new System.Drawing.Size(547, 26);
            this.txtFinishedName.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(25, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nom de produit :";
            // 
            // dgvFinishedProducts
            // 
            this.dgvFinishedProducts.AllowUserToAddRows = false;
            this.dgvFinishedProducts.AllowUserToDeleteRows = false;
            this.dgvFinishedProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFinishedProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFinishedProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvFinishedProducts.Location = new System.Drawing.Point(3, 3);
            this.dgvFinishedProducts.Name = "dgvFinishedProducts";
            this.dgvFinishedProducts.ReadOnly = true;
            this.dgvFinishedProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFinishedProducts.Size = new System.Drawing.Size(802, 185);
            this.dgvFinishedProducts.TabIndex = 2;
            // 
            // frmStockManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 431);
            this.Controls.Add(this.tabControlStock);
            this.Name = "frmStockManagement";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestion des stocks";
            this.Load += new System.EventHandler(this.frmStockManagement_Load);
            this.tabControlStock.ResumeLayout(false);
            this.tabRawMaterials.ResumeLayout(false);
            this.grpRawMaterialDetails.ResumeLayout(false);
            this.grpRawMaterialDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRawQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRawMaterials)).EndInit();
            this.tabFinishedProducts.ResumeLayout(false);
            this.grpFinishedProductDetails.ResumeLayout(false);
            this.grpFinishedProductDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFinishedQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinishedProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlStock;
        private System.Windows.Forms.TabPage tabRawMaterials;
        private System.Windows.Forms.DataGridView dgvRawMaterials;
        private System.Windows.Forms.TabPage tabFinishedProducts;
        private System.Windows.Forms.GroupBox grpRawMaterialDetails;
        private System.Windows.Forms.Button btnDeleteRaw;
        private System.Windows.Forms.Button btnSaveRaw;
        private System.Windows.Forms.Button btnNewRaw;
        private System.Windows.Forms.TextBox txtRawUnit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numRawQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRawName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpFinishedProductDetails;
        private System.Windows.Forms.Button btnDeleteFinished;
        private System.Windows.Forms.Button btnSaveFinished;
        private System.Windows.Forms.Button btnNewFinished;
        private System.Windows.Forms.TextBox txtFinishedUnit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numFinishedQuantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFinishedName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvFinishedProducts;
    }
}