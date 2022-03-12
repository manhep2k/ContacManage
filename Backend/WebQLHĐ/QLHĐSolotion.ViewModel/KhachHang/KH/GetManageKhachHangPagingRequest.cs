using QLHĐSolotion.ViewModel.Doitac.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHĐSolotion.Application.KhachHang.KH
{
    public class GetManageKhachHangPagingRequest: PagingRequestBase
    {
        public string Keyword { get; set; }

        public List<int> CategoryIds { get; set; }
    }
}
