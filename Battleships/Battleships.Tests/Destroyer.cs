namespace Battleships.Tests
{
    internal class Destroyer : Ship
    {
        private int positionX;
        private int positionY;
        private string orientation;

        public Destroyer(int positionX, int positionY, string orientation)
        {
            this.positionX = positionX;
            this.positionY = positionY;
            this.orientation = orientation;
        }
    }
}