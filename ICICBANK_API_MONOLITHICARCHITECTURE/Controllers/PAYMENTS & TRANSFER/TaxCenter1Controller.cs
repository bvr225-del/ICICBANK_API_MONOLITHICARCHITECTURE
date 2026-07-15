using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ICICBANK.API.Controllers.Payments_Transfer
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaxCenter1Controller : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAccountsInformation()
        {
            //get the information of user balance amount and account details
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Generatethereport()
        {
            // return File("sample.pdf");
            return Ok();
        }

    }
}
