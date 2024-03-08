using FTPFileApp.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FTPFileApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileManagerController : ControllerBase
    {
        private readonly IManageFile _iManageFile;
        public FileManagerController(IManageFile iManageFile)
        {
            _iManageFile = iManageFile;
        }

        [HttpPost]
        [Route("upload-file")]
        public async Task<IActionResult> UploadFile(IFormFile file)
        {
            var result = await _iManageFile.UploadFile(file);
            return Ok(result);
        }

        [HttpGet]
        [Route("download-file")]
        public async Task<IActionResult> DownloadFile(string fileName)
        {
            var result = await _iManageFile.DownloadFile(fileName);
            return File(result.Item1, result.Item2, result.Item3);
        }
    }
}
