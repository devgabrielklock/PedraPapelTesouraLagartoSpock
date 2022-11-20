using RockPaperScissorsLizardSpock.Shared;

namespace RockPaperScissorsLizardSpock.Entities
{
    public class Paper : Possibility
    {        
        public Paper() : base() { }

        public static Paper CreateWithPossibility()
        {
            var paper = new Paper();
            paper.AddPossibility(new Spock());
            paper.AddPossibility(new Rock());

            return paper;
        }
    }
}
