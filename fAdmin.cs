using DoAn_31211027580.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_31211027580
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
            LoadDoanhThu();
        }
        #region Method
        void LoadDoanhThu()
        {
            dataGridDThu.DataSource = DoanhThuDAO.Instance.DoanhThuTable();
            
        }
        #endregion
        #region Envent
        private void fAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quan_Ly_Ban_HangDataSet.USP_BillReport' table. You can move, or remove it, as needed.
            this.uSP_BillReportTableAdapter.Fill(this.quan_Ly_Ban_HangDataSet.USP_BillReport);
            // TODO: This line of code loads data into the 'quan_Ly_Ban_HangDataSet1.USP_BillReport' table. You can move, or remove it, as needed.


            this.reportViewer1.RefreshReport();
        }
        #region BillTab
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dateTime = Convert.ToDateTime(dateTimePicker1.Text);

            dataGridDThu.DataSource = DoanhThuDAO.Instance.FindBillByDate(dateTime);
        }
        private void dataGridDThu_DataSourceChanged(object sender, EventArgs e)
        {
            int total = 0;
            foreach (DataGridViewRow row in dataGridDThu.Rows)
            {
                int colIndex = dataGridDThu.Columns["Thành tiền"].Index;
                if (row.Cells[4].Value != null) total += Convert.ToInt32(row.Cells[colIndex].Value.ToString());
            }
            lblTotalValue.Text = total.ToString();
        }

        private void btAll_Click(object sender, EventArgs e)
        {
            dataGridDThu.DataSource = DoanhThuDAO.Instance.DoanhThuTable();
        }
        private void dataGridDThu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow =e.RowIndex;
            if (Char.IsDigit(dataGridDThu.Rows[numrow].Cells[0].Value.ToString()[0]))
            {
                if (numrow >= 0)
                {
                    int billID = (int)dataGridDThu.Rows[numrow].Cells[0].Value;
                    dataGridDThu.DataSource = null;
                    dataGridDThu.DataSource = OrderDAO.Instance.GetOrder(billID);
                }
            }
        }
        #endregion

        #region AccTab
        #endregion

        #region CustomerTab
        #endregion

        #endregion
    }
}
