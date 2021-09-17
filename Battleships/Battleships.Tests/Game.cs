using System;
using System.Collections.Generic;

namespace Battleships.Tests
{
    public class Game
    {
        public Game(int lengthX, int lengthY)
        {

        }

        public string Print() {
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