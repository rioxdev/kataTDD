using FluentAssertions;
using kataTDD.Tests.TestData;
using Xunit;

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

        public static TheoryData<int[], int> CreateTheroyData()
        {
            return new TheoryData<int[], int>()
            {
                { new int[] { 1,2} , 1 },
                { new int[]  {-3,4,-7 },-3 }
            };
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

        [Theory, MemberData(nameof(CreateTheroyData))]
        public void ThermometerGivenTheroryDataShouldReturnsTempCloseToZero(int[] temperatures, int expected)
        {
            var temperature = Thermometer.GetCloseToZero(temperatures);
            temperature.Should().Be(expected);
        }


        [Theory, ClassData(typeof(StronglyTypedTestData))]
        public void ThermometerGivenStronglyTypedTestDataShouldReturnsTempCloseToZero(int[] temperatures, int expected)
        {
            var temperature = Thermometer.GetCloseToZero(temperatures);
            temperature.Should().Be(expected);
        }
    }
}
