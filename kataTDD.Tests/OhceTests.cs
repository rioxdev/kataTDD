using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace kataTDD.Tests
{
    public class OhceTests
    {

        [Fact]
        public void PrintShouldPrintMorningGreetings()
        {
            var date = DateTime.MinValue.AddHours(6);
            var output = Ohce.Print("ohce Pedro", date);
            output.Should().Be("Buenos dias Pedro !");
        }

        [Fact]
        public void PrintShouldPrintAfternoonGreetings()
        {
            var date = DateTime.MinValue.AddHours(14);
            var output = Ohce.Print("ohce Pedro", date);
            output.Should().Be("Buenas tardes Pedro !");
        }

        [Fact]
        public void PrintShouldPrintNightGreetings()
        {
            var date = DateTime.MinValue.AddHours(22);
            var output = Ohce.Print("ohce Pedro", date);
            output.Should().Be("Buenas noches Pedro !");
        }

        [Fact]
        public void PrintShouldPrintReverseOutput()
        {
            var output = Ohce.Print("hola", DateTime.UtcNow);
            output.Should().Be("aloh");
        }

        [Fact]
        public void PrintShouldHandlePalindrome()
        {
            var output = Ohce.Print("oto", DateTime.UtcNow);
            output.Should().Be("oto\nBonita palabra !");
        }

        [Fact]
        public void PrintShouldHandleStop()
        {
            var output = Ohce.Print("Stop!", DateTime.Now);
            output.Should().Be("Adios Pedro");
        }

    }
}
