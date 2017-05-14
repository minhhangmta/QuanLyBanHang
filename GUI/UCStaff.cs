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
        private string acction = "";
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
            dtgStaff.Columns["Stall"].Visible = false;
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

        public void enableButton(bool bol)
        {
            btnDelete.Enabled = bol;
            btnEdit.Enabled = bol;
            btnSave.Enabled = bol;
            btnCancel.Enabled = bol;
        }

        private void dtgStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                List<DataItem> listCbbStaff = stallBus.getListDataItemStall();
                txtId.Text = dtgStaff.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                txtName.Text = dtgStaff.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                txtAddress.Text = dtgStaff.Rows[e.RowIndex].Cells["Address"].Value.ToString();
                txtPhone.Text = dtgStaff.Rows[e.RowIndex].Cells["Phone"].Value.ToString();
                txtPosition.Text = dtgStaff.Rows[e.RowIndex].Cells["Position"].Value.ToString();
                dtpBirthDay.Text = dtgStaff.Rows[e.RowIndex].Cells["Date"].Value.ToString();
                txtSarary.Text = dtgStaff.Rows[e.RowIndex].Cells["Salary"].Value.ToString();
                Utils.Utils.LoadNameFromID(cbbStall, int.Parse(dtgStaff.Rows[e.RowIndex].Cells["IdStall"].Value.ToString()), listCbbStaff);
            }
            catch (Exception er)
            {
                Console.Write(er.Message);
            }
        }

        //private void LoadNameFromID(ComboBox cbb, int id, List<DataItem> list)
        //{
        //    // cbb.DataSource = list;
        //    LoadComboboxData(cbb, list);
        //    int i = 0;
        //    foreach (DataItem item in list)
        //    {
        //        if (item.Value == id)
        //        {
        //            cbb.SelectedIndex = i;
        //            return;
        //        }
        //        i++;
        //    }
        //}

        //private void LoadComboboxData(ComboBox cbb, List<DataItem> list)
        //{
        //    cbb.DataSource = list;
        //    cbb.ValueMember = "Value";
        //    cbb.DisplayMember = "Name";
        //}

        private void btnAdd_Click(object sender, EventArgs e)
        {
            setEnableToolBox(true);
            Utils.Utils.LoadComboboxData(cbbStall, stallBus.getListDataItemStall());
            acction = "add";
            ClearTextBox();
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnAdd.Enabled = false;
        }

        private Staff getStaff()
        {

            Staff staff = new Staff()
            {
                Name = txtName.Text,
                Address = txtAddress.Text,
                Position = txtPosition.Text,
                Date = dtpBirthDay.Value,
                Salary = decimal.Parse(txtSarary.Text),
                Phone = txtPhone.Text,
                IdStall = int.Parse(cbbStall.SelectedValue.ToString())
            };
            return staff;
        }

        private void ClearTextBox()
        {
            txtName.Text = "";
            txtPhone.Text = "";
            txtPosition.Text = "";
            txtSarary.Text = "";
            txtAddress.Text = "";
            Utils.Utils.LoadComboboxData(cbbStall, stallBus.getListDataItemStall());
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!checkData())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ các trường!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int result = -1;
            if (acction.Contains("add"))
            {
                result = staffBus.SaveStaff(getStaff());
                if (result == 1)
                {
                    MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTextBox();
                    LoadData();
                    setEnableToolBox(false);
                    btnAdd.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Lưu không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (acction.Contains("edit"))
            {
                Staff staff = getStaff();
                staff.Id = int.Parse(txtId.Text);
                result = staffBus.EditStaff(staff);
                if (result == 1)
                {
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTextBox();
                    LoadData();
                    setEnableToolBox(false);
                    btnAdd.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Sửa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        public bool checkData()
        {
            if (txtName.Text == "" || txtPosition.Text == ""
                || txtAddress.Text == "" || txtSarary.Text == "")
                return false;
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            setEnableToolBox(false);
            ClearTextBox();
            btnAdd.Enabled = true;
        }

        private void dtgStaff_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var ht = dtgStaff.HitTest(e.X, e.Y);
                // See if the user right-clicked over the header of the last column.
                if ((ht.ColumnIndex == dtgStaff.Columns.Count - 1)
                     && (ht.Type == DataGridViewHitTestType.ColumnHeader))
                {
                    // This positions the menu at the mouse's location.
                    contextMenuStrip1.Show(MousePosition);
                }
            }
        }

        private void dtgStaff_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var ht = dtgStaff.HitTest(e.X, e.Y);
                // See if the user right-clicked over the header of the last column.
                if ((ht.ColumnIndex == dtgStaff.Columns.Count - 1)
                     && (ht.Type == DataGridViewHitTestType.ColumnHeader))
                {
                    // This positions the menu at the mouse's location.
                    contextMenuStrip1.Show(MousePosition);
                }
            }
        }



        private void dtgStaff_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dtgStaff.Columns[e.ColumnIndex].Name == "IdStall")
            {
                if (e.Value != null)
                {
                    foreach (Stall stall in stallBus.getListStall())
                    {
                        if (e.Value.ToString() == stall.Id.ToString())
                        {
                            e.Value = stall.Name;
                        }
                    }

                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            acction = "edit";
            setEnableToolBox(true);
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Staff staff = getStaff();
            staff.Id = int.Parse(txtId.Text);
            DialogResult res = MessageBox.Show("Xóa nhân viên : " + staff.Name, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            {
                if (res == DialogResult.OK)
                {
                    int result = staffBus.DeleteStaff(staff);
                    if (result == 1)
                    {
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearTextBox();
                        LoadData();
                        setEnableToolBox(false);
                        btnAdd.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void txtSarary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable result = staffBus.Search(txtKeySearch.Text);
            if(result == null || result.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy kết quả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblResult.Text = "0";
                return;
            }
            lblResult.Text = result.Rows.Count.ToString();
            dtgStaff.DataSource = result;
        }
    }
}
