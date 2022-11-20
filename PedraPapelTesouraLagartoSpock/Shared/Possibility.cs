using RockPaperScissorsLizardSpock.Entities;

namespace RockPaperScissorsLizardSpock.Shared
{
    public abstract class Possibility : Entity
    {
        private IList<Possibility> _possibilitiesWinning;

        public Possibility() : base()
        {
            _possibilitiesWinning = new List<Possibility>();
        }

        public bool? WinOrDraw(Possibility possibility)
        {
            if (possibility.GetType().Name == GetType().Name)
                return null;
            
            return _possibilitiesWinning.Any(x => x.GetType().Name == possibility.GetType().Name);
        }

        public void AddPossibility(Possibility possibility)
        {
            _possibilitiesWinning.Add(possibility);
        }        
    }
}
