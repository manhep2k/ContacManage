using QLHĐSolotion.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHĐSolotion.ViewModel.HopDong
{
    public class HopDongViewModel
    {
        public int CtrHopDongID { get; set; }
   
        public string MaHĐ { get; set; }
      
        public string TenHopDong { get; set; }
       
        public string NoiDungHD { get; set; }
       

        public DateTime NgayLap { get; set; }
  

        public DateTime NgayNghiemThu { get; set; }

        public string NguoiPhuTrachHopDong { get; set; }

        public string DonViHDDT { get; set; }

        public string LinkHDDT { get; set; }

        public string TaiKhoanHDDT { get; set; }

        public string LinkPhanMem { get; set; }


        public decimal GiaTriGoiDV { get; set; }

        public int CtrDoiTacID { get; set; }
      
        public int CtrKhachHangID { get; set; }
        public int CtrCongNoID { set; get; }
        public bool TrangThai { get; set; }

        public virtual CtrDoiTac CtrDoiTac { get; set; }

        public virtual CtrKhachHang CtrKhachHang { get; set; }
        public virtual CtrCongNo CtrCongNo { get; set; }
        //public List<string> Categories { get; set; } = new List<string>();
    }
}
