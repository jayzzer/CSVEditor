using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSVEditor
{
    public partial class Loader : Form
    {
        public Loader()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Loader_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar.Value++;
            if (progressBar.Value == 60)
            {
                ((MainForm)Application.OpenForms["MainForm"]).LoadFile();
                Close();
            }
        }
    }
}
