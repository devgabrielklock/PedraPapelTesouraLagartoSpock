using RockPaperScissorsLizardSpock.Shared;

namespace RockPaperScissorsLizardSpock.Entities
{
    public class Lizard : Possibility
    {
        public Lizard() : base() { }

        public static Lizard CreateWithPossibility()
        {
            var lizart = new Lizard();
            lizart.AddPossibility(new Spock());
            lizart.AddPossibility(new Paper());

            return lizart;
        }
    }
}
