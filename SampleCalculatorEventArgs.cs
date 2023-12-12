using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCalculator
{
    public class SampleCalculatorEventArgs : EventArgs
    {
        public double Result { get; }

        public SampleCalculatorEventArgs(double result)
        {
            Result = result;
        }

        public delegate void CalculationPerformedEventHandler(object sender, SampleCalculatorEventArgs e);
    }

    public class Publisher
    {
        public event SampleCalculatorEventArgs.CalculationPerformedEventHandler CalculationPerformed;

        public void Add(double num1, double num2)
        {
            double result = num1 + num2;

            CalculationPerformed?.Invoke(this, new SampleCalculatorEventArgs(result));
        }
    }
}
