using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHĐSolotion.Application.KhachHang.KH
{
    public class CtrKhachHangUpdateRequest
    {
        public int CtrKhachHangID { get; set; }
      
        public string MaKH { get; set; }

        public string TenKhachHang { get; set; }

 
        public int MaSothue { get; set; }

        public string Diachi { get; set; }

        public int Dienthoai { get; set; }


        public string Website { get; set; }


        public string Skype { get; set; }


        public string Email { get; set; }

        public DateTime NgayDangKy { get; set; }
      
        public DateTime NgayCapNhat { get; set; }

        public bool TrangThai { get; set; }
    }
}
