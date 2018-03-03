using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VideoPoint_WinFormsAsynAwait
{
    public partial class MostEffectiveSalesPersonForm : Form
    {
        private BackgroundWorker backgroundWorker = new BackgroundWorker();

        public MostEffectiveSalesPersonForm()
        {
            InitializeComponent();
            backgroundWorker.DoWork += ReportBuildBackground;
            backgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
        }

        private void btnReportBuild_Click(object sender, EventArgs e)
        {
            resultGrid.DataSource = null;

            var command = new SqlCommand(
                @"SELECT top 50000 *
                  FROM Production.TransactionHistory th
                  INNER JOIN Production.TransactionHistoryArchive tha ON th.Quantity = tha.Quantity
                  INNER JOIN Production.Product prod ON prod.ProductId = th.ProductID
                  WHERE th.TransactionDate > '2014-08-02'");

            using (var connection = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=AdventureWorks2017;Data Source=localhost\\SQLEXPRESS"))
            {
                connection.Open();

                command.Connection = connection;
                var result = command.ExecuteReader();

                var dataTable = new DataTable();
                dataTable.Load(result);
                resultGrid.DataSource = dataTable;
            }
        }

        private DataTable backgroundReportResult;
        private void ReportBuildBackground(object sender, DoWorkEventArgs args)
        {
            var command = new SqlCommand(
                @"SELECT top 50000 *
                  FROM Production.TransactionHistory th
                  INNER JOIN Production.TransactionHistoryArchive tha ON th.Quantity = tha.Quantity
                  INNER JOIN Production.Product prod ON prod.ProductId = th.ProductID
                  WHERE th.TransactionDate > '2014-08-02'");

            using (var connection = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=AdventureWorks2017;Data Source=localhost\\SQLEXPRESS"))
            {
                connection.Open();

                command.Connection = connection;
                var result = command.ExecuteReader();

                backgroundReportResult = new DataTable();
                backgroundReportResult.Load(result);
            }
        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            resultGrid.DataSource = backgroundReportResult;
        }

        private void btnBackground_Click(object sender, EventArgs e)
        {
            resultGrid.DataSource = null;
            backgroundWorker.RunWorkerAsync();
        }
    }
}
