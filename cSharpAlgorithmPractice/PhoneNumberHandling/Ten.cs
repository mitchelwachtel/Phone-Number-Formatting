using System;
namespace cSharpAlgorithmPractice.PhoneNumberHandling
{
    public class Ten
    {
        public static string Format(string input)
        {
            string output = "";

            if (int.TryParse(input, out int num))
            {
                output = $"({input[0]}{input[1]}{input[2]}){input[3]}{input[4]}{input[5]}-{input[6]}{input[7]}{input[8]}{input[9]}";
            } else
            {
                output = "Not a valid phone number";
            }

            return output;
        }
    }
}

