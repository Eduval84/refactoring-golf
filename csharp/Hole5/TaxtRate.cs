using System;

namespace Hole5
{
    public class TaxtRate
    {
        private readonly int percent;

        public TaxtRate(int percent)
        {
            this.percent = percent;
        }

        public Money Apply(Money total)
        {
            Double amount = total.value * (percent / 100d);
            return Money.Create(Convert.ToInt32(amount), total.currency);
        }
    }
}