using RockPaperScissorsLizardSpock.Shared;

namespace RockPaperScissorsLizardSpock.Entities
{
    public class Game : Entity
    {
        public Game()
        {
            _turns = new List<Turn>();
        }

        private IList<Turn> _turns;

        public Turn AddTurn(Move move1, Move move2)
        {
            var turn = new Turn(move1, move2);
            _turns.Add(turn);
            return turn;
        }
    }
}
