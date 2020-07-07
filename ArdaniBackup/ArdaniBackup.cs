using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArdaniBackup
{
    public partial class ArdaniBackup : Form
    {
        private DataRow dataRow;
        public ArdaniBackup()
        {
            InitializeComponent();
        }

        private void ArdaniBackup_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;

           // DataGridViewRow row = (DataGridViewRow)dataBackup.Rows[1].Clone();
            //dataBackup.Rows.Add(row);
        }

        public void addNewRow(DataGridView dg, int rowNumber)
        {
            dataRow = new DataRow();
            DataGridViewRow newRow = (DataGridViewRow)dg.Rows[rowNumber].Clone();
        //    newRow.Cells["colType"]
            

        }
    }
}
