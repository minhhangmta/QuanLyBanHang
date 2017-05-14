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
using static QuanLyBanHang.Utils.Utils;
using QuanLyBanHang.BUS;

namespace QuanLyBanHang.UI
{
    public partial class UCStaff : UserControl
    {
        private DataClasses1DataContext dbContext;
        private StallBus stallBus;
        private StaffBus staffBus;
        public UCStaff()
        {
            InitializeComponent();

            dbContext = new DataClasses1DataContext();
            stallBus = new StallBus();
            staffBus = new StaffBus();

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
            DataTable dt = staffBus.getDataTableStaff();
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
            cbbStall.Enabled = bol;
        }

        private void dtgStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                List<DataItem> listCbbStaff = stallBus.getListDataItemStall();
                txtId.Text = dtgStaff.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                txtName.Text = dtgStaff.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                txtAddress.Text = dtgStaff.Rows[e.RowIndex].Cells["Address"].Value.ToString();
                txtPhone.Text = dtgStaff.Rows[e.RowIndex].Cells["Phone"].Value.ToString();
                txtPosition.Text = dtgStaff.Rows[e.RowIndex].Cells["Position"].Value.ToString();
                dtpBirthDay.Text = dtgStaff.Rows[e.RowIndex].Cells["Date"].Value.ToString();
                txtSarary.Text = dtgStaff.Rows[e.RowIndex].Cells["Salary"].Value.ToString();
                LoadNameFromID(cbbStall, int.Parse(dtgStaff.Rows[e.RowIndex].Cells["IdStall"].Value.ToString()), listCbbStaff);
            }
            catch (Exception er)
            {
                Console.Write(er.Message);
            }
        }

        private void LoadNameFromID(ComboBox cbb, int id, List<DataItem> list)
        {
            // cbb.DataSource = list;
            LoadComboboxData(cbb, list);
            int i = 0;
            foreach (DataItem item in list)
            {
                if (item.Value == id)
                {
                    cbb.SelectedIndex = i;
                    return;
                }
                i++;
            }
        }

        private void LoadComboboxData(ComboBox cbb, List<DataItem> list)
        {
            cbb.DataSource = list;
            cbb.ValueMember = "Value";
            cbb.DisplayMember = "Name";
        }
    }
}
