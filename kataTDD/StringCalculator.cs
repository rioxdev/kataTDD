using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kataTDD;

public static class StringCalculator
{

    public static int Add(string numbers)
    {
        if (String.IsNullOrEmpty(numbers)) 
            return 0;

        var defaultDelimiter = ",";

        var lines = numbers.Split('\n').ToList();

        var firstLine = lines.FirstOrDefault();
        if (firstLine != null && firstLine.StartsWith("//"))
        {
            defaultDelimiter = firstLine[2].ToString();
            lines.RemoveAt(0);
        }

        var finalString = string.Join('\n', lines);

        var uniformizedSeparator = finalString.Replace("\n", defaultDelimiter);

        var arrayOfNumbers = uniformizedSeparator.Split(defaultDelimiter)
            .Select(n => int.Parse(n)).ToList();

        var negativeNumbers = arrayOfNumbers.Where(n => n < 0).ToList();
        if (negativeNumbers.Any())
        {
            var exceptionMessage = $"negatives not allowed: {string.Join(",", negativeNumbers)}";
            throw new ArgumentOutOfRangeException(exceptionMessage, new Exception());
        }

        arrayOfNumbers = arrayOfNumbers.Where(n => n < 1000).ToList();

        return arrayOfNumbers.Sum();
    }

}
