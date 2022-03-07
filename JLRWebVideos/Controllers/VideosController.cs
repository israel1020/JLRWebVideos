using JLRWebVideos.Providers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoIsraelFutbol.Helpers;
using System.Threading.Tasks;

namespace JLRWebVideos.Controllers
{
    public class VideosController : Controller
    {
        private HelperUploadFiles helper;
        public VideosController(HelperUploadFiles helper)
        {
            this.helper = helper;
        }
        
        public IActionResult Videos()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Videos(IFormFile video)
        {
            string fileName = video.FileName;
            if(fileName != null)
            {
                ViewData["video"] = fileName;
            }
            string path = await this.helper.UploadFileAsync(video, Folders.Videos, fileName);
            return View();
        }
    }
}
