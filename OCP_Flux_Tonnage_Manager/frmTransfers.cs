using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OCP_Flux_Tonnage_Manager
{
    public partial class frmTransfers : Form
    {
        public frmTransfers()
        {
            InitializeComponent();
        }

        private void frmTransfers_Load(object sender, EventArgs e)
        {
            // قم بتحميل سجل الحركات عند فتح الفورم
            LoadTransfersHistory();
        }

        private void LoadTransfersHistory()
        {
            // TODO: اكتب هنا كود جلب البيانات من جدول Transfers
            // وعرضها في dgvTransfersLog
            
        }

        private void cmbItemType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // هذا الكود يعمل عندما يختار المستخدم نوع العنصر
            cmbItemName.Items.Clear(); // مسح القائمة القديمة

            if (cmbItemType.SelectedItem.ToString() == "Matière première")
            {
                lblItemName.Text = "Nom du matière :";
                // TODO: اكتب هنا كود جلب أسماء المواد الخام من جدول RawMaterials
                // وإضافتها إلى cmbItemName
                // مثال: 
                // List<string> rawMaterials = GetRawMaterialNamesFromDB();
                // cmbItemName.Items.AddRange(rawMaterials.ToArray());
                cmbItemName.Items.Add("Phosphate Rock");
                cmbItemName.Items.Add("Sulfur");
            }
            else if (cmbItemType.SelectedItem.ToString() == "Produit final")
            {
                lblItemName.Text = "Nom du produit :";
                // TODO: اكتب هنا كود جلب أسماء المنتجات النهائية من جدول FinishedProducts
                // وإضافتها إلى cmbItemName
                // مثال:
                // List<string> finishedProducts = GetFinishedProductNamesFromDB();
                // cmbItemName.Items.AddRange(finishedProducts.ToArray());
                cmbItemName.Items.Add("DAP Fertilizer");
                cmbItemName.Items.Add("MAP Fertilizer");
            }
        }

        private void btnSaveTransfer_Click(object sender, EventArgs e)
        {
            // TODO: اكتب هنا كود حفظ بيانات الحركة الجديدة في جدول Transfers
            // 1. التحقق من أن كل الحقول مملوءة
            // 2. قراءة البيانات من الحقول
            // 3. تنفيذ أمر INSERT في قاعدة البيانات
            // 4. تحديث سجل الحركات dgvTransfersLog
            MessageBox.Show("Mouvement enregistré avec succès !");
        }

        private void btnSaveTransfer_Click_1(object sender, EventArgs e)
        {

        }

        private void grpNewTransfer_Enter(object sender, EventArgs e)
        {

        }

        private void cmbItemName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}