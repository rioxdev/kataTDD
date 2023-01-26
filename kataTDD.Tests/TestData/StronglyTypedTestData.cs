using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace kataTDD.Tests.TestData
{
    public class StronglyTypedTestData : TheoryData<int[], int>
    {
        public StronglyTypedTestData()
        {
            Add(new int[] { 6, 50, 34 }, 6);
            Add(new int[] { -4 }, 4);
        }
    }
}
