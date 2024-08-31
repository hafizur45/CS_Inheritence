using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount sv1 = new SavingsAccount();
            sv1.Name = "Hafizur";
            sv1.Email = "hafizur@gmail.com";
            sv1.InterestAmount = 500;
            sv1.Deposite(20000);
            //Console.WriteLine( sv1.Deposite(20000));
            sv1.WithDraw(5000);

            CurrentAccount cr1 = new CurrentAccount();
            cr1.Name = "Supon";
            cr1.Email = "Supon@gmail.com";
            cr1.ServiceCharge = 1200;
            cr1.Deposite(80000);
            cr1.WithDraw(5000);
        }
    }
}
