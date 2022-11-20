using RockPaperScissorsLizardSpock.Shared;

namespace RockPaperScissorsLizardSpock.Entities
{
    public class Turn : Entity
    {
        public Turn(Move move1, Move move2)
        {
            _move1 = move1;
            _move2 = move2;
        }

        private Move _move1;
        private Move _move2;

        public string WinTurn()
        {
            var result = _move2.Possibility.WinOrDraw(_move1.Possibility);

            if (result == true)
            {
                return $"{_move2.Player.Name} Ganhou.";
            }
            else if (result == false)
            {
                return $"{_move1.Player.Name} Ganhou.";
            }
            else
            {
                return "Empate.";
            }
        }
    }
}
