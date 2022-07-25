using cSharpAlgorithmPractice.PhoneNumberHandling;

// See https://aka.ms/new-console-template for more information
// Goal: All Phone Numbers are in the format (XXX)XXX-XXXX

    while(true)
    {
        Console.WriteLine("Please input your 10 digit phone number");

        string input = Console.ReadLine();
        string output = Switch.ProcessPhoneNumber(input);


        Console.WriteLine(output);

    }

