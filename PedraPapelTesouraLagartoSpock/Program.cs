using RockPaperScissorsLizardSpock.Entities;

var player1 = new Player("Adler");
var player2 = new Player("Ana");

var game = new Game();

var move1 = new Move(player1, Scissors.CreateWithPossibility());
var move2 = new Move(player2, Paper.CreateWithPossibility());

var turn = game.AddTurn(move1, move2);

var result = turn.WinTurn();

Console.WriteLine(result);