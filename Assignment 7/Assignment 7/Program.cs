using System;
using System.Collections.Generic;
using System.Linq;
using sc = System.Console;

namespace Assignment_7
{
    class Program
    {
        static void Main(string[] args)
        {
            var values = new
            {
                maxMinSize = 6,
                resultContains = "teen",
                resultSixContains = "six"

            };

            IList<string> stringList = new List<string>() {
                "one",
                "two",
                "three",
                "four" ,
                "five",
                "six",
                "seven",
                "eight",
                "nine",
                "ten",
                "eleven",
                "twelve",
                "thirteen",
                "fourteen",
                "fifteen",
                "sixteen",
                "seventeen",
                "eighteen",
                "nineteen",
                "twenty",
                "twenty-one",
                "twenty-two",
                "twenty-three",
                "twenty-four",
                "twenty-five",
                "twenty-six",
                "twenty-sevevn",
                "twenty-eight",
                "twenty-nine",
                "six six six"

            };

            IEnumerable<string> result = stringList.Where(s => s.Length <= values.maxMinSize);
            int resSize = result.Count();
            result = result.Concat(stringList.Where(s => s.Length > resSize));
            result = result.Concat(stringList.Where(s => s.Contains(values.resultContains)));

            IEnumerable<string> resultSix = result.Where(r => r.Contains(values.resultSixContains));

            foreach (string str in result)
                sc.WriteLine(str);

            sc.WriteLine();
            sc.WriteLine("Result, except it's just the sixes");
            foreach(string str in resultSix)
                sc.WriteLine(str);

        }

    }

}
