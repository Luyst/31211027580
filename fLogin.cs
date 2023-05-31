using DoAn_31211027580.DAO;
using System;
using System.Windows.Forms;

namespace DoAn_31211027580
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }
        #region Method
        #endregion
        #region Events
        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btLogin_Click(object sender, EventArgs e)
        {
            string userName = txtTKhoan.Text;
            string userPass = txtMkhau.Text;

            if (Login(userName, userPass))
            {
                fSell fSell = new fSell(userName, userPass);
                this.Hide();
                fSell.ShowDialog();
                fSell.WindowState = FormWindowState.Maximized;

                this.Show();
            }
            else
            {
                MessageBox.Show("Bạn đã nhập sai mật khẩu hoặc tên đăng nhập", "Đăng nhập thất bại", MessageBoxButtons.OK);
            }
        }
        public bool Login(string username, string password)
        {
            return AccountDAO.Instance.LoginAccept(username, password);
        }
        #endregion
    }
}
