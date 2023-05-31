using DoAn_31211027580.DAO;
using DoAn_31211027580.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;


namespace DoAn_31211027580
{
    public partial class fSell : Form
    {
        private string userName, password;
        public fSell(string userName,string password)
        {
            InitializeComponent();
            LoadMenu();
            LoadcmbCategory();
            LoadcmbGoods();
            this.userName=userName; this.password=password;
        }
        #region Method
        void LoadMenu()
        {
            dgvMenu.DataSource = GoodsDAO.Instance.GetMenuList();
        }
        void LoadcmbCategory()
        {
            List<GoodsCategoryDTO> list = GoodsCategoryDAO.Instance.GetListCategory();
            cmbCategory.DataSource = list;
            cmbCategory.DisplayMember = "Name";
            cmbCategory.Text = null;
        }
        void LoadcmbGoods()
        {
            List<GoodsDTO> list = GoodsDAO.Instance.GetGoodsList();
            cmbGoods.DataSource = list;
            cmbGoods.DisplayMember = "Name";
            cmbGoods.Text = null;
        }
        public bool CheckAdmin(string userName,string password)
        {
            return AccountDAO.Instance.CheckAdmin(userName,password);
        }

        #endregion
        #region Event
        #region OrderEvent
        private void btThem_Click(object sender, EventArgs e)
        {
            int bId, count;
            float price;
            string nameGood = cmbGoods.Text;
            if (nameGood != "")
            {
                string gID = GoodsDAO.Instance.GetGoods(nameGood).ID.ToString();
                if ((int)numQuanlity.Value == 0) //Kiểm tra số lượng món
                {
                    MessageBox.Show("Số lượng không thể bằng không", "Thêm món thất bại", MessageBoxButtons.OK);
                }
                else
                {
                    if (dgvOrder.Rows.Count == 0)
                    //Kiểm tra xem có bill nào đang order không
                    //Nếu không thì khỏi tạo bill mới

                    {
                        string accID = AccountDAO.Instance.AccCurrent(userName, password).Id.ToString();
                        BillDAO.Instance.BillInssert(accID);
                        bId = BillDAO.Instance.GetCurrentBill().ID;
                        price = GoodsDAO.Instance.GetGoods(nameGood).Price;
                        count = (int)numQuanlity.Value;
                        Bill_InforDAO.Instance.Insert_Bill_Infor(bId, gID, count);
                        lblMaBillValue.Text = bId.ToString();
                        dgvOrder.DataSource = OrderDAO.Instance.GetOrder(bId);
                    }
                    else //Nếu có thì thêm món vào bill 
                    {
                        int check = 0;
                        for (int run = 0; run < dgvOrder.Rows.Count - 1; run++)
                        {
                            if (dgvOrder.Rows[run].Cells[0].Value.ToString() == gID)
                            {
                                check++;
                                break;
                            }
                        }
                        // Kiểm tra món đã có trong bill chưa 
                        if (check == 0) //chưa có thì thêm vào
                        {
                            bId = BillDAO.Instance.GetCurrentBill().ID;
                            price = GoodsDAO.Instance.GetGoods(nameGood).Price;
                            count = (int)numQuanlity.Value;
                            Bill_InforDAO.Instance.Insert_Bill_Infor(bId, gID, count);
                            dgvOrder.DataSource = OrderDAO.Instance.GetOrder(bId);
                        }
                        else // đã có thì chỉ thêm số lượng
                        {
                            bId = BillDAO.Instance.GetCurrentBill().ID;
                            price = GoodsDAO.Instance.GetGoods(nameGood).Price;
                            count = (int)numQuanlity.Value;
                            Bill_InforDAO.Instance.AddQuanlityOrder(gID, count, bId);
                            dgvOrder.DataSource = OrderDAO.Instance.GetOrder(bId);
                        }

                    }
                    //Cập nhật tiền hàng
                    lbSoTienHang.Text = OrderDAO.Instance.TotalOrder(bId).ToString();
                    lbSoThanhTien.Text = (OrderDAO.Instance.TotalOrder(bId) - Convert.ToDouble(lbSoGiamGia.Text)).ToString();
                    dgvMenu.DataSource = GoodsDAO.Instance.GetMenuList();
                    cmbCategory.Text = "";
                    cmbGoods.Text = "";
                }
            }
        }
        private void dgvMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            if (numrow >= 0)
            {
                cmbGoods.Text = dgvMenu.Rows[numrow].Cells[1].Value.ToString();
                cmbCategory.Text = dgvMenu.Rows[numrow].Cells[2].Value.ToString();
            }
        }

        //Chọn món hiển thị theo loại
        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string category = cmbCategory.Text;
            if (category != "DoAn_mau.DTO.GoodsCategoryDTO" && category != "")
            {
                dgvMenu.DataSource = GoodsDAO.Instance.GetMenuListByCategory(category);
            }
            else { dgvMenu.DataSource = GoodsDAO.Instance.GetMenuList(); }
        }
        private void btThanhToan_Click(object sender, EventArgs e)
        {
            dgvOrder.DataSource = null;
            lbSoThanhTien.Text = "0";
            lbSoTienHang.Text = "0";
            lblMaBillValue.Text = "0";
        }
        private void cmbGoods_KeyPress(object sender, KeyPressEventArgs e)
        {
            string goodName = cmbGoods.Text;
            if (goodName != "DoAn_mau.DTO.GoodsDTO" && goodName != "" && goodName != null)
            {
                dgvMenu.DataSource = GoodsDAO.Instance.GetMenuByName(goodName);
            }
            else { dgvMenu.DataSource = GoodsDAO.Instance.GetMenuList(); }
        }
        #endregion
        #region EventOther
        private void fSell_Load(object sender, EventArgs e)
        {
            string accName = AccountDAO.Instance.AccCurrent(userName, password).DisplayName.ToString();
            tàiKhoảnĐăngNhậpToolStripMenuItem.Text = "Xin chào " + accName;
        }
        private void fSell_Close(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đăng xuất.", "Thông báo", MessageBoxButtons.YesNo) != System.Windows.Forms.DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Kiểm tra quyền Admin
            if(CheckAdmin(userName,password))
            {
                fAdmin fAdmin = new fAdmin();
                this.Hide();
                fAdmin.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Bạn chưa được cấp phép truy cập.","Thao tác thất bại",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccountDetail fAccountDetail = new fAccountDetail(userName, password);
            this.Hide();
            fAccountDetail.ShowDialog();
            this.Show();
        }
        #endregion
        #endregion
    }
}