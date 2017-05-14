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
        }

        public void LoadData()
        {
            DataTable dt = Utils.Utils.ToDataTable(dbContext.Staffs.ToList());
            dtgStaff.DataSource = dt;
        }
    }
}
