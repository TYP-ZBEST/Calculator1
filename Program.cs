using System;

namespace Calculator1
{
    class AwesomeCalculator
    {        
        static double secondnum;
        static double result;
        static bool ifPrime;
        static double num;
        public static string firstValue;

        static bool boolResult;

        public static string expression;
        static void Main(string[] args)
        {
            Console.Title = "An Awesome Calculator!";

          Console.WriteLine("Welcome to the calculator!");  
          Console.WriteLine("Type a number here. (You can type in help here to access the help menu, explain for the explain menu, or pie for π)");
          firstValue = Console.ReadLine();                     
            
            while (expression != "exit"){

            
            if (firstValue == "help")
            {
                HelpText();
            }
            else if (firstValue == "explain"){
                ExplainText();
            }
            else if(firstValue == "pie"){
                decimal pieValue = (decimal) 22/7;
                System.Console.WriteLine(pieValue);
            }
            else if(double.TryParse(firstValue ,out num))
            {
                num = Convert.ToDouble(firstValue);
            
                Console.WriteLine("Type what you want me to do with the number (+, -, *, /, !, remainder, sqr, sqrt, hypotenuse, prime, random, %, explain, leap)");
                expression = Console.ReadLine();                    
                
                switchBoi(expression);
                }
                else
                {
                    System.Console.WriteLine("Please provide a vaild number or keyword!");
                }

                
            Console.ReadKey();    
            }                   
            }
            
            
            static double GetSecondNumber(){

                Console.WriteLine("Type another number:");
                var valueEntered = Console.ReadLine();
                double anothernum;
                if (double.TryParse(valueEntered, out anothernum))
                {
                    anothernum = Convert.ToDouble(valueEntered);
                    return anothernum;
                }
                else
                {
                    System.Console.WriteLine("Please enter a valid number! A value of 0 will be returned \n In case of random, It wont work \n Press Enter to continue");
                    Console.ReadKey();
                    return 0;                
                }
                
                

            }

            static void DisplayResult(double result) {
                Console.WriteLine("Your Result is: " + result);
                System.Console.WriteLine("Press Enter to exit");
               
                
            }
            static void DisplayResult(bool result) {
                Console.WriteLine("Your Result is: " + result); 
            }
            #region TheCalculations
            static double Add(double firstnum, double secondnum)
            {
                double result = firstnum + secondnum;
                
                return result;
            }

            static double Subtract(double firstnum, double secondnum)
            {
                double result = firstnum - secondnum;
                return result;
            }

            static double Multiply(double firstnum, double secondnum)
            {
                double result = firstnum * secondnum;
                return result;
            }

            static double DivideEm(double firstnum, double secondnum)
            {
                double result = firstnum / secondnum;
                return result;
            }

            static double Factorial(double number){
            double factorialnum = 1;
            for (int i = 1; i <= number; i++)
            {
                factorialnum = factorialnum * i;
            }  
            return factorialnum;       
                
                #region FactorialExplanation
                /*How it works
                factorialnum and i are equal to 1
                lets say num = 5
                First Iteration
                factorialnum will be set to 1 * 1
                = 1
                i will become 2
                Second Iteration
                factorialnum will be set to 1 * 2
                = 2
                i will become 3
                Third Iteration
                factorialnum will be set to 2 * 3
                = 6

                ...

                Last Iteration
                factorialnum will be set to 24 * 5
                = 120

                120 is our answer

                */
                #endregion
            }
            static double CalculateRemainder(double firstnum, double secondnum){
                double result = firstnum % secondnum;
                return result;
            }
            static double CalculateSqrt(double num){
                double result = Math.Sqrt(num);
                return result;
            }
            static double CalculateSqr(double num){
                double result = num * num;
                return result;
            }
            static double CalculateHypotenuse(double firstnum, double secondnum){
                double resultsquared = CalculateSqr(firstnum) + CalculateSqr(secondnum);
                double result = CalculateSqrt(resultsquared);
                return result;
            }

            static bool CheckIfPrime(double num){
            if (num <= 1)
            {
                return false;
            }
            else{
                for (int i = 2; i < num; i++)
                {                      
                    if (num % i == 0)
                    {
                        return false;
                    }             
                } 
            }   
            
            return true;
            }
            static double GenerateRandomNumber(int firstnum, int secondnum){
                Random random = new Random();
                int randomNum = random.Next(firstnum, secondnum);
                return randomNum;
            }

