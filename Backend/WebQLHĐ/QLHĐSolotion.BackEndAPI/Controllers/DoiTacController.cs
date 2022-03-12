using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QLHĐSolotion.Application.Doitac;
using QLHĐSolotion.Data.EF;
using QLHĐSolotion.ViewModel.Doitac.Dtos;
using System.Data.Entity;
using Microsoft.EntityFrameworkCore;
using QLHĐSolotion.Application.Doitac.Dtos;
using Microsoft.AspNetCore.Authorization;


namespace QLHĐSolotion.BackendAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoiTacController : ControllerBase

    {
        //private readonly testDbontext _context;
        private readonly IPublicDoiTacServicer _DoiTacService;
        //private readonly IDoitacService _doitacService;
        public DoiTacController(IPublicDoiTacServicer DoiTacService)/*, testDbontext context*/
        {
            //_context = context;
            _DoiTacService = DoiTacService;

        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var doitac = await _DoiTacService.GetAll();
            return Ok(doitac);
        }

        //create
        [HttpPost]
        //[Consumes("multipart/form-data")]
        //[Authorize]
        public async Task<IActionResult> Create([FromBody] CtrDoiTacCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var productId = await _DoiTacService.Create(request);
            //request.CtrDoiTacID = Guid.NewGuid();
            if (productId == 0)
                return BadRequest();

            //var product = await _doitacService.GetById(productId, request.LanguageId);
            return Ok(productId);
        }


        [HttpPut("{doitacID}")]

        public async Task<IActionResult> Update(/*FromRoute] int productId,*/ [FromBody] CtrDoiTacUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            //request.CtrDoiTacID = productId;
            var affectedResult = await _DoiTacService.Update(request);
            if (affectedResult == 0)
                return BadRequest();
            return Ok(affectedResult);
        }

        // Delete
        [HttpDelete("{doitacID}")]
        //[Authorize]
        public async Task<IActionResult> Delete(int doitacID)
        {
            var affectedResult = await _DoiTacService.Delete(doitacID);
            if (affectedResult == 0)
                return BadRequest();
            return Ok();
        }

        [HttpGet("{doitacID}")]
        public async Task<IActionResult> GetById(int doitacID)
        {
            var product = await _DoiTacService.GetById(doitacID);
            //if (product == null)
            //    return badrequest("cannot find product");
            return Ok(product);
        }
    }
}




//private readonly testDbontext _context;


//public DoiTacController(testDbontext context)
//{
//    _context = context;

//}
//[HttpGet]
//public async Task<IActionResult> Get()
//{
//    var query = from dt in _context.CtrDoiTacs
//                select dt;
//    var doitac = await query.Select(x => new DoiTacViewModels()
//    {
//        CtrDoitacID = x.CtrDoiTacID,
//        MaDoitac = x.MaDoitac,
//        TenDoiTac = x.TenDoiTac,
//        DiaChi = x.DiaChi,
//        MaSoThue = x.MaSoThue,
//        DienThoai = x.DienThoai,
//        TaiKhoanDangNhap = x.TaiKhoanDangNhap
//    }).ToListAsync();

//    return Ok(doitac);
//}
