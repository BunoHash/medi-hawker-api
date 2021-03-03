using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace medi_hawker_api.Controllers
{
    [Route("api/Upload")]
    [ApiController]
    public class UploadController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public UploadController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost, DisableRequestSizeLimit]
        [Route("uploadProductImage")]
        public async Task<IActionResult> uploadProductImage()
            {
                try
                {



                var formCollection = await Request.ReadFormAsync();
                    var file = formCollection.Files.First();
                    var folderName = Path.Combine("StaticFiles", "Images");
                    //var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);
                var imageRootPath = _configuration.GetSection("ImageFileConfig:ImageRootPath").Value;


                if (file.Length > 0)
                {
                    var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    var fullPath = Path.Combine(imageRootPath, fileName);
                    var dbPath = Path.Combine(folderName, fileName);

                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }

                    return Ok(new { dbPath });
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex}");
            }
        }
    }
}
