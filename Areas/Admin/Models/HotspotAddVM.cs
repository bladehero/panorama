namespace OdekuTour.Areas.Admin.Models
{
    public class HotspotAddVM
    {
        public string CurrentSceneId { get; set; }
        public string NextSceneId { get; set; }
        public bool HasNextSceneId { get; set; }
        public string Yaw { get; set; }
        public string Pitch { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Description { get; set; }
        public string Footer { get; set; }
        public string HotspotType { get; set; }
        public bool HasURL { get; set; }
        public string URL { get; set; }
    }
}
