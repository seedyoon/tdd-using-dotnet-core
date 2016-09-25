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

        private int amount;

        public int Amount {get {return amount;}}
        public override bool Equals (object obj)
        {
            //
            // See the full list of guidelines at
            //   http://go.microsoft.com/fwlink/?LinkID=85237
            // and also the guidance for operator== at
            //   http://go.microsoft.com/fwlink/?LinkId=85238
            //
            
         
            // TODO: write your implementation of Equals() here
            
            var dollar = (Dollar) obj;

            return amount == dollar.Amount;
        }
        
        // override object.GetHashCode
        public override int GetHashCode()
        {
            // TODO: write your implementation of GetHashCode() here
            throw new System.NotImplementedException();
            return base.GetHashCode();
        }
    }

    public class Franc{

        public Franc(int amount){
            this.amount = amount;
        }

        public Franc times(int multiplier){
            return new Franc(amount * multiplier);
        }   

        private int amount;

        public int Amount {get {return amount;}}
        public override bool Equals (object obj)
        {
            //
            // See the full list of guidelines at
            //   http://go.microsoft.com/fwlink/?LinkID=85237
            // and also the guidance for operator== at
            //   http://go.microsoft.com/fwlink/?LinkId=85238
            //
            
         
            // TODO: write your implementation of Equals() here
            
            var franc = (Franc) obj;

            return amount == franc.Amount;
        }
        
        // override object.GetHashCode
        public override int GetHashCode()
        {
            // TODO: write your implementation of GetHashCode() here
            throw new System.NotImplementedException();
            return base.GetHashCode();
        }
    }
}