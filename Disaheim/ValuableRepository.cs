using System.Xml.Linq;

namespace Disaheim
{
    public class ValuableRepository : IPersistable
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

        public void Save()
        {
            using (StreamWriter wr = new StreamWriter("ValuableRepository.txt"))
            {
                foreach (IValuable valuable in valuables)
                {
                    wr.WriteLine(valuable);
                }
            }
        }

        public void Save(string fileName)
        {
            using (StreamWriter wr = new StreamWriter(fileName))
            {
                foreach (IValuable valuable in valuables)
                {
                    wr.WriteLine(valuable);
                }
            }
        }

        public void Load()
        {
            using (StreamReader sr = new StreamReader("ValuableRepository.txt"))
            {
                foreach (IValuable valuable in valuables)
                {
                    sr.ReadLine();
                }
            }
        }

        public void Load(string fileName)
        {
            using (StreamReader sr = new StreamReader(fileName))
            {
                foreach (IValuable valuable in valuables)
                {
                  sr.ReadLine();           
                }
            }
        }
    }
}
