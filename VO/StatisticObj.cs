using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.VO
{
    public class StatisticObj
    {
            public decimal TotalImport { get; set; }
            public decimal TotalSell { get; set; }
            public decimal TotalRevenue { get; set; }
            public DateTime Date { get; set; }
    }
}
