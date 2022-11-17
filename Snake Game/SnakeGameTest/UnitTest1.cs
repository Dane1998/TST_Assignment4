
using System.Xml.Linq;

namespace SnakeGameTest
{
    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    };

    public class Tests
    {
        [Test]
        public void SnakeSizeLessThan3()
        {
            Assert.Throws<ArgumentException>(
                () => new Game(1, Direction.Right));
        }

        [Test]
        public void TestGameState()
        {
            var snakeSize = 3;
            var direction = Direction.Right;

            Game sut = new Game(snakeSize, direction);

            Assert.That(sut.SnakeSize, Is.EqualTo(snakeSize));
            Assert.That(sut.Direction, Is.EqualTo(direction));
        }
        [Test]
        [TestCase(Direction.Left, Direction.Left)]
        [TestCase(Direction.Left, Direction.Right)]
        [TestCase(Direction.Right, Direction.Right)]
        [TestCase(Direction.Right, Direction.Left)]
        [TestCase(Direction.Up, Direction.Up)]
        [TestCase(Direction.Up, Direction.Down)]
        [TestCase(Direction.Down, Direction.Down)]
        [TestCase(Direction.Down, Direction.Up)]
        public void PlayerMakesMove_InvalidMovement_ReturnsFalse(
            Direction snakeDirection, Direction playerDirection)
        {
            Game sut = new(3, snakeDirection);
            Assert.That(sut.CanMove(playerDirection), Is.EqualTo(false));
        }

        [Test]
        [TestCase(Direction.Left, Direction.Up)]
        [TestCase(Direction.Left, Direction.Down)]
        [TestCase(Direction.Right, Direction.Up)]
        [TestCase(Direction.Right, Direction.Down)]
        [TestCase(Direction.Up, Direction.Left)]
        [TestCase(Direction.Up, Direction.Right)]
        [TestCase(Direction.Down, Direction.Left)]
        [TestCase(Direction.Down, Direction.Right)]
        public void PlayerMakesMove_ValidMovement_ReturnsTrue(
            Direction snakeDirection, Direction playerDirection)
        {
            Game sut = new(3, snakeDirection);
            Assert.That(sut.CanMove(playerDirection), Is.EqualTo(true));
        }

    }
    public class Game
    {
        public int SnakeSize { get; set; }
        public Direction Direction { get; set; }

        public Game(int snakeSize, Direction direction)
        {
            if (snakeSize < 3)
                throw new ArgumentException("Snake size has to be >= 3");

            SnakeSize = snakeSize;
            Direction = direction;
        }
        public bool CanMove(Direction direction)
        {
            return (Direction, direction) switch
            {
                (Direction.Left, Direction.Left) => false,
                (Direction.Left, Direction.Right) => false,
                (Direction.Right, Direction.Right) => false,
                (Direction.Right, Direction.Left) => false,
                (Direction.Up, Direction.Up) => false,
                (Direction.Up, Direction.Down) => false,
                (Direction.Down, Direction.Down) => false,
                (Direction.Down, Direction.Up) => false,
                _ => true
            };
        }
       
    }
}