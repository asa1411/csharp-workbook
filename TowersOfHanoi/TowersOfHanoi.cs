using System;
using System.Collections.Generic;

namespace TowerOfHanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            /* Then you should generate four Blocks, each with a different weight, and Push, then into stack A.*/
            // Console.WriteLine("How many blocks for the game?");
            // int num = int.Parse(Console.ReadLine());
            // for (int i = num; i > 0; i--)
            // {
            //     Block b = new Block(i);
            //     game.towers["A"].blocks.Push(b);
            // }
            game.PrintBoard();

            bool won = false;
            while (!won)
            {
                Console.WriteLine("From what tower do you move a disk? A, B or C");
                string from = Console.ReadLine();
                Console.WriteLine("What tower do you want to move to? A, B or C");
                string to = Console.ReadLine();
                if (game.IsLegal(game.towers[from], game.towers[to]))
                { game.MovePiece(game.towers[from], game.towers[to]); }
                else { Console.WriteLine("It's an invalid input. Try again."); }
                //to access a key in a dictionary which is Tower 

                game.PrintBoard();
                won = game.CheckforWin();
            }

        }
    }
    class Block
    {
        public int weight { get; set; }
        public Block(int initialWeight)
        {
            this.weight = initialWeight;
        }
    }
    class Tower
    {
        public Stack<Block> blocks;
        public Tower()
        {
            this.blocks = new Stack<Block>();
        }

    }
    class Game
    {
        public Dictionary<string, Tower> towers = new Dictionary<string, Tower>();//key is string "A", "B", "C", and value is instances of Tower
        public Game()
        {
            Tower towerA = new Tower();
            Tower towerB = new Tower();
            Tower towerC = new Tower();
            Block block1 = new Block(1);
            Block block2 = new Block(2);
            Block block3 = new Block(3);
            Block block4 = new Block(4);
            towerA.blocks.Push(block4);
            towerA.blocks.Push(block3);
            towerA.blocks.Push(block2);
            towerA.blocks.Push(block1);
            towers.Add("A", towerA);
            towers.Add("B", towerB);
            towers.Add("C", towerC);


        }
        //In your Game class, add a method that iterates over the Keys of your Towers, and prints out the Tower key ("A", "B", "C") and the block weights in each tower.
        public void PrintBoard()
        {
            foreach (KeyValuePair<string, Tower> tower in this.towers)
            {
                Console.Write("tower {0}: ", tower.Key);
                foreach (Block block in tower.Value.blocks)
                {
                    Console.Write(block.weight);
                }
                System.Console.WriteLine("");
            }

        }
        /* In your Game class, write a method MovePiece that takes a popOff and pushOn string of the towers you want to move the block between; game.MovePiece("A", "B"). This method will Pop off the last block from the first tower, set it to a variable, and push that block onto the second tower. Try moving a block and then printing out the game board.*/
        public void MovePiece(Tower From, Tower To)
        {
            if (IsLegal(From, To))

            {
                Block b = From.blocks.Pop();
                To.blocks.Push(b);

            }

        }
        /*On your Game class IsLegal() takes two arguments, popOff and pushOn, and will Peek to see if the block being moved, from the popOff stack is smaller than last block in pushOn stack. return true; if it is allowed, otherwise, return false;. Also, don't forget to think about if the pushOn stack is empty, you may put any block there. Put this check before your MovePiece() function. */
        public bool IsLegal(Tower From, Tower To)
        {
            if (From.blocks.Count == 0 && To.blocks.Count == 0)
            { return false; }
            if (From.blocks.Count == 0)
            { return false; }
            if (To.blocks.Count == 0)
            { return true; }
            if (From.blocks.Peek().weight < To.blocks.Peek().weight)
            { return true; }
            else { return false; }

        }
        public bool CheckforWin()
        {//n CheckForWin() on the Game class, you can simply check if the B stack or C stack has a .Count() of 4, then log out a message like "You Won!!!" and return true; if a win is detected, or a false if not.
            if (towers["B"].blocks.Count == 4 || towers["C"].blocks.Count == 4)
            {
                Console.WriteLine("You won");
                return true;
            }
            else
            { return false; }
        }

    }//saved in under a different gitname
}