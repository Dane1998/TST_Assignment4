
namespace Snake_Game
{

    public enum Direction { 
        Up, 
        Down, 
        Left, 
        Right 
    };

    internal class Settings
    {
        public static int Width { get; set; }
        public static int Height { get; set; }
        public static int Speed { get; set; }
        public static int Score { get; set; }
        public static int Points { get; set; }
        public static bool GamerOver { get; set; }
        public static Direction direction { get; set; }

        public Settings()
        {
            Width = 16;
            Height = 16;
            Speed = 16;
            Score = 0;
            Points = 100;
            GamerOver = false;
            direction = Direction.Down;
        }

    }
}
