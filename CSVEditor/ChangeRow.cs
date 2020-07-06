using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSVEditor
{
    public partial class ChangeRow : Form
    {
        private readonly int recordIndex = -1;

        public ChangeRow()
        {
            InitializeComponent();

            Text = "Добавить элемент";
        }

        public ChangeRow(int index, ClientInfo editingData)
        {
            InitializeComponent();

            Text = "Изменить элемент";

            recordIndex = index;

            idInput.Value = editingData.Id;
            clientTextbox.Text = editingData.Client;
            datePicker.Value = editingData.InsertDate;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            ClientInfo newInfo = new ClientInfo(
                Convert.ToInt32(idInput.Value),
                clientTextbox.Text,
                datePicker.Value
            );

            if (recordIndex == -1)
            {
                DataHandler.AddRow(newInfo);
            } else
            {
                DataHandler.UpdateRow(recordIndex, newInfo);
            }

            ((MainForm)Application.OpenForms["MainForm"]).UpdateTable();

            Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
