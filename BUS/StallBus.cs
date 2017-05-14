using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static QuanLyBanHang.Utils.Utils;
using QuanLyBanHang.DAL;
namespace QuanLyBanHang.BUS
{
    class StallBus
    {
        private DataClasses1DataContext dbContext;

        public StallBus()
        {
            this.dbContext = new DataClasses1DataContext();
        }

        public List<DataItem> getListDataItemStall()
        {
            List<Stall> listStall = dbContext.Stalls.ToList();
            List<DataItem> list = new List<DataItem>();

            foreach (Stall stall in listStall)
            {
                DataItem item = new DataItem()
                {
                    Value = stall.Id,
                    Name = stall.Name
                };
                list.Add(item);
            }

            return list;
        }
    }
}
