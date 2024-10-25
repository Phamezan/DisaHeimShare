namespace Disaheim
{
    public class Amulet : Merchandise
    {
        //public string ItemId { get; set; }
        public string Design { get; set; }
        public Level Quality { get; set; }
        public static double LowQualityValue { get; set; } = 12.5;

        public static double MediumQualityVlaue { get; set; } = 20.0;

        public static double HighQualityValue { get; set; } = 27.5;
        public Amulet(string itemId) : this (itemId, Level.medium, "")
        {
        }

        public Amulet(string itemId, Level quality) : this (itemId, quality, "")
        {
        }

        public Amulet(string itemId, Level quality, string design) 
        {
            this.ItemId = itemId;
            this.Quality = quality;
            this.Design = design;
        }

        public override string ToString()
        {
            return $"ItemId: {ItemId}, Quality: {Quality}, Design: {Design}";
        }

        public override double GetValue()
        {
            double total = 0;
            switch (Quality)
            {
                case Level.low:
                    total = LowQualityValue; break;
                case Level.medium:
                    total = MediumQualityVlaue; break;
                case Level.high:
                    total = HighQualityValue; break;
            }
            return total;
        }
    }
}
