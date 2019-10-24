namespace OdekuTour.Areas.Admin.Models
{
    public class SceneAddVM
    {
        public string Name { get; set; }
        public int Hfov { get; set; }
        public string Image { get; set; }
        public bool AutoLoad { get; set; }
        public bool IsMain { get; set; }
        public bool IsUnit { get; set; }
    }
}
