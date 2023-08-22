using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace S.H.I.E.L.D_Server
{
    public partial class MainForm : Form
    {
        private Thread communicationThread;
        private DecisionTreeClassifier classifier;
        private bool activityFlag = false;
        private bool statusFlag = false;
        public List<string[]> dataRows = new List<string[]>();

        public MainForm(DecisionTreeClassifier classifier)
        {
            this.classifier = classifier;

            InitializeComponent();
            stopDataSniffing.Enabled = false;
            TableInitialization();
            InitializeSearchComponents();

            communicationThread = new Thread(HandleCommunication);
            communicationThread.Start();
        }

        private void HandleCommunication()
        {
            Server server = new Server(classifier, this);

            while (true)
            {
                if (activityFlag)
                {
                    server.EstablishConnection();
                }

                Thread.Sleep(100);
            }
        }

        private void TableInitialization()
        {
            GridView.Columns.Add("ID", "ID");
            GridView.Columns.Add("DestinationIP", "Destination IP");
            GridView.Columns.Add("DestinationPort", "Destination Port");
            GridView.Columns.Add("AvgForwardSegmentSize", "Average Forward Segment Size");
            GridView.Columns.Add("MaxPacketLength", "Max Packet Length");
            GridView.Columns.Add("MinPacketLength", "Min Packet Length");
            GridView.Columns.Add("TotalLengthForward", "Total Length (Forward)");
            GridView.Columns.Add("TotalLengthBackward", "Total Length (Backward)");
            GridView.Columns.Add("Classification", "Classification");
            GridView.Columns.Add("Data", "Data");

            // Set the AutoSizeMode to fill for each column
            foreach (DataGridViewColumn column in GridView.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void InitializeSearchComponents()
        {
            List<string> columnNames = GridView.Columns.Cast<DataGridViewColumn>()
                            .Select(column => column.HeaderText)
                            .ToList();
            columnNames.Insert(0, "Select column");
            columnsList.DataSource = columnNames;
            columnsList.SelectedIndex = 0;
        }

        public void AddNewRow(string[] newRow)
        {
            dataRows.Add(newRow);

            if (statusFlag)
            {
                Invoke((MethodInvoker)GetFilteredRows);
            }
            else
            {
                Invoke((MethodInvoker)LoadDataRow);
            }
        }

        private void LoadDataRow()
        {
            GridView.Rows.Clear();

            for (int index = 0; index < dataRows.Count; index++)
            {
                string[] rowData = dataRows[index];

                GridView.Rows.Add(rowData);

                string classification = rowData[rowData.Length - 2];
                Color rowColor = classification == "Malicious" ? Color.Red : Color.Green;
                GridView.Rows[index].DefaultCellStyle.BackColor = rowColor;
            }

            GridView.FirstDisplayedScrollingRowIndex = GridView.RowCount - 1;
        }

        private void GetFilteredRows()
        {
            string columnName = columnsList.SelectedItem.ToString();
            string value = searchValue.Text;

            List<string[]> filteredRows = new List<string[]>();

            if (string.IsNullOrEmpty(columnName) || string.IsNullOrEmpty(value))
            {
                filteredRows = dataRows;
            }
            else
            {
                foreach (string[] rowData in dataRows)
                {
                    if (rowData.Length >= 9 && rowData[Array.IndexOf(GridView.Columns.Cast<DataGridViewColumn>().Select(column => column.HeaderText).ToArray(), columnName)].Equals(value))
                    {
                        filteredRows.Add(rowData);
                    }
                }
            }

            GridView.Rows.Clear();

            for (int index = 0; index < filteredRows.Count; index++)
            {
                string[] rowData = filteredRows[index];

                GridView.Rows.Add(rowData);
                string classification = rowData[rowData.Length - 2];
                Color rowColor = classification == "Malicious" ? Color.Red : Color.Green;
                GridView.Rows[index].DefaultCellStyle.BackColor = rowColor;
            }

            GridView.FirstDisplayedScrollingRowIndex = GridView.RowCount - 1;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            statusFlag = true;
            GetFilteredRows();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            statusFlag = false;

            columnsList.SelectedIndex = 0;
            searchValue.Text = string.Empty;

            LoadDataRow();
        }

        private void startDataSniffing_Click(object sender, EventArgs e)
        {
            activityFlag = true;

            startDataSniffing.Enabled = false;
            stopDataSniffing.Enabled = true;
        }

        private void stopDataSniffing_Click(object sender, EventArgs e)
        {
            activityFlag = false;

            stopDataSniffing.Enabled = false;
            startDataSniffing.Enabled = true;
        }
    }
}