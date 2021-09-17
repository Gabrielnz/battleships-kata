namespace Battleships.Tests
{
    internal class GunShip : Ship
    {
        private int positionX;
        private int positionY;

        public GunShip(int positionX, int positionY)
        {
            this.positionX = positionX;
            this.positionY = positionY;
        }
    }
}