using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COVID.Models
{
    public class TB_COVID_01
    {
        public string city { get; set; }

        public int? city_ibge_code { get; set; }

        public DateTime? date { get; set; }

        public int? epidemiological_week { get; set; }

        public int? estimated_population { get; set; }

        public int? estimated_population_2019 { get; set; }

        public bool? is_last { get; set; }

        public bool? is_repeated { get; set; }

        public string last_available_confirmed { get; set; }

        public double? last_available_confirmed_per_100k_inhabitants { get; set; }

        public DateTime? last_available_date { get; set; }

        public double? last_available_death_rate { get; set; }

        public string last_available_deaths { get; set; }

        public string order_for_place { get; set; }

        public string place_type { get; set; }

        public string state { get; set; }

        public string new_confirmed { get; set; }

        public string new_deaths { get; set; }
    }
}
