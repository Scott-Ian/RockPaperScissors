using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissors.Models;

namespace RockPaperScissors.TestTools
{
  [TestClass]
  public class PlayerTests
  {
    [TestMethod]
    public void PlayerConstructor_CreatesInstanceOfPlayer_Player()
    {
      Player newPlayer = new Player();
      Assert.AreEqual(typeof(Player), newPlayer.GetType());
    }

    [TestMethod]
    public void RPSComparison_DeterminesWinner_true()
    {
      Player rockPlayer = new Player();
      rockPlayer.RPS = "R";
      Player scissorsPlayer = new Player();
      scissorsPlayer.RPS = "S";
      Player.RPSComparison(rockPlayer, scissorsPlayer);
      Assert.AreEqual(true, rockPlayer.IsWin);
    }

    [TestMethod]
    public void RPSComparison_DeterminesNoWinner_false()
    {
      Player rockPlayer = new Player();
      rockPlayer.RPS = "R";
      Player scissorsPlayer = new Player();
      scissorsPlayer.RPS = "S";
      Player.RPSComparison(rockPlayer, scissorsPlayer);
      Assert.AreEqual(false, scissorsPlayer.IsWin);
    }
  }
}