using System.Collections.Generic;
using System.Linq;

namespace AssignPinNumbers
{
    /// <summary>
    /// Pin number helper class
    /// </summary>
    public class PinNumberHelper
    {
        /// <summary>
        /// Get list of pin numbers
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        public static IList<int> GetPinNumberList(int count)
        {
            return Enumerable.Range(1000, 9999).Where(IsPinNumber).Take(count).ToList();
        }

        /// <summary>
        /// Check if a number is pin number
        /// </summary>
        /// <param name="number">number to check</param>
        /// <returns>true if it is pin number, otherwise false</returns>
        public static bool IsPinNumber(int number)
        {
            if (number < 1000 || number > 9999)
            {
                return false;
            }

            var num4 = number % 10;
            var num3 = number / 10 % 10;
            var num2 = number / 100 % 10;
            var num1 = number / 1000 % 10;
            return new List<int> { num1, num2, num3, num4 }.Distinct().Count() == 4 &&
                   !(num1 < num2 && num2 < num3 && num3 < num4);
        }
    }
}
