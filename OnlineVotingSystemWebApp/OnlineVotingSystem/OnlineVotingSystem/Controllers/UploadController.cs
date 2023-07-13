using Google.Cloud.Storage.V1;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using OnlineVotingSystem.Models;

namespace OnlineVotingSystem.Controllers
{
    public class UploadController : Controller
    {
        private IWebHostEnvironment _env;

        public IActionResult Index() => View();

        public UploadController(IWebHostEnvironment env)
        {
            _env = env;
        }

        public async Task<IActionResult> UploadImageAsync (string bucketName, IFormFile file)
        {
            bucketName = "online-voting-system-dd4f9.appspot.com";
            
            string fileName = file.FileName;
            string contentType = file.ContentType;
            var fileExtension = Path.GetExtension(file.FileName);
            var fullPath = Path.GetFullPath(fileName);
            var dir = _env.WebRootPath;
            using (var fileStream = new FileStream(Path.Combine(dir, $"images/{fileName}"), FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.Read))
            {
                file.CopyTo(fileStream);
                TempData["fileName"] = fileName;
                TempData["contentType"] = contentType;
                TempData["fileExtension"] = fileExtension;

            }
 
            return RedirectToAction("Index", "SuCandi");
        }
    }
}
