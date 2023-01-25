using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kataTDD;

public static class FizzBuzz
{

    public static List<string> GetList()
    {
        var result = new List<string>();

        Enumerable.Range(1, 100).ToList().ForEach(x =>
        {
            if (x % 3 == 0 && x % 5 == 0)
                result.Add("FizzBuzz");
            else
                if (x % 3 == 0)
                result.Add("Fizz");
            else if (x % 5 == 0)
                result.Add("Buzz");
            else
                result.Add(x.ToString());
        });

        return result;
    }

}
