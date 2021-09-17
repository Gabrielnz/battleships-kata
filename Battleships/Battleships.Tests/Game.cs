using System;
using System.Collections.Generic;
using System.Text;

namespace Battleships.Tests
{
    public class Game
    {
        private readonly char[,] board;
        private readonly int lengthX;
        private readonly int lengthY;

        public Game(int lengthX, int lengthY)
        {
            board = new char[lengthX, lengthY];
            this.lengthX = lengthX;
            this.lengthY = lengthY;
        }

        public string Print() {
            var result = new StringBuilder();

            for (int i = 0; i < UPPER; i++) {
                
            }

            for (int i = 0; i < lengthX - 1; i++) {
                if (i == 0) {
                    result.Append(i.ToString());
                }

                result.Append(board[i]);
                for (int j = 0; j < lengthY; j++) {
                    if (i == 0) {
                        result.Append(i.ToString());
                    }
                }
            }
            return @"
     | 0 | 1 | 2 | 3 | 4 |
   0 |   |   |   |   |   |
   1 |   |   |   |   |   |
   2 |   |   |   |   |   |
   3 |   |   |   |   |   |
   4 |   |   |   |   |   |";
        }

        internal void AddPlayer(List<Ship> ships)
        {
        }

        public void Start() {
        }

        public void Fire(int x, int y) {
        }

        public void EndTurn() {
        }
    }
}           