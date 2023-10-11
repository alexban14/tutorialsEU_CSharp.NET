using System;

namespace Classes_Basics
{
    public class Human
    {
        private string firstName { get; set };
        private string lastName;
        private string eyeColor;
        private int age;

        // standard constructor
        public Human()
        {
            Console.WriteLine("Object created!");
        }

        public Human(string firstName, string lastName)
        {
            this.lastName = lastName;
            this.firstName = firstName;
        }

        // parameterized constructor
        public Human(string firstName, string lastName, string eyeColor, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }

        public void IntroduceMyself()
        {
            Console.WriteLine("My name is {0} {1} I am {2} years old and I have {3} eyes", this.firstName, this.lastName, this.age,this.eyeColor);
        }
    }
}
