using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherWebApplication1.Models
{
    public class WeatherForecast
    {
        [DisplayName("Id")]
        public int Id { get; set; }

        [DisplayName("Weather State Name")]
        public string Weather_state_name { get; set; }

        [DisplayName("Weather State Abbr")]
        public string Weather_state_abbr { get; set; }

        [DisplayName("Wind Direction Compass")]
        public string Wind_direction_compass { get; set; }

        [DisplayName("Created")]
        public DateTime Created { get; set; }

        [DisplayName("Applicable Date")]
        public string Applicable_date { get; set; }

        [DisplayName("Min Temp")]
        public float? Min_temp { get; set; }

        [DisplayName("Max Temp")]
        public float? Max_temp { get; set; }

        [DisplayName("The Temp")]
        public float? The_temp { get; set; }

        [DisplayName("Wind Speed")]
        public float? Wind_speed { get; set; }

        [DisplayName("Wind Direction")]
        public float Wind_direction { get; set; }

        [DisplayName("Air Pressure")]
        public float? Air_pressure { get; set; }

        [DisplayName("Humidity")]
        public int? Humidity { get; set; }

        [DisplayName("Visibility")]
        public float? Visibility { get; set; }

        [DisplayName("Predictability")]
        public int Predictability { get; set; }
    }
    
}
