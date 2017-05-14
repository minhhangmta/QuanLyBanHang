namespace QuanLyBanHang
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.btnProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.btnResponsitory = new System.Windows.Forms.ToolStripMenuItem();
            this.tácVuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBill = new System.Windows.Forms.ToolStripMenuItem();
            this.btnImport = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExport = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStatisByDay = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStatisByMonth = new System.Windows.Forms.ToolStripMenuItem();
            this.theoQuýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStatisByYear = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhMụcToolStripMenuItem,
            this.tácVuToolStripMenuItem,
            this.thốngKêToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(786, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tabControl
            // 
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl.Location = new System.Drawing.Point(0, 24);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(786, 508);
            this.tabControl.TabIndex = 1;
            this.tabControl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl_DrawItem);
            this.tabControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabControl_MouseDown);
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhânViênToolStripMenuItem,
            this.btnCustomer,
            this.btnProduct,
            this.btnResponsitory});
            this.danhMụcToolStripMenuItem.Image = global::QuanLyBanHang.Properties.Resources.book;
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.danhMụcToolStripMenuItem.Text = "Danh mục";
            // 
            // nhânViênToolStripMenuItem
            // 
            this.nhânViênToolStripMenuItem.Image = global::QuanLyBanHang.Properties.Resources.staff;
            this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nhânViênToolStripMenuItem.Text = "Nhân viên";
            this.nhânViênToolStripMenuItem.Click += new System.EventHandler(this.nhânViênToolStripMenuItem_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Image = global::QuanLyBanHang.Properties.Resources.cusommer;
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(152, 22);
            this.btnCustomer.Text = "Khách hàng";
            // 
            // btnProduct
            // 
            this.btnProduct.Image = global::QuanLyBanHang.Properties.Resources.packing;
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(152, 22);
            this.btnProduct.Text = "Sản phẩm";
            // 
            // btnResponsitory
            // 
            this.btnResponsitory.Image = global::QuanLyBanHang.Properties.Resources.Shipping6;
            this.btnResponsitory.Name = "btnResponsitory";
            this.btnResponsitory.Size = new System.Drawing.Size(152, 22);
            this.btnResponsitory.Text = "Kho hàng";
            // 
            // tácVuToolStripMenuItem
            // 
            this.tácVuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBill,
            this.btnImport,
            this.btnExport});
            this.tácVuToolStripMenuItem.Image = global::QuanLyBanHang.Properties.Resources.major;
            this.tácVuToolStripMenuItem.Name = "tácVuToolStripMenuItem";
            this.tácVuToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.tácVuToolStripMenuItem.Text = "Nghiệp vụ";
            // 
            // btnBill
            // 
            this.btnBill.Image = global::QuanLyBanHang.Properties.Resources.Sales_by_Payment_Method_rep;
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(152, 22);
            this.btnBill.Text = "Hóa đơn";
            // 
            // btnImport
            // 
            this.btnImport.Image = global::QuanLyBanHang.Properties.Resources.move_file_arrow_import_left_document;
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(152, 22);
            this.btnImport.Text = "Phiếu nhập";
            // 
            // btnExport
            // 
            this.btnExport.Image = global::QuanLyBanHang.Properties.Resources.export;
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(152, 22);
            this.btnExport.Text = "Phiếu xuất";
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnStatisByDay,
            this.btnStatisByMonth,
            this.theoQuýToolStripMenuItem,
            this.btnStatisByYear});
            this.thốngKêToolStripMenuItem.Image = global::QuanLyBanHang.Properties.Resources.chart;
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // btnStatisByDay
            // 
            this.btnStatisByDay.Image = global::QuanLyBanHang.Properties.Resources.calendar_icon_1487803_960_720;
            this.btnStatisByDay.Name = "btnStatisByDay";
            this.btnStatisByDay.Size = new System.Drawing.Size(152, 22);
            this.btnStatisByDay.Text = "Theo ngày";
            // 
            // btnStatisByMonth
            // 
            this.btnStatisByMonth.Image = global::QuanLyBanHang.Properties.Resources.calendar_selection_day_icon;
            this.btnStatisByMonth.Name = "btnStatisByMonth";
            this.btnStatisByMonth.Size = new System.Drawing.Size(152, 22);
            this.btnStatisByMonth.Text = "Theo tháng";
            // 
            // theoQuýToolStripMenuItem
            // 
            this.theoQuýToolStripMenuItem.Name = "theoQuýToolStripMenuItem";
            this.theoQuýToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.theoQuýToolStripMenuItem.Text = "Theo quý";
            // 
            // btnStatisByYear
            // 
            this.btnStatisByYear.Image = global::QuanLyBanHang.Properties.Resources.Calender_2017;
            this.btnStatisByYear.Name = "btnStatisByYear";
            this.btnStatisByYear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnStatisByYear.Size = new System.Drawing.Size(152, 22);
            this.btnStatisByYear.Text = "Theo năm";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 532);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý bán hàng siêu thị";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tácVuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnCustomer;
        private System.Windows.Forms.ToolStripMenuItem btnProduct;
        private System.Windows.Forms.ToolStripMenuItem btnResponsitory;
        private System.Windows.Forms.ToolStripMenuItem btnBill;
        private System.Windows.Forms.ToolStripMenuItem btnImport;
        private System.Windows.Forms.ToolStripMenuItem btnExport;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnStatisByDay;
        private System.Windows.Forms.ToolStripMenuItem btnStatisByMonth;
        private System.Windows.Forms.ToolStripMenuItem theoQuýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnStatisByYear;
    }
}

