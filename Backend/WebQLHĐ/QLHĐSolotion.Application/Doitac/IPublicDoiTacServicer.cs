using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using QLHĐSolotion.Application.Doitac.Dtos;

namespace QLHĐSolotion.ViewModel.Doitac.Dtos
{
    public  interface IPublicDoiTacServicer
    {
        Task<PagedResult<DoiTacViewModels>> GetAllByCategoryId(GetPublicDoiTacPagingRequest request);

         Task<List<DoiTacViewModels>> GetAll();
        Task<int> Create(CtrDoiTacCreateRequest request);

        Task<int> Update(CtrDoiTacUpdateRequest request);

        Task<int> Delete(int doitacID);


        Task<DoiTacViewModels> GetById(int productId);
        List<DoiTacViewModels> GetAllPaging(String keywork, int pageIndex, int pageSize);
    }

}
