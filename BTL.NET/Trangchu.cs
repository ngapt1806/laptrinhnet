using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL.NET
{
    public partial class Trangchu: Form
    {
        public Trangchu()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Trangchu_Load(object sender, EventArgs e)
        {
            Class.Functions.ketnoi();
        }

        private void samphamToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void khachangToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nhanvienToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hoadonbanhangToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hoadonnhaphangToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void timkiemhoadonbanhangToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void baocaobanhangToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void baocaodoanhthuStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void baocaosanphambanchayToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Ví dụ: quay về form đăng nhập hoặc thoát chương trình
                this.Hide(); // ẩn form hiện tại
                             // hoặc Application.Exit(); để thoát chương trình hoàn toàn
            }
        }
    }
}
