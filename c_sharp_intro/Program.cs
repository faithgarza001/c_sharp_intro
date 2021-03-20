using System;

namespace c_sharp_intro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //Console.ReadLine();

            //below we are going to draw a trinagle shape in the terminal
            Console.WriteLine("     /|");
            Console.WriteLine("    / |");
            Console.WriteLine("   /  |");
            Console.WriteLine("  /   |");
            Console.WriteLine(" /____|");

            //ReadLine will leave the terminal window open until it is further instructed
            //Console.ReadLine();

            //creating variables
            //String variable

            //storing a single string character
            char grade = 'A';
            //storing more than once character
            string characterName = "John";
            //int variable
            //not assigning a value
            int age;
            //assigning variable a value
             age = 30;
            //double used for decimals
            double gpa = 3.0;
           
            //true or false
            //bool isLearning = true;

            Console.WriteLine("There once was a man named " + characterName + " who was " + age + " who had an " + grade + " average but " + characterName + " really had a " + gpa + " gpa." );


        }
    }
}
