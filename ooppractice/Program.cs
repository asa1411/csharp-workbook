using System;

namespace ooppractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            trees loquat = new trees("decidious", "yellow");
            loquat.height = 12;
            loquat.evergreen = true;
            
            trees figtree = new trees("decidious", "summer sweet");
            figtree.height = 10;
            figtree.evergreen = false;
            
            Console.WriteLine($"Figtree's leaves are {figtree.leaves}, and its fruit is {figtree.fruit}.");
            Console.WriteLine("Is loquat evergreen? Yes, it is {0}.", loquat.evergreen);
            Console.WriteLine($"My figtree is {figtree.height} feet high, and my loquat is {loquat.height} feet high.");

        }
    }

    class trees
    {
        public string leaves;
        public string fruit;
        public bool evergreen;
        public int height;

        public trees (string initialleaves, string initialfruit)
        {
            this.leaves = initialleaves;
            this.fruit = initialfruit;
        }

    }
}
