using System.Collections.Generic;
using XamlBrewer.Uwp.RadDataGridSample.Models;

namespace XamlBrewer.Uwp.RadDataGridSample.Data
{
    public partial class Dal
    {
        public static List<Location> Locations
        {
            get
            {
                var result = new List<Location>();

                result.Add(new Location()
                {
                    Code = "AU",
                    Name = "Australia"
                });

                result.Add(new Location()
                {
                    Code = "BE",
                    Name = "Belgium"
                });

                result.Add(new Location()
                {
                    Code = "CZ",
                    Name = "Czech Republic"
                });

                result.Add(new Location()
                {
                    Code = "DA",
                    Name = "Daytona"
                });

                result.Add(new Location()
                {
                    Code = "DE",
                    Name = "Germany"
                });

                result.Add(new Location()
                {
                    Code = "DO",
                    Name = "Dover"
                });

                result.Add(new Location()
                {
                    Code = "FR",
                    Name = "France"
                });

                result.Add(new Location()
                {
                    Code = "GB",
                    Name = "United Kingdom"
                });

                result.Add(new Location()
                {
                    Code = "IT",
                    Name = "Italy"
                });

                result.Add(new Location()
                {
                    Code = "KA",
                    Name = "Kansas"
                });

                result.Add(new Location()
                {
                    Code = "LV",
                    Name = "Las Vegas"
                });

                result.Add(new Location()
                {
                    Code = "MA",
                    Name = "Malastare"
                });

                result.Add(new Location()
                {
                    Code = "NZ",
                    Name = "New Zealand"
                });

                result.Add(new Location()
                {
                    Code = "SP",
                    Name = "Spain"
                });

                result.Add(new Location()
                {
                    Code = "TA",
                    Name = "Tatooine"
                });

                result.Add(new Location()
                {
                    Code = "US",
                    Name = "USA"
                });

                return result;
            }
        }
    }
}
