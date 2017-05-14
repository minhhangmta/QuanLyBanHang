using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanHang.DAL;
using QuanLyBanHang.Utils;
using System.Data;
using System.Windows.Forms;
using static QuanLyBanHang.Utils.Utils;

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

        public int SaveStaff(Staff staff)
        {
            try
            { 
            dbContext.Staffs.InsertOnSubmit(staff);
            dbContext.SubmitChanges();
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                return -1;
            }
            return 1;
        }

       
    }
}
