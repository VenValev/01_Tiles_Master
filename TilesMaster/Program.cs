using System;
using System.Collections;
using System.Collections.Generic;

namespace TilesMaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] whiteTiles = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries); // stack
            string[] grayTiles = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);  // opa6ka

            Stack<int> whiteTilesArea = new Stack<int>();
            Queue<int> grayTilesArea = new Queue<int>();

            for(int i = 0; i < whiteTiles.Length; i++)
            {
                whiteTilesArea.Push(int.Parse(whiteTiles[i]));
            }
            for (int i = 0; i < grayTiles.Length; i++)
            {
                grayTilesArea.Enqueue(int.Parse(grayTiles[i]));
            }

            while(true)
            {
                int newTileArea = 0;
                if (whiteTilesArea.Peek() == grayTilesArea.Peek())
                {
                    newTileArea = whiteTilesArea.Peek() + grayTilesArea.Peek();

                    if (newTileArea == 70)
                    {
                        //Wall
                        whiteTilesArea.Pop();
                        grayTilesArea.Dequeue();
                    }
                    else if (newTileArea == 60)
                    {
                        //Countertop
                        whiteTilesArea.Pop();
                        grayTilesArea.Dequeue();
                    }
                    else if (newTileArea == 50)
                    {
                        //Oven
                        whiteTilesArea.Pop();
                        grayTilesArea.Dequeue();
                    }
                    else if (newTileArea == 40)
                    {
                        //Sink
                        whiteTilesArea.Pop();
                        grayTilesArea.Dequeue();
                    }
                    else
                    {
                        // Floor
                        whiteTilesArea.Pop();
                        grayTilesArea.Dequeue();
                    }
                }
                else
                {
                    int newWTile = whiteTilesArea.Peek() / 2;
                    whiteTilesArea.Pop();
                    whiteTilesArea.Push(newWTile);
                    int newGTile = grayTilesArea.Peek();
                    grayTilesArea.Dequeue();
                    grayTilesArea.Enqueue(newGTile);

                }


            }
        }
    }
}
