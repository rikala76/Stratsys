using Microsoft.AspNetCore.Mvc;
using Stratsys.Enums;
using Stratsys.Models;
using Stratsys.Services;

namespace Stratsys.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CrossCountrySkiController : ControllerBase
    {
        private CrossCountrySkiService _crossCountrySkiService;

        public CrossCountrySkiController(CrossCountrySkiService crossCountrySkiService)
        {
            _crossCountrySkiService = crossCountrySkiService ?? throw new ArgumentNullException(nameof(crossCountrySkiService));
        }

        [HttpGet(Name = "GetSkiLength")]
        public ActionResult<CrossCountrySkiLength> Get(int length, int age, CrossCountrySkiStyle skiStyle)
        {
            if (length <= 0)
            {
                return BadRequest("Length could not be zero or less");
            }

            return _crossCountrySkiService.CalculateSkiLength(length, age, skiStyle);
        }
    }
}
