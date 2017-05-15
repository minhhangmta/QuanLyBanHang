using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanHang.DAL;
namespace QuanLyBanHang.BUS
{
    class StatisticBus
    {
        private DataClasses1DataContext dbContext;

        public StatisticBus()
        {
            this.dbContext = new DataClasses1DataContext();
        }


    }
}
