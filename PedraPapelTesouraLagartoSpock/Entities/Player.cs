using RockPaperScissorsLizardSpock.Shared;

namespace RockPaperScissorsLizardSpock.Entities
{
    public class Player : Entity
    {
        public string Name { get; private set; }
        public Player(string name) : base()
        {
            Name = name;
        }
    }
}
