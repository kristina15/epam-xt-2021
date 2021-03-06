namespace Epam.Task_2._2._1.GAME
{
    public abstract class Bonuses:ObjectsOnField
    {
        public Bonuses(int _x, int _y) : base(_x, _y)
        {
        }

        public abstract bool GetBonus();
    }
}