using RockPaperScissorsLizardSpock.Shared;

namespace RockPaperScissorsLizardSpock.Entities
{
    public class Spock : Possibility
    {        
        public Spock() : base() { }

        public static Spock CreateWithPossibility()
        {
            var spock = new Spock();
            spock.AddPossibility(new Rock());
            spock.AddPossibility(new Scissors());

            return spock;
        }
    }
}
