using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace kataTDD.Tests
{
    public class StringCalculatorTests
    {
        //STEP 1
        [Fact]
        public void Add_GivenEmptyReturns0()
        {
            int sum = StringCalculator.Add(string.Empty);
            sum.Should().Be(0);
        }

        [Fact]
        public void Add_GivenOneNumberReturnsTheNumber()
        {
            int sum = StringCalculator.Add("7");
            sum.Should().Be(7);
        }

        [Fact]
        public void Add_GivenTwoNumbersReturnsTheSum()
        {
            int sum = StringCalculator.Add("4,2");
            sum.Should().Be(6);
        }

        //STEP 2
        [Fact]
        public void Add_GivenUnknownAmountNumbersReturnsSum()
        {
            int sum = StringCalculator.Add("12,4,8,10");
            sum.Should().Be(34);
        }

        //STEP 3
        [Fact]
        public void Add_ShouldHandleNewLinesSeparator()
        {
            int sum = StringCalculator.Add("1\n2,3");
            sum.Should().Be(6);
        }

        //STEP 4
        [Fact]
        public void Add_ShouldHandleFirstLineSeparator()
        {
            int sum = StringCalculator.Add("//;\n1;2");
            sum.Should().Be(3);
        }

        //STEP 5
        [Fact]
        public void Add_GivenNegativeNumbersThrowsException()
        {

            Action act = () => StringCalculator.Add("-1,7");
            act.Should().Throw<ArgumentOutOfRangeException>();
        }

        [Fact]
        public void Add_GivenNegativeNumbersThrowsExceptionWithCustomeMessageIncludingTheNumbers()
        {
            string customeMessage = "negatives not allowed: -3,-8";
            Action act = () => StringCalculator.Add("2,-3,7\n-8");
            act.Should().Throw<ArgumentOutOfRangeException>()
                .WithMessage(customeMessage);
        }

        //STEP 6
        [Fact]
        public void Add_ShouldIgnoreNumberBiggerThan1000()
        {
            int sum = StringCalculator.Add("2,1001");
            sum.Should().Be(2);
        }
    }
}
