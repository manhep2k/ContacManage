using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QLHĐSolotion.Application.HopDong;
using QLHĐSolotion.ViewModel.HopDong;

namespace QLHĐSolotion.BackEndAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HopDongController : ControllerBase

    {
        //private readonly testDbontext _context;
        private readonly IPublicHopDongServicer _HopDongService;
        //private readonly IDoitacService _doitacService;
        public HopDongController(IPublicHopDongServicer HopDongService)/*, testDbontext context*/
        {
            //_context = context;
            _HopDongService = HopDongService;

        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var doitac = await _HopDongService.GetAll();
            return Ok(doitac);
        }

        //create
        [HttpPost]
        [Consumes("multipart/form-data")]
        //[Authorize]
        public async Task<IActionResult> Create([FromForm] HopDongCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var _hopdong = await _HopDongService.Create(request);
            //request.CtrKhachHangID = Guid.NewGuid();
            if (_hopdong == 0)
                return BadRequest();

            //var product = await _doitacService.GetById(productId, request.LanguageId);
            return Ok(_hopdong);
        }


        [HttpPut]

        public async Task<IActionResult> Update(/*[FromRoute] Guid productId,*/ [FromForm] HopDongUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
           /* var productId = new Guid()*/;
            //request.CtrKhachHangID = productId;
            var affectedResult = await _HopDongService.Update(request);
            if (affectedResult == 0)
                return BadRequest();
            return Ok(affectedResult);
        }

        // Delete
        [HttpDelete("{HopDongID}")]
        //[Authorize]
        public async Task<IActionResult> Delete(int HopDongID)
        {
            var affectedResult = await _HopDongService.Delete(HopDongID);
            if (affectedResult == 0)
                return BadRequest();
            return Ok();
        }
    }
}
