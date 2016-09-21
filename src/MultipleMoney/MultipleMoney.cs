using System;

namespace MultipleMoney
{
    public class Dollar{

        public Dollar(int amount){
            this.amount = amount;
        }

        public Dollar times(int multiplier){
            return new Dollar(amount * multiplier);
        }

        public int amount;

    }

}