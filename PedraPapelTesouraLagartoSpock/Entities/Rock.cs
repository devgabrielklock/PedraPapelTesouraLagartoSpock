using RockPaperScissorsLizardSpock.Shared;

namespace RockPaperScissorsLizardSpock.Entities
{
    public class Rock : Possibility
    {        
        public Rock() : base() { }

        public static Rock CreateWithPossibility()
        {
            var rock = new Rock();
            rock.AddPossibility(new Lizard());
            rock.AddPossibility(new Scissors());

            return rock;
        }
    }
}
