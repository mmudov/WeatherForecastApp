﻿using System.ComponentModel.DataAnnotations;

namespace WeatherForecastApp.Models
{
    public class SearchByCity
    {
        [Required(ErrorMessage = "City name is emty!")]
        [Display(Name = "City Name")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Invalid Input, Length must be between 2 to 20 characters")]
        public string CityName { get; set; }
    }
}
