namespace RockPaperScissors.Models
{
  public class Player
  {
    public string RPS {get; set;}

    public Player(string rps)
    {
      RPS = rps;
    }

    public static Player RPSComparison(Player player1, Player player2)
    {
      return player2;
    }

  }
}