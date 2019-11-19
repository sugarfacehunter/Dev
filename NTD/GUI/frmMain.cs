using NTD.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NTD
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPhanQuyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPhanQuyen phanQuyen = new frmPhanQuyen();
            phanQuyen.MdiParent = this;
            phanQuyen.Show();
        }

        private void btnNhatKyHeThong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmNhatKy nk = new frmNhatKy();
            nk.MdiParent = this;
            nk.Show();
        }

        private void K_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmKhuVuc kv = new frmKhuVuc();
            kv.MdiParent = this;
            kv.Show();
        }

        private void btnKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmKhachHang kh = new frmKhachHang();
            kh.MdiParent = this;
            kh.Show();
        }

        private void btnNhaCungCap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmNhaCungCap ncc = new frmNhaCungCap();
            ncc.MdiParent=this;
            ncc.Show();
        }

        private void btnKhoHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmKhoHang kh = new frmKhoHang();
            kh.MdiParent = this;
            kh.Show();
        }

        private void btnDonViTinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDonViTinh dvt = new frmDonViTinh();
            dvt.MdiParent = this;
            dvt.Show();
        }

        private void btnNhomHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmNhomHang nh = new frmNhomHang();
            nh.MdiParent = this;
            nh.Show();
        }

        private void btnHangHoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmHangHoa hh = new frmHangHoa();
            hh.MdiParent = this;
            hh.Show();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTyGia tg = new frmTyGia();
            tg.MdiParent = this;
            tg.Show();
        }

        private void btnBoPhan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmBoPhan bp = new frmBoPhan();
            bp.MdiParent = this;
            bp.Show();
        }

        private void btnNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmNhanVien nv = new frmNhanVien();
            nv.MdiParent = this;
            nv.Show();
        }
    }
}
