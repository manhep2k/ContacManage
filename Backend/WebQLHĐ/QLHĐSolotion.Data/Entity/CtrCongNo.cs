using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHĐSolotion.Data.Entity
{  [Table("CtrCongNo")]
    public partial class CtrCongNo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CtrCongNo()
        {
            CtrHopDongs = new HashSet<CtrHopDong>();
        }
    public int CtrCongNoID { set; get; }
        public string MaCongNo { set; get; }
        public decimal TongNo { set; get; }
        public decimal DaThanhToan { set; get; }
        public DateTime NgayThanhToan { set; get; }
        public decimal DuNo { set; get; }
        public decimal KhauTru { set; get; }
        public DateTime Kyhan { set; get; }
         public string GhiChu { set; get; }
        public bool Trangthai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CtrHopDong> CtrHopDongs { get; set; }
    }
}
