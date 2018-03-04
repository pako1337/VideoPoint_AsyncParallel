using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;

namespace VideoPoint_WinFormsAsynAwait
{
    public partial class MostEffectiveSalesPersonForm : Form
    {
        private const string ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=AdventureWorks2017;Data Source=localhost\\SQLEXPRESS";
        private BackgroundWorker backgroundWorker = new BackgroundWorker();

        public MostEffectiveSalesPersonForm()
        {
            InitializeComponent();
            backgroundWorker.DoWork += ReportBuildBackground;
            backgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
        }

        private void btnReportBuild_Click(object sender, EventArgs e)
        {
            using (var connection = CreateOpenConnection())
            {
                var command = GetReportQuery(connection);
                var result = command.ExecuteReader();

                var dataTable = new DataTable();
                dataTable.Load(result);
                grid.DataSource = dataTable;
            }
        }

        private DataTable backgroundReportResult;
        private void ReportBuildBackground(object sender, DoWorkEventArgs args)
        {
            using (var connection = CreateOpenConnection())
            {
                var command = GetReportQuery(connection);
                var result = command.ExecuteReader();

                backgroundReportResult = new DataTable();
                backgroundReportResult.Load(result);
            }
        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            grid.DataSource = backgroundReportResult;
        }

        private void btnBackground_Click(object sender, EventArgs e)
        {
            grid.DataSource = null;
            backgroundWorker.RunWorkerAsync();
        }

        private void btnIAsyncResult_Click(object sender, EventArgs e)
        {
            grid.DataSource = null;
            using (var connection = CreateOpenConnection())
            {
                connection.Open();
                var command = GetReportQuery(connection);

                var asyncReportRunning = command.BeginExecuteReader();
                while (!asyncReportRunning.IsCompleted)
                {
                }

                var dataTable = new DataTable();
                dataTable.Load(command.EndExecuteReader(asyncReportRunning));
                grid.DataSource = dataTable;
            }
        }

        Thread reportingThread;
        DataTable newThreadResult;
        bool newThreadResultApplied;
        System.Windows.Forms.Timer applyNewThreadResultWhenReady;
        private void btnNewThread_Click(object sender, EventArgs e)
        {
            grid.DataSource = null;
            newThreadResult = null;
            newThreadResultApplied = false;
            reportingThread = new Thread(NewThreadReporting);
            reportingThread.Start();

            applyNewThreadResultWhenReady = new System.Windows.Forms.Timer();
            applyNewThreadResultWhenReady.Interval = 500;
            applyNewThreadResultWhenReady.Tick += (s, args) =>
            {
                if (!newThreadResultApplied && newThreadResult != null)
                {
                    grid.DataSource = newThreadResult;
                    newThreadResultApplied = true;
                    applyNewThreadResultWhenReady.Stop();
                }

            };
            applyNewThreadResultWhenReady.Start();
        }

        private void NewThreadReporting()
        {
            using (var connection = CreateOpenConnection())
            {
                var command = GetReportQuery(connection);
                var result = command.ExecuteReader();

                var resultTable = new DataTable();
                resultTable.Load(result);

                newThreadResult = resultTable;
            }
        }

        private void btnSynchronisationContext_Click(object sender, EventArgs e)
        {
            grid.DataSource = null;
            var syncContext = SynchronizationContext.Current;
            ThreadPool.QueueUserWorkItem(_ =>
            {
                using (var connection = CreateOpenConnection())
                {
                    var command = GetReportQuery(connection);
                    var result = command.ExecuteReader();

                    var resultTable = new DataTable();
                    resultTable.Load(result);

                    syncContext.Post(__ => grid.DataSource = resultTable, null);
                }
            });
        }

        private void btnBeginInvoke_Click(object sender, EventArgs e)
        {
            grid.DataSource = null;
            var syncContext = SynchronizationContext.Current;
            ThreadPool.QueueUserWorkItem(_ =>
            {
                using (var connection = CreateOpenConnection())
                {
                    var command = GetReportQuery(connection);
                    var result = command.ExecuteReader();

                    var resultTable = new DataTable();
                    resultTable.Load(result);

                    grid.BeginInvoke((Action)(() => grid.DataSource = resultTable));
                }
            });
        }

        private async void btnAsync_Click(object sender, EventArgs e)
        {
            grid.DataSource = null;
            using (var connection = CreateOpenConnection())
            {
                var command = GetReportQuery(connection);
                var result = await command.ExecuteReaderAsync();

                var resultTable = new DataTable();
                resultTable.Load(result);

                grid.DataSource = resultTable;
            }
        }

        private static SqlCommand GetReportQuery(SqlConnection connection)
        {
            var commandText = System.IO.File.ReadAllText("BestSellingProducts.sql");
            var command = new SqlCommand(commandText);
            command.Connection = connection;

            return command;
        }

        private SqlConnection CreateOpenConnection()
        {
            var connection = new SqlConnection(ConnectionString);
            connection.Open();

            return connection;
        }
    }
}
