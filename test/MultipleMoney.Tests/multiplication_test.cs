using System;
using MultipleMoney;
using Xunit;

namespace MultipleMoney.Test
{
    public class Multiplication_Test
    {
        
        public Multiplication_Test(){}

        [Fact]
        public void testMultiplication()
        {
            Dollar five = new Dollar(5);
                        
            Assert.Equal( new Dollar(10), five.times(2));

            Assert.Equal( new Dollar(15), five.times(3));
            
        }

        [Fact]
        public void TestEquality(){
            Assert.True(new Dollar(5).Equals(new Dollar(5)));
            
            Assert.False(new Dollar(5).Equals(new Dollar(6)));
        }


        [Fact]
        public void testFrancMultiplication()
        {
            Franc five = new Franc(5);
                        
            Assert.Equal( new Franc(10), five.times(2));

            Assert.Equal( new Franc(15), five.times(3));
            
        }

    }
}