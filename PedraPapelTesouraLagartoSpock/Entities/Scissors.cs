using RockPaperScissorsLizardSpock.Shared;

namespace RockPaperScissorsLizardSpock.Entities
{
    public class Scissors : Possibility
    {        
        public Scissors() : base() { }

        public static Scissors CreateWithPossibility()
        {
            var scissors = new Scissors();
            scissors.AddPossibility(new Paper());
            scissors.AddPossibility(new Lizard());

            return scissors;
        }
    }
}
