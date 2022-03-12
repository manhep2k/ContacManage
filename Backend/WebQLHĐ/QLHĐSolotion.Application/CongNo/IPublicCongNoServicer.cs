using QLHĐSolotion.ViewModel.CongNo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Text;
using System.Threading.Tasks;

namespace QLHĐSolotion.Application.CongNo
{
    public interface IPublicCongNoServicer
    {
        //Task<PagedResult<CongNoViewModel>> GetAllByCategoryId(GetPublicCongNoPagingRequest request);

        Task<List<CongNoViewModel>> GetAll();
        Task<int> Create(CongNoCreateRequest request);

        Task<int> Update(CongNoUpdateRequest request);

        Task<int> Delete(int CongNoID);


        //List<DoiTacViewModels> GetAll();
        List<CongNoViewModel> GetAllPaging(String keywork, int pageIndex, int pageSize);
    }
}
