using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OCP_Flux_Tonnage_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var myButton = new AnimatedHoverButton()
            {
                Text = "Cliquez-moi",
                Size = new Size(150, 50),
                Location = new Point(20, 20)
            };

            this.Controls.Add(myButton);
            // يمكنك إضافة أي كود تريده أن يعمل عند بدء تشغيل هذه الواجهة هنا
        }

        // ملاحظة: لربط الأزرار بهذه الأكواد، اذهب إلى وضع التصميم
        // اضغط على الزر مرتين، وسيقوم فيجوال ستوديو بربطها تلقائياً

        private void btnStock_Click(object sender, EventArgs e)
        {
            // هنا ستكتب الكود لفتح واجهة إدارة المخزون
            MessageBox.Show("L'interface de gestion des stocks s'ouvrira.");
        }

        private void btnTransfers_Click(object sender, EventArgs e)
        {
            // هنا ستكتب الكود لفتح واجهة إدارة الحركات
            MessageBox.Show("L'interface de gestion des mouvements logistiques s'ouvrira.");
        }

        private void btnProduction_Click(object sender, EventArgs e)
        {
            // هنا ستكتب الكود لفتح واجهة متابعة الإنتاج
            MessageBox.Show("L'interface de surveillance de la production s'ouvrira.");
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            // هنا ستكتب الكود لفتح واجهة التقارير والإحصائيات
            MessageBox.Show("L'interface Rapports et statistiques s'ouvrira.");
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTransfers_Click_1(object sender, EventArgs e)
        {
            frmTransfers Moe = new frmTransfers();

            Moe.Show();
            // Cache la fenêtre actuelle
            this.Hide();

            // Événement FormClosed : C'est la clé. Ce code s'exécute lorsque la nouvelle fenêtre est fermée.
            Moe.FormClosed += (s, args) => {
                // Une fois la Form2 fermée, on ferme l'application en demandant à la Form1 de se fermer.
                this.Hide();
                Form1 mainForm = new Form1();
                mainForm.Show();

            };
        }

        private void btnStock_Click_1(object sender, EventArgs e)
        {
            frmStockManagement tuy = new frmStockManagement();

            tuy.Show();
            // Cache la fenêtre actuelle
            this.Hide();

            // Événement FormClosed : C'est la clé. Ce code s'exécute lorsque la nouvelle fenêtre est fermée.
            tuy.FormClosed += (s, args) => {
                // Une fois la Form2 fermée, on ferme l'application en demandant à la Form1 de se fermer.
                this.Hide();
                Form1 mainForm = new Form1();
                mainForm.Show();

            };



        }

        private void btnProduction_Click_1(object sender, EventArgs e)
        {
            frmProduction  Mos = new frmProduction();

            Mos.Show();
            Show();
            // Cache la fenêtre actuelle
            this.Hide();

            // Événement FormClosed : C'est la clé. Ce code s'exécute lorsque la nouvelle fenêtre est fermée.
            Mos.FormClosed += (s, args) => {
                // Une fois la Form2 fermée, on ferme l'application en demandant à la Form1 de se fermer.
                this.Hide();
                Form1 mainForm = new Form1();
                mainForm.Show();

            };

        }

        private void btnReports_Click_1(object sender, EventArgs e)
        {
            frmReports def = new frmReports();

            def.Show();
            Show();
            // Cache la fenêtre actuelle
            this.Hide();

            // Événement FormClosed : C'est la clé. Ce code s'exécute lorsque la nouvelle fenêtre est fermée.
            def.FormClosed += (s, args) => {
                // Une fois la Form2 fermée, on ferme l'application en demandant à la Form1 de se fermer.
                this.Hide();
                Form1 mainForm = new Form1();
                mainForm.Show();

            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void modernButton1_Click(object sender, EventArgs e)
        {
            frmTransfers Moe = new frmTransfers();

            Moe.Show();
            // Cache la fenêtre actuelle
            this.Hide();

            // Événement FormClosed : C'est la clé. Ce code s'exécute lorsque la nouvelle fenêtre est fermée.
            Moe.FormClosed += (s, args) => {
                // Une fois la Form2 fermée, on ferme l'application en demandant à la Form1 de se fermer.
                this.Hide();
                Form1 mainForm = new Form1();
                mainForm.Show();


            };
        }

        private void modernButton2_Click(object sender, EventArgs e)
        {
            frmStockManagement tuy = new frmStockManagement();

            tuy.Show();
            // Cache la fenêtre actuelle
            this.Hide();

            // Événement FormClosed : C'est la clé. Ce code s'exécute lorsque la nouvelle fenêtre est fermée.
            tuy.FormClosed += (s, args) => {
                // Une fois la Form2 fermée, on ferme l'application en demandant à la Form1 de se fermer.
                this.Hide();
                Form1 mainForm = new Form1();
                mainForm.Show();

            };
        }

        private void modernButton3_Click(object sender, EventArgs e)
        {
            frmProduction Mos = new frmProduction();

            Mos.Show();
            Show();
            // Cache la fenêtre actuelle
            this.Hide();

            // Événement FormClosed : C'est la clé. Ce code s'exécute lorsque la nouvelle fenêtre est fermée.
            Mos.FormClosed += (s, args) => {
                // Une fois la Form2 fermée, on ferme l'application en demandant à la Form1 de se fermer.
                this.Hide();
                Form1 mainForm = new Form1();
                mainForm.Show();

            };
        }

        private void modernButton4_Click(object sender, EventArgs e)
        {
            frmReports def = new frmReports();

            def.Show();
            Show();
            // Cache la fenêtre actuelle
            this.Hide();

            // Événement FormClosed : C'est la clé. Ce code s'exécute lorsque la nouvelle fenêtre est fermée.
            def.FormClosed += (s, args) => {
                // Une fois la Form2 fermée, on ferme l'application en demandant à la Form1 de se fermer.
                this.Hide();
                Form1 mainForm = new Form1();
                mainForm.Show();

            };
        }

        private void modernButton5_Click(object sender, EventArgs e)
        {
            frmTransfers Moe = new frmTransfers();

            Moe.Show();
            // Cache la fenêtre actuelle
            this.Hide();

            // Événement FormClosed : C'est la clé. Ce code s'exécute lorsque la nouvelle fenêtre est fermée.
            Moe.FormClosed += (s, args) => {
                // Une fois la Form2 fermée, on ferme l'application en demandant à la Form1 de se fermer.
                this.Hide();
                Form1 mainForm = new Form1();
                mainForm.Show();

            };
        }

        private void modernButton1_Click_1(object sender, EventArgs e)
        {
            frmStockManagement tuy = new frmStockManagement();

            tuy.Show();
            // Cache la fenêtre actuelle
            this.Hide();

            // Événement FormClosed : C'est la clé. Ce code s'exécute lorsque la nouvelle fenêtre est fermée.
            tuy.FormClosed += (s, args) => {
                // Une fois la Form2 fermée, on ferme l'application en demandant à la Form1 de se fermer.
                this.Hide();
                Form1 mainForm = new Form1();
                mainForm.Show();

            };
        }

        private void modernButton2_Click_1(object sender, EventArgs e)
        {
            frmReports def = new frmReports();

            def.Show();
            Show();
            // Cache la fenêtre actuelle
            this.Hide();

            // Événement FormClosed : C'est la clé. Ce code s'exécute lorsque la nouvelle fenêtre est fermée.
            def.FormClosed += (s, args) => {
                // Une fois la Form2 fermée, on ferme l'application en demandant à la Form1 de se fermer.
                this.Hide();
                Form1 mainForm = new Form1();
                mainForm.Show();

            };
        }

        private void modernButton3_Click_1(object sender, EventArgs e)
        {
            frmProduction Mos = new frmProduction();

            Mos.Show();
            Show();
            // Cache la fenêtre actuelle
            this.Hide();

            // Événement FormClosed : C'est la clé. Ce code s'exécute lorsque la nouvelle fenêtre est fermée.
            Mos.FormClosed += (s, args) => {
                // Une fois la Form2 fermée, on ferme l'application en demandant à la Form1 de se fermer.
                this.Hide();
                Form1 mainForm = new Form1();
                mainForm.Show();

            };
        }
    }
}