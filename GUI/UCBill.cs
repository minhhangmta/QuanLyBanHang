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

namespace QuanLyBanHang.GUI
{
    public partial class UCBill : UserControl
    {
        private BillBus billBus;
        private StaffBus staffBus;
        private CustomerBus customerBus;
        public UCBill()
        {
            InitializeComponent();
            billBus = new BillBus();
            staffBus = new StaffBus();
            customerBus = new CustomerBus();

            LoadData();
        }

        public void LoadData()
        {
            dtgBill.DataSource = billBus.getDataTableBill();
            dtgBill.Columns["Staff"].Visible = false;
            dtgBill.Columns["Customer"].Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void dtgBill_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dtgBill.Columns[e.ColumnIndex].Name == "IdStaff")
            {
                if (e.Value != null)
                {
                    foreach (Staff staff in staffBus.getListStaff())
                    {
                        if (e.Value.ToString() == staff.Id.ToString())
                        {
                            e.Value = staff.Name;
                        }
                    }

                }
            }
            if (this.dtgBill.Columns[e.ColumnIndex].Name == "IdCustomer")
            {
                if (e.Value != null)
                {
                    foreach (Customer customer in customerBus.getListCustomer())
                    {
                        if (e.Value.ToString() == customer.Id.ToString())
                        {
                            e.Value = customer.Name;
                        }
                    }

                }
            }
        }

        private void dtgBill_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                var hti = dtgBill.HitTest(e.X, e.Y);
                dtgBill.ClearSelection();
                dtgBill.Rows[hti.RowIndex].Selected = true;
                contextMenuStrip1.Show(dtgBill, new Point(e.X, e.Y));
            }
        }

        private void btnEditCMS_Click(object sender, EventArgs e)
        {
            int index = dtgBill.CurrentCell.RowIndex;
            txtId.Text = index.ToString();
        }
    }
}
