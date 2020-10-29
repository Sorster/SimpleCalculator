using System;

namespace ConsoleApp2
{
    class Program 
    {
        static void Main(string[] args)
        {
            bool check = true; //a variable to exit the program
            do
            {
                int choice; //a choice of an operation 
                do
                {
                    Console.Write("\nWhat operation do you want to do? \n1.(+)\n2.(-)\n3.(*)\n4.(/)\n5.(Percentage of the first number of the second one)\n6.(Square root)\n7.Close the program\nCommand:>"); //choice menu
                    var key = Console.ReadLine();
                    if (int.TryParse(key, out choice)) break; //check the right operation choice input 
                    else Console.WriteLine("\nError! Please write a number from 1 to 6!");
                } while (true);

                Console.Write("Enter the first number: ");
                var fNum = Console.ReadLine();
                int firstNum; //the first number
                do
                {
                    if (int.TryParse(fNum, out firstNum)) break; //check the right first number input
                    else
                    {
                        Console.Write("Error! Please rewrite the first number: ");
                        fNum = Console.ReadLine();
                    }
                } while (true);

                Console.Write("Enter the second number: ");
                var sNum = Console.ReadLine();
                int secondNum; //the second number
                do
                {
                    if (int.TryParse(sNum, out secondNum)) break; //check the right second number input
                    else
                    {
                        Console.Write("Error! Please rewrite the second number: ");
                        sNum = Console.ReadLine();
                    }
                } while (true);

                double result = 0;
                switch(choice)
                {
                    case 1:
                        {
                            result = firstNum + secondNum; //addition of two numbers
                            break;
                        }
                    case 2:
                        {
                            result = firstNum - secondNum; //subtraction of two numbers
                            break;
                        }
                    case 3:
                        {
                            result = firstNum * secondNum; //multiplication of two numbers
                            break;
                        }
                    case 4:
                        {
                            result = (double) firstNum / secondNum; //deviding the first number by the second one
                            break;
                        }
                    case 5:
                        {
                            result = (double) firstNum / secondNum * 100; //Percentage of the first number of the second one
                            break;
                        }
                    case 6:
                        { 
                            int choice1; // a choice of a number
                            do
                            {
                                Console.Write("Square root of: 1.First number, 2.Second number: ");
                                var key1 = Console.ReadLine();
                                if (int.TryParse(key1, out choice1)) break; //check the right number choice input
                                else Console.WriteLine("\nError! Please write a number 1 or 2!");
                            } while (true);

                            switch (choice1)
                            {
                                case 1:
                                    {
                                        result = Math.Sqrt(firstNum); //square root of the first number
                                        break;
                                    }
                                case 2:
                                    {
                                        result = Math.Sqrt(secondNum); //square root of the second number
                                        break;
                                    }
                            }                      
                            break;
                        }
                    case 7:
                        { 
                            check = false; //exit the program
                            break;
                        }
                }
                Console.WriteLine($"Result: {result}\n"); //Output result
                
            } while (check);
 
            Console.ReadKey();
        }
    }
}