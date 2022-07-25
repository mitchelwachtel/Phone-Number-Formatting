using System;
namespace cSharpAlgorithmPractice.PhoneNumberHandling
{
    public class Switch
    {
  

        public static string ProcessPhoneNumber(string input)
        {
            string output;
            switch (input.Length)
            {
                case 10:
                    output = Ten.Format(input);
                    break;
                case 11:
                    output = Eleven.Format(input);
                    break;
                case 12:
                    output = Twelve.Format(input);
                    break;
                case 13:
                    output = Thirteen.Format(input);
                    break;
                default:
                    output = "Not a valid phone number.";
                    break;
            }

            return output;
        }


    }
}

