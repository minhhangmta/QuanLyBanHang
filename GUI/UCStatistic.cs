using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using QuanLyBanHang.BUS;
using QuanLyBanHang.VO;

namespace QuanLyBanHang.GUI
{
    public partial class UCStatistic : UserControl
    {
        private StatisticBus statisticBus;
        public UCStatistic()
        {
            InitializeComponent();
            statisticBus = new StatisticBus();
            initChart();
        }

        public void initChart()
        {
            List<StatisticObj> listStatistic = statisticBus.getListStatisticByDay();

            foreach (StatisticObj item in listStatistic)
            {
                chart1.Series["Tổng nhập"].Points.AddXY
                               (item.Date.Day, item.TotalImport / 1000);
                chart1.Series["Tổng thu"].Points.AddXY
                                  (item.Date.Day, item.TotalSell / 1000);
                //chart1.Series["Tổng lãi"].Points.AddXY
                //                  (item.Date.Day, item.TotalRevenue);
            }

        }


        public void LoadData()
        {

        }

        private void btnByDay_Click(object sender, EventArgs e)
        {
            resetValueChart();
            List<StatisticObj> listStatistic = statisticBus.getListStatisticByDay();

            foreach (StatisticObj item in listStatistic)
            {
                chart1.Series["Tổng nhập"].Points.AddXY
                               (item.Date.Day, item.TotalImport / 1000);
                chart1.Series["Tổng thu"].Points.AddXY
                                  (item.Date.Day, item.TotalSell / 1000);
                //chart1.Series["Tổng lãi"].Points.AddXY
                //                  (item.Date.Day, item.TotalRevenue);
            }
        }

        private void resetValueChart()
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
        }

        private void btnByMonth_Click(object sender, EventArgs e)
        {
            resetValueChart();
            List<StatisticObj> listStatistic = statisticBus.getListStatisticByMonth();
            foreach (StatisticObj item in listStatistic)
            {
                chart1.Series["Tổng nhập"].Points.AddXY
                               (item.Date.Month, item.TotalImport / 1000);
                chart1.Series["Tổng thu"].Points.AddXY
                                  (item.Date.Month, item.TotalSell / 1000);
                //chart1.Series["Tổng lãi"].Points.AddXY
                //                  (item.Date.Day, item.TotalRevenue);
            }
        }

        private void btnByYear_Click(object sender, EventArgs e)
        {
            resetValueChart();
            List<StatisticObj> listStatistic = statisticBus.getListStatisticByYear();
            foreach (StatisticObj item in listStatistic)
            {
                chart1.Series["Tổng nhập"].Points.AddXY
                               (item.Date.Year, item.TotalImport / 1000);
                chart1.Series["Tổng thu"].Points.AddXY
                                  (item.Date.Year, item.TotalSell / 1000);
                //chart1.Series["Tổng lãi"].Points.AddXY
                //                  (item.Date.Day, item.TotalRevenue);
            }
        }
    }
}
