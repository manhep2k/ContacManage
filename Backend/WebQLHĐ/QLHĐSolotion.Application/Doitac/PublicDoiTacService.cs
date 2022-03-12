using QLHĐSolotion.Data.EF;
using QLHĐSolotion.Data.Entity;
using QLHĐSolotion.ViewModel.Doitac.Dtos;
//using System.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Text;
using System.Threading.Tasks;
using QLHĐSolotion.Application.Doitac.Dtos;
using QLHĐSolotion.Data.Extensions;
using Microsoft.Xrm.Sdk.Workflow;

namespace QLHĐSolotion.Application.Doitac
{
    public class PublicDoiTacService : IPublicDoiTacServicer
    {
        private readonly testDbontext _context;
        //private readonly IStorageService _storageService;

        public PublicDoiTacService(testDbontext context/*, IStorageService storageService*/)
        {
            _context = context;
            //_storageService= storageService;
        }
        public async Task<List<DoiTacViewModels>> GetAll()
        {
            var query = from dt in _context.CtrDoiTacs
                        select dt;
            var doitac = await query.Select(x => new DoiTacViewModels()
            {
                CtrDoitacID = x.CtrDoiTacID,
                MaDoitac = x.MaDoitac,
                TenDoiTac = x.TenDoiTac,
                DiaChi = x.DiaChi,
                MaSoThue = x.MaSoThueDT,
                DienThoai = x.DienThoai,
                TaiKhoanDangNhap = x.TaiKhoanDangNhap
            }).ToListAsync();

            return doitac;
        }

        public Task<PagedResult<DoiTacViewModels>> GetAllByCategoryId(GetPublicDoiTacPagingRequest request)
        {
            throw new NotImplementedException();
        }
      
        public async Task<int> Create(CtrDoiTacCreateRequest request)
        {    /*  request.CtrDoiTacID = Guid.NewGuid();*/
            var doitac = new CtrDoiTac()
            {
                //CtrDoiTacID = request.CtrDoiTacID,
                MaDoitac = request.MaDoitac,
                TenDoiTac = request.TenDoiTac,
                DiaChi = request.DiaChi,
                MaSoThueDT = request.MaSoThue,
                DienThoai = request.DienThoai,
                TaiKhoanDangNhap = request.TaiKhoanDangNhap
            };
            _context.CtrDoiTacs.Add(doitac);
            await _context.SaveChangesAsync();
            return doitac.CtrDoiTacID;
        }

        public async Task<int> Delete(int doitacID)
        {

            var doitac = await _context.CtrDoiTacs.FindAsync(doitacID);
            if (doitac == null) throw new EShopException($"Cannot find a product: {doitacID}");

            //var images = _context.ProductImages.Where(i => i.ProductId == productId);
            //foreach (var image in images)
            //{
            //    await _storageService.DeleteFileAsync(image.ImagePath);
            //}

            _context.CtrDoiTacs.Remove(doitac);

            return await _context.SaveChangesAsync();
        }

        public async Task<DoiTacViewModels> GetById(int id)
        {
            var request = await _context.CtrDoiTacs.FindAsync(id);
            //if (request == null)
            //    throw new eshopexception($"cannot find an image with id {id}");

            var viewModel = new DoiTacViewModels()
            {
                CtrDoitacID = request.CtrDoiTacID,
                MaDoitac = request.MaDoitac,
                TenDoiTac = request.TenDoiTac,
                DiaChi = request.DiaChi,
                MaSoThue = request.MaSoThueDT,
                DienThoai = request.DienThoai,
                TaiKhoanDangNhap = request.TaiKhoanDangNhap
            };
            
            
            return viewModel;
        }
    

        public List<DoiTacViewModels> GetAllPaging(string keywork, int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Update(CtrDoiTacUpdateRequest request)
        {
            var product = await _context.CtrDoiTacs.FindAsync(request.CtrDoiTacID);
            //if (product == null) throw new EShopException($"Cannot find a product with id: {request.CtrDoiTacID}");
            
            {
                product.CtrDoiTacID = request.CtrDoiTacID;
                product.MaDoitac = request.MaDoitac;
                product.TenDoiTac = request.TenDoiTac;
                product.DiaChi = request.DiaChi;
                product.MaSoThueDT = request.MaSoThue;
                product.DienThoai = request.DienThoai;
                product.TaiKhoanDangNhap = request.TaiKhoanDangNhap;
                _context.CtrDoiTacs.Update(product);
                await _context.SaveChangesAsync();
                return product.CtrDoiTacID;

            }
          
        }
    }
}

