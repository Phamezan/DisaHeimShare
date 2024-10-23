using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Disaheim
{
    public class AmuletRepository
    {
        private List<Amulet> amulets;
        public void AddAmulet(Amulet amulet)
        {
            this.amulets.Add(amulet);
        }

        public Amulet GetAmulet(string itemId)
        {
            foreach (Amulet amulet in amulets)
            {
                if (amulet.ItemId == itemId)
                {
                    return amulet;
                }
            }
            return null;

        }
        public double GetTotalValue()
        {
            double total = 0;
            foreach (Amulet amulet in amulets)
            {
                switch (amulet.Quality)
                {
                    case Level.low:
                        total += 12.5;
                        break;
                    case Level.medium:
                        total += 20.0;
                        break;
                    case Level.high:
                        total += 27.5;
                        break;
                }
            }
            return total;
        }
        public AmuletRepository()
        {
            amulets = new List<Amulet>();
        }
    }
}
