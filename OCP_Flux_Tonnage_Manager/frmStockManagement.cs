using System;
using System.Windows.Forms;

namespace OCP_Flux_Tonnage_Manager
{
    public partial class frmStockManagement : Form
    {
        public frmStockManagement()
        {
            InitializeComponent();
        }

        private void frmStockManagement_Load(object sender, EventArgs e)
        {
            // عند تحميل الفورم، قم بجلب البيانات من قاعدة البيانات
            LoadRawMaterials();
            LoadFinishedProducts();
        }

        private void LoadRawMaterials()
        {
            // TODO: اكتب هنا كود جلب البيانات من جدول RawMaterials
            // وعرضها في dgvRawMaterials
            // مثال: dgvRawMaterials.DataSource = dataTable;
            
        }

        private void LoadFinishedProducts()
        {
            
        }

        // يمكنك إضافة دوال الأزرار هنا (Add, Save, Delete)
        // لكل من المواد الخام والمنتجات النهائية
    }
}