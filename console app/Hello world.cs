


using console_app;
using System.ComponentModel;

 class Program 
{

    static void Main(string[] args)
    {
        //Learning how to output hello world and string variables on the console
        HelloWorld();

        // Basics of strings
        BasicsOfStrings();

        // Searching strings
        SearchingStrings();

        // Learning about numbers and Math
        NumbersAndMath();

        // Conditional statements
        Conditionals();

        // Loops
        Loops();

        // Arrays or Lists
        Lists();

        // Classes
        Classes();
    }

    static void HelloWorld()
    {
        Console.WriteLine("[1] **** Outputting hello world and values from string variable ****");

        Console.Out.NewLine = "\r\n\r\n";

        Console.WriteLine("Hello World !");

        Console.Out.NewLine = "\r\n\r\n";

        Console.WriteLine("[1.a] *** Outputing values with from string variable ***");

        string name = "Amos";

        Console.WriteLine($"Good morning {name}");

    }

    static void BasicsOfStrings()
    {
        Console.WriteLine("[2] **** Caluclating the length of a string ****");

        Console.Out.NewLine = "\r\n\r\n";

        string word = "Massachusetts";

        Console.WriteLine($"The word '{word}' has {word.Length} letters");

        Console.WriteLine("[2.a] *** Changing the cases of strings ***");

        string first_name = "floyd";

        string last_name = "mayweather";

        Console.WriteLine($"'{first_name} {last_name}' to upper case is '{first_name.ToUpper()} {last_name.ToUpper()}'");

        string first_name2 = "MANNY";
        string last_name2 = "PACQUIAO";

        Console.WriteLine("while");

        Console.WriteLine($"'{first_name2} {last_name2}' to lower case is '{first_name2.ToLower()} {last_name2.ToLower()}'");

        Console.Out.NewLine = "\r\n\r\n";
        Console.WriteLine("[2.b] *** Trimming whitespace in a string");

        string whitespace = "       whitespace      ";

        Console.WriteLine($"[{whitespace}]");
        Console.WriteLine("** Trimming whitespace at the start **");
        Console.WriteLine($"[{whitespace.TrimStart()}]");
        Console.WriteLine("** Trimming whitespace at the end **");
        Console.WriteLine($"[{whitespace.TrimEnd()}]");
        Console.WriteLine("** Trimming all whitespace in the string **");
        Console.WriteLine($"[{whitespace.Trim()}]");
    }

    static void SearchingStrings()
    {
        Console.WriteLine("[3] **** Searching Strings ****");

        Console.Out.NewLine = "\r\n\r\n";

        Console.WriteLine("[3.a] *** Searching for a certain word in a string ***");

        string word = "Knowledge is power if you use it";

        if (word.Contains("power"))
        {
            Console.WriteLine($"The phrase '{word}' does include the word 'power'");
        }
        else
        {
            Console.WriteLine($"The phrase '{word}' does not include the word 'power'");

        }

        Console.Out.NewLine = "\r\n\r\n";

        Console.WriteLine("[3.a] *** Replacing a certain word in a string ***");

        Console.WriteLine($"Replacing the words 'knowledge' and 'use' in the phrase '{word}' with 'ignorance' and 'keep' to make a new phrase '{word.Replace("Knowledge", "Ignorance").Replace("use", "keep")}'");
    
    }

    static void NumbersAndMath()
    {
        Console.WriteLine("[4] **** Numbers and Math ****");

        Console.WriteLine("[4.a] *** Addition ***");

        int a = 2;

        int b = 5;

        Console.WriteLine($"The sum of a and b is {a+b}");

        Console.WriteLine("[4.b] *** Subtraction ***");

        Console.WriteLine($"The difference between b and a is {b-a}");

        Console.WriteLine("[4.c] *** Multiplication ***");

        Console.WriteLine($"The product of a and b is {a * b}");

        Console.WriteLine("[4.d] *** Division ***");

        Console.WriteLine($"The ratio of b to a is {b / a}");

        Console.WriteLine("[4.e] *** Modulus *** ");

        Console.WriteLine($"The Modulus of b and a is {b % a}");

        Console.Out.NewLine = "\r\n\r\n";

        Console.WriteLine("[4.f] *** Various integer data types and their ranges *** ");

        Console.WriteLine("** int **");
        Console.WriteLine($"int ranges from {int.MinValue} to {int.MaxValue}");

        Console.WriteLine("** decimal **");
        Console.WriteLine($"decimal ranges from {decimal.MinValue} to {decimal.MaxValue}");

        Console.WriteLine("** short **");
        Console.WriteLine($"short ranges from {short.MinValue} to {short.MaxValue}");

        Console.WriteLine("** double **");
        Console.WriteLine($"double ranges from {double.MinValue} to {double.MaxValue}");

        Console.WriteLine("** float **");
        Console.WriteLine($"float ranges from {float.MinValue} to {float.MaxValue}");


    }

