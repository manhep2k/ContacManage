using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHĐSolotion.Data.Entity
{
    [Table("CtrKhachHang")]
    public partial class CtrKhachHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CtrKhachHang()
        {
            CtrHopDongs = new HashSet<CtrHopDong>();
        }

        public int CtrKhachHangID { get; set; }
        [Required(ErrorMessage = "Mời nhập mã số")]
        [Display(Name = "Mã số")]
        [StringLength(50, ErrorMessage = "Độ đài ít nhất 3 kí tự.", MinimumLength = 3)]
        public string MaKH { get; set; }

        [Required(ErrorMessage = "Mời nhập Tên khách hàng")]
        [Display(Name = "Tên khách hàng")]
        [StringLength(100, ErrorMessage = "Độ đài ít nhất 5 kí tự.", MinimumLength = 5)]
        public string TenKhachHang { get; set; }

        [Required(ErrorMessage = "Mời nhập mã số thuế")]
        [Display(Name = "Mã số thuế")]
        [StringLength(50, ErrorMessage = "Độ đài ít nhất 3 kí tự.", MinimumLength = 10)]
        public int MaSothueKH { get; set; }
        [Required(ErrorMessage = "Mời nhập Địa chỉ")]

        [Display(Name = "Địa chỉ")]
        [StringLength(300, ErrorMessage = "Độ đài ít nhất 5 kí tự.", MinimumLength = 5)]
        public string Diachi { get; set; }
        [Required(ErrorMessage = "Mời nhập số điện thoại")]
        [Phone(ErrorMessage = "Số điện thoại bạn nhập không đúng")]
        [Display(Name = "Điện thoại")]
        [StringLength(50, ErrorMessage = "Độ đài ít nhất 10 kí tự.", MinimumLength = 10)]
        public int Dienthoai { get; set; }

        [Required(ErrorMessage = "Mời nhập Website")]
        [Display(Name = "Website")]
        [StringLength(200, ErrorMessage = "Độ đài ít nhất 5 kí tự.", MinimumLength = 5)]
        public string Website { get; set; }

        [Required(ErrorMessage = "Mời nhập Skype")]
        [Display(Name = "Skype")]
        [StringLength(100, ErrorMessage = "Độ đài ít nhất 5 kí tự.", MinimumLength = 5)]
        public string Skype { get; set; }

        [Required(ErrorMessage = "Mời nhập Email")]
        [EmailAddress(ErrorMessage = "Email là không hợp lệ")]
        [Display(Name = " Email")]
        [StringLength(100, ErrorMessage = "Độ đài ít nhất 5 kí tự..", MinimumLength = 5)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Mời nhập ngày đăng ký")]
        [Display(Name = " Ngày đăng ký")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime NgayDangKy { get; set; }
        [Required(ErrorMessage = " Mời nhập ngày cập nhập")]
        [Display(Name = " Ngày cập nhập")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime NgayCapNhat { get; set; }

        public bool TrangThai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CtrHopDong> CtrHopDongs { get; set; }
    }
}
