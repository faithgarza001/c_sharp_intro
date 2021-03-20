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

            string Phrase = ("There once was a man named " + characterName + " who was " + age + " who had an " + grade + " average but " + characterName + " really had a " + gpa + " gpa." );
            //checking is a there is a certain string
            Console.WriteLine(Phrase.Contains("John"));
            //grabbing the index
            Console.WriteLine(Phrase[2]);
            //below using indexOf to see if it contains a value as well as the index of the character..
            Console.WriteLine(Phrase.IndexOf("a"));
            //below a -1 will print when this line is ran because there is no z
            Console.WriteLine(Phrase.IndexOf("z"));
            //using substring to pull in a part of a string (start index, how many charcaters do you want to grab)
            Console.WriteLine(Phrase.Substring(8, 3));
            //using substring and index of to pull in a part of a string
            Console.WriteLine(Phrase.Substring(Phrase.IndexOf("named")));
           




        }
    }
}
