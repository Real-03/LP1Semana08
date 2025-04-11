namespace GameUnit
{
    class SettlerUnit : Unit
    {
        public SettlerUnit() : base(1, 3) // movement = 1, health = 3
        {
        }
        public override float Cost
        {
            get { return 5f; }
        }
    }
}