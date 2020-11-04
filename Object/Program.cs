using System;

namespace Object
{
   public class Program
    {
        static void Main(string[] args)
        {
          spiritualFruit love = new spiritualFruit ("good", "four");
          spiritualFruit joy = new spiritualFruit ("delight", "three");
          
          Console.WriteLine ("{0} is spiritual fruit.", love.order);
        }
    }

    public class spiritualFruit
    {
       private string type;
       private string length;

       public string order {
           get
           {return type+" "+length;}
       }

    public spiritualFruit (string initialType, string initialLength)
    {
         this.type = initialType;
         this.length = initialLength;
    }

    }
}
