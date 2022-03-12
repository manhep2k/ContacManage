using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using QLHĐSolotion.Application.KhachHang.KH;

namespace QLHĐSolotion.ViewModel.Doitac.Dtos
{
    public  interface IPublicKhachHangServicer
    {
        Task<PagedResult<KhachHangViewModels>> GetAllByCategoryId(GetPublicKhachHangPagingRequest request);

         Task<List<KhachHangViewModels>> GetAll();
        Task<int> Create(CtrKhachHangCreateRequest request);

        Task<int> Update(CtrKhachHangUpdateRequest request);

        Task<int> Delete(int KhachHangID);

        Task<KhachHangViewModels> GetById(int KhachHangID);
        //List<DoiTacViewModels> GetAll();
        List<KhachHangViewModels> GetAllPaging(String keywork, int pageIndex, int pageSize);
    }

}
