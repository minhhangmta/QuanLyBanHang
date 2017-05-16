using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanHang.DAL;
using System.Data;

namespace QuanLyBanHang.BUS
{
    class BillBus
    {
        private DataClasses1DataContext dbContext;

        
        public BillBus()
        {
            this.dbContext = new DataClasses1DataContext();
        }

        public DataTable getDataTableBill()
        {
            return Utils.Utils.ToDataTable(dbContext.Bills.ToList());
        }
    }
}
