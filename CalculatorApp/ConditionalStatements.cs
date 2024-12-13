namespace CalculatorApp
{
    public class ConditionalStatements
    {

        // One Crucial part of Programming is the ability to add conditions.

        // Two types of Conditional statements 
        // - IF-ELSE Statement
        // - SWITCH

        // Structure of a Method -
        // AccessModifier  returnType NameOfTheMethod(InputParametersType InputParameterName) {

        //   Operations inside the method

        //
        // }
        public void Check(int age, double amountPaid)
        {
            // Structure of IF-ELSE STATEMENT
            /* if (condition that will result into true or false) {
                
            What should happen if the contiion is true

            }
            else {
                What should if the contion is not true!
            }

            */
            // Possible Condition checks: equal ==, notEqual !=, greaterThan >, lessThan <, greaterOrEqual >=, LessOrEqual <=
            // 
            if (age >= 18)
            {
                Console.WriteLine("You are allowed to View this Site");
            }
            else
            {
                Console.WriteLine("You are not allowed to view this site! Repent!");
            }

            // Cascaded COnditions - Multiple Conditions
            // WE use Logic Operators to join two or more conditional statements - OR: ||, AND: &&
            // OR
            if (age >= 18 || amountPaid > 1000)
            {
                Console.WriteLine("You either are above 18 or you have paid above #1000");
            }
            else
            {
                Console.WriteLine("You are not allowed to view this site! Repent!");
            }

            // AND
            if (age >= 18 && amountPaid > 1000)
            {
                Console.WriteLine("You are both above 18 and have also paid above 1000");
            }
            else
            {
                Console.WriteLine("You are not allowed to view this site! Repent!");
            }

            // Cascade Conditional Statements - Chaining If statements

            if (amountPaid >= 1000 && amountPaid < 5000)
            {
                Console.WriteLine("Your section is Regular");
            }
            else if (amountPaid >= 5000 && amountPaid < 10000)
            {
                Console.WriteLine("Your Section is Exective");
            }
            else if (amountPaid >= 10000 && amountPaid < 30000)
            {
                Console.WriteLine("Your Section is VIP");
            }
            else if (amountPaid >= 30000)
            {
                Console.WriteLine("Your Section is Premium ");
            }
            else
            {
                Console.WriteLine("You are a cleaner in this event");
            }


        }

        public void checkSection(string SectionName)
        {

            switch (SectionName)
            {
                case "Regular":
                    Console.WriteLine("You can go and seat at the back back back!");
                    break;
                case "Executive":
                    Console.WriteLine("You can seat at an comfortable space in the middle, we will get cream crackers for you");
                    break;
                case "VIP":
                    Console.WriteLine("You can go and seat in the front, we are getting you a bottle of champagne!");
                    break;
                case "Premium":
                    Console.WriteLine("You can seat any where you like, your Henessey or Azul will arrive instantly with your special food!");
                    break;
                default:
                    Console.WriteLine("Depart from me, you poor man");
                    break;
            }
        }



    }
}
