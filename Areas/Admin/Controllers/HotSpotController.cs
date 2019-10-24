using Microsoft.AspNetCore.Mvc;
using OdekuTour.Areas.Admin.Models;
using OdekuTour.Settings.Hotspots;
using System;
using System.Linq;
using System.Net;

namespace OdekuTour.Areas.Admin.Controllers
{
    [Area("admin")]
    public class HotSpotController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddHotspot(HotspotAddVM hotspot)
        {
            var success = true;
            var message = "Pointer was successfully added!";
            IHotspot hotspotToAdd = null;
            try
            {
                double pitch = double.Parse(hotspot.Pitch);
                double yaw = double.Parse(hotspot.Yaw);
                if (hotspot.HotspotType == "info")
                {
                    hotspotToAdd = new InfoHotspot
                    {
                        Description = hotspot.Description,
                        Footer = hotspot.Footer,
                        Pitch = pitch,
                        Yaw = yaw,
                        Subtitle = hotspot.Subtitle,
                        Title = hotspot.Title,
                        URL = hotspot.HasURL ? hotspot.URL : null
                    };
                }
                else if (hotspot.HotspotType == "scene")
                {
                    if (!hotspot.HasNextSceneId)
                    {
                        throw new Exception("Pointer should have scene!");
                    }
                    hotspotToAdd = new SceneHotspot
                    {
                        Description = hotspot.Description,
                        Footer = hotspot.Footer,
                        Pitch = pitch,
                        Yaw = yaw,
                        Subtitle = hotspot.Subtitle,
                        Title = hotspot.Title,
                        SceneId = hotspot.NextSceneId
                    };
                }

                var scene = Loader.Scenes.FirstOrDefault(x => x.Name == hotspot.CurrentSceneId);
                if (scene != null)
                {
                    scene.Hotspots.Add(hotspotToAdd);
                    Loader.UpdateScenes();
                }
                else
                {
                    throw new Exception($"Scene isn't found with name '{hotspot.CurrentSceneId}'!");
                }
            }
            catch (Exception ex)
            {
                success = false;
                message = ex.Message;
            }
            return new ObjectResult(new { success, message });
        }

        [HttpPost]
        public IActionResult DeleteHotspot(int id, string sceneId)
        {
            var success = true;
            var message = "Pointer was successfully deleted!";
            try
            {
                var scene = Loader.Scenes.FirstOrDefault(x => x.Name == WebUtility.HtmlDecode(sceneId) || x.Name == sceneId);
                if (scene != null)
                {
                    scene.Hotspots.RemoveAt(id);
                    Loader.UpdateScenes();
                }
                else
                {
                    throw new Exception($"Scene isn't found!");
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