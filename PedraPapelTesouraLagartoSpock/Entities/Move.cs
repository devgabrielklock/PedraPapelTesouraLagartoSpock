using RockPaperScissorsLizardSpock.Shared;

namespace RockPaperScissorsLizardSpock.Entities
{
    public class Move : Entity
    {
        public Move(Player player, Possibility possibility) : base()
        {
            Player = player;
            Possibility = possibility;
        }

        public Player Player { get; set; }
        public Possibility Possibility { get; set; }
    }
}
