using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using sample.Models;

using System.Runtime.Intrinsics.X86;

namespace sample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CsvfilesController : ControllerBase
    {
        private csv_fileContext _context;

        public CsvfilesController(csv_fileContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<SampleCsvFile>>> Get()
        {
            return Ok(await _context.SampleCsvFiles.ToListAsync());
        }

        [HttpPost]

        public async Task<IActionResult> Post([FromForm] Customcsv csv)
        {

            SampleCsvFile csv1 = new SampleCsvFile();

            csv1.Id = csv.Id;
            csv1.Name = csv.Name;
            csv1.FirstName = csv.FirstName;
            csv1.LastName = csv.LastName;
            csv1.Column = csv.Column;
            csv1.Mail = csv.Mail;


            _context.SampleCsvFiles.Add(csv1);

            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = csv1.Id }, csv);


        }
    }
}