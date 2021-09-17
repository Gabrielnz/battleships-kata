namespace Battleships.Tests
{
    internal class Carrier : Ship
    {
        private int positionX;
        private int positionY;
        private string orientation;

        public Carrier(int positionX, int positionY, string orientation)
        {
            this.positionX = positionX;
            this.positionY = positionY;
            this.orientation = orientation;
        }
    }
}