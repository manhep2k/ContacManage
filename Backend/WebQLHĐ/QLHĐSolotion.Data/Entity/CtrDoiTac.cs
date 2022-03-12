using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHĐSolotion.Data.Entity
{
    [Table("CtrDoiTac")]
    public partial class CtrDoiTac
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CtrDoiTac()
        {
            CtrHopDongs = new HashSet<CtrHopDong>();
        }

        public int CtrDoiTacID { get; set; }

        [Required(ErrorMessage = "Mời nhập mã số")]
        [StringLength(50, ErrorMessage = "Độ đài ít nhất 3 kí tự.", MinimumLength = 3)]
        [Display(Name = "Mã Số")]

        public string MaDoitac { get; set; }
        [Required(ErrorMessage = "Mời nhập Tên đối tác")]
        [Display(Name = "Tên đối tác")]
        [StringLength(300, ErrorMessage = "Độ đài ít nhất 5 kí tự.", MinimumLength = 5)]
        public string TenDoiTac { get; set; }
        [Required(ErrorMessage = "Mời nhập Địa chỉ")]
        [Display(Name = "Địa chỉ")]
        [StringLength(200, ErrorMessage = "Độ đài ít nhất 5 kí tự.", MinimumLength = 5)]
        public string DiaChi { get; set; }
        [Required(ErrorMessage = "Mời nhập Mã số thuế")]
        [Display(Name = "Mã số thuế")]
        [StringLength(50, ErrorMessage = "Độ đài ít nhất 10 kí tự.", MinimumLength = 10)]
        public int MaSoThueDT { get; set; }
        [Required(ErrorMessage = "Mời nhập Điện thoại")]
        [Display(Name = "Điện thoại")]
        [Phone(ErrorMessage = "Số điện thoại bạn nhập không đúng")]
        [StringLength(50, ErrorMessage = "Độ đài ít nhất 10 chữ số.", MinimumLength = 10)]
        public int DienThoai { get; set; }
        [Required(ErrorMessage = "Mời chon tài khoản đăng nhập")]
        [Display(Name = "Tài khoản đăng nhập")]
        [StringLength(50)]
        public string TaiKhoanDangNhap { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CtrHopDong> CtrHopDongs { get; set; }
    }
}
