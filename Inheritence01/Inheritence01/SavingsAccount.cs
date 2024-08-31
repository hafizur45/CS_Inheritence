using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence01
{
    internal class SavingsAccount:Account
    {
        public double InterestAmount {get; set; }
        public override string WithDraw(double amount)
        {
            if (Balance - amount >= 1000)
            {
                return base.WithDraw(amount);
            }
            else
            {
                return "Insufficient balance";
            }
        }

    }
}
