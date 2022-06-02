using System;

namespace InterviewTesting
{
    class Program
    {
        abstract class animal
        {
            public abstract void eat();
            public void sound()
            {
                Console.WriteLine("dog can sound");
            }
        }
        class dog : animal
        {
            public override void eat()
            {
                Console.WriteLine("dog can eat");
            }
        }
        static void Main(string[] args)
        {
            dog mydog = new dog();
            mydog.eat();
            animal thePet = mydog;
            thePet.eat();
            mydog.sound();
            Console.Read();
        }
    }
}
