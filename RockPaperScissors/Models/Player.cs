using System;

namespace RockPaperScissors.Models
{
  public class Player
  {
    public string RPS {get; set;}
    public bool IsWin {get; set;}

    /*public Player(string rps)
    {
      RPS = rps;
    }*/

    public static void RPSComparison(Player player1, Player player2)
    {
      if (player1.RPS == player2.RPS)
      {
        player1.IsWin = false;
        player2.IsWin = false;
      } 
      else if ((player1.RPS == "R" && player2.RPS == "S") || (player1.RPS == "P" && player2.RPS == "R") || (player1.RPS == "S" && player2.RPS == "P"))
      {
        player1.IsWin = true;
      }
      else
      {
        player2.IsWin = true;
      }
    }

    public void ComputerChoice()
    {
      Random rnd = new Random();
      int rpsChoice = rnd.Next(1,4);

      if (rpsChoice == 1)
      {
        RPS = "R";
      }
      else if (rpsChoice == 2)
      {
        RPS = "P";
      }
      else
      {
        RPS = "S";
      }
    }
  }
}