﻿using System;
using System.Collections.Generic;
using System.Linq;
// using System.Globalization;

namespace Checkers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Game g = new Game();


        }
    }

    public class Checker
    {
        public string Symbol { get; set; }
        public int[] Position { get; set; }
        public string Color { get; set; }

        public Checker(string color, int[] position)
        {
            this.Color = color;
            this.Position = position;
            int openCircleId = int.Parse("25CB", System.Globalization.NumberStyles.HexNumber);
            string openCircle = char.ConvertFromUtf32(openCircleId);
            int closedCircleId = int.Parse("25CF", System.Globalization.NumberStyles.HexNumber);
            string closedCircle = char.ConvertFromUtf32(closedCircleId);
            if (Color == "white")
            {
                Symbol = openCircle;
            }
            else
            {
                Symbol = closedCircle;
            }
        }
    }

    public class Board
    {
        public string[][] Grid { get; set; }
        public List<Checker> Checkers { get; set; }
        public Board()
        {
            // this.Grid = grid;
            this.Checkers = new List<Checker>();
            // return;
        }
        // public Board()
        // {
        //     // Your code here
        //     return;
        // }

        public void CreateBoard()
        {

            return;
        }

        public void GenerateCheckers()
        {
            // for first and third lines of the white position
            for (int i = 1; i < 8; i += 2)
            {
                Checker c1 = new Checker("white", new int[] { 0, i });
                Checker c3 = new Checker("white", new int[] { 2, i });
                Checkers.Add(c1);
                Checkers.Add(c3);
            }
            //for the second line of the white position
            for (int i = 0; i < 7; i += 2)
            {
                Checker c2 = new Checker("white", new int[] { 1, i });
                Checkers.Add(c2);
            }
            // for the first and third lines of the black position
            for (int i = 0; i < 7; i += 2)
            {
                Checker c4 = new Checker("black", new int[] { 5, i });
                Checker c6 = new Checker("black", new int[] { 7, i });
                Checkers.Add(c4);
                Checkers.Add(c6);
            }

            for (int i = 1; i < 8; i += 2)
            {
                Checker c5 = new Checker("black", new int[] { 6, i });
                Checkers.Add(c5);
            }
            return;
        }

        public void PlaceCheckers()
        {
            // Your code here
            return;
        }

        public void DrawBoard()
        {
            string[,] grid = new string[8, 8];
            //backward slash t does create evenly tab space
            Console.WriteLine("\t0 \t1 \t2 \t3 \t4 \t5 \t6 \t7");
            for (int i = 0; i < 8; i++)
            {//up and down numbers from 0 to 7
                Console.Write("{0}\t", i);
                for (int j = 0; j < 8; j++)
                {
                    Console.Write("{0}\t", grid[i, j]);

                }
                Console.Write("\n");

            }
            // Your code here
            foreach (Checker c in Checkers)
            {
                int x = c.Position[0];
                int y = c.Position[1];
                grid[x, y] = c.Symbol;
            }
            return;
        }

        public Checker SelectChecker(int row, int column)
        {
            return Checkers.Find(x => x.Position.SequenceEqual(new List<int> { row, column }));
        }

        public void RemoveChecker(int row, int column)
        {
            // Your code here
            return;
        }

        public bool CheckForWin()
        {
            return Checkers.All(x => x.Color == "white") || !Checkers.Exists(x => x.Color == "white");
        }
    }

    class Game
    {
        public Game()
        {
            Board board = new Board();
            board.GenerateCheckers();
            board.DrawBoard();

            // Your code here
        }
    }
}
