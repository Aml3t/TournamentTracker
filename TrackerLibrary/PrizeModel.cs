namespace TrackerLibrary
{
    public class PrizeModel
    {
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
        public double PricePercentage { get; set; }
    }
}