using System;
using System.Linq;
using XamlBrewer.Uwp.RadDataGridSample.Data;

namespace XamlBrewer.Uwp.RadDataGridSample.Models
{
    public class Driver
    {
        public string Name { get; set; }

        public string Team { get; set; }

        public string LocationCode { get; set; }

        public Experience Experience { get; set; }

        public DateTime? MostRecentVictory { get; set; }

        public bool IsStillActive { get; set; } = true;

        public string ActiveDescription => IsStillActive ? "Active" : "Retired";

        public double ExperienceAsNumber => (double)Experience;

        public Location Location => (from c in Dal.Locations
                                     where c.Code == LocationCode
                                     select c).FirstOrDefault();

        public string LocationName => Location.Name;

    }
}
