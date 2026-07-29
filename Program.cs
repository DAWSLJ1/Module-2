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
                Console.WriteLine("2. List Operations");
                Console.WriteLine("3. Book List");
                Console.WriteLine("4. Student Grades Dictionary");
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
                        List();
                        break;
                    case 3:
                        Console.Clear();
                        Book();
                        break;
                    case 4:
                        Console.Clear();
                        Grade();
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
        }
        public static void List()
        {
            bool Is35;
            List<int> nums = new List<int> { 65, 35, 79, 101, 35 };
            nums.Insert(1, 25);
            if (nums.Contains(35))
            {
                Is35 = true;
            }
            else
            {
                Is35 = false;
            }
            int firstNumberGreaterThan30 = nums.Find(f => f > 30);
            nums.Sort();
            foreach (var i in nums)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(Is35);

            Console.ReadLine();
        }
        public static void Book()
        {
            List<string> bookTitles = new List<string> { "The Great Gatsby", "To Kill a Mockingbird", "1984", "Brave New World" };
            int totalBooks = bookTitles.Count;
            bool IsBNW;
            int Index1984 = bookTitles.IndexOf("1984");
            foreach (var bookTitle in bookTitles)
            {
                Console.WriteLine(bookTitle);
            }
            Console.WriteLine();
            Console.WriteLine($"There are {totalBooks} books");
            if (bookTitles.Contains("Brave New World"))
            {
                IsBNW = true;
            }
            else
            {
                IsBNW = false;
            }
            Console.WriteLine(IsBNW);
            Console.WriteLine(Index1984);
            bookTitles.Clear();
            Console.WriteLine(totalBooks);
            Console.ReadLine();

        }
        public static void Grade()
        {
            Dictionary<string, int> studentGrades = new Dictionary<string, int>
            { 
        { "Alice", 92 }, { "Bob", 87 }, { "Charlie", 95 }, { "Diana", 88 }, { "Eve", 91 } };

            studentGrades.Add("Frank", 89);
            studentGrades["Bob"] = 90;
            bool hasAlice = studentGrades.ContainsKey("Alice");
            foreach (var entry in studentGrades)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }
            Console.WriteLine(hasAlice);
            if (studentGrades.TryGetValue("Grace", out int grace))
            {
                Console.WriteLine($"Grace's score: {grace}");
            }
            else
            {
                Console.WriteLine("No value has shown up for 'Grace'");
            }
            Console.WriteLine();
            Console.WriteLine("Grades above 90%");
                Console.ReadLine();
        }
    } 
    }

