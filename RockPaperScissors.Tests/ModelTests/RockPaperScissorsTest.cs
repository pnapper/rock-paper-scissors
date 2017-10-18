using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using RockPaperScissors.Models;
using System;

namespace RockPaperScissors.Tests
{

  [TestClass]
  public class GameTest
  {
    //Creating a test case to check if 2 objects with name and play properties are created
    [TestMethod]
    public void GetPlayerName_ReturnResult_Name()
    {
      //Arrange
      Game Player1 = new Game("Patrick", "Rock");
      Game Player2 = new Game("Daniel", "Scissors");
      List<Game> _thisGames = Game.GetGames();


      //Act
      string Player1Name = _thisGames[0].GetPlayerName();
      string Player2Name = _thisGames[1].GetPlayerName();
      string Player1Play = _thisGames[0].GetPlayerPlay();
      string Player2Play = _thisGames[1].GetPlayerPlay();

      // Assert
      Console.Write("Player1: ");
      Console.Write(Player1Name);
      Console.Write("; Player1's Play: ");
      Console.WriteLine(Player1Play);
      Console.Write("Player2: ");
      Console.Write(Player2Name);
      Console.Write("; Player2's Play: ");
      Console.WriteLine(Player2Play);

    }
  }
}
