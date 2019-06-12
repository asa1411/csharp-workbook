using System;

namespace practice_5_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Human h1 = new Human("William", "Bill");
            SuperHuman h2 = new SuperHuman("Batman", "Bruce Wayne", "Reach");
            // Console.WriteLine("h1's name is {0}, with nickname{1}", h1.name, h1.nickName);
            // Console.WriteLine("h2's name is {0}, with nickname{1}", h2.name, h2.nickName);
            //instead of above statements
            Console.WriteLine(h1.Greetings());//human message
            greetBack(h1);
            Console.WriteLine(h2.Greetings());//superhuman message
            Human h4 = (Human)h2;
            Console.WriteLine(h4.Greetings());//still superhuman message
        }
        public static void greetBack(Human human)
        {
            Console.WriteLine("Nice to meet you {0}", human.name);
        }
    }
    public class Human
    {
        public string name { get; private set; }
        public string nickName;
        public Human(string initialName, string initialNickName)
        {
            this.name = initialName;
            this.nickName = initialNickName;
        }
        virtual
        public string Greetings()
        {
            String greeting = String.Format("Hi my name is {0}, you may call me {1}", this.name, this.nickName);
            return greeting;
        }

    }
    class SuperHuman : Human
    {
        public string superPower { get; private set; }
        public string realName;
        public SuperHuman(string initialName, string realName, string initialSuperPower) :
        base(initialName, null)

        {
            this.superPower = initialSuperPower;

        }
        override//override is followed by "virtual" in the Greetings of the class Human  so it has its own string format.
        public string Greetings()
        {
            string greeting = string.Format("Hi, I am {0}, and I can {1}", this.name, this.superPower);
            return greeting;
        }
    }
}

//practice with other stuffs like animal and dog, plant and tulip
//no initialNickName so add "null" in line 39.
//Make sure that you practice today's instruction two times at home before go to bed.
//"no virtual and new" vs. virtual and override had different results.

