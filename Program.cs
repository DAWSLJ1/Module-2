namespace Module2
{
    internal class Program
    {
        static void Main()
        {
            int input;
            do
            {
                Console.Clear();
                Console.WriteLine("\tModule 2");
                Console.WriteLine("Which task would you like to visit?");
                Console.WriteLine();
                Console.WriteLine("1. Combining Lists");
                Console.WriteLine("2. ConvertToSeconds");
                Console.WriteLine("3. Remove Vowels");
                Console.WriteLine("4. Array Average");
                Console.WriteLine("5. Array Operation");
                Console.WriteLine("6. Word Count");
                Console.WriteLine("7. Is Prime");
                Console.WriteLine("8. Is Palindrome");
                Console.WriteLine("9. Is Anagram");
                Console.WriteLine("10. Filter Countries");
                Console.WriteLine("11. Random Joke");
                Console.WriteLine("0. Exit");
                input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 0:
                        break;
                    case 1:
                        Console.Clear();
                        Combine();
                        break;
                    case 2:
                        Console.Clear();
                        
                        break;
                    case 3:
                        Console.Clear();
                        
                        break;
                    case 4:
                        Console.Clear();
                        
                        break;
                    case 5:
                        Console.Clear();
                        
                        break;
                    case 6:
                        Console.Clear();
                        
                        break;
                    case 7:
                        Console.Clear();
                        
                        break;
                    case 8:
                        Console.Clear();
                        
                        break;
                    case 9:
                        Console.Clear();
                      
                        break;
                    case 10:
                        Console.Clear();
                        
                        break;
                    case 11:
                        Console.Clear();
                       
                        break;
                    default:
                        Console.Clear();
                        //Main();
                        break;
                }

            } while (input != 0);

        }
        public static void Combine()
        {
            List<string> progLangsOne = new List<string> { "C#", "JavaScript", "Kotlin", "Python" };
            List<string> progLangsTwo = new List<string> { "C++", "Go", "Swift", "TypeScript" };
            List<string> allProgLangs = new List<string> { };
            allProgLangs.AddRange(progLangsOne);
            allProgLangs.AddRange(progLangsTwo);
            allProgLangs.Remove("Swift");
            allProgLangs.Add("Rust");

            foreach (var lag in allProgLangs)
            {
                Console.WriteLine(lag);
            }
            Console.ReadLine();
            Main();
        }
    }
    }

