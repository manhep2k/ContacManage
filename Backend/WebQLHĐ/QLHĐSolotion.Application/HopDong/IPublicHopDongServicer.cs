using QLHĐSolotion.Application.KhachHang.KH;
using QLHĐSolotion.ViewModel.HopDong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Text;
using System.Threading.Tasks;

namespace QLHĐSolotion.Application.HopDong
{
    public interface IPublicHopDongServicer
    {
        //Task<PagedResult<HopDongViewModels>> GetAllByCategoryId(GetPublicKhachHangPagingRequest request);

        Task<List<HopDongViewModel>> GetAll();
        Task<int> Create(HopDongCreateRequest request);

        Task<int> Update(HopDongUpdateRequest request);

        Task<int> Delete(int doitacID);


        //List<DoiTacViewModels> GetAll();
        List<HopDongViewModel> GetAllPaging(String keywork, int pageIndex, int pageSize);
    }
}
