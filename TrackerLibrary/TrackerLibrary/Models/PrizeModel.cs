using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TrackerLibrary.Models
{
    public class PrizeModel
    {
        public int Id { get; set; }

        [Display(Name = "Place Number")]
        [Range(1, 100)]
        [Required]
        public  int PlaceNumber { get; set; }

        [Display(Name = "Place Name")]
        [StringLength(30, MinimumLength = 3)]
        [Required]
        public string PlaceName { get; set; }

        [Display(Name = "Prize Amount")]
        [DataType(DataType.Currency)]
        public decimal PrizeAmount { get; set; }

        [Display(Name = "Prize Percentage")]
        public double PrizePercentage { get; set; }

        public PrizeModel()
        {

        }

        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
      
            PlaceName = placeName;

            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;
        }
    }
}
