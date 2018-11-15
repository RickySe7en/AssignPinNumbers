using System;

namespace AssignPinNumbers
{
    class Program
    {
        private const int RequiredItemNumber = 1000;

        static void Main()
        {
            Console.WriteLine("Returning 1000 unique pin numbers.");
            Console.WriteLine(string.Join(",\t", PinNumberHelper.GetPinNumberList(RequiredItemNumber)));
        }
    }
}