    static void Conditionals()
    {
        Console.WriteLine("[5] **** Conditional statements ****");

        int a = 3;

        int b = 5;

        if(a > b)
        {
            Console.WriteLine($"{a} is greater than {b}");
        }
        else
        {
            Console.WriteLine($"{b} is greater than {a}");
        }

        Console.WriteLine("[5.a] *** Using AND operand in if-statement ***");


        if ((10%a == 0) && (10%b == 0))
        {
            Console.WriteLine($"10 is divisible by both {a} and {b}");
        }
        else
        {
            Console.WriteLine($"10 is divisible by either {a} or {b} or none of them");
        }
    }

    static void Loops()
    {
        Console.WriteLine("[6] **** Loops ****");

        Console.WriteLine("[6.a] *** while loops *** ");

        int a = 0;

        while(a<10)
        {
            Console.WriteLine($"Count for while loop is {a}");
            a++;
        }

        Console.WriteLine("[6.b] *** do while loops *** ");

        int b = 0;
        do
        {
            Console.WriteLine($"Count for do-while loop is {b}");
            b++;
        } while (b < 10);

        Console.WriteLine("[6.c] *** for loops ***");

        for(int i = 0; i < 8; i++)
        {
            Console.WriteLine($"Count for for loop is {i}");
        }

        Console.WriteLine("Assignment: Calculate the sum of numbers from 1 to 15 which are divisible by 4");

        int sum = 0;

        for (int i = 1; i <=15; i++)
        {
            if(i%4 == 0)
            {
                Console.WriteLine($"Number divisible {i}");
                sum = sum + i;
                Console.WriteLine($"Sum is: {sum}");

            }
        }
    }

    static void Lists()
    {
        Console.WriteLine("[7] **** Lists or Arrays ****");

        var series = new List<string> { "Sopranos", "Narcos", "Breaking bad", "Reina de la sur", "Peaky Blinders" };

        Console.WriteLine("[7.a] *** Iterating through a list *** ");
        Console.WriteLine("A list of famous crime series");
        foreach(var serie in series)
        {
            Console.WriteLine(serie);
        }

        Console.WriteLine("[7.b] *** Sorting a list ***");

        //var cars = new List<string> { "bmw", "maclaren", "porche", "honda", "toyota" };
        series.Sort();

        foreach (var serie in series)
        {
            Console.WriteLine(serie);
        }

        Console.WriteLine("[7.c] *** Adding an item to a list ***");

        Console.WriteLine("Add item 'King of Tulsa' in series List");

        series.Add("King of Tulsa");

        foreach (var serie in series)
        {
            Console.WriteLine(serie);
        }

        Console.WriteLine("[7.d] *** Remove an item from a list ***");

        Console.WriteLine("Removing item 'Reina de la sur' from series List");


        series.Remove("Reina de la sur");

        foreach (var serie in series)
        {
            Console.WriteLine(serie);
        }

        Console.WriteLine("[7.e] *** List of int type *** ");

        var Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        Console.WriteLine("** List of even numbers from array **");

        foreach(var number in Numbers)
        {
            if(number % 2 == 0)
            {
                Console.WriteLine($"Even numbers: {number}");
            }
        }


        Console.WriteLine("[7.f] *** Generating a fibonacci sequence from an array *** ");

        var fibonacciNumbers = new List<int> { 1, 1 };

        Console.WriteLine("** Fibonacci series for the first 25 numbers from 1**");

        while(fibonacciNumbers.Count <= 25) {

            var prev1 = fibonacciNumbers[fibonacciNumbers.Count - 1];
            var prev2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

            fibonacciNumbers.Add(prev1 + prev2);
        }

        foreach(var number in fibonacciNumbers) Console.WriteLine(number);
    }

    static void Classes()
    {
        var cars = new Cars(7, 5);
        cars.calculateFuelCost(7, 5);
    }
}