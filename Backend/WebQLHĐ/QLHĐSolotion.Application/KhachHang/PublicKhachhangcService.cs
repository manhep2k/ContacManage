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
using QLHĐSolotion.Application.KhachHang.KH;

namespace QLHĐSolotion.Application.KhachHang
{
    public class PublicKhachHangService : IPublicKhachHangServicer
    {
        private readonly testDbontext _context;
        //private readonly IStorageService _storageService;

        public PublicKhachHangService(testDbontext context/*, IStorageService storageService*/)
        {
            _context = context;
            //_storageService= storageService;
        }
        public async Task<List<KhachHangViewModels>> GetAll()
        {
            var query = from dt in _context.CtrKhachHangs
                        select dt;
            var doitac = await query.Select(x => new KhachHangViewModels()
            {
                CtrKhachHangID = x.CtrKhachHangID,
                MaKH = x.MaKH,
                TenKhachHang = x.TenKhachHang,
                MaSothue = x.MaSothueKH,
                Diachi = x.Diachi,
                Dienthoai = x.Dienthoai,
                Website = x.Website,
                Skype = x.Skype,
                Email = x.Email,
                NgayDangKy = x.NgayDangKy,
                NgayCapNhat = x.NgayCapNhat,
                TrangThai = x.TrangThai
            }).ToListAsync();

            return doitac;
        }

        public Task<PagedResult<KhachHangViewModels>> GetAllByCategoryId(GetPublicKhachHangPagingRequest request)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Create(CtrKhachHangCreateRequest x)
        {
            //x.CtrKhachHangID = Guid.NewGuid();
            var khachHang = new CtrKhachHang()
            {
                //CtrKhachHangID = x.CtrKhachHangID,
                MaKH = x.MaKH,
                TenKhachHang = x.TenKhachHang,
                MaSothueKH = x.MaSothue,
                Diachi = x.Diachi,
                Dienthoai = x.Dienthoai,
                Website = x.Website,
                Skype = x.Skype,
                Email = x.Email,
                NgayDangKy = x.NgayDangKy,
                NgayCapNhat = x.NgayCapNhat,
                TrangThai = x.TrangThai
            };
            _context.CtrKhachHangs.Add(khachHang);
            await _context.SaveChangesAsync();
            return khachHang.CtrKhachHangID;
        }

        public async Task<int> Delete(int KhachHangID)
        {

            var khachhang = await _context.CtrKhachHangs.FindAsync(KhachHangID);
            if (khachhang == null) throw new EShopException($"Cannot find a product: {KhachHangID}");

            //var images = _context.ProductImages.Where(i => i.ProductId == productId);
            //foreach (var image in images)
            //{
            //    await _storageService.DeleteFileAsync(image.ImagePath);
            //}

            _context.CtrKhachHangs.Remove(khachhang);

            return await _context.SaveChangesAsync();
        }
        public async Task<KhachHangViewModels> GetById(int id)
        {
            var x = await _context.CtrKhachHangs.FindAsync(id);
            //if (request == null)
            //    throw new eshopexception($"cannot find an image with id {id}");

            var viewModel = new KhachHangViewModels()
            {
                CtrKhachHangID = x.CtrKhachHangID,
                MaKH = x.MaKH,
                TenKhachHang = x.TenKhachHang,
                MaSothue = x.MaSothueKH,
                Diachi = x.Diachi,
                Dienthoai = x.Dienthoai,
                Website = x.Website,
                Skype = x.Skype,
                Email = x.Email,
                NgayDangKy = x.NgayDangKy,
                NgayCapNhat = x.NgayCapNhat,
                TrangThai = x.TrangThai
            };


            return viewModel;
        }
        public List<KhachHangViewModels> GetAllPaging(string keywork, int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Update(CtrKhachHangUpdateRequest x)
        {
            var product = await _context.CtrKhachHangs.FindAsync(x.CtrKhachHangID);
            if (product == null) throw new EShopException($"Cannot find a product with id: {x.CtrKhachHangID}");

            {
                {
                    product.CtrKhachHangID = x.CtrKhachHangID;
                    product.MaKH = x.MaKH;
                    product.TenKhachHang = x.TenKhachHang;
                    product.MaSothueKH = x.MaSothue;
                    product.Diachi = x.Diachi;
                    product.Dienthoai = x.Dienthoai;
                    product.Website = x.Website;
                    product.Skype = x.Skype;
                    product.Email = x.Email;
                    product.NgayDangKy = x.NgayDangKy;
                    product.NgayCapNhat = x.NgayCapNhat;
                    product.TrangThai = x.TrangThai;
                    _context.CtrKhachHangs.Update(product);
                    await _context.SaveChangesAsync();
                    return product.CtrKhachHangID;

                }

            }
        }
    }
}

