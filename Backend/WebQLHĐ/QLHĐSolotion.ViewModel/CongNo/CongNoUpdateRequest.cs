using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHĐSolotion.ViewModel.CongNo
{
    public class CongNoUpdateRequest
    {
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
    }
}
