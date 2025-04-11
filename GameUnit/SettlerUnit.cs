namespace GameUnit
{
    public class SettlerUnit : Unit
    {
        public override float Cost => 5f;

        public SettlerUnit() : base(1, 3) { }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}