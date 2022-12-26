using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Controllers
{
    [ApiController]
    [Route("api/files")]
    public class FilesController : ControllerBase
    {
        [HttpPost("upload")]
        public async Task<IActionResult> Upload(IFormFile file)
        {
            if(!ModelState.IsValid)
                return BadRequest();
            
            // folder
            var folder = Path.Combine(Directory.GetCurrentDirectory(), "Media");
            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);

            // path
            var path = Path.Combine(folder, file?.FileName);

            // stream
            using (var stream = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            // response body
            return Ok(new
            {
                file = file.FileName,
                path = path,
                size = file.Length
            });
        }

        [HttpGet("download")]
        public async Task<IActionResult> Download(string fileName)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            // filePath
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "Media", fileName);

            // ContentType : (MIME)
            var provider = new FileExtensionContentTypeProvider();
            if(!provider.TryGetContentType(fileName, out var contentType))
            {
                contentType = "application/octet-stream";
            }

            // Read
            var bytes = await System.IO.File.ReadAllBytesAsync(filePath);
            return File(bytes, contentType, Path.GetFileName(filePath));
        }
    }
}
