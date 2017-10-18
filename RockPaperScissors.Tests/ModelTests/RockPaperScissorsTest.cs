using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using RockPaperScissors.Models;
using System;

namespace RockPaperScissors.Tests
{

  [TestClass]
  public class GameTest : IDisposable
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
    //Test for Player 1 equals to Player 2 play ie. Draw Condition
    [TestMethod]
    public void ComparePlay_ComparePlayersPlay_Draw()
    {
      //Arrange
      Game Player1 = new Game("Patrick", "Scissors");
      Game Player2 = new Game("Daniel", "Scissors");

      //Act
      string _thisGames = Game.ComparePlay();

      //Assert
      Console.WriteLine("Scissors v. Scissors result: " + _thisGames);
    }
    //Test for Player 1 wins with Scissors over Paper.

    [TestMethod]
    public void ComparePlay_ComparePlayersPlay_PlayerOneWin()
    {
      //Arrange
      Game Player1 = new Game("Patrick", "Scissors");
      Game Player2 = new Game("Daniel", "Paper");

      //Act
      string _thisGames = Game.ComparePlay();

      //Assert
      Console.WriteLine("Scissors v. Paper result: " + _thisGames);
    }
    [TestMethod]
    public void ComparePlay_ComparePlayersPlay_PlayerTwoWin()
    {
      //Arrange
      Game Player1 = new Game("Patrick", "Scissors");
      Game Player2 = new Game("Daniel", "Rock");

      //Act
      string _thisGames = Game.ComparePlay();

      //Assert
      Console.WriteLine("Scissors v. Rock result: " + _thisGames);
    }
    [TestMethod]
    public void SetPlayerTwoPlay_PlayerPlayRecorded_NotNull()
    {
      //Arrange
      Game Player1 = new Game("Patrick");
      Game Player2 = new Game("Daniel");
      List<Game> _thisGames = Game.GetGames();

      //Act
      Game.SetPlayerOnePlay("Scissors");
      Game.SetPlayerTwoPlay("Rock");


      //Assert
      Console.WriteLine("Patrick's Play: " + _thisGames[0].GetPlayerPlay());
      Console.WriteLine("Daniel's Play: " + _thisGames[1].GetPlayerPlay());

    }

    public void Dispose()
    {
      Game.ClearAll();
    }
  }
}
