using QuanLyBanHang.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static QuanLyBanHang.Utils.Utils;

namespace QuanLyBanHang.BUS
{
    class ProductsBus
    {
        private DataClasses1DataContext dbContext;
        public ProductsBus()
        {
            dbContext = new DataClasses1DataContext();
        }
        public List<Product> getListProduct()
        {
            return dbContext.Products.ToList();
        }
        public DataTable getDataTableProducts()
        {
            List<Product> list = dbContext.Products.ToList();
            return Utils.Utils.ToDataTable(list);
        }

    }
}
