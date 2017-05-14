using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanHang.DAL;
using QuanLyBanHang.Utils;

namespace QuanLyBanHang.UI
{
    public partial class UCStaff : UserControl
    {
        private DataClasses1DataContext dbContext;
        public UCStaff()
        {
            InitializeComponent();
            dbContext = new DataClasses1DataContext();
            LoadData();
            setEnableToolBox(false);
            initButton();
        }

        private void initButton()
        {
            btnAdd.Enabled = true;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnSearch.Enabled = true;
        }

        public void LoadData()
        {
            DataTable dt = Utils.Utils.ToDataTable(dbContext.Staffs.ToList());
            dtgStaff.DataSource = dt;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        public void setEnableToolBox(bool bol)
        {
            txtName.Enabled = bol;
            txtAddress.Enabled = bol;
            txtPhone.Enabled = bol;
            txtPosition.Enabled = bol;
            txtSarary.Enabled = bol;
            dtpBirthDay.Enabled = bol;
            cbbStaff.Enabled = bol;
        }
    }
}
