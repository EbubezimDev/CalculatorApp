namespace CalculatorApp
{

    // OOP - Object Oriented Programming 


    internal class Program
    {

        // 3 things that can be in a class
        // - Fields  - fieldNames usually are in camelCase or lowerCase
        // - Properties  - PropertyNames are in PascalCase
        // - Methods    - MethodsNames are in PascalCase

        // Access Modifiers - private, public, internal  
        // Internal - Can be accessed inside the namespace
        // Private - It cannot be accessed outside itself
        // Public - It can be accessed anywhere

        // By default, if I create a class or a method without any access modifier, it is automatically set to private 


        static void Main(string[] args)
        {
            #region Introduction

            /*

            // Introductory Section 

            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Beep(900, 1000);
            Console.Beep(700, 1000);
            Console.Beep(500, 1000);
            Console.Beep(300, 1000);
            Console.Beep(100, 1000);


            Console.WriteLine("Hello, World!");

            Average average = new Average();

            average.Backward();
            average.Forward();
            average.Calculate();



            //  DataTypes
            // - Integers: Whole Postitive and negative numbers
            // - Decimals: Numbers with decimal points
            // - Double: Handles both decimals and integers
            // - Float: Handles floating numbers.
            // - Strings: Alphabets, letters, sentences etc. 
            // - Char: Can only take one character.
            // - Boolean: Handles two sided conditions - True or False
            // - 

            // Definition and Initialization
            // Variables: Is a memory locations used to store data.
            // Variable defination- VariableName, DataType and the Value
            // RUles for naming a variable
            // - A variable should not start with a number
            // - A viarble should not contain spaces
            // - A variable should not contain Keywords

            // To join multiple words in naming a variable: either you use underscore _ or you join them together using camelCasing or PascalCasing

            int Score;
            Score = 23;

            string StudentName = "Jonny";

            int Score_In_Maths = 80;

            int ScoreInEnglish = 78;   // Pascal Casing

            int scoreInGeography = 68;  // camelCasing 



            Console.WriteLine(Score);
            Console.WriteLine(StudentName);

            // Arithematic Operators
            // +, -, *, /, % , =, <, >, <=, >=, !=,  OR, AND, 

            int answer = 45 * 5;
            Console.WriteLine(answer);

            int x = 30;
            int y = 40;

            double z = x + y;

            Console.WriteLine(z);

            // Taking users input.
            Console.WriteLine("Enter your Name");

            string Name = Console.ReadLine();


            Console.WriteLine(Name);

            // Concatenation - Joining multiple strings/words together

            Console.WriteLine("Welcome " + Name + "!, This is our first Program");

            Console.WriteLine("Enter your Age");

            // Console.Readline Only returns a string, thus when we want to store it in another data type that is not string,
            // we must convert from string to that data type
            // Parse

            int Age = int.Parse(Console.ReadLine());

            decimal Amoount = decimal.Parse(Console.ReadLine());

            float AccountBalance = float.Parse(Console.ReadLine());


            Console.WriteLine(Age);
            Console.WriteLine(AccountBalance);
            Console.WriteLine(Amoount);

            */

            #endregion


            #region Conditional Statements
            /*
             Conditional STatements Section

            ConditionalStatements checker = new ConditionalStatements();

            Console.WriteLine("Welcome to Our Website");

            Console.WriteLine("Before you Proceed, let's confirm your age");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("One more thing, how much are you willing to pay");
            double amount = double.Parse(Console.ReadLine());


            checker.Check(age, amount);

            Console.WriteLine("To know your seating position, whats your Section Name");
            string SectionName = Console.ReadLine();

            checker.checkSection(SectionName);

             */
            #endregion


            Loops loopCheck = new Loops();

            loopCheck.Run();

        }
    }
}
