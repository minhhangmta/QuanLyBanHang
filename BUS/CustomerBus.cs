using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanHang.DAL;
using System.Data;

namespace QuanLyBanHang.BUS
{
   
    class CustomerBus
    {
        private DataClasses1DataContext dbContext;

        public CustomerBus()
        {
            this.dbContext = new DataClasses1DataContext();
        }

        public List<Customer> getListCustomer()
        {
            return dbContext.Customers.ToList();
        }

        public DataTable getDataTableCustomer()
        {
            return Utils.Utils.ToDataTable(getListCustomer());
        }

        public int AddCustomer(Customer customer)
        {
            try
            {
                dbContext.Customers.InsertOnSubmit(customer);
                dbContext.SubmitChanges();
            }catch(Exception e)
            {
                return -1;
            }
            return 1;
        }

        public int DeleteCustomer(Customer cus)
        {
            try
            {
                Customer customer = dbContext.Customers.Single(s => s.Id == cus.Id);
                dbContext.Customers.DeleteOnSubmit(customer);
                dbContext.SubmitChanges();
            }
            catch (Exception e)
            {
                return -1;
            }
            return 1;
        }

        public int EditCustomer(Customer cus)
        {
            try
            {
                Customer customer = dbContext.Customers.Single(m => m.Id == cus.Id);
                customer.Name = cus.Name;
                customer.Address = cus.Address;
                customer.Date = cus.Date;
                customer.PhoneNumber = cus.PhoneNumber;
                customer.Gender = cus.Gender;
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
