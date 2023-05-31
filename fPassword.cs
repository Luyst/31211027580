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
    public partial class fPassword : Form
    {
        private string username;
        private string password;
        public fPassword(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;   
        }
        #region Method
        #endregion
        #region Events
        private void fPassword_Load(object sender, EventArgs e)
        {
            txtTenDangNhap.Text = username;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            password = AccountDAO.Instance.AccCurrent(username).Password.ToString();
            if(txtMkCu.Text!= password)
            {
                MessageBox.Show("Mật khẩu đăng nhập chưa chính xác!","Đổi mật khẩu thất bại",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
            else if(txtNhapLai.Text!=txtMkMoi.Text || txtNhapLai.Text==null ||txtMkMoi.Text==null)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!", "Đổi mật khẩu thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txtMkCu.Text == password && txtNhapLai.Text == txtMkMoi.Text)
            {
                if (MessageBox.Show("Bạn có chắc chắn đổi mật khẩu!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    bool complete = AccountDAO.Instance.ChangePass(username, txtMkMoi.Text);
                    if (complete)
                    {
                        MessageBox.Show("Đổi mật khẩu thành công", "Thông bảo", MessageBoxButtons.OK);
                    }
                }
                
            }
        }
        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
    }
}
