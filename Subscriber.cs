using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCalculator
{
    public class Subscriber
    {
        public void Subscribe(Publisher publisher)
        {
            publisher.CalculationPerformed += CalculationPerformed;
        }

        private void CalculationPerformed(object sender, SampleCalculatorEventArgs e)
        {
            Console.WriteLine($"The result is: {e.Result}");
        }
    }
}
