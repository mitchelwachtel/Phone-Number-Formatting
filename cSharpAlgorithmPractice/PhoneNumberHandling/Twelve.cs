using System;
namespace cSharpAlgorithmPractice.PhoneNumberHandling
{
    public class Twelve
    {
        public static string Format(string input)
        {
            string output;
            string areaCode1 = $"{input[0]}{input[1]}{input[2]}";
            string areaCode2 = $"{input[1]}{input[2]}{input[3]}";
            string firstThree1 = $"{input[3]}{input[4]}{input[5]}";
            string firstThree2 = $"{input[4]}{input[5]}{input[6]}";
            string firstThree3 = $"{input[5]}{input[5]}{input[6]}";
            string lastFour = $"{input[8]}{input[9]}{input[10]}{input[11]}";

            if (int.TryParse(input, out int num))
            {
                output = "Phone number has too many digits";
            }
            else if (Char.IsNumber(input[0]) && !Char.IsNumber(input[3]) && !Char.IsNumber(input[7]) && int.TryParse(areaCode1, out int num2) && int.TryParse(firstThree2, out int num3) && int.TryParse(lastFour, out int num4))
            {
                output = $"({input[0]}{input[1]}{input[2]}){input[4]}{input[5]}{input[6]}-{input[8]}{input[9]}{input[10]}{input[11]}";
            }
            else if (!Char.IsNumber(input[0]) && !Char.IsNumber(input[4]) && int.TryParse(areaCode2, out int num5) && int.TryParse(firstThree3, out int num6) && int.TryParse(lastFour, out int num7))
            {
                output = $"({input[1]}{input[2]}{input[3]}){input[5]}{input[6]}{input[7]}-{input[8]}{input[9]}{input[10]}{input[11]}";
            }
            else if (!Char.IsNumber(input[3]) && !Char.IsNumber(input[4]) && int.TryParse(areaCode1, out int num8) && int.TryParse(firstThree3, out int num9) && int.TryParse(lastFour, out int num10))
            {
                output = $"({input[0]}{input[1]}{input[2]}){input[5]}{input[6]}{input[7]}-{input[8]}{input[9]}{input[10]}{input[11]}";
            }
            else
            {
                output = "Phone number is not in a recognized format.";
            }

            return output;
        }
    }
}

