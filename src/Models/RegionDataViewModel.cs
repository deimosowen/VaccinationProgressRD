using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace VaccinationProgressRD.Models
{
    public class RegionDataViewModel
    {
        public List<RegionData> RegionsData { get; internal set; }
    }
}
