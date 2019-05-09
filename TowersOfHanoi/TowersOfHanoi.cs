using System;
using System.Collections.Generic;

namespace TowersOfHanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class Block
    {
        public int Weight { get; private set; }
        public Block(int initialWeight)
        {
            this.Weight = initialWeight;
        }
    }

    class Tower
    {

        public Stack<Block> myStack = new Stack<Block>();
        public Tower(int numberOfBlocks)
        {
            numberOfBlocks = 3;
        }
        myStack.push(Block.Weight);
    }
    class Game
    {
        Dictionary<Tower, string> dict = new Dictionary<Tower, string>();
        dict.Add<Tower, "">;
    }
}
