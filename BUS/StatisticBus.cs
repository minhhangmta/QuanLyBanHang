using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanHang.DAL;
using QuanLyBanHang.Utils;
using QuanLyBanHang.VO;

namespace QuanLyBanHang.BUS
{
    class StatisticBus
    {
        private DataClasses1DataContext dbContext;

        public StatisticBus()
        {
            this.dbContext = new DataClasses1DataContext();
        }

        public List<StatisticObj> getListStatisticByDay()
        {
            DateTime date = DateTime.Now;
            List<Import> listImport = dbContext.Imports.Where(m => m.Date.Month == date.Month).ToList();
            List<Bill> listBill = dbContext.Bills.Where(m => m.Date.Month == date.Month).ToList();
            List<StatisticObj> listStatistic = new List<StatisticObj>();

            for(int i = 1; i <= 31; i++)
            {
                StatisticObj statistic = new StatisticObj();
                statistic.Date = new DateTime(date.Year,date.Month,i);

                Import import = getImportByDay(i,listImport);
                if (import == null){
                    statistic.TotalImport = 0;
                }else{
                    statistic.TotalImport = import.GrandTotal;
                }
                Bill bill = getBillByDay(i,listBill);
                if(bill == null){
                    statistic.TotalSell = 0;
                }else{
                    statistic.TotalSell = bill.GrandTotal;
                }
                statistic.TotalRevenue = statistic.TotalSell - statistic.TotalImport;

                listStatistic.Add(statistic);
            }
            return listStatistic;
        }

        private Import getImportByDay(int day, List<Import> list)
        {
            foreach (Import import in list)
            {
                if (import.Date.Day == day)
                    return import;
            }
            return null;
        }

        private Bill getBillByDay(int day, List<Bill> list)
        {
            foreach (Bill bill in list)
            {
                if (bill.Date.Day == day)
                    return bill;
            }
            return null;

        }


        private decimal getTotalImportByMonth(int month, List<Import> list)
        {
            List<Import> listImport = new List<Import>();
            decimal total = 0;
            foreach (Import import in list)
            {
                if (import.Date.Month == month)
                    total += import.GrandTotal;
                     
            }
            return total;
        }


        private decimal getTotalBillByMonth(int month, List<Bill> list)
        {
            decimal total = 0;
            foreach (Bill bill in list)
            {
                if (bill.Date.Month == month)
                    total += bill.GrandTotal;
            }
            return total;
        }

        public List<StatisticObj> getListStatisticByMonth()
        {
            DateTime date = DateTime.Now;
            List<Import> listImport = dbContext.Imports.Where(m => m.Date.Year == date.Year).ToList();
            List<Bill> listBill = dbContext.Bills.Where(m => m.Date.Year == date.Year).ToList();
            List<StatisticObj> listStatistic = new List<StatisticObj>();

            for (int i = 1; i <= 12; i++)
            {
                StatisticObj statistic = new StatisticObj();
                statistic.Date = new DateTime(date.Year,i,1);

                statistic.TotalImport = getTotalImportByMonth(i,listImport);
                statistic.TotalSell = getTotalBillByMonth(i,listBill);
                statistic.TotalRevenue = statistic.TotalSell - statistic.TotalImport;

                listStatistic.Add(statistic);
            }
            return listStatistic;
        }

        private decimal getTotalImportByYear(int year,List<Import> list)
        {
            decimal total = 0;
            foreach (Import import in list)
            {
                if (import.Date.Year == year)
                    total += import.GrandTotal;
            }
            return total;
        }


        private decimal getTotalBillByYear(int year,List<Bill> list)
        {
            decimal total = 0;
            foreach (Bill bill in list)
            {
                if (bill.Date.Year == year)
                    total += bill.GrandTotal;
            }
            return total;
        }


        // 5 year ago from now
        public List<StatisticObj> getListStatisticByYear()
        {
            DateTime date = DateTime.Now;
            List<Import> listImport = dbContext.Imports.ToList();
            List<Bill> listBill = dbContext.Bills.ToList();
            List<StatisticObj> listStatistic = new List<StatisticObj>();

            for (int i = 2015; i <= 2017; i++)
            {
                StatisticObj statistic = new StatisticObj();
                statistic.Date = new DateTime(i, 1, 1);

                statistic.TotalImport = getTotalImportByYear(i,listImport);
                statistic.TotalSell = getTotalBillByYear(i,listBill);
                statistic.TotalRevenue = statistic.TotalSell - statistic.TotalImport;
                listStatistic.Add(statistic);
            }
            return listStatistic;
        }
    }
}
