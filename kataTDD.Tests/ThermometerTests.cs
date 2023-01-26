using FluentAssertions;
using kataTDD.Tests.TestData;

namespace kataTDD.Tests
{
    public class ThermometerTests
    {

        public static IEnumerable<object[]> CreateParameters()
        {
            yield return new object[] { Array.Empty<int>(), 0 };
            yield return new object[] { new int[] { 2, 9, 1 }, 1 };
            yield return new object[] { new int[] { 2, 9, -1 }, -1 };
            yield return new object[] { new int[] { 2, 9, -2, -3 }, 2 };
            yield return new object[] { new int[] { -11 }, 11 };
        }

        [Theory]
        [MemberData(nameof(CreateParameters))]
        public void ThermometerShouldReturnsTempCloseToZero(int[] temperatures, int expected)
        {
            var temperature = Thermometer.GetCloseToZero(temperatures);
            temperature.Should().Be(expected);
        }

        [Theory]
        [ClassData(typeof(ThermometerTestData))]    
        public void ThermometerGivenTestDataShouldReturnsTempCloseToZero(int[] temperatures, int expected)
        {
            var temperature = Thermometer.GetCloseToZero(temperatures);
            temperature.Should().Be(expected);
        }
             
    }
}
