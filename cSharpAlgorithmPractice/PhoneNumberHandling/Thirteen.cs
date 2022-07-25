using System;
namespace cSharpAlgorithmPractice.PhoneNumberHandling
{
    public class Thirteen
    {
        public static string Format(string input)
        {
            string output;
            string areaCode = $"{input[1]}{input[2]}{input[3]}";
            string firstThree = $"{input[5]}{input[6]}{input[7]}";
            string lastFour = $"{input[9]}{input[10]}{input[11]}{input[12]}";

            if (int.TryParse(input, out int num))
            {
                output = "Phone number has too many digits";
            }
            
            else if (!Char.IsNumber(input[0]) && !Char.IsNumber(input[4]) && !Char.IsNumber(input[8]) && int.TryParse(areaCode, out int num1) && int.TryParse(firstThree, out int num2) && int.TryParse(lastFour, out int num3))
            {
                output = $"({input[1]}{input[2]}{input[3]}){input[5]}{input[6]}{input[7]}-{input[9]}{input[10]}{input[11]}{input[12]}";
            }
            
            else
            {
                output = "Phone number is not in a recognized format.";
            }

            return output;
        }
    }
}

