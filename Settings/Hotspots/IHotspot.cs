namespace OdekuTour.Settings.Hotspots
{
    public interface IHotspot
    {
        double Yaw { get; set; }
        double Pitch { get; set; }
        string Title { get; set; }
        string Subtitle { get; set; }
        string Description { get; set; }
        string Footer { get; set; }
        string Type { get; }
    }
}
