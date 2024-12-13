namespace CalculatorApp
{
    public class Loops
    {
        // Loops are like repeat statements that is use to continually execute a given block of codes unitl a condition is met.
        /* Types of Loops
           - While Loop - 
                while(condtion)  {
               Codes that should be running as long as the condition is true. It will stop running when the condition is false.
        }
            - DoWhile Loop
            - For Loop
            - ForEach
          Loops usually have a condition that will be met before it stops else it will continue forever. 
           Thus you must ensure that your loops have a condition that will stop it else it can crash your system! 

        */
        public void Run()
        {
            int counter = 0;
            while (counter <= 50)
            {
                Console.WriteLine("Using While Loop " + counter);
                //counter++;
                counter = counter + 1;

            }

            do
            {
                Console.WriteLine("Using DoWHile! " + counter);
                //counter++;
                counter = counter + 1;

            }
            while (counter <= 50);




        }

    }
}