            static double CalculatePercentage(double num, double percent){
                result = DivideEm(Multiply(num, percent), 100);
                return result;
            }

            static bool CheckIfLeap(double num){
                if(num % 4 == 0){
                    return true;
                }
                else{
                    return false;
                }
            }
            
            #endregion

            static void HelpText(){
                Console.WriteLine("Hey! Welcome to this calculator! It was made by Kinshuk Agrawal to improve his coding skills!");
                Console.WriteLine("How to use:");
                Console.WriteLine("First up, you need to start by typing a number. Then you will see a bunch of operations you can do. \n Most of them are pretty self explanatory. However, there are some special cases we would like you to know: \n Random: Generates a random number. First value you add is the minimum and second is the maximum range \n PLEASE NOTE: Do not type in a decimal number if you are doing random");
                System.Console.WriteLine("Percent: First number added is the number and second is the percent. Result is number/100 * percent");
                System.Console.WriteLine("The explain keyword is to explain every keyword in detail");
            }
            static void ExplainText(){
                System.Console.WriteLine("+ : Adds stuff\n- : Subtracts stuff\n*: Multiplies stuff\n/ : Divides stuff\nremainder: Divides stuff and tells you the remainder\n!: Factorial\nsqr : Squares a number\nsqrt: Find out the square root of a number\n%: First number added is the number and second is the percent. Result is number/100 * percent\n random: Generates a random number. First value you add is the minimum and second is the maximum range\nprime: Checks if the given number is prime or not\nhypotenuse: Takes in A and B. Squares A and B, Adds them together and square roots the result\npie : Shows you the value of pie\nleap : Checks if the year will be a leap or not");
            }

            static void switchBoi(string _expression){
                switch (_expression) {
                    case "+":
                    secondnum = GetSecondNumber();
                    result = Add(num, secondnum);
                    DisplayResult(result);
                        break;

                    case "-":
                    secondnum = GetSecondNumber();
                    result = Subtract(num, secondnum);
                    DisplayResult(result);
                        break; 

                    case "*":
                    secondnum = GetSecondNumber();
                    result = Multiply(num, secondnum);
                    DisplayResult(result);
                        break;
                    case "/":
                    secondnum = GetSecondNumber();
                    result = DivideEm(num, secondnum);
                    DisplayResult(result);
                        break;
                    case "!":
                    result = Factorial(num);
                    DisplayResult(result);
                        break;
                    case "remainder":
                    secondnum = GetSecondNumber();
                    result = CalculateRemainder(num, secondnum);
                    DisplayResult(result);
                        break;
                    case "sqrt":
                    result = CalculateSqrt(num);
                    DisplayResult(result);
                        break;
                    case "sqr":
                    result = CalculateSqr(num);
                    DisplayResult(result);
                        break;     
                    case "hypotenuse":
                    secondnum = GetSecondNumber();
                    result = CalculateHypotenuse(num, secondnum);
                    DisplayResult(result);
                        break;
                    case "prime":
                    ifPrime = CheckIfPrime(num);
                    DisplayResult(ifPrime);
                        break;
                    case "random":
                    int firstnum = Convert.ToInt32(num);
                    secondnum = GetSecondNumber();
                    int anothernum = Convert.ToInt32(secondnum);
                    if (firstnum < anothernum)
                    {
                        result = GenerateRandomNumber(firstnum, anothernum);
                        DisplayResult(result);
                    }
                    else{
                        Console.WriteLine("Hey! The first number you add must be less then the second number!");
                    }

                        break;
                    case "%":
                    double percentage = GetSecondNumber();
                    result = CalculatePercentage(num, percentage);
                    DisplayResult(result);
                        break; 
                    case "explain":
                    ExplainText();
                        break; 
                    case "leap":
                    boolResult = CheckIfLeap(num);
                    DisplayResult(boolResult);
                        break;
                    default:
                    System.Console.WriteLine("That is not a thing I can do! Maybe you have misspelled it?");   
                        break;         
                    }
                   
        }
        
    }
}
