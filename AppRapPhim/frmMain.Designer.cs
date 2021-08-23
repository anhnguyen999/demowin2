namespace AppRapPhim
{
    partial class frmMain
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
            this.hỆTHỐNGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.bÁNVÉToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qUẢNLÝHÓAĐƠNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qUẢNLÝKHÁCHHÀNGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pHÂNQUYỀNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.xUẤTHÓAĐƠNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xUẤTDOANHTHUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hỆTHỐNGToolStripMenuItem,
            this.menuQuanLy,
            this.menuBaoCao});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(990, 62);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hỆTHỐNGToolStripMenuItem
            // 
            this.hỆTHỐNGToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDangNhap,
            this.menuDangXuat});
            this.hỆTHỐNGToolStripMenuItem.Name = "hỆTHỐNGToolStripMenuItem";
            this.hỆTHỐNGToolStripMenuItem.Size = new System.Drawing.Size(234, 58);
            this.hỆTHỐNGToolStripMenuItem.Text = "HỆ THỐNG";
            // 
            // menuDangNhap
            // 
            this.menuDangNhap.Name = "menuDangNhap";
            this.menuDangNhap.Size = new System.Drawing.Size(364, 62);
            this.menuDangNhap.Text = "ĐĂNG NHẬP";
            this.menuDangNhap.Click += new System.EventHandler(this.ĐĂNGNHẬPToolStripMenuItem_Click);
            // 
            // menuDangXuat
            // 
            this.menuDangXuat.Name = "menuDangXuat";
            this.menuDangXuat.Size = new System.Drawing.Size(364, 62);
            this.menuDangXuat.Text = "ĐĂNG XUẤT";
            this.menuDangXuat.Click += new System.EventHandler(this.MenuDangXuat_Click);
            // 
            // menuQuanLy
            // 
            this.menuQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bÁNVÉToolStripMenuItem,
            this.qUẢNLÝHÓAĐƠNToolStripMenuItem,
            this.qUẢNLÝKHÁCHHÀNGToolStripMenuItem,
            this.pHÂNQUYỀNToolStripMenuItem});
            this.menuQuanLy.Name = "menuQuanLy";
            this.menuQuanLy.Size = new System.Drawing.Size(202, 58);
            this.menuQuanLy.Text = "QUẢN LÝ";
            // 
            // bÁNVÉToolStripMenuItem
            // 
            this.bÁNVÉToolStripMenuItem.Name = "bÁNVÉToolStripMenuItem";
            this.bÁNVÉToolStripMenuItem.Size = new System.Drawing.Size(561, 62);
            this.bÁNVÉToolStripMenuItem.Text = "BÁN VÉ";
            this.bÁNVÉToolStripMenuItem.Click += new System.EventHandler(this.OpenBanVe_Click);
            // 
            // qUẢNLÝHÓAĐƠNToolStripMenuItem
            // 
            this.qUẢNLÝHÓAĐƠNToolStripMenuItem.Name = "qUẢNLÝHÓAĐƠNToolStripMenuItem";
            this.qUẢNLÝHÓAĐƠNToolStripMenuItem.Size = new System.Drawing.Size(561, 62);
            this.qUẢNLÝHÓAĐƠNToolStripMenuItem.Text = "QUẢN LÝ HÓA ĐƠN";
            // 
            // qUẢNLÝKHÁCHHÀNGToolStripMenuItem
            // 
            this.qUẢNLÝKHÁCHHÀNGToolStripMenuItem.Name = "qUẢNLÝKHÁCHHÀNGToolStripMenuItem";
            this.qUẢNLÝKHÁCHHÀNGToolStripMenuItem.Size = new System.Drawing.Size(561, 62);
            this.qUẢNLÝKHÁCHHÀNGToolStripMenuItem.Text = "QUẢN LÝ KHÁCH HÀNG";
            this.qUẢNLÝKHÁCHHÀNGToolStripMenuItem.Click += new System.EventHandler(this.QUẢNLÝKHÁCHHÀNGToolStripMenuItem_Click);
            // 
            // pHÂNQUYỀNToolStripMenuItem
            // 
            this.pHÂNQUYỀNToolStripMenuItem.Name = "pHÂNQUYỀNToolStripMenuItem";
            this.pHÂNQUYỀNToolStripMenuItem.Size = new System.Drawing.Size(561, 62);
            this.pHÂNQUYỀNToolStripMenuItem.Text = "PHÂN QUYỀN";
            // 
            // menuBaoCao
            // 
            this.menuBaoCao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xUẤTHÓAĐƠNToolStripMenuItem,
            this.xUẤTDOANHTHUToolStripMenuItem});
            this.menuBaoCao.Name = "menuBaoCao";
            this.menuBaoCao.Size = new System.Drawing.Size(208, 58);
            this.menuBaoCao.Text = "BÁO CÁO";
            // 
            // xUẤTHÓAĐƠNToolStripMenuItem
            // 
            this.xUẤTHÓAĐƠNToolStripMenuItem.Name = "xUẤTHÓAĐƠNToolStripMenuItem";
            this.xUẤTHÓAĐƠNToolStripMenuItem.Size = new System.Drawing.Size(473, 62);
            this.xUẤTHÓAĐƠNToolStripMenuItem.Text = "XUẤT HÓA ĐƠN";
            // 
            // xUẤTDOANHTHUToolStripMenuItem
            // 
            this.xUẤTDOANHTHUToolStripMenuItem.Name = "xUẤTDOANHTHUToolStripMenuItem";
            this.xUẤTDOANHTHUToolStripMenuItem.Size = new System.Drawing.Size(473, 62);
            this.xUẤTDOANHTHUToolStripMenuItem.Text = "XUẤT DOANH THU";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 553);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHƯƠNG TRÌNH QUẢN LÝ RẠP PHIM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hỆTHỐNGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuDangNhap;
        private System.Windows.Forms.ToolStripMenuItem menuDangXuat;
        private System.Windows.Forms.ToolStripMenuItem menuQuanLy;
        private System.Windows.Forms.ToolStripMenuItem bÁNVÉToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qUẢNLÝHÓAĐƠNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qUẢNLÝKHÁCHHÀNGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pHÂNQUYỀNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuBaoCao;
        private System.Windows.Forms.ToolStripMenuItem xUẤTHÓAĐƠNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xUẤTDOANHTHUToolStripMenuItem;
    }
}