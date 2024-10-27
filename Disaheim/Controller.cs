using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Controller
    {
        public ValuableRepository ValuableRepo;

        public Controller()
        {
            ValuableRepo = new ValuableRepository();
        }

        public void AddToList(IValuable valuable)
        {
            ValuableRepo.AddValuable(valuable);
        }

    }
}
