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

        private void csvData_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ChangeRow changeRow = new ChangeRow();
            changeRow.Show();
        }

        private void importMenuBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();
            switch (result)
            {
                case DialogResult.OK:
                    string filename = openFileDialog.FileName;
                    try
                    {
                        DataHandler.ReadFile(filename);

                        int rowsCount = DataHandler.GetRowsCount();
                        for (int i = 0; i < rowsCount; i++)
                        {
                            ClientInfo clientInfo = DataHandler.GetRow(i);
                            csvData.Rows.Add(clientInfo.Id, clientInfo.Client, clientInfo.InsertDate.ToString(new CultureInfo("de-DE")));
                        }
                    } catch (IOException)
                    {
                        MessageBox.Show("Не удалось открыть файл", "Ошибка чтения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }
        }
    }
}
