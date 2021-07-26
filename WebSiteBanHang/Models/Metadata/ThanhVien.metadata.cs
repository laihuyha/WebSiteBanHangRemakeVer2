using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace WebSiteBanHang.Models
{
    [MetadataTypeAttribute(typeof(ThanhVienMetaData))]
    public  partial class ThanhVien
    {
        internal sealed class ThanhVienMetaData
        {

            [Display(Name = "Mã Thành viên")]
            public int MaThanhVien { get; set; }
            [Display(Name = "Tài khoản")]
            [Required(ErrorMessage = "Vui lòng nhập tên tài khoản")]
            public string TaiKhoan { get; set; }
            [Display(Name = "Mật khẩu")]
            [Required(ErrorMessage = "Vui lòng nhập mật khẩu")]
            public string MatKhau { get; set; }
            [Display(Name = "Họ và Tên")]
            public string HoTen { get; set; }
            [Display(Name = "Địa chỉ")]
            public string DiaChi { get; set; }
            [Display(Name = "Email")]
            [EmailAddress(ErrorMessage = "Mail ảo à?")]
            public string Email { get; set; }
            [Display(Name = "Số điện thoại")]
            public string SoDienThoai { get; set; }
            [Display(Name = "Câu hỏi bảo mật")]
            public string CauHoi { get; set; }
            [Display(Name = "Câu trả lời")]
            public string CauTraLoi { get; set; }
            [Display(Name = "Mã loại thành viên")]
            public Nullable<int> MaLoaiTV { get; set; }
        }
    }
}