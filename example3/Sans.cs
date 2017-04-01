namespace example3
{
    public class Sans : ICombatant
    {
        public Sans()
        {
            HP = 1;
        }
        public string Name { get { return nameof(Sans); } }
        public int HP { get; set; }
        public int AT { get { return 1; } }
        public int DF { get { return 1; } }
    }

    public partial class WDGaster : ICombatant
    {
        public string Name { get { return "✌️"; } }
        public int AT { get { return 10; } }
    }
}
