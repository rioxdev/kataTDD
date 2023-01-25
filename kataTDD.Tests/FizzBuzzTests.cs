using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Abstractions;

namespace kataTDD.Tests;

public class FizzBuzzTests
{

    private readonly ITestOutputHelper _outputHelper;

    public FizzBuzzTests(ITestOutputHelper outputHelper)
    {
        _outputHelper = outputHelper;
    }

    [Fact]
    public void GetList_ContainsFuzzAtLine3()
    {
        var result = FizzBuzz.GetList();

        result.Should().HaveElementAt(2, "Fizz");
    }

    [Fact]
    public void GetList_ContainsBuzzAtLine5()
    {
        var result = FizzBuzz.GetList();

        result.Should().HaveElementAt(4, "Buzz");
    }

    [Fact]
    public void GetList_ContainsFizzBuzzAtLine15()
    {
        var result = FizzBuzz.GetList();
        result.Should().HaveElementAt(14, "FizzBuzz");
    }

    [Fact]
    public void GetList_Contains4AtLine3()
    {
        var result = FizzBuzz.GetList();

        result.Should().HaveElementAt(3, "4");
    }

}
