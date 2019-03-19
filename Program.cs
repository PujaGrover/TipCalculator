using System;

namespace TipCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask user for total bill amount is
            //Get input from user

            Console.WriteLine("What was your bill amount?");
            string billInput = Console.ReadLine();
           /* billInput = billInput.Trim(); //Important to trim white spaces if not can cause error
            billInput = billInput.Trim('$');*/
            billInput = billInput.Trim().Trim('$');

            double bill;

            if (!double.TryParse(billInput, out bill))
            {
                Console.WriteLine($"The value {billInput} is not a valid bill amount.");
                Console.ReadLine();
                return;
            }
            

            //Ask about what % choice they would want to pick from 5, 10, 15 or other...(User Input)
            //Get input from user

            Console.WriteLine("What percent would you like to tip?");            
            string tipPercentInput = Console.ReadLine();
            //tipPercentInput = tipPercentInput.Trim();
            //tipPercentInput = tipPercentInput.Trim('%');
            tipPercentInput = tipPercentInput.Trim().Trim('%');

            double tipPercent;
            if (!double.TryParse(tipPercentInput, out tipPercent)) // Adding ! makes if = not true
            {
                Console.WriteLine($"The value {tipPercentInput} is not a valid value");
            }
           
                

            //parse my inputs
            //Apply % input from user to an algoritm(Tip= percent * bill/100
            //Total Bill= Bill +Tip

            //double bill = double.Parse(billInput);
           //int tipPercent = int.Parse(tipPercentInput);

            double tipAmount = Math.Round(tipPercent * bill / 100, 2);
            double totalBill = Math.Round(bill + tipAmount, 2);
            //double roundedTipAmount = Math.Round(tipAmount, 2);
           // double roundedTotalBill = Math.Round(totalBill, 2);
            

            //Return tip amount
            //string tipAmountString = tipAmount.ToString(); TO CONVERT tipAmount TO STRING

            Console.WriteLine($"Your tip amount is ${tipAmount}");
            //Return Total Bill
            Console.WriteLine($"Your total bill is ${totalBill}");

            Console.ReadLine();

            /* ALTERNATIVE SOLUTION BY THE TEACHER
           double bill = 0;
           double tipPercent = 0;
           //This is a typical way of doing a while loop when there is only one logical way to exit the loop 
           //(ie. getting a parsable input), and you are ok with looping forever till that condition is met.
           //Notice that I did a seperate loop for each entry. Why that instead of one loop for both entries?
           while (true)
           {
               Console.WriteLine("What was your bill amount?");
               string billInput = Console.ReadLine();

               billInput = billInput.Trim().Trim('$');

               if (double.TryParse(billInput, out bill))
               {
                   break;
               }

               Console.WriteLine($"The value {billInput} is not a valid bill amount. Please try again.");
           }

           while (true)
           {
               Console.WriteLine("What percent would you like to tip?");
               string tipPercentInput = Console.ReadLine();
               tipPercentInput = tipPercentInput.Trim().Trim('%');

               if (double.TryParse(tipPercentInput, out tipPercent))
               {
                   break;
               }

               Console.WriteLine($"The value {tipPercentInput} is not a valid tip. Please try again.");
           }

           double tipAmount = Math.Round(tipPercent * bill / 100, 2);
           double totalBill = Math.Round(bill + tipAmount, 2);

           Console.WriteLine($"You tip amount is ${tipAmount}.");
           Console.WriteLine($"Your total bill ${totalBill}.");

           Console.ReadLine();
           */



        }
    }
}
