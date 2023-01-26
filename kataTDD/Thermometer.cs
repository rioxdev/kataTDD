using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kataTDD
{
    public class Thermometer
    {
        public static int GetCloseToZero(int[] temperatures)
        {
            if (temperatures == null || !temperatures.Any())
                return 0;

            var positives = temperatures.Where(t => t >= 0);
            var negatives = temperatures.Where(t => t < 0);

            if (positives.Any() && negatives.Any())
            {
                var posMin = positives.Min();
                var negMax = negatives.Max();

                if (Math.Abs(negMax) < posMin)
                    return negMax;
                else
                    return posMin;
            }
            else if (!positives.Any() ) {
                return Math.Abs(negatives.Max());            
            }
            else 
            {
                return positives.Min();
            }

        }
    }
}
