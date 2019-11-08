using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OdekuTour.Areas.Admin.Models;
using OdekuTour.Middlewares;
using OdekuTour.Settings;
using System;
using System.IO;
using System.Linq;

namespace OdekuTour.Areas.Admin.Controllers
{
    [Area("admin")]
    public class HomeController : Controller
    {
        IHostingEnvironment _hostingEnvironment;
        public HomeController(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        [HttpPost]
        public IActionResult Logout()
        {
            bool success;
            try
            {
                Response.Cookies.Delete(TokenMiddleware._key);
                success = true;
            }
            catch (Exception)
            {
                success = false;
            }
            return Json(new { success });
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DeleteScene(string name)
        {
            var scenes = Loader.Scenes.Where(x => x.Name != name).ToList();
            var message = Loader.UpdateScenes(scenes);
            return new ObjectResult(new { success = !message.IsError, text = message.Text });
        }

        public IActionResult GetScene(string name)
        {
            var scene = Loader.Scenes.FirstOrDefault(x => x.Name == name);
            return new ObjectResult(scene);
        }

        [HttpPost]
        public IActionResult UpdateScene(SceneUpdateVM scene)
        {
            var success = true;
            var message = string.Empty;
            try
            {
                var fileName = Path.GetFileName(scene.Image);
                var sceneToUpdate = new Scene()
                {
                    AutoLoad = scene.AutoLoad,
                    Hfov = scene.Hfov,
                    Image = fileName,
                    IsMain = scene.IsMain,
                    IsUnit = scene.IsUnit,
                    Name = scene.Name
                };
                Loader.UpdateScene(sceneToUpdate);
            }
            catch (Exception ex)
            {
                success = false;
                message = ex.Message;
            }
            return new ObjectResult(new { success, message });
        }

        [HttpPost]
        public IActionResult AddScene(SceneAddVM scene)
        {
            var success = true;
            var message = string.Empty;
            try
            {
                var fileName = Path.GetFileName(scene.Image);
                var sceneToAdd = new Scene()
                {
                    AutoLoad = scene.AutoLoad,
                    Hfov = scene.Hfov,
                    Image = fileName,
                    IsMain = scene.IsMain,
                    IsUnit = scene.IsUnit,
                    Name = scene.Name
                };
                Loader.AddScene(sceneToAdd);
            }
            catch (Exception ex)
            {
                success = false;
                message = ex.Message;
            }
            return new ObjectResult(new { success, message });
        }

        [HttpPost]
        public IActionResult UploadImage(IFormFile file)
        {
            var success = true;
            var message = string.Empty;
            try
            {
                string path = Path.Combine(_hostingEnvironment.WebRootPath, "images", file.FileName);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }
            }
            catch (Exception ex)
            {
                success = false;
                message = ex.Message;
            }
            return new ObjectResult(new { success, message });
        }
    }
}