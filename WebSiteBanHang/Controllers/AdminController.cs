using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSiteBanHang.Models;

namespace WebSiteBanHang.Controllers
{
    [Authorize(Roles = "QuanTri")]
    public class AdminController : Controller
    {
        QuanLyBanHangEntities db = new QuanLyBanHangEntities();
        // GET: Admin
        public ActionResult TrangChu()
        {
            ViewBag.TongDoanhThu = ThongKeDoanhThu();
            ViewBag.TongDDH = ThongKeDonHang();
            ViewBag.TongThanhVien = TongThanhVien();
            ViewBag.TongLuotXem = TongLuotXem();
            return View();
        }

        public ActionResult StatusPartial()
        {
            ViewBag.TongDoanhThu = ThongKeDoanhThu();
            ViewBag.TongDDH = ThongKeDonHang();
            ViewBag.TongThanhVien = TongThanhVien();
            ViewBag.TongLuotXem = TongLuotXem();
            return PartialView();
        }

        public decimal? ThongKeDoanhThu()
        {
            var TongDoanhThu = db.DonDatHangs.Where(n => n.DaThanhToan == true);
            decimal? TongTien = 0;
            //Duyệt chi tiết đơn hàng theo điều kiện
            foreach (var item in TongDoanhThu)
            {
                TongTien += item.ChiTietDonDatHangs.Sum(n => n.DonGia * n.SoLuong);
            }
            return TongTien;
        }

        public double ThongKeDonHang()
        {
            //Đếm đơn đặt hàng
            double sl = db.DonDatHangs.Count();
            return sl;
        }

        public double TongThanhVien()
        {
            double slTV = db.ThanhViens.Count();
            return slTV;
        }

        public double TongLuotXem()
        {
            var SanPham = db.SanPhams.Where(n => n.DaXoa == false);
            int tongluotXem = 0;
            foreach (var item in SanPham)
            {
                tongluotXem = (int)SanPham.Sum(o => o.LuotXem);
            }
            return tongluotXem;
        }
    }
}