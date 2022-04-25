using System.Collections.Generic;
using System.Linq;

namespace Hole5
{
    public class TakeHomeCalculator
    {
        private readonly TaxtRate taxtRate;

        public TakeHomeCalculator(TaxtRate taxRate)
        {
            this.taxtRate = taxRate;
        }

        public Money NetAmount(Money first, params Money[] rest)
        {
            List<Money> monies = rest.ToList();

            Money total = first;

            foreach (Money next in monies)
            {
                total = total.Plus(next);
            }

            Money tax = taxtRate.Apply(total);
            return total.Minus(tax);
        }
    }
}