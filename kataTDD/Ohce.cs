using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace kataTDD
{
    public class Ohce
    {
        static readonly string userFile = "user.txt";

        public static string Print(string input, DateTime date)
        {
            var output = string.Empty;

            var inputArray = input.Split(' ');
            var command = inputArray[0];

            if (command == "ohce")
            {
                var name = inputArray[1];

                if (date.Hour >= 6 && date.Hour <= 12)
                    output = $"Buenos dias {name} !";
                else if (date.Hour > 12 && date.Hour <= 20)
                    output = $"Buenas tardes {name} !";
                else
                    output = $"Buenas noches {name} !";

                SaveUserName(name);
            }
            else if (command == "Stop!")
            {
                output = $"Adios {LoadUserName()}";
            }
            else
            {
                if (IsPalindrome(command))
                {
                    output = $"{command}\nBonita palabra !";
                }
                else
                {
                    var reversed = command.ToCharArray().Reverse();
                    output = string.Join(string.Empty, reversed);
                }
            }

            return output;
        }

        private static bool IsPalindrome(string str)
        {
            var reversed = str.ToCharArray().Reverse();
            return str == string.Join(string.Empty, reversed);
        }

        private static void SaveUserName(string name) => File.WriteAllText(userFile, name);

        private static string LoadUserName() => File.ReadAllText(userFile);


    }
}
