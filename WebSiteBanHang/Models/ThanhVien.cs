﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebSiteBanHang.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class ThanhVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ThanhVien()
        {
            this.BinhLuans = new HashSet<BinhLuan>();
            this.KhachHangs = new HashSet<KhachHang>();
        }
    
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
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BinhLuan> BinhLuans { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KhachHang> KhachHangs { get; set; }
        public virtual LoaiThanhVien LoaiThanhVien { get; set; }
    }
}