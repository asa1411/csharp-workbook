using System;
using System.Collections.Generic;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game(new Dictionary<string, Tower>());
            /* Then you should generate four Blocks, each with a different weight, and Push, then into stack A.*/
            Block b1 = new Block(1);
            Block b2 = new Block(2);
            Block b3 = new Block(3);
            Block b4 = new Block(4);

            game.towers["A"].blocks.Push(b1);
            game.towers["A"].blocks.Push(b2);
            game.towers["A"].blocks.Push(b3);
            game.towers["A"].blocks.Push(b4);

            game.PrintBoard();

        }
    }
    class Block
    {
        public int weight { get; private set; }
        public Block(int initialWeight)
        {
            this.weight = initialWeight;
        }
    }
    class Tower
    {
        public Stack<Block> blocks = new Stack<Block>();
        public Tower(Stack<Block> initialblocks)
        {
            this.blocks = initialblocks;
        }

    }
    class Game
    {
        public Dictionary<string, Tower> towers = new Dictionary<string, Tower>();//key is string "A", "B", "C", and value is instances of Tower
        public Game(Dictionary<string, Tower> initialTowers)
        {
            this.towers = initialTowers;
            towers.Add("A", new Tower(new Stack<Block>()));//instantiate stack of blocks
            towers.Add("B", new Tower(new Stack<Block>()));
            towers.Add("C", new Tower(new Stack<Block>()));
        }
        //In your Game class, add a method that iterates over the Keys of your Towers, and prints out the Tower key ("A", "B", "C") and the block weights in each tower.
        public void PrintBoard()
        {
            foreach (KeyValuePair<string, Tower> tower in this.towers)
            {
                Console.WriteLine("tower {0}: ", tower.Key);
                foreach (Block block in tower.Value.blocks)
                {
                    Console.WriteLine(block.weight);
                }
                System.Console.WriteLine("");
            }

        }
    }
}
