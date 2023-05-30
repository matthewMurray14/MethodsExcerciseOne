using System;
using System.Drawing;
//changes so hopefully I can push this up


namespace MethodsOne
{
    class Program
    {
        //method for returning int

        //Modifier, returnType,method name parameter list
        public static int Sum(int numOne, int numTwo)
        {
            
            return numOne + numTwo;
        }

        public static int Sub(int sub1, int sub2)
        {
            return sub1 - sub2;
        }

        public static double Multi(double mult1, double mult2)
        {
            return mult1 * mult2;
        }

        public static int Divid (int uDiv, int uDiv2)
        {
            return uDiv / uDiv2;
        }

        




        static void Main(string[] args)
        {
            

            Console.WriteLine("What is your name?");
            var uName = Console.ReadLine();
            Console.WriteLine($"Hi, {uName}! Do you have a favorite color? How about a favorite animal and band?");
            var uColor = Console.ReadLine();
            Console.WriteLine("Oh, nice! How about animal?");
            var uAnimal = Console.ReadLine();
            Console.WriteLine("Well, thats pedestrian :( hopefully your favorite band is interesting.");
            var uBand = Console.ReadLine();

            Console.WriteLine($"So, lets get this straight. Your name is, {uName}, your favorite color is, {uColor}, your favorite animal is, {uAnimal} and you favorite band is, {uBand}");
            Console.WriteLine("Well, you're just a special maverick aren't you. You must go on a lot of dates.");
            //methods practicing, not overloading yet.

            Console.WriteLine("At this point, you really should be much farther a long. Let's make this up. Makes some methods to add, subtract, mulitply, and divid.");
            Console.WriteLine("We're doing this over and over again bruv. Please enter a number to add.");
            int numOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Ok, and what else?");
            int numTwo = int.Parse(Console.ReadLine());
            Console.WriteLine(Sum(numOne, numTwo));
            int answer1 = Sum(numOne, numTwo);
            Console.WriteLine($"The answer is : {answer1}");

            Console.WriteLine("Let's do some subtraction. Enter a number.");
            int sub1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter another one.");
            int sub2 = int.Parse(Console.ReadLine());
            int subAns = Sub(sub1, sub2);
            Sub(sub1, sub2);
            Console.WriteLine($"The answer is: {subAns}");
            Console.WriteLine(Sub(sub1, sub2));

            Console.WriteLine("We are doing multiplying now. Enter a number");
            double mult1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter another");
            double mult2 = double.Parse(Console.ReadLine()); 
            
            double multAns = Multi(mult1, mult2);
            Multi(mult1, mult2);
            Console.WriteLine($"The answer is : {multAns}");

            Console.WriteLine("Now doing division. Please enter number");
            int uDiv = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number.");
            int uDiv2 = int.Parse(Console.ReadLine());
            int divAns = Divid(uDiv, uDiv2);
            Divid(uDiv, uDiv2);
            Console.WriteLine(divAns);
            int uMod = uDiv % uDiv2;
            Console.WriteLine($"The answer is: {divAns}.{uMod}");

            //Done with this branch

            

        }
        
    

    }






}