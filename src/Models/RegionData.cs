namespace VaccinationProgressRD.Models
{
    public class RegionData
    {
        public int Id { get; set; }
        public string Municipality { get; set; }
        public string Vaccinated { get; set; }
        public string HighlightedVaccines { get; set; }
        public string VaccinatedQuantity { get; set; }
        public string VaccinatedPercent { get; set; }
        public string Path { get; set; }
    }
}
