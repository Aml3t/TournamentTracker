namespace TrackerLibrary.Models
{
    public class PrizeModel
    {
        /// <summary>
        /// The unique id of the prize.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The number of the place the winner gets.
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// The name of the winner
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// The price amount of the winner.
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// The percentage of the prize that should be given.
        /// </summary>
        public double PrizePercentage { get; set; }

        public PrizeModel()
        {

        }

        public PrizeModel(string placeName, string placeNumber,
                          string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double pricePercentageValue = 0;
            double.TryParse(prizePercentage, out pricePercentageValue);
            PrizePercentage = pricePercentageValue;

        }
    }
}