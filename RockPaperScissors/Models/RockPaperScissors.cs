using System.Collections.Generic;
using System;

namespace RockPaperScissors.Models
{

  public class Game
  {
    private string _name;
    private string _play;
    private static List<Game> _games = new List<Game> {};

    public Game(string name, string play = "null")
    {
      _name = name;
      _play = play;
      _games.Add(this);
    }

    public string GetPlayerName()
    {
      return _name;
    }
    public string GetPlayerPlay()
    {
      return _play;
    }
    public static Game GetPlayerOne()
    {
      return _games[0];
    }
    public static Game GetPlayerTwo()
    {
      return _games[1];
    }
    public static void SetPlayerOnePlay(string newPlay)
    {
      _games[0]._play = newPlay;
    }
    public static void SetPlayerTwoPlay(string newPlay)
    {
      _games[1]._play = newPlay;
    }
    public static List<Game> GetGames()
    {
      return _games;
    }
    public static string ComparePlay()
    {
     string Player1Play = _games[0].GetPlayerPlay();
     string Player2Play = _games[1].GetPlayerPlay();
     string Player1Name = _games[0].GetPlayerName();
     string Player2Name = _games[1].GetPlayerName();
     string result = Player2Name + " Wins";

     if (Player1Play == Player2Play)
     {
       result = "Draw";
     }
     if (Player1Play == "Rock" && Player2Play == "Scissors" || Player1Play == "Paper" && Player2Play == "Rock"|| Player1Play == "Scissors" && Player2Play == "Paper")
     {
         result = Player1Name + " Wins";
     }
     return result;
    }
    public static void ClearAll()
    {
      _games.Clear();
    }
  }
}
