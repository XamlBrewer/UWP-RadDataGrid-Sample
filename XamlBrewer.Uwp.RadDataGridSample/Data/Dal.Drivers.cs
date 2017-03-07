﻿using System;
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
                    Name = "Jacky Ickx",
                    Team = "Scuderia Ferrari",
                    LocationCode = "BE",
                    Experience = Experience.Champion,
                    MostRecentVictory = new DateTime(1983, 1, 15)
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
                    Team = "The Force",
                    LocationCode = "TA",
                    Experience = Experience.Winner,
                    VictoryCodes = "TA"
                });

                result.Add(new Driver()
                {
                    Name = "Sebulba",
                    Team = "Independent Driver",
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

                result.Add(new Driver()
                {
                    Name = "Dick Dastardly",
                    Team = "Wacky Races",
                    LocationCode = "US",
                    Experience = Experience.Rookie,
                    VictoryCodes = ""
                });

                result.Add(new Driver()
                {
                    Name = "Penelope Pitstop",
                    Team = "Wacky Races",
                    LocationCode = "US",
                    Experience = Experience.Winner,
                    VictoryCodes = ""
                });

                result.Add(new Driver()
                {
                    Name = "Jeremy Clarkson",
                    Team = "The Grand Tour",
                    LocationCode = "UK",
                    Experience = Experience.Winner,
                    VictoryCodes = ""
                });

                result.Add(new Driver()
                {
                    Name = "Richard Hammond",
                    Team = "The Grand Tour",
                    LocationCode = "UK",
                    Experience = Experience.Podium,
                    VictoryCodes = ""
                });

                result.Add(new Driver()
                {
                    Name = "James May",
                    Team = "The Grand Tour",
                    LocationCode = "UK",
                    Experience = Experience.Rookie,
                    VictoryCodes = ""
                });

                return result.OrderBy(x => x.Name).ToList();
            }
        }
    }
}
