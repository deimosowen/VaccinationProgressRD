﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VaccinationProgressRD.Models
{
    public static class RegionSvgDictionary
    {
        private static readonly Dictionary<string, string> Regions = new()
        {
            ["Махачкала город"] = "path4245",
            ["Буйнакск город"] = "path4572",
            ["Дагестанские Огни город"] = "path4574",
            ["Дербент город"] = "path4492",
            ["Избербаш город"] = "path4486",
            ["Каспийск город"] = "path4482",
            ["Кизилюрт город"] = "path4564",
            ["Кизляр город"] = "path4592",
            ["Хасавюрт город"] = "path4566",
            ["Южно-Сухокумск город"] = "path4570",
            ["Агульский район"] = "path4539",
            ["Акушинский район"] = "path4559",
            ["Ахвахский район"] = "path4549",
            ["Ахтынский район"] = "path4498",
            ["Бабаюртовский район"] = "path4478",
            ["Ботлихский район"] = "path4510",
            ["Буйнакский район"] = "path4524",
            ["Гергебильский район"] = "path4554",
            ["Гумбетовский район"] = "path4512",
            ["Гунибский район"] = "path4556",
            ["Дахадаевский район"] = "path4560",
            ["Дербентский район"] = "path4490",
            ["Докузпаринский район"] = "path4496",
            ["Казбековский район"] = "path4514",
            ["Кайтагский район"] = "path4530",
            ["Карабудахкентский район"] = "path4484",
            ["Каякентский район"] = "path4488",
            ["Кизилюртовский район"] = "path4520",
            ["Кизлярский район"] = "path4476",
            ["Кулинский район"] = "path4540",
            ["Кумторкалинский район"] = "path4522",
            ["Курахский район"] = "path4536",
            ["Лакский район"] = "path4542",
            ["Левашинский район"] = "path4526",
            ["Магарамкентский район"] = "path4494",
            ["Новолакский район"] = "path4516",
            ["Ногайский район"] = "path9112",
            ["Рутульский район"] = "path4500",
            ["Сергокалинский район"] = "path4528",
            ["Сулейман-Стальский район"] = "path4534",
            ["Табасаранский район"] = "path4532",
            ["Тарумовский район"] = "path4474",
            ["Тляратинский район"] = "path4502",
            ["Унцукульский район"] = "path4552",
            ["Хасавюртовский район"] = "path4213",
            ["Хивский район"] = "path4562",
            ["Хунзахский район"] = "path4550",
            ["Цумадинский район"] = "path4508",
            ["Цунтинский район"] = "path4506",
            ["Чародинский район"] = "path4544",
            ["Шамильский район"] = "path4546",
            ["Бежтинский участок"] = "path4504"
        };
        public static string GetPathByName(string name) => Regions.FirstOrDefault(f => f.Key == name).Value;
        public static string GetPathByIndex(int index) => Regions.ElementAtOrDefault(index).Value;
    }
}
