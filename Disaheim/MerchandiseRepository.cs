namespace Disaheim
{
    public class MerchandiseRepository
    {
        private List<Merchandise> merchandises;

        public MerchandiseRepository()
        {
            List<Book> books = new List<Book>();
            List<Amulet> amulets = new List<Amulet>();
            merchandises = new List<Merchandise>();
        }

        public void AddMerchandise(Merchandise merchandise)
        {
            merchandises.Add(merchandise);
        }

        public Merchandise GetMerchandise(string itemId)
        {
            foreach (Merchandise merchandise in merchandises)
            {
                if (merchandise.ItemId == itemId)
                {
                    return merchandise;
                }
            }
            return null;
        }

        public double GetTotalValue()
        {
            double totalValue = 0;
            if (merchandises != null)
            {
                foreach (Merchandise merchandise in merchandises)
                {
                    if (merchandise is Amulet amulet) 
                    {
                        totalValue += Utility.GetValueOfMerchandise(merchandise);
                    }
                    else if (merchandise is Book) 
                    {
                        totalValue += Utility.GetValueOfMerchandise(merchandise);
                    }
                }
            }
            return totalValue;
        }
    }
}
