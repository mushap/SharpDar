using System;
using System.Collections.Generic;
using System.Text;

namespace ToolKit
{
    public class DelegateExample
    {
      
        public List<int> getEvenNumbers(List<int> numbers)
        {

            List<int> evenNumbers = new List<int>();

            evenNumbers=numbers.FindAll(delegate (int number)
            {
                return number % 2 == 0;
            });

            return evenNumbers;
        }


    }
}
