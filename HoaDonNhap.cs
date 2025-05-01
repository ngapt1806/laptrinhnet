using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baocao
{
    public partial class HoaDonNhap : Form
    {
        public HoaDonNhap()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void HoaDonNhap_Load(object sender, EventArgs e)
        {
            try
            {
                loadDataToGridView();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loadDataToGridView()
        {

            string sql = "Select * from HoaDonNhap";
            DataTable dt = function.LoadDataToTable(sql);
            dataGridViewHĐN.DataSource = dt;
            if (dataGridViewHĐN.Columns.Count >= 4)
            {
                dataGridViewHĐN.Columns[0].HeaderText = "Số hóa đơn nhập ";
                dataGridViewHĐN.Columns[1].HeaderText = "Mã nhân viên ";
                dataGridViewHĐN.Columns[2].HeaderText = "Ngày nhập";
                dataGridViewHĐN.Columns[3].HeaderText = "Mã nhà cung cấp";
                dataGridViewHĐN.Columns[4].HeaderText = "Tổng tiền";
                dataGridViewHĐN.Columns[0].Width = 150;
                dataGridViewHĐN.Columns[1].Width = 120;
                dataGridViewHĐN.Columns[2].Width = 120;
                dataGridViewHĐN.Columns[3].Width = 120;
                dataGridViewHĐN.Columns[4].Width = 120;
                dataGridViewHĐN.AllowUserToAddRows = false; // Không cho người dùng thêm dòng mới
                dataGridViewHĐN.EditMode = DataGridViewEditMode.EditProgrammatically; // Không cho phép chỉnh sửa
                int sumSoluongHĐ = dataGridViewHĐN.Rows.Count;
                lblTongHĐ.Text = " Số lượng hóa đơn :" + sumSoluongHĐ;

            }

            dataGridViewHĐN.AllowUserToAddRows = false;
        }
        private void dataGridViewHĐN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frmChitietHĐN = new ChitietHĐN();
            a.Show();

        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string sql;
            if((txtkhoangbd.Text != "") && (txtkhoangkt.Text == ""))
            {
                MessageBox.Show("Hãy nhập khoảng tiền tối đa muốn tìm kiếm ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtkhoangkt.Focus();
                return;
            }
            if (txtkhoangbd.Text == "" && txtkhoangkt.Text != "")
            {
                MessageBox.Show("Hãy nhập khoảng tiền tối thiểu muốn tìm kiếm ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtkhoangbd.Focus();
                return;
            }
            if(txtkhoangbd.Text != "" && txtkhoangkt.Text != "") && Convert.ToInt32(txtkhoangbd.Text) >= Convert.ToInt32(txtkhoangkt.Text))
            {
                MessageBox.Show("Khoảng tiền tối thiểu không được lớn hơn khoảng tiền tối đa ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtkhoangbd.Focus();
                return;
            }
            if(mskdenngay)
            {
                
            }
        }
    }
}
