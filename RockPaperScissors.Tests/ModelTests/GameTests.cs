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
      Player newPlayer = new Player("R");
      Assert.AreEqual(typeof(Player), newPlayer.GetType());
    }

    [TestMethod]
    public void RPSComparison_DeterminesWinner_true()
    {
      Player rockPlayer = new Player("R");
      Player scissorsPlayer = new Player("S");
      Player.RPSComparison(rockPlayer, scissorsPlayer);
      Assert.AreEqual(true, rockPlayer.IsWin);
    }

    [TestMethod]
    public void RPSComparison_DeterminesNoWinner_false()
    {
      Player rockPlayer = new Player("R");
      Player scissorsPlayer = new Player("R");
      Player.RPSComparison(rockPlayer, scissorsPlayer);
      Assert.AreEqual(false, rockPlayer.IsWin);
      Assert.AreEqual(false, scissorsPlayer.IsWin);
    }
  }
}