using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamlBrewer.Uwp.RadDataGridSample.Data;

namespace XamlBrewer.Uwp.RadDataGridSample.Models
{
    public class Driver
    {
        public string Name { get; set; }

        public string Team { get; set; }

        public string LocationCode { get; set; }

        public Experience Experience { get; set; }

        public string VictoryCodes { get; set; }

        public DateTime? MostRecentVictory { get; set; }

        public Location Location => (from c in Dal.Locations
                                     where c.Code == LocationCode
                                     select c).FirstOrDefault();

        public List<Location> Victories
        {
            get
            {
                List<Location> result = new List<Location>();
                if (VictoryCodes == null)
                {
                    return result;
                }

                foreach (var code in this.VictoryCodes.Split(',', ' '))
                {
                    var country = (from c in Dal.Locations
                                   where c.Code == code
                                   select c).FirstOrDefault();
                    if (country != null)
                    {
                        result.Add(country);
                    }
                }

                return result;
            }
        }
    }
}
