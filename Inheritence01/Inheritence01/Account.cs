using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence01
{
    internal class Account
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public double Balance { get; private set; }
        public string Deposite(double amount)
        {
            Balance += amount;
            return "Success";
        }
        public virtual string WithDraw(double amount)
        {
            if (Balance - amount >= 1000)
            {
                Balance -= amount;
                return "Success";
            }
            else
            {
                return "Insufficient Balance";
            }
        }
    }
}
