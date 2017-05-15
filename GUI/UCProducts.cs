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
using QuanLyBanHang.BUS;

namespace QuanLyBanHang.GUI
{
    public partial class UCProducts : UserControl
    {
        private DataClasses1DataContext dbContext;
        private ProductsBus productsBus;
        public UCProducts()

        {
            InitializeComponent();
            dbContext = new DataClasses1DataContext();
            productsBus = new ProductsBus();
            LoadData();
        }
        public void LoadData()
        {
            DataTable dt = productsBus.getDataTableProducts();
            dgvProducts.DataSource = dt;

        }
    }
}
