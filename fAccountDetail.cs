using DoAn_31211027580.DAO;
using DoAn_31211027580.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_31211027580
{
    public partial class fAccountDetail : Form
    {
        private string username; 
        private string password;
        public fAccountDetail(string userName, string password)
        {
            InitializeComponent();
            this.username = userName;
            LoadAcc(userName, password);
            this.password = password;
        }
        #region Method
        void LoadAcc(string userName,string password) 
        {
            AccountDTO acc =AccountDAO.Instance.AccCurrent(userName, password);
            string displayName = acc.DisplayName;
            int type = acc.Type;
            lblAccShow.Text = userName;
            lblNameShow.Text = displayName;
            lblTypeShow.Text = (type==0)?"Nhân viên thu ngân":"Admin quản lý";
            lblDoanhThuShow.Text = LoadDoanhThuPerson(userName, password).ToString();

        }
        public int LoadDoanhThuPerson(string userName,string password) 
        {
            return DoanhThuDAO.Instance.DoanhThuPerson(userName, password);
        }
        #endregion
        #region Event

        private void btChangeMk_Click(object sender, EventArgs e)
        {
            fPassword fPassword = new fPassword(username,password);
            this.Hide();
            fPassword.ShowDialog();
            this.Show();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
    }
}
