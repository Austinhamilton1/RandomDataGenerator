using System;
using System.CodeDom.Compiler;
using System.Collections;

namespace RandomDataGenerator
{
    class Program
    {
        static List<Person> _people;
        public static void Main(string[] args)
        {
            _people = new List<Person>();
            int input = 0;

            do
            {
                PrintMenu();
                input = GetInput();
                ParseInput(input);
            } while (input != 7);

        }

        static void PrintMenu()
        {
            Console.Clear();
            Console.WriteLine("------------------------------");
            Console.WriteLine("1. Create a Person.");
            Console.WriteLine("2. Show All Person Objects");
            Console.WriteLine("3. Remove Person");
            Console.WriteLine("4. Generate Random Last Name");
            Console.WriteLine("5. Generate Random SSN");
            Console.WriteLine("6. Generate Random Phone Number");
            Console.WriteLine("7. Exit");
            Console.WriteLine("------------------------------");
            Console.Write("Enter your choice >> ");
        }

        static int GetInput()
        {
            //try to get the input as an integer, if it doesn't work, give a 0
            try
            {
                int input = Convert.ToInt32(Console.ReadLine());
                return input;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        static void Continue()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        static string GenerateLastName()
        {
            Random random = new Random();
            Array values = Enum.GetValues(typeof(LastName));
            return values.GetValue(random.Next(values.Length)).ToString();
        }

        static void PrintPeople()
        {
            for (int i = 0; i < _people.Count; i++)
            {
                Console.WriteLine($"{i + 1}.");
                Console.WriteLine(_people[i]);
            }
        }

        static void ParseInput(int input)
        {
            switch(input)
            {
                case 1:
                    Person person = new Person();
                    Console.WriteLine(person);
                    _people.Add(person);
                    Continue();
                    break;
                case 2:
                    PrintPeople();
                    Continue();
                    break;
                case 3:
                    PrintPeople();
                    Console.Write("Enter the number of the person you would like to " +
                        "remove>> ");
                    try
                    {
                        int p = Convert.ToInt32(Console.ReadLine());
                        if(p <= _people.Count && p > 0)
                            _people.RemoveAt(p - 1);
                        else
                            Console.WriteLine("Invalid Input.");
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine("Invalid Input.");
                    }
                    Continue();
                    break;
                case 4:
                    Console.WriteLine(GenerateLastName());
                    Continue();
                    break;
                case 5:
                    Console.WriteLine(new SSN());
                    Continue();
                    break;
                case 6:
                    Console.WriteLine(new Phone());
                    Continue();
                    break;
                case 7:
                    Console.WriteLine("Good Bye!");
                    break;
                default:
                    Console.WriteLine("Invalid Input.");
                    Continue();
                    break;
            }
        }
    }
}