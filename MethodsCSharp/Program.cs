using System;
//changes so hopefully I can push this up


namespace MethodsOne
{
    class Program
    { 
        public static void oldMan()
        {
            Console.WriteLine("What?! Huh?!!");
            int userRate = int.Parse(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, what is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine($"Nice to meet you {userName}! What do you like to do on your days off?");
            string userACT = Console.ReadLine();
            
            Console.WriteLine("That Sounds like fun! On a scale of 1 to 10, how good are you?");
            int userRate = int.Parse(Console.ReadLine());

            Console.WriteLine("What!? You'll have to speak up sonny! I'm an old man.");
            //Change to signify change. Working with my 2nd branch of this program on my own. May not go so well.
            oldMan();
            oldMan();
            oldMan();
            
            Console.WriteLine("I don't know what you are trying to say to me! You young people today. Back in my day, we showed respect to elders!");

            Console.WriteLine($"Today, {userName}, walked into the store to get supplies for his trip. An older man came up to him asking questions. {userName} did answer his question with, {userRate} but, this man just could not understand it.");
    }

    }






}