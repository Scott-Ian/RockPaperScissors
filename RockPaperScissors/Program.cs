using RockPaperScissors.Models;
using System;

namespace RockPaperScissors
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to the Rock Paper Scissors Tourney!");
      Console.WriteLine("Would you like to play against a computer? Y/N");
      string gameChoice = Console.ReadLine();

      if (gameChoice == "Y") {
        ComputerOpponent();
      } 
      else
      {
        HumanOpponent();
      }
    
    }

    public static void ComputerOpponent()
    {
      string userSelection = GetInput();
      Player player1 = new Player();
      player1.RPS = userSelection;

      Player computerPlayer = new Player();
      computerPlayer.ComputerChoice();

      Player.RPSComparison(player1, computerPlayer);

      EvgeniyaAndIanAreGREAT(player1, computerPlayer);
    }

    public static void HumanOpponent()
    {
      Console.WriteLine("Player 1:");
      string player1Input = GetInput();

      Console.WriteLine("Player 2:");
      string player2Input = GetInput();

      Player player1 = new Player();
      player1.RPS = player1Input;

      Player player2 = new Player();
      player2.RPS = player2Input;

      Player.RPSComparison(player1, player2);
      EvgeniyaAndIanAreGREAT(player1, player2);

    }

    public static string GetInput()
    {
      Console.WriteLine("Please enter [R]ock, [P]aper, or [S]cissors!");
      string userSelection = Console.ReadLine();
      return userSelection;
    }
    public static void EvgeniyaAndIanAreGREAT(Player player1, Player player2)
    {
      if(player1.IsWin)
      {
        Console.WriteLine("Player 1 wins!");
      } 
      else if(player2.IsWin)
      {
        Console.WriteLine("Player 2 wins!");
      }
      else
      {
        Console.WriteLine("This round is a draw!");
      }

      PlayAgain();
    }
    public static void PlayAgain()
    {
      Console.WriteLine("Would you like to Play again? Y/N");
      string playAgain = Console.ReadLine();

      if(playAgain == "Y") 
      {
        Main();
      }
      else 
      {
        Console.WriteLine("Thank you for playing!");
      }
    }
  }
}