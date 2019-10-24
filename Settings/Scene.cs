using OdekuTour.Settings.Hotspots;
using System.Collections.Generic;
using System.IO;

namespace OdekuTour.Settings
{
    public class Scene
    {
        private const string _imagePath = "images/";
        
        public string Name { get; set; }        
        public string Panorama => Path.Combine(_imagePath, Image);
        public string Image { get; set; }
        public bool ShowFullscreenCtrl { get; set; }
        public bool AutoLoad { get; set; }
        public int Hfov { get; set; }

        public bool IsMain { get; set; }
        public bool IsUnit { get; set; }
        public List<IHotspot> Hotspots { get; set; }

        public Scene()
        {
            Hotspots = new List<IHotspot>();
            AutoLoad = true;
            Hfov = 180;
        }
        public Scene(IEnumerable<IHotspot> hotspots) : this()
        {
            Hotspots = new List<IHotspot>(hotspots);
        }

        public override int GetHashCode() => Name.GetHashCode();
        public override bool Equals(object obj) => obj?.GetHashCode() == GetHashCode();
        public override string ToString()
        {
            return $"{Name}({Hotspots.Count}): {Panorama}";
        }
    }
}
