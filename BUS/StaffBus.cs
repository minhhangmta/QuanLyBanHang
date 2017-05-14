using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanHang.DAL;
using QuanLyBanHang.Utils;
using System.Data;

namespace QuanLyBanHang.BUS
{
    class StaffBus
    {
        private DataClasses1DataContext dbContext;

        public StaffBus()
        {
            dbContext = new DataClasses1DataContext();
        }

        public List<Staff> getListStaff()
        {
            return dbContext.Staffs.ToList();
        }

        public DataTable getDataTableStaff()
        {
           return  Utils.Utils.ToDataTable(dbContext.Staffs.ToList());
        } 
    }
}
