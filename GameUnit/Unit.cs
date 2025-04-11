using Humanizer;
namespace GameUnit
{
    public abstract class Unit
    {
        private readonly int movement;
        public virtual int Health { get; set; }

        public abstract float Cost {get; }

        public Unit(int movement, int health)
        {
            this.movement = movement;
            Health = health;
        }
        
        public string Move()
        {
            return movement.ToRoman();
        }
    }
}
