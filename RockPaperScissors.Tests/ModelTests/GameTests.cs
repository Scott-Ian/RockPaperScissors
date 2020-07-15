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
    public void RPSComparison_DeterminesWinner_Player()
    {
      Player rockPlayer = new Player("R");
      Player scissorsPlayer = new Player("S");

      Assert.AreEqual(rockPlayer, Player.RPSComparison(rockPlayer, scissorsPlayer));
    }
  }
}