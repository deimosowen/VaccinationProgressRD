using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using VaccinationProgressRD.Models;
using VaccinationProgressRD.Services;

namespace VaccinationProgressRD.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IHtmlWebParser _htmlWebParser; 
        private readonly ILogger<IndexModel> _logger; 

        public IndexModel(IHtmlWebParser htmlWebParser, ILogger<IndexModel> logger)
        {
            _htmlWebParser = htmlWebParser;
            _logger = logger;
        }

        public RegionDataViewModel ViewModel { get; private set; }

        public void OnGet()
        {
            ViewModel = new RegionDataViewModel()
            {
                RegionsData = _htmlWebParser.GetVaccinationProgress()
            };
        }
    }
}