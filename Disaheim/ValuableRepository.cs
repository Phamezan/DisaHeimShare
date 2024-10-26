namespace Disaheim
{
    public class ValuableRepository
    {
        private List<IValuable> valuables;

        public ValuableRepository()
        {
            valuables = new List<IValuable>();
        }
        public void AddValuable(IValuable valuable)
        {
            valuables.Add(valuable);
        }

        public IValuable GetValuable(string id)
        {
            foreach (IValuable valuable in valuables)
            {
               
                if (valuable is Merchandise merchandise && merchandise.ItemId == id)
                {
                    return valuable;
                } 
            }
            return null;
        }
        public double GetTotalValue()
        {
            double total = 0;
            foreach (IValuable valuable in valuables)
            {
                total += valuable.GetValue();
            }
            return total;
        }
        public int Count()
        {
            return valuables.Count;
        }
    }
}
