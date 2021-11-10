using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.CsvToSql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CsvToSql.API.Controllers
{
    [Route("CsvToSql")]
    public class CsvToSqController : Controller
    {
        private readonly ICsvToSqlService _csvToSqlService;
        public CsvToSqController(ICsvToSqlService csvToSqlService)
        {
            _csvToSqlService = csvToSqlService;
        }

        [HttpPost]
        [Route("new-add")]
        public ActionResult<int> AddNewAdvertisement(IFormFile file)
        {
            // If there's no file return a bad request.
            if (file == null)
            {
                return BadRequest("Something went wrong, no file was given, please try again.");
            }

            var response = _csvToSqlService.AddNewAd(file.OpenReadStream());

            return Ok(response);
        }

    }
}
