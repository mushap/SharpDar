using System;
using System.Collections.Generic;
using System.Text;

namespace ToolKit
{
   public class TupleExample
    {
        public static string exampleOfTupple()

        {
            Tuple<string, int, double> tuple = new Tuple<string, int, double>("first",1,0.5);

            List<Tuple<string, int>> tuples = new List<Tuple<string, int>>();
            tuples.Add(new Tuple<string, int>("second", 2));

            return  tuple.Item1;
        }
    }
}
