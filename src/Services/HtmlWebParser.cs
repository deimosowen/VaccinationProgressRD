using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using HtmlAgilityPack;
using VaccinationProgressRD.Models;

namespace VaccinationProgressRD.Services
{
    public class HtmlWebParser: IHtmlWebParser
    {
        public List<RegionData> GetVaccinationProgress()
        {
            var web = new HtmlWeb();
            var doc = web.Load("https://mydagestan.e-dag.ru/vaccination-against-covid-19/");
            var table = doc.DocumentNode.SelectSingleNode("//div[@class='municipalities-section']//table//tbody");

            return (from trs in table.SelectNodes("tr")
                select trs.ChildNodes.Where(w => w.HasChildNodes)
                into nodes
                let id = int.Parse(nodes.ElementAt(0).InnerText.Replace(".", ""))
                select new RegionData()
                {
                    Id = id,
                    Municipality = nodes.ElementAt(1).InnerText,
                    Vaccinated = Regex.Replace(nodes.ElementAt(3).InnerText, @"\s(\.[\d]+)?", ""),
                    HighlightedVaccines = Regex.Replace(nodes.ElementAt(4).ChildNodes[0].InnerText, @"\s(\.[\d]+)?", ""),
                    VaccinatedQuantity = Regex.Replace(nodes.ElementAt(5).ChildNodes[0].InnerText, @"\s(\.[\d]+)?", ""),
                    VaccinatedPercent = Regex.Replace(nodes.ElementAt(7).ChildNodes[0].InnerText, @"\s(\.[\d]+)?", ""),
                    Path = RegionSvgDictionary.GetPathByIndex(id - 1)
                }).ToList();
        }
    }
}