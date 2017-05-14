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
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khoHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tácVuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lậpHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lậpPhiếuNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lậpPhiếuXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theoNgàyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theoThángToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theoQuýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theoNămToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.kháchHàngToolStripMenuItem,
            this.sảnPhẩmToolStripMenuItem,
            this.khoHàngToolStripMenuItem});
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
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.Image = global::QuanLyBanHang.Properties.Resources.cusommer;
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kháchHàngToolStripMenuItem.Text = "Khách hàng";
            // 
            // sảnPhẩmToolStripMenuItem
            // 
            this.sảnPhẩmToolStripMenuItem.Image = global::QuanLyBanHang.Properties.Resources.packing;
            this.sảnPhẩmToolStripMenuItem.Name = "sảnPhẩmToolStripMenuItem";
            this.sảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sảnPhẩmToolStripMenuItem.Text = "Sản phẩm";
            // 
            // khoHàngToolStripMenuItem
            // 
            this.khoHàngToolStripMenuItem.Image = global::QuanLyBanHang.Properties.Resources.Shipping6;
            this.khoHàngToolStripMenuItem.Name = "khoHàngToolStripMenuItem";
            this.khoHàngToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.khoHàngToolStripMenuItem.Text = "Kho hàng";
            // 
            // tácVuToolStripMenuItem
            // 
            this.tácVuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lậpHóaĐơnToolStripMenuItem,
            this.lậpPhiếuNhậpToolStripMenuItem,
            this.lậpPhiếuXuấtToolStripMenuItem});
            this.tácVuToolStripMenuItem.Image = global::QuanLyBanHang.Properties.Resources.major;
            this.tácVuToolStripMenuItem.Name = "tácVuToolStripMenuItem";
            this.tácVuToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.tácVuToolStripMenuItem.Text = "Nghiệp vụ";
            // 
            // lậpHóaĐơnToolStripMenuItem
            // 
            this.lậpHóaĐơnToolStripMenuItem.Image = global::QuanLyBanHang.Properties.Resources.Sales_by_Payment_Method_rep;
            this.lậpHóaĐơnToolStripMenuItem.Name = "lậpHóaĐơnToolStripMenuItem";
            this.lậpHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.lậpHóaĐơnToolStripMenuItem.Text = "Hóa đơn";
            // 
            // lậpPhiếuNhậpToolStripMenuItem
            // 
            this.lậpPhiếuNhậpToolStripMenuItem.Image = global::QuanLyBanHang.Properties.Resources.move_file_arrow_import_left_document;
            this.lậpPhiếuNhậpToolStripMenuItem.Name = "lậpPhiếuNhậpToolStripMenuItem";
            this.lậpPhiếuNhậpToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.lậpPhiếuNhậpToolStripMenuItem.Text = "Phiếu nhập";
            // 
            // lậpPhiếuXuấtToolStripMenuItem
            // 
            this.lậpPhiếuXuấtToolStripMenuItem.Image = global::QuanLyBanHang.Properties.Resources.export;
            this.lậpPhiếuXuấtToolStripMenuItem.Name = "lậpPhiếuXuấtToolStripMenuItem";
            this.lậpPhiếuXuấtToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.lậpPhiếuXuấtToolStripMenuItem.Text = "Phiếu xuất";
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.theoNgàyToolStripMenuItem,
            this.theoThángToolStripMenuItem,
            this.theoQuýToolStripMenuItem,
            this.theoNămToolStripMenuItem});
            this.thốngKêToolStripMenuItem.Image = global::QuanLyBanHang.Properties.Resources.chart;
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // theoNgàyToolStripMenuItem
            // 
            this.theoNgàyToolStripMenuItem.Image = global::QuanLyBanHang.Properties.Resources.calendar_icon_1487803_960_720;
            this.theoNgàyToolStripMenuItem.Name = "theoNgàyToolStripMenuItem";
            this.theoNgàyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.theoNgàyToolStripMenuItem.Text = "Theo ngày";
            // 
            // theoThángToolStripMenuItem
            // 
            this.theoThángToolStripMenuItem.Image = global::QuanLyBanHang.Properties.Resources.calendar_selection_day_icon;
            this.theoThángToolStripMenuItem.Name = "theoThángToolStripMenuItem";
            this.theoThángToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.theoThángToolStripMenuItem.Text = "Theo tháng";
            // 
            // theoQuýToolStripMenuItem
            // 
            this.theoQuýToolStripMenuItem.Name = "theoQuýToolStripMenuItem";
            this.theoQuýToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.theoQuýToolStripMenuItem.Text = "Theo quý";
            // 
            // theoNămToolStripMenuItem
            // 
            this.theoNămToolStripMenuItem.Image = global::QuanLyBanHang.Properties.Resources.Calender_2017;
            this.theoNămToolStripMenuItem.Name = "theoNămToolStripMenuItem";
            this.theoNămToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.theoNămToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.theoNămToolStripMenuItem.Text = "Theo năm";
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
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khoHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lậpHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lậpPhiếuNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lậpPhiếuXuấtToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem theoNgàyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem theoThángToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem theoQuýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem theoNămToolStripMenuItem;
    }
}

