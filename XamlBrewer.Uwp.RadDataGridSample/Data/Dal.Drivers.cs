using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamlBrewer.Uwp.RadDataGridSample.Models;

namespace XamlBrewer.Uwp.RadDataGridSample.Data
{
    partial class Dal
    {
        public static List<Driver> Drivers
        {
            get
            {
                var result = new List<Driver>();

                result.Add(new Driver()
                {
                    Name = "Mario",
                    Team = "Nintendo",
                    LocationCode = "IT",
                    Experience = Experience.Winner,
                    MostRecentVictory = DateTime.Today
                });

                result.Add(new Driver()
                {
                    Name = "Luigi",
                    Team = "Nintendo",
                    LocationCode = "IT",
                    Experience = Experience.Winner
                });

                result.Add(new Driver()
                {
                    Name = "Stoffel Vandoorne",
                    Team = "McLaren F1",
                    LocationCode = "BE",
                    Experience = Experience.Rookie
                });

                result.Add(new Driver()
                {
                    Name = "Fernando Alonso",
                    Team = "McLaren F1",
                    LocationCode = "SP",
                    Experience = Experience.Legend
                });

                result.Add(new Driver()
                {
                    Name = "Anakin Skywalker",
                    Team = "Indie",
                    LocationCode = "TA",
                    Experience = Experience.Winner,
                    VictoryCodes = "TA"
                });

                result.Add(new Driver()
                {
                    Name = "Sebulba",
                    Team = "Indie",
                    LocationCode = "TA",
                    Experience = Experience.Champion,
                    VictoryCodes = "TA"
                });

                result.Add(new Driver()
                {
                    Name = "Jimmie Johnson",
                    Team = "Hendrick Motorsports",
                    LocationCode = "US",
                    Experience = Experience.Legend,
                    VictoryCodes = "DA,DO,KA,LV"
                });

                return result.OrderBy(x => x.Name).ToList();
            }
        }
    }
}
