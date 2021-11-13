using System.Collections.Generic;
using VaccinationProgressRD.Models;

namespace VaccinationProgressRD.Services
{
    public interface IHtmlWebParser
    {
        List<RegionData> GetVaccinationProgress();
    }
}
