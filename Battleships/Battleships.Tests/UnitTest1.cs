using FluentAssertions;
using NUnit.Framework;
using System.Collections.Generic;

namespace Battleships.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Create_a_new_game() {
            var game = new Game(5, 5);

            var resultingBoard = game.Print();

            var expectedBoard = @"
     | 0 | 1 | 2 | 3 | 4 |
   0 |   |   |   |   |   |
   1 |   |   |   |   |   |
   2 |   |   |   |   |   |
   3 |   |   |   |   |   |
   4 |   |   |   |   |   |";
            resultingBoard.Should().Be(expectedBoard);
        }

        [Test]
        public void Acceptance_Test()
        {
            var game = new Game(10, 10);
            var ships = new List<Ship>()
            {
                new GunShip(1, 7),
                new GunShip(9, 9),
                new GunShip(7, 2),
                new GunShip(6, 4),
                new Destroyer(2, 3, "H"),
                new Destroyer(5, 7, "V"),
                new Carrier(8, 4, "V")
            };
            game.AddPlayer(ships);
            game.Start();
            game.Fire(y: 0, x:2);
            game.EndTurn();
				  
            game.Fire(y: 1, x:1);
            game.EndTurn();
            game.Fire(y: 1, x:3);
            game.EndTurn();
				  
            game.Fire(y: 2, x:1);
            game.EndTurn();
            game.Fire(y: 2, x:7);
            game.EndTurn();
				  
            game.Fire(y: 3, x:2);
            game.EndTurn();
            game.Fire(y: 3, x:3);
            game.EndTurn();
            game.Fire(y: 3, x:4);
            game.EndTurn();
				  
            game.Fire(y: 4, x:1);
            game.EndTurn();
            game.Fire(y: 4, x:6);
            game.EndTurn();
            game.Fire(y: 4, x:8);
            game.EndTurn();
				  
            game.Fire(y: 5, x:1);
            game.EndTurn();
            game.Fire(y: 5, x:2);
            game.EndTurn();
            game.Fire(y: 5, x:5);
            game.EndTurn();
            game.Fire(y: 5, x:8);
				  
            game.Fire(y: 6, x:3);
            game.EndTurn();
            game.Fire(y: 6, x:6);
            game.EndTurn();
            game.Fire(y: 6, x:8);
            game.EndTurn();
				  
            game.Fire(y: 7, x:1);
            game.EndTurn();
            game.Fire(y: 7, x:5);
            game.EndTurn();
            game.Fire(y: 7, x:8);
            game.EndTurn();
				  
            game.Fire(y: 8, x:2);
            game.EndTurn();
            game.Fire(y: 8, x:3);
            game.EndTurn();
            game.Fire(y: 8, x:5);
            game.EndTurn();
            game.Fire(y: 8, x:8);
            game.EndTurn();
				  
            game.Fire(y: 9, x:4);
            game.EndTurn();
            game.Fire(y: 9, x:5);
            game.EndTurn();
            game.Fire(y: 9, x:6);
            game.EndTurn();
            game.Fire(y: 9, x: 9);

            var result = game.Print();

            var expectedBoard = @"
     | 0 | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 |
   0 |   |   | o |   |   |   |   |   |   |   |
   1 |   | o |   | o |   |   |   |   |   |   |
   2 |   | o |   |   |   |   |   | X |   |   |
   3 |   |   | X | X | X |   |   |   |   |   |
   4 |   | o |   |   |   |   | g |   | c |   |
   5 |   | o | o |   |   | o |   |   | c |   |
   6 |   |   |   | o |   |   | o |   | c |   |
   7 |   | X |   |   |   | d |   |   | x |   |
   8 |   |   | o | o |   | d |   |   | o |   |
   9 |   |   |   |   | o | x | o |   |   | X |";
            result.Should().Be(expectedBoard);
        }
    }
}