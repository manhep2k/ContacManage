using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHĐSolotion.Data.Entity
{
    public partial class CtrHopDong
    {
        public int CtrHopDongID { get; set; }
        [Required(ErrorMessage = "Mời nhập mã số")]
        [Display(Name = "Mã số")]
        [StringLength(50, ErrorMessage = "Độ đài ít nhất 3 kí tự.", MinimumLength = 3)]
        public string MaHĐ { get; set; }
        [Required(ErrorMessage = "Mời nhập Tên hợp đồng")]
        [Display(Name = "Tên hợp đồng")]
        [StringLength(300, ErrorMessage = "Độ đài ít nhất 3 kí tự.", MinimumLength = 5)]
        public string TenHopDong { get; set; }
        [Required(ErrorMessage = "Mời nhập Nội dung hợp đồng")]
        [Display(Name = "ND hợp đồng")]

        public string NoiDungHD { get; set; }
        [Required(ErrorMessage = "Mời nhập Ngày lập")]
        [DisplayName("Ngày lập ")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]

        public DateTime NgayLap { get; set; }
        [Required(ErrorMessage = "Mời nhập Ngày nghiệm thu")]
        [DisplayName("Ngày nghiệm thu")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]

        public DateTime NgayNghiemThu { get; set; }

        [Required(ErrorMessage = "Mời nhập Người phụ trách")]
        [Display(Name = "Người phụ trách hợp đồng")]
        [StringLength(200, ErrorMessage = "Độ đài ít nhất 3 kí tự.", MinimumLength = 5)]
        public string NguoiPhuTrachHopDong { get; set; }
        [Required(ErrorMessage = "Mời nhập Đơn vị HDDT")]
        [Display(Name = "Đơn vị HDDT")]
        [StringLength(50, ErrorMessage = "Độ đài ít nhất 3 kí tự..", MinimumLength = 3)]
        public string DonViHDDT { get; set; }
        [Required(ErrorMessage = "Mời nhập Link HDDT")]
        [Display(Name = "Link HDDT")]
        [StringLength(500, ErrorMessage = "Độ đài ít nhất 5 kí tự.", MinimumLength = 5)]
        public string LinkHDDT { get; set; }
        [Required(ErrorMessage = "Mời nhập Tài Khoản HDĐT")]
        [Display(Name = "Tài Khoản HDĐT")]
        [StringLength(100, ErrorMessage = "Độ đài ít nhất 5 kí tự.", MinimumLength = 5)]
        public string TaiKhoanHDDT { get; set; }
        [Required(ErrorMessage = "Mời nhập Link Phần mềm")]
        [Display(Name = "Link Phần mềm")]
        [StringLength(500, ErrorMessage = "Độ đài ít nhất 5 kí tự.", MinimumLength = 5)]
        public string LinkPhanMem { get; set; }

        [Required(ErrorMessage = "Mời nhập GiaTriGoiDV")]
        [Display(Name = "GiaTriGoiDV")]
        [Column(TypeName = "money")]
        public decimal GiaTriGoiDV { get; set; }
        [Required(ErrorMessage = "Mời chọn ID đối tác")]
        [Display(Name = "ID Đối tác")]
        public int CtrDoiTacID { get; set; }
        [Required(ErrorMessage = "Mời chọn ID Khách hàng")]
        [Display(Name = "ID Khách Hàng")]
        public int CtrKhachHangID { get; set; }
        public int CtrCongNoID { set; get; }
        public bool TrangThai { get; set; }

        //public string TenDoiTac { get; set; }
        //public string TenKhachHang { get; set; }

        public virtual CtrDoiTac CtrDoiTac { get; set; }

        public virtual CtrKhachHang CtrKhachHang { get; set; }
        public virtual CtrCongNo CtrCongNo { get; set; }

        public virtual AppUser AppUser { get; set; }
    }
}
