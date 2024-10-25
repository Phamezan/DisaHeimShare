//namespace Disaheim
//{
//    public class AmuletRepository : MerchandiseRepository
//    {
//        private List<Amulet> amulets;
//        public void AddAmulet(Amulet amulet)
//        {
//            this.amulets.Add(amulet);
//        }

//        public Amulet GetAmulet(string itemId)
//        {
//            foreach (Amulet amulet in amulets)
//            {
//                if (amulet.ItemId == itemId)
//                {
//                    return amulet;
//                }
//            }
//            return null;


//        public override double GetTotalValue()
//        {
//            double total = 0;
//            foreach (Amulet amulet in merchandises)
//            {
//                switch (amulet.Quality)
//                {
//                    case Level.low:
//                        total += 12.5;
//                        break;
//                    case Level.medium:
//                        total += 20.0;
//                        break;
//                    case Level.high:
//                        total += 27.5;
//                        break;
//                }
//            }
//            return total;
//        }
//    }
//}
