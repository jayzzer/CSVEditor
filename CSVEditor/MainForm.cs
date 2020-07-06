using CsvHelper.TypeConversion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSVEditor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void csvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            DataGridViewCellCollection rowData = csvData.Rows[e.RowIndex].Cells;
            int recordIndex = e.RowIndex;
            ClientInfo editingData = new ClientInfo(
                (int)rowData["id"].Value,
                (string)rowData["client"].Value,
                DateTime.Parse((string)rowData["insertDate"].Value)
            );

            ChangeRow changeRow = new ChangeRow(recordIndex, editingData);
            changeRow.Show();
        }

        private void importMenuBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();
            switch (result)
            {
                case DialogResult.OK:
                    Loader loader = new Loader();
                    loader.Show();

                    break;
            }
        }

        public void LoadFile()
        {
            string filename = openFileDialog.FileName;
            try
            {
                DataHandler.ReadFile(filename);
            }
            catch (IOException)
            {
                MessageBox.Show("Не удалось открыть файл", "Ошибка чтения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (TypeConverterException)
            {
                MessageBox.Show("Неправильный тип поля", "Ошибка чтения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            UpdateTable();

            addBtn.Enabled = deleteBtn.Enabled = prevPageBtn.Enabled = nextPageBtn.Enabled = true;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            ChangeRow changeRow = new ChangeRow();
            changeRow.Show();
        }

        private void DeleteSelectedRows()
        {
            DataGridViewSelectedRowCollection selected = csvData.SelectedRows;
            if (selected.Count == 0) return;

            DataHandler.DeleteRows(selected[0]);

            UpdateTable();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DeleteSelectedRows();
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DeleteSelectedRows();
            }
        }

        private void prevPageBtn_Click(object sender, EventArgs e)
        {
            DataHandler.SetCurrentPage(DataHandler.GetCurrentPage() - 1);
        }

        private void nextPageBtn_Click(object sender, EventArgs e)
        {
            DataHandler.SetCurrentPage(DataHandler.GetCurrentPage() + 1);
        }

        public void UpdatePageNumView()
        {
            pageNumber.Text = DataHandler.GetCurrentPage().ToString();

            int currentPage = DataHandler.GetCurrentPage();

            prevPageBtn.Enabled = nextPageBtn.Enabled = true;
            if (currentPage == 1)
            {
                prevPageBtn.Enabled = false;
            }
            if (currentPage == DataHandler.MaxPage)
            {
                nextPageBtn.Enabled = false;
            }
        }

        public void UpdateTable()
        {
            csvData.Rows.Clear();

            foreach (ClientInfo clientInfo in DataHandler.GetParsedData(DataHandler.GetCurrentPage()))
            {
                csvData.Rows.Add(clientInfo.Id, clientInfo.Client, clientInfo.InsertDate.ToString(new CultureInfo("de-DE")));
            }
        }
    }
}
