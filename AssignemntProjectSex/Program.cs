using System;

namespace AssignemntProjectSex
{

    #region Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.

    public enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }


    #endregion


    #region Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members. 

    public enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }
    #endregion


    #region  Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.


    public enum Permissions
    {
        None = 0,      
        Read = 1 << 0,  
        Write = 1 << 1, 
        Delete = 1 << 2,
        Execute = 1 << 3
    }

    #endregion

    #region  Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as 
    enum Colors
    {
        Red,
        Green,
        Blue
    }

    #endregion


    internal class Program
    {
      
        static void Main(string[] args)
        {

            #region Q1)call
            //int valueParam = 10;
            //int refParam = 20;

            //Console.WriteLine("Before Method Call:");
            //Console.WriteLine($"Value Parameter: {valueParam}");
            //Console.WriteLine($"Reference Parameter: {refParam}");

            //// Passing by value
            //ModifyByValue(valueParam);
            //// Passing by reference
            //ModifyByReference(ref refParam);

            //Console.WriteLine("\nAfter Method Call:");
            //Console.WriteLine($"Value Parameter: {valueParam}"); // Unchanged
            //Console.WriteLine($"Reference Parameter: {refParam}"); // Changed
            #endregion
            #region Q2) call 

            //Console.WriteLine("Enter Your number");
            //int.TryParse(Console.ReadLine(), out int num);
            //int result = SumDigits(num);
            //Console.WriteLine($"the result is {result}");

            #endregion

            #region  Q3) call

            //Console.WriteLine("Enter your number");
            //int.TryParse(Console.ReadLine(),out int num);
            //bool result = isPrime(num);
            //if(!result)
            //{
            //    Console.WriteLine("the number is prime");

            //}

            //else
            //{
            //    Console.WriteLine("not prime");
            //}
            #endregion

            #region Q4)call
            //int[] arr = { 10, 2, 5, 7, 4, 7, -5 };
            //int[] arrResult = MinMax(arr);
            //Console.WriteLine(arrResult[0]);
            //Console.WriteLine(arrResult[1]);
            #endregion

            #region Q5) call
            //Console.WriteLine(Factorial(5));
            #endregion

            #region Q6)call
            //Person person1 = new Person { Name = "Original" };
            //Person person2 = new Person { Name = "Original" };

            //Console.WriteLine("Before PassByValueExample: " + person1.Name);
            //PassByValueExample(person1);
            //Console.WriteLine("After PassByValueExample: " + person1.Name);

            //Console.WriteLine("Before PassByReferenceExample: " + person2.Name);
            //PassByReferenceExample(ref person2);
            //Console.WriteLine("After PassByReferenceExample: " + person2.Name);
            #endregion

            #region Q7)call
            //int x, y, sum = 0, sub = 0;
            //Console.WriteLine("enter your first number");
            //x = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter your second number");

            //y = int.Parse(Console.ReadLine());

            //(int, int) result = SumSub(x, y, ref sum, ref sub);

            //Console.WriteLine(sum);
            //Console.WriteLine(sub);

            #endregion

            #region Q8)call
            //Console.WriteLine(ChangeChar("ahmed", 7, 'h'));

            #endregion


            //-----------------------prat--------------(2)-------------------------------

            #region  Q1)call 

            // Loop through all values of the enum and print them
            //foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(day);
            //}

            #endregion


            #region  Q2)call

            //Console.WriteLine("Enter a season name (Spring, Summer, Autumn, Winter):");
            //string userInput = Console.ReadLine();

            //// Try to parse the input into the Season enum
            //if (Enum.TryParse(userInput, true, out Season selectedSeason))
            //{
            //    // Display the month range based on the selected season
            //    string monthRange = GetMonthRange(selectedSeason);
            //    Console.WriteLine($"The months for {selectedSeason} are: {monthRange}");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid season name. Please enter Spring, Summer, Autumn, or Winter.");
            //}
            #endregion


            #region Q3)call
            //// Create a variable to store permissions
            //Permissions userPermissions = Permissions.None;

            //// Add permissions
            //userPermissions = AddPermission(userPermissions, Permissions.Read);
            //userPermissions = AddPermission(userPermissions, Permissions.Write);

            //Console.WriteLine("After Adding Read and Write:");
            //Console.WriteLine(userPermissions);

            //// Check if a specific permission exists
            //Console.WriteLine($"Has Write Permission: {HasPermission(userPermissions, Permissions.Write)}");
            //Console.WriteLine($"Has Delete Permission: {HasPermission(userPermissions, Permissions.Delete)}");

            //// Remove a permission
            //userPermissions = RemovePermission(userPermissions, Permissions.Write);
            //Console.WriteLine("After Removing Write:");
            //Console.WriteLine(userPermissions);
            #endregion

            #region Q4 call)

            //Console.WriteLine("Enter a color name:");
            //string userInput = Console.ReadLine();

            //if (Enum.TryParse(typeof(Colors), userInput, true, out var color) && Enum.IsDefined(typeof(Colors), color))
            //{
            //    Console.WriteLine($"{userInput} is a primary color.");
            //}
            //else
            //{
            //    Console.WriteLine($"{userInput} is not a primary color.");
            //}
            #endregion



        }


        #region Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.

        // Method that modifies a value-type parameter passed by value
        static void ModifyByValue(int num)
        {
            num += 10; 
        }

        // Method that modifies a value-type parameter passed by reference
        static void ModifyByReference(ref int num)
        {
            num += 10; 
        }


        #endregion

        #region   Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.

        public static int SumDigits(int num)
        {
            int result = 0;
            while (num > 0)
            {
                result += num % 10;
                num /= 10;
            }
            return result;

        }
        #endregion



        #region Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:

        static bool isPrime(int n)
        {
            if (n <= 1) return false;


            for (int i = 2; i * i <= n; i++)          
            {
                if (n % i == 0) return false;
            }
            return true;

        }
        #endregion


        #region Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters

        static int[] MinMax(int[] arr)
        {

            int min = arr[0];
            int max = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            int[] result = { min, max };
            return result;

        }

        #endregion

        #region Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter

        static int Factorial(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return (result);
        }
        #endregion


        #region Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example


        //Passing by Value

        /*
         When a reference type is passed by value, the reference to
        the object is copied. Both the original and the method's parameter point
        to the same object in memory,so changes to the object's contents will be reflected outside the method.
        However, if the method assigns a new object to the parameter, 
        this change does not affect the original reference outside the method.

 
         */

        /*
         Passing by Reference
        When a reference type is passed by reference (using the ref or out keyword), 
        the method gets direct access to the reference itself.
        This means the method can change the object contents as well as reassign the reference itself,
        and these changes will be visible outside the method.
         
         */

        // Pass by Value (Reference Type)
        static void PassByValueExample(Person person)
        {
            person.Name = "John"; // Changes contents of the object
            person = new Person { Name = "New Person" }; // Reassigns reference (has no effect outside the method)
        }

        // Pass by Reference
        static void PassByReferenceExample(ref Person person)
        {
            person.Name = "Jane"; // Changes contents of the object
            person = new Person { Name = "New Person" }; // Reassigns reference (affects the caller's reference)
        }





        #endregion


        #region Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers

        public static (int, int) SumSub(int x, int y, ref int sum, ref int sub)
        {
            sum = x + y;
            sub = x - y;
            return (sum, sub);

        }

        #endregion


        #region Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different lette

        static string ChangeChar(string str, int pos, char newChar)
        {
            if (pos < 0 || pos > str.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(pos), "position is out of range");
            }

            char[] chars = str.ToCharArray();
            chars[pos] = newChar;
            return new string(chars);
        }
        #endregion




        // Method to return the month range for a given season
        static string GetMonthRange(Season season)
        {
            return season switch
            {
                Season.Spring => "March to May",
                Season.Summer => "June to August",
                Season.Autumn => "September to November",
                Season.Winter => "December to February",
                _ => "Unknown"
            };
        }



        static Permissions AddPermission(Permissions current, Permissions toAdd)
        {
            return current | toAdd; // Use bitwise OR to add permission
        }

        static Permissions RemovePermission(Permissions current, Permissions toRemove)
        {
            return current & ~toRemove; // Use bitwise AND with complement to remove permission
        }

        static bool HasPermission(Permissions current, Permissions toCheck)
        {
            return (current & toCheck) == toCheck; // Use bitwise AND to check permission
        }

    }



}
class Person
{
    public string Name { get; set; }
}