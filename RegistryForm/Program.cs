using System.Text.RegularExpressions;

namespace RegistryForm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fName, lName, gender;
            int age;
            bool isRegistered;

            Console.WriteLine("Enter your information correctly to register.");

            Console.WriteLine("What is your first name?");
            fName = Console.ReadLine();
            while (string.IsNullOrEmpty(fName) == true)
            {
                Console.WriteLine("Enter your first name correctly!");
                fName = Console.ReadLine();
            }
            fName = fName.Trim();

            Console.WriteLine("What is your last name?");
            lName = Console.ReadLine();
            while (string.IsNullOrEmpty(lName) == true)
            {
                Console.WriteLine("Enter your last name correctly!");
                lName = Console.ReadLine();
            }
            lName = lName.Trim();

            //Gender
            Console.WriteLine("Enter your gender: Male/Female");
            gender = Console.ReadLine();
            while (string.IsNullOrEmpty(gender) == true && gender != "Male" && gender != "Female")
            {
                Console.WriteLine("Enter your gender correctly!");
                gender = Console.ReadLine();
            }
            gender = gender.Trim();

            //Phone number
            Console.WriteLine("Enter your phone number:");
            string phone = Console.ReadLine() ?? string.Empty;
            int lenph = phone.Length;
            if (!phone.StartsWith("09") && lenph != 11)
            {
                Console.WriteLine("Enter a valid phone number please!");
                phone = Console.ReadLine() ?? string.Empty;
            }

            //Age
            Console.WriteLine("How old are you?");
            age = int.Parse(Console.ReadLine());
            if (age >= 15 && gender == "Female")
            {
                isRegistered = true;
                Console.WriteLine($"You {fName} {lName} as a {gender} with phone number {phone} and age {age} are signed up successfully.");
            }else if(age >= 18 && gender == "Male")
            {
                isRegistered = true;
                Console.WriteLine($"You {fName} {lName} as a {gender} with phone number {phone} and age {age} are signed up successfully.");
            }
            else
            {
                isRegistered = false;
                Console.WriteLine("You are not allowed to sign up.");
                Console.ForegroundColor = ConsoleColor.DarkRed;
            }
                Console.ReadLine();
        }
    }
}
