using SampleCalculator;

namespace SampleCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Publisher calculator = new Publisher();
            Subscriber resultDisplay = new Subscriber();

            resultDisplay.Subscribe(calculator);

            calculator.Add(2, 3);

        }
    }
}