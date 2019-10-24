namespace OdekuTour.Settings.Hotspots
{
    public sealed class SceneHotspot : IHotspot
    {
        public double Pitch { get; set; }
        public double Yaw { get; set; }
        public string Type => "scene";
        public string SceneId { get; set; }
        
        public string Title { get;set; }
        public string Subtitle { get; set; }
        public string Description { get; set; }
        public string Footer { get; set; }
    }
}
