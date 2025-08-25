using System;
using System.Data; // Required for DataTable
using System.Windows.Forms;

namespace OCP_Flux_Tonnage_Manager
{
    public partial class frmReports : Form
    {
        public frmReports()
        {
            InitializeComponent();
        }

        private void frmReports_Load(object sender, EventArgs e)
        {
            // Add the available report options to the dropdown list
            cmbReportList.Items.Add("Liste d'inventaire complète");
            cmbReportList.Items.Add("Bilan de production du mois en cours");
            cmbReportList.Items.Add("Les 100 derniers mouvements logistiques");
            cmbReportList.Items.Add("Liste des matières premières uniquement");
            cmbReportList.Items.Add("Liste des produits finales uniquement");
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (cmbReportList.SelectedItem == null)
            {
                MessageBox.Show("Veuillez d’abord sélectionner un type de rapport.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedReport = cmbReportList.SelectedItem.ToString();
            lblReportTitle.Text = selectedReport;
            DataTable reportData = new DataTable();

            // This is where you will fetch data from your database
            // based on the selected report.

            switch (selectedReport)
            {
                case "Liste d'inventaire complète":
                    // TODO: Write a SQL query that combines data from RawMaterials and FinishedProducts.
                    // A UNION ALL query would be perfect here.
                    // For example:
                    // SELECT MaterialName as 'Item', QuantityInStock as 'Quantity', 'Raw Material' as 'Type' FROM RawMaterials
                    // UNION ALL
                    // SELECT ProductName as 'Item', QuantityInStock as 'Quantity', 'Finished Product' as 'Type' FROM FinishedProducts;
                    MessageBox.Show("Récupération de l'inventaire complet des stocks...");
                    break;

                case "Bilan de production du mois en cours":
                    // TODO: Write a SQL query to select all records from ProductionLog
                    // where the ProductionDate is within the current month.
                    // You would join with the FinishedProducts table to get the product name.
                    MessageBox.Show("Récupération du bilan de production du mois en cours...");
                    break;

                case "Les 100 derniers mouvements logistiques":
                    // TODO: Write a SQL query to select the TOP 100 records from the Transfers table,
                    // ordered by TransferDate descending.
                    MessageBox.Show("Récupération de la liste des 100 derniers mouvements logistiques...");
                    break;

                case "Liste des matières premières uniquement":
                    // TODO: Write a simple SQL query: SELECT * FROM RawMaterials;
                    MessageBox.Show("Récupération de la liste des matières premières...");
                    break;

                case "Liste des produits finales uniquement":
                    // TODO: Write a simple SQL query: SELECT * FROM FinishedProducts;
                    MessageBox.Show("Récupération de la liste des produits finis...");
                    break;
            }

            // After you get the data from the database into a DataTable (reportData),
            // you will display it in the grid like this:
            // dgvReportData.DataSource = reportData;
        }

        private void cmbReportList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}