using System.Collections.Generic;
using System;

namespace RockPaperScissors.Models
{

  public class Game
  {
    private string _name;
    private string _play;
    private static List<Game> _games = new List<Game> {};

    public Game(string name, string play)
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
     string result = "game on";

     if (Player1Play == Player2Play)
     {
       result = "Draw";
     }
     if (Player1Play == "Rock")
     {
       if (Player2Play == "Scissors")
       {
         result = Player1Name + " Wins";
       }
       else if (Player2Play == "Paper")
       {
         result = Player2Name + " Wins";
       }
     }
     if (Player1Play == "Paper")
     {
       if (Player2Play == "Rock")
       {
         result = Player1Name + " Wins";
       }
       else if (Player2Play == "Scissors")
       {
         result = Player2Name + " Wins";
       }
     }
     if (Player1Play == "Scissors")
     {
       if (Player2Play == "Paper")
       {
         result = Player1Name + " Wins";
       }
       else if (Player2Play == "Rock")
       {
         result = Player2Name + " Wins";
       }
     }
     return result;
    }
    public static void ClearAll()
    {
      _games.Clear();
    }
  }
}
