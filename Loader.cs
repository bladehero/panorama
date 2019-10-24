using OdekuTour.Settings;
using System.Collections.Generic;
using System.Linq;

namespace OdekuTour
{
    public static class Loader
    {
        public static IEnumerable<Scene> Scenes { get; private set; }
        public static string Main => Scenes.FirstOrDefault(scene => scene.IsMain)?.Name;
        public static IEnumerable<Scene> Units => Scenes.Where(scene => scene.IsUnit && !scene.IsMain);

        static Loader()
        {
            Scenes = SettingProvider.Deserialize();
            if (Scenes == null)
            {
                Scenes = new List<Scene>();
            }
        }

        public static SettingMessage UpdateScenes()
        {
            return SettingProvider.Serialize(Scenes);
        }
        public static SettingMessage UpdateScenes(IEnumerable<Scene> scenes)
        {
            var message = SettingProvider.Serialize(scenes);
            if (!message.IsError)
            {
                Scenes = scenes;
            }
            return message;
        }
        public static SettingMessage AddScene(Scene scene)
        {
            var newScenes = new List<Scene>(Scenes);
            newScenes.Add(scene);
            var message = SettingProvider.Serialize(newScenes);
            if (!message.IsError)
            {
                Scenes = newScenes;
            }
            return message;
        }
        public static SettingMessage UpdateScene(Scene scene)
        {
            var sceneToUpdate = Scenes.FirstOrDefault(x => x.Name == scene.Name);
            sceneToUpdate.AutoLoad = scene.AutoLoad;
            sceneToUpdate.Hfov = scene.Hfov;
            sceneToUpdate.Hotspots = scene.Hotspots;
            sceneToUpdate.Image = scene.Image;
            sceneToUpdate.IsMain = scene.IsMain;
            sceneToUpdate.IsUnit = scene.IsUnit;
            sceneToUpdate.Name = scene.Name;
            sceneToUpdate.ShowFullscreenCtrl = scene.ShowFullscreenCtrl;
            var message = SettingProvider.Serialize(Scenes);
            return message;
        }
    }
}
