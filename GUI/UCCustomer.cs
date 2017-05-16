using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanHang.BUS;
using QuanLyBanHang.DAL;

namespace QuanLyBanHang.UI
{
    public partial class UCCustomer : UserControl
    {

        private CustomerBus customerBus;
        private static int acction;

        public UCCustomer()
        {
            InitializeComponent();
            customerBus = new CustomerBus();

            LoadData();
        }

        public void LoadData()
        {
            DataTable dt = customerBus.getDataTableCustomer();
            dtgCustomer.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnAdd.Enabled = false;
            ClearTextBox();
            acction = 1;  // add
            enableTextBox(true);
        }

        public void ClearTextBox()
        {
            txtAddress.Text = "";
            txtId.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
        }

        public Customer getCustomer()
        {
            string gender;
            if(rbtMale.Checked == true){
                gender = "Nam";
            }
            else{
                gender = "Nữ";
            }
            Customer customer = new Customer()
            {
                Name = txtName.Text,
                Address = txtAddress.Text,
                PhoneNumber = txtPhone.Text,
                Gender = gender,
                Date = dtpBirthDay.Value
            };
            return customer;
        }

        public bool isValid()
        {
            if (txtAddress.Text == "" || txtName.Text == "" || txtPhone.Text == "")
                return false;
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!isValid())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            if (acction == 1)
            {
                int result = customerBus.AddCustomer(getCustomer());
                if(result == 1){
                    MessageBox.Show("Thêm khách hàng thành công!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    ClearTextBox();
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;
                    btnAdd.Enabled = true;
                    LoadData();
                    enableTextBox(false);
                } else{
                    MessageBox.Show("Thêm khách hàng không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (acction == 2)
            {
                Customer customer = getCustomer();
                customer.Id = int.Parse(txtId.Text);
                int result = customerBus.EditCustomer(customer);
                if (result == 1)
                {
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTextBox();
                    LoadData();
                    enableTextBox(false);
                    btnAdd.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Sửa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearTextBox();
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            enableTextBox(false);
            btnAdd.Enabled = true;
        }

        private void enableTextBox(bool bol)
        {
            txtName.Enabled = bol;
            txtAddress.Enabled = bol;
            txtPhone.Enabled = bol;
            rbtMale.Enabled = bol;
            rbtFemal.Enabled = bol;
            dtpBirthDay.Enabled = bol;
        }

        private void UCCustomer_Load(object sender, EventArgs e)
        {

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Customer customer = getCustomer();
            customer.Id = int.Parse(txtId.Text);
            DialogResult res = MessageBox.Show("Xóa khách hàng : " + customer.Name, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            {
                if (res == DialogResult.OK)
                {
                    int result = customerBus.DeleteCustomer(customer);
                    if (result == 1)
                    {
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearTextBox();
                        LoadData();
                        enableTextBox(false);
                        btnAdd.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dtgCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
               
                txtId.Text = dtgCustomer.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                txtName.Text = dtgCustomer.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                txtAddress.Text = dtgCustomer.Rows[e.RowIndex].Cells["Address"].Value.ToString();
                txtPhone.Text = dtgCustomer.Rows[e.RowIndex].Cells["PhoneNumber"].Value.ToString();
                dtpBirthDay.Text = dtgCustomer.Rows[e.RowIndex].Cells["Date"].Value.ToString();
                if (dtgCustomer.Rows[e.RowIndex].Cells["Gender"].Value.ToString().Contains("Nam")){
                    rbtMale.Checked = true;
                }
                else{
                    rbtFemal.Checked = false;
                }
            }
            catch (Exception er)
            {
                Console.Write(er.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            acction = 2;
            enableTextBox(true);
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void btnEditCMS_Click(object sender, EventArgs e)
        {

        }
    }
}
