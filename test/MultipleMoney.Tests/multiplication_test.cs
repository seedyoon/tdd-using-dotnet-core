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
            
            var product = five.times(2);
            
            Assert.Equal(10, product.amount);

            product = five.times(3);

            Assert.Equal(15, product.amount);
            
        }

    }
}