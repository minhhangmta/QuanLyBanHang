using QuanLyBanHang.GUI;
using QuanLyBanHang.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class FormMain : Form
    {

        private UCStaff ucStaff;
        private UCCustomer ucCustomer;
        private UCStatistic ucStatistic; 
        public FormMain()
        {
            InitializeComponent();
            ucStaff = new UCStaff();
            ucCustomer = new UCCustomer();
            ucStatistic = new UCStatistic();
        }

        public void AddNewTab(UserControl userControl)
        {

            foreach (TabPage tab in tabControl.TabPages)
            {
                if (tab.Name == userControl.Name)
                {
                    tabControl.SelectedTab = tab;
                    return;
                }
            }

            userControl.Dock = DockStyle.Fill;
            TabPage newTab = new TabPage(userControl.AccessibleDescription + "         ");//Create new tabpage , set name tab
            newTab.Controls.Add(userControl);
            newTab.Name = userControl.Name;
            tabControl.TabPages.Add(newTab);
            tabControl.SelectedTab = newTab;
        }


        private Bitmap img = Properties.Resources.close;
        private void tabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
                e.Graphics.DrawImage(img, new Point(e.Bounds.Right - 18, e.Bounds.Top + 1));
                e.Graphics.DrawString(this.tabControl.TabPages[e.Index].Text, e.Font, Brushes.Black, e.Bounds.Left + 3, e.Bounds.Top + 4);
                e.DrawFocusRectangle();
        }

        private void tabControl_MouseDown(object sender, MouseEventArgs e)
        {

            Rectangle r = tabControl.GetTabRect(this.tabControl.SelectedIndex);
            Rectangle closeButton = new Rectangle(r.Right - 15, r.Top + 4, 9, 7);
            if (closeButton.Contains(e.Location))
            {
                
                this.tabControl.TabPages.Remove(this.tabControl.SelectedTab);
            }
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewTab(ucStaff);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            AddNewTab(ucCustomer);
        }

        private void btnStatisByDay_Click(object sender, EventArgs e)
        {
            AddNewTab(ucStatistic);
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewTab(ucStatistic);
        }
    }
}
