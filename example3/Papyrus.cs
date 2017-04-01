namespace example3
{
    public class Papyrus : ICombatant
    {
        public Papyrus()
        {
            HP = 680;
        }
        public string Name { get { return nameof(Papyrus); } }
        public int HP { get; set; }
        public int AT { get { return 20; } }
        public int DF { get { return 20; } }
    }    

    public partial class WDGaster : ICombatant
    {
        public int HP { get; set; }
        public int DF { get { return 10; } }
    }
}
