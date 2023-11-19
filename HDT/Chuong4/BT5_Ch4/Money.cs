using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT5_Ch4
{
    class Money
    {
        private int dollars;
        private int cents;

        
        public int Dollars
        {
            get
            {
                return dollars;
            } 
        }

        public int Cents
        {
            get
            {
                return cents;
            }
        }

        public Money()
        {

        }
        public Money(int dollars, int cents)
        {
            this.dollars = dollars;
            this.cents = cents;
        }

        public string toString()
        {
            return ($"Dollars: {this.dollars}$.\nCents: {this.cents} cents.");
        }
        public static Money operator +(Money money1, Money money2)
        {
            Money total = new Money();
            total.cents = money1.cents + money2.cents;
            total.dollars = money1.dollars + money2.dollars;
            return total;
        }

        public static Money operator -(Money money1, Money money2)
        {
            Money total = new Money();
            if (money1.cents > money2.cents && money1.dollars > money2.dollars)
            {
            total.cents = money1.cents - money2.cents;
            total.dollars = money1.dollars - money2.dollars;
            return total;
            }
            return total;
        }
    }
}
