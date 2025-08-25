using System;
using System.Windows.Forms;

namespace OCP_Flux_Tonnage_Manager
{
    public partial class frmProduction : Form
    {
        public frmProduction()
        {
            InitializeComponent();
        }

        private void frmProduction_Load(object sender, EventArgs e)
        {
            // عند تحميل الفورم، قم بتعبئة قائمة المنتجات وتحميل سجل الإنتاج
            LoadFinishedProducts();
            LoadProductionHistory();
        }

        private void LoadFinishedProducts()
        {
            // TODO: اكتب هنا كود جلب أسماء المنتجات النهائية من جدول FinishedProducts
            // وإضافتها إلى ComboBox الخاص بالمنتجات
            // مثال:
            // cmbProduct.DataSource = productNamesList;
            cmbProduct.Items.Add("DAP Fertilizer");
            cmbProduct.Items.Add("MAP Fertilizer");
            cmbProduct.Items.Add("TSP Fertilizer");
        }

        private void LoadProductionHistory()
        {
            // TODO: اكتب هنا كود جلب البيانات من جدول ProductionLog
            // وعرضها في dgvProductionLog
            
        }

        private void btnSaveProduction_Click(object sender, EventArgs e)
        {
            // TODO: اكتب هنا كود حفظ بيانات الإنتاج الجديد في جدول ProductionLog
            // 1. تأكد من أن المستخدم اختار منتجاً وأدخل كمية
            // 2. اقرأ البيانات من الواجهة
            // 3. نفذ أمر INSERT في قاعدة البيانات لإضافة السجل الجديد
            // 4. قم بتحديث الكمية في جدول FinishedProducts (زيادة المخزون)
            // 5. قم بتحديث عرض سجل الإنتاج في dgvProductionLog
            MessageBox.Show("Journal de production enregistré avec succès !");
        }
    }
}