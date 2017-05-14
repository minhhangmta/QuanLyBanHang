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
            List<Staff> list = dbContext.Staffs.ToList();
            return Utils.Utils.ToDataTable(list);
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

        public int EditStaff(Staff st)
        {
            try
            {
                Staff staff = dbContext.Staffs.Single(m => m.Id == st.Id);
                staff.Name = st.Name;
                staff.Address = st.Address;
                staff.Date = st.Date;
                staff.Salary = st.Salary;
                staff.IdStall = st.IdStall;
                staff.Position = st.Position;
                dbContext.SubmitChanges();
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                return -1;
            }
            return 1;
        }

        public int DeleteStaff(Staff st)
        {
            try
            {
                Staff staff = dbContext.Staffs.Single(s => s.Id == st.Id);
                dbContext.Staffs.DeleteOnSubmit(staff);
                dbContext.SubmitChanges();
            }
            catch (Exception e)
            {
                return -1;
            }
            return 1;
        }

        public DataTable Search(string key)
        {
            if (key == null || key == "")
                return null;
            List<Staff> list;
            try
            {
                int x = int.Parse(key);
                Decimal sa = decimal.Parse(key);
                list = dbContext.Staffs.Where(m => m.Id == int.Parse(key)
                                                    || m.Name.Contains(key)
                                                    || m.Address.Contains(key)
                                                    || m.Salary == sa
                                                    || m.Phone.Contains(key)
                                                    || m.Position.Contains(key)).ToList();
            }
            catch (Exception e)
            {
                list = dbContext.Staffs.Where(m => m.Name.Contains(key)
                                                    || m.Address.Contains(key)
                                                    || m.Phone.Contains(key)
                                                    || m.Position.Contains(key)).ToList();
            }
        
            return Utils.Utils.ToDataTable(list);
        }
       
    }
}
