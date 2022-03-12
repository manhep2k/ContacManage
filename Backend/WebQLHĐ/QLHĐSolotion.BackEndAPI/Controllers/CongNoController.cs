using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QLHĐSolotion.Application.CongNo;
using QLHĐSolotion.ViewModel.CongNo;

namespace QLHĐSolotion.BackEndAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CongNoController : ControllerBase

    {
        //private readonly testDbontext _context;
        private readonly IPublicCongNoServicer _CongNoService;
        //private readonly IDoitacService _doitacService;
        public CongNoController(IPublicCongNoServicer DoiTacService)/*, testDbontext context*/
        {
            //_context = context;
            _CongNoService = DoiTacService;

        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var doitac = await _CongNoService.GetAll();
            return Ok(doitac);
        }

        //create
        [HttpPost]
        [Consumes("multipart/form-data")]
        //[Authorize]
        public async Task<IActionResult> Create([FromForm] CongNoCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var productId = await _CongNoService.Create(request);
            //request.CtrDoiTacID = Guid.NewGuid();
            if (productId == 0)
                return BadRequest();

            //var product = await _doitacService.GetById(productId, request.LanguageId);
            return Ok(productId);
        }


        [HttpPut]

        public async Task<IActionResult> Update(/*FromRoute] int productId,*/ [FromForm] CongNoUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            //request.CtrDoiTacID = productId;
            var affectedResult = await _CongNoService.Update(request);
            if (affectedResult == 0)
                return BadRequest();
            return Ok(affectedResult);
        }

        // Delete
        [HttpDelete("{CongNoID}")]
        //[Authorize]
        public async Task<IActionResult> Delete(int CongNoID)
        {
            var affectedResult = await _CongNoService.Delete(CongNoID);
            if (affectedResult == 0)
                return BadRequest();
            return Ok();
        }
    }
}
